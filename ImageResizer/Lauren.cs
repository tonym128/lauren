using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lauren
{
    public partial class Lauren : Form
    {
        static Point FocalPoint = new Point(0, 0);
        static String File = string.Empty;
        public Lauren()
        {
            InitializeComponent();
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

            Orig_X.Text = Orig.Size.Width.ToString();
            Orig_Y.Text = Orig.Size.Height.ToString();
            System.IO.FileInfo fi = new System.IO.FileInfo(openFileDialog1.FileName);
            Orig_Size.Text = fi.Length.ToString();
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

            Resize_Image(openFileDialog1.FileName, PicOrig.Image, ref PicSmallest);
            Resize_Image(openFileDialog1.FileName, PicOrig.Image, ref PicSmaller);
            Resize_Image(openFileDialog1.FileName, PicOrig.Image, ref Pic_Large);
            Resize_Image(openFileDialog1.FileName, PicOrig.Image, ref pic_Ban);
            Resize_Image(openFileDialog1.FileName, PicOrig.Image, ref Pic_Mid);
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
            Bitmap retrn = new Bitmap(i2, NewSize);
            i2.Dispose();
            return retrn;
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpImage2 = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            bmpImage.Dispose();
            return bmpImage2;
        }

        private long Resize_Image(string Extension, string filename, Image Original, Size s, ref PictureBox output)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(filename);
            string sSmallest = fi.DirectoryName + "\\" + fi.Name.Remove(fi.Name.Length - fi.Extension.Length) + "_" + Extension + ".jpg";
            Image i = CalculateAndCropImage(0.05, s, Original);

            Bitmap smallest = new Bitmap(i, s);
            smallest.Save(sSmallest, System.Drawing.Imaging.ImageFormat.Jpeg);
            smallest.Dispose();
            fi = new System.IO.FileInfo(sSmallest);
            using (Image h = Image.FromFile(sSmallest))
            {
                Bitmap h2 = new Bitmap(h);
                output.Image = h2;
                h.Dispose();
            }

            return fi.Length;
        }

        private long Resize_Image(string filename, Image Original, ref PictureBox output)
        {
            return Resize_Image(output.Tag.ToString(), filename, Original, output.Size, ref output);
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
    }
}
