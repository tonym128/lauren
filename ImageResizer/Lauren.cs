using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace Lauren
{
    public partial class Lauren : Form
    {
        static Point FocalPoint = new Point(0, 0);
        static string File = string.Empty;
        List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Lauren()
        {
            InitializeComponent();
            SetupProfiles();
            radioButton1.Checked = true;
        }

        private void SetupSizes(List<String> sizes, int CompressionValue, int MaxSize, string ProfileName = "")
        {
            pictureBoxes.Clear();
            foreach (string size in sizes)
            {
                pictureBoxes.Add(CreatePictureBox(Convert.ToInt16(size.Split('x').First()), Convert.ToInt16(size.Split('x').Last()), ProfileName));
            }

            trackBar1.Value = CompressionValue;
            label2.Text = trackBar1.Value.ToString();
            label3.Text = MaxSize.ToString();
        }

        private PictureBox CreatePictureBox(int x, int y, string ProfileName)
        {
            PictureBox picture = new PictureBox();
            picture.Size = new Size(x, y);
            picture.Tag = String.Format("{2}{0}x{1}", x, y, ProfileName);
            return picture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                this.textBox1.Text = openFileDialog1.FileName;
                ShowPicture();
                ResizePicture();
                DrawFocalPoint(FocalPoint);
            }
            else
            {
                this.textBox1.Text = string.Empty;
            }
        }

        private void ShowPicture()
        {
            Image Orig = Image.FromFile(openFileDialog1.FileName);
            PicOrig.Image = Orig;
            FocalPoint = new Point(Orig.Size.Width / 2, Orig.Size.Height / 2);
        }

        private Point DrawFocalPoint(Point xy)
        {
            Pen p = new Pen(Color.Red, 15);
            var g = Graphics.FromImage(PicOrig.Image);
            var width = 80;
            var newsize = new Size(width, width);
            xy.X -= width / 2;
            xy.Y -= width / 2;

            g.DrawEllipse(p, new Rectangle(xy, newsize));
            PicOrig.Invalidate();
            return xy;
        }

        private void ResizePicture()
        {
            Image Orig = Image.FromFile(openFileDialog1.FileName);
            PicOrig.Image = Orig;

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                long fileSize = 0;
                long maxFileSize = Convert.ToInt64(label3.Text)*1024;
                long compression = (long)trackBar1.Value;

                fileSize = Resize_Image(openFileDialog1.FileName, PicOrig.Image, pictureBox, compression);

                while (fileSize > maxFileSize && compression > 10 && maxFileSize > 0)
                {
                    fileSize = Resize_Image(openFileDialog1.FileName, PicOrig.Image, pictureBox, compression);
                    compression -= 1;
                }
            }
        }

        private static Size CalculateRatio(Size From, Size To)
        {
            double FromRatio = Convert.ToDouble(From.Width) / Convert.ToDouble(From.Height);
            double ToRatio = Convert.ToDouble(To.Width) / Convert.ToDouble(To.Height);
            double Margin = 0.05; // 5% margin

            Size NewFrom = From;
            double NewFromRatio = FromRatio;
            if (Math.Abs(FromRatio - ToRatio) < Margin)
            {
                // 5% margin for error before resize
                return new Size(0, 0);
            }
            else if (NewFromRatio > ToRatio)
            {
                while (Math.Abs(NewFromRatio - ToRatio) > Margin)
                {
                    NewFrom.Width -= 1;
                    NewFromRatio = Convert.ToDouble(NewFrom.Width) / Convert.ToDouble(NewFrom.Height);
                }
            }
            else if (NewFromRatio < ToRatio)
            {
                while (Math.Abs(NewFromRatio - ToRatio) > Margin)
                {
                    NewFrom.Height -= 1;
                    NewFromRatio = Convert.ToDouble(NewFrom.Width) / Convert.ToDouble(NewFrom.Height);
                }
            }

            Size RemovalFrom = new Size(From.Width - NewFrom.Width, From.Height - NewFrom.Height);

            return RemovalFrom;
        }

        private Image CalculateAndCropImage(double Margin, Size NewSize, Image Input)
        {
            Size CurrentSize = Input.Size;
            Size RemovePixels = CalculateRatio(CurrentSize, NewSize);
            Point FocalPointWorking = FocalPoint;
            Size WorkingSize = CurrentSize;

            int CropLeft = 0;
            int CropRight = 0;
            int CropTop = 0;
            int CropBottom = 0;

            while (RemovePixels.Width > 0)
            {
                double FocalPointToRight = WorkingSize.Width - FocalPointWorking.X;
                double FocalPointToLeft = FocalPointWorking.X;
                double ratio = FocalPointToRight >= FocalPointToLeft ? FocalPointToLeft / FocalPointToRight : FocalPointToRight / FocalPointToLeft;
                if (ratio < 1 - Margin)
                {
                    if (FocalPointToLeft > FocalPointToRight)
                    {
                        CropLeft += 1;
                        FocalPointWorking.X -= 1;
                        RemovePixels.Width -= 1;
                        WorkingSize.Width -= 1;
                    }
                    else
                    {
                        CropRight += 1;
                        RemovePixels.Width -= 1;
                        WorkingSize.Width -= 1;
                    }
                }
                else
                {
                    CropLeft += RemovePixels.Width / 2;
                    CropRight += RemovePixels.Width / 2;
                    RemovePixels.Width = 0;
                }
            }
            while (RemovePixels.Height > 0)
            {
                double FocalPointToTop = FocalPointWorking.Y;
                double FocalPointToBottom = WorkingSize.Height - FocalPointWorking.Y;
                double ratio = FocalPointToTop >= FocalPointToBottom ? FocalPointToBottom / FocalPointToTop : FocalPointToTop / FocalPointToBottom;
                if (ratio < 1 - Margin)
                {
                    if (FocalPointToTop > FocalPointToBottom)
                    {
                        CropTop += 1;
                        FocalPointWorking.Y -= 1;
                        RemovePixels.Height -= 1;
                        WorkingSize.Height -= 1;
                    }
                    else
                    {
                        CropBottom += 1;
                        RemovePixels.Height -= 1;
                        WorkingSize.Height -= 1;
                    }
                }
                else
                {
                    CropTop += RemovePixels.Height / 2;
                    CropBottom += RemovePixels.Height / 2;
                    RemovePixels.Height = 0;
                }
            }

            Rectangle cropRect = new Rectangle(CropLeft, CropTop, CurrentSize.Width - CropLeft - CropRight, CurrentSize.Height - CropTop - CropBottom);
            Image i2 = cropImage(Input, cropRect);
            Bitmap retrn = ResizeImage(i2, NewSize.Width,NewSize.Height);
            i2.Dispose();
            return retrn;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpImage2 = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            bmpImage.Dispose();
            return bmpImage2;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private long Resize_Image(string Extension, string filename, Image Original, Size s, PictureBox output, long compression)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(filename);
            string sSmallest = fi.DirectoryName + "\\" + fi.Name.Remove(fi.Name.Length - fi.Extension.Length) + "_" + Extension + ".jpg";
            Image i = CalculateAndCropImage(0.05, s, Original);

            Bitmap smallest = new Bitmap(i, s);

            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, compression);
            myEncoderParameters.Param[0] = myEncoderParameter;
            smallest.Save(sSmallest, jpgEncoder, myEncoderParameters);

            smallest.Dispose();
            fi = new System.IO.FileInfo(sSmallest);
            using (Image h = Image.FromFile(sSmallest))
            {
                Bitmap h2 = new Bitmap(h);
                output.Image = h2;
            }

            return fi.Length;
        }

        private long Resize_Image(string filename, Image Original, PictureBox output, long compression)
        {
            return Resize_Image(output.Tag.ToString(), filename, Original, output.Size, output, compression);
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (System.IO.File.Exists(files[0]))
            {
                openFileDialog1.FileName = files[0];
                ShowPicture();
                ResizePicture();
                DrawFocalPoint(FocalPoint);
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void PicOrig_MouseDown(object sender, MouseEventArgs e)
        {
            FocalPoint.X = Convert.ToInt32(Convert.ToDouble(e.X) / Convert.ToDouble(PicOrig.Size.Width) * PicOrig.Image.Size.Width);
            FocalPoint.Y = Convert.ToInt32(Convert.ToDouble(e.Y) / Convert.ToDouble(PicOrig.Size.Height) * PicOrig.Image.Size.Height);

            ResizePicture();
            DrawFocalPoint(FocalPoint);
        }

        private void ImageResizer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void ImageResizer_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (System.IO.File.Exists(files[0]))
            {
                openFileDialog1.FileName = files[0];
                ShowPicture();
                ResizePicture();
                DrawFocalPoint(FocalPoint);
            }
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            try{
                ResizePicture();
                DrawFocalPoint(FocalPoint);
            } catch { }

        }

        private void SetupProfiles()
        {
            if (Properties.Settings.Default.Profile1Name == String.Empty) radioButton1.Visible = false;
            radioButton1.Text = Properties.Settings.Default.Profile1Name;

            if (Properties.Settings.Default.Profile2Name == String.Empty) radioButton2.Visible = false;
            radioButton2.Text = Properties.Settings.Default.Profile2Name;

            if (Properties.Settings.Default.Profile3Name == String.Empty) radioButton3.Visible = false;
            radioButton3.Text = Properties.Settings.Default.Profile3Name;

            if (Properties.Settings.Default.Profile4Name == String.Empty) radioButton4.Visible = false;
            radioButton4.Text = Properties.Settings.Default.Profile4Name;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetupSizes(Properties.Settings.Default.Profile1Sizes.Split(';').ToList(), (int)Properties.Settings.Default.Profile1Compression, (int)Properties.Settings.Default.Profile1MaxSize, Properties.Settings.Default.Profile1Name);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetupSizes(Properties.Settings.Default.Profile2Sizes.Split(';').ToList(), (int)Properties.Settings.Default.Profile2Compression, (int)Properties.Settings.Default.Profile2MaxSize, Properties.Settings.Default.Profile2Name);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetupSizes(Properties.Settings.Default.Profile3Sizes.Split(';').ToList(), (int)Properties.Settings.Default.Profile3Compression, (int)Properties.Settings.Default.Profile3MaxSize, Properties.Settings.Default.Profile3Name);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SetupSizes(Properties.Settings.Default.Profile4Sizes.Split(';').ToList(), (int)Properties.Settings.Default.Profile4Compression, (int)Properties.Settings.Default.Profile4MaxSize, Properties.Settings.Default.Profile4Name);
        }
    }
}
