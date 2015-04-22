namespace Lauren
{
    partial class Lauren
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lauren));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PicOrig = new System.Windows.Forms.PictureBox();
            this.PicSmaller = new System.Windows.Forms.PictureBox();
            this.PicSmallest = new System.Windows.Forms.PictureBox();
            this.Pic_Large = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pic_Mid = new System.Windows.Forms.PictureBox();
            this.pic_Ban = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicOrig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmaller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmallest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Large)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ban)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(843, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // PicOrig
            // 
            this.PicOrig.Location = new System.Drawing.Point(12, 95);
            this.PicOrig.Name = "PicOrig";
            this.PicOrig.Size = new System.Drawing.Size(386, 243);
            this.PicOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOrig.TabIndex = 2;
            this.PicOrig.TabStop = false;
            this.PicOrig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicOrig_MouseDown);
            // 
            // PicSmaller
            // 
            this.PicSmaller.Location = new System.Drawing.Point(624, 691);
            this.PicSmaller.Name = "PicSmaller";
            this.PicSmaller.Size = new System.Drawing.Size(190, 100);
            this.PicSmaller.TabIndex = 3;
            this.PicSmaller.TabStop = false;
            this.PicSmaller.Tag = "Smaller";
            // 
            // PicSmallest
            // 
            this.PicSmallest.Location = new System.Drawing.Point(820, 727);
            this.PicSmallest.Name = "PicSmallest";
            this.PicSmallest.Size = new System.Drawing.Size(65, 65);
            this.PicSmallest.TabIndex = 4;
            this.PicSmallest.TabStop = false;
            this.PicSmallest.Tag = "Smallest";
            // 
            // Pic_Large
            // 
            this.Pic_Large.Location = new System.Drawing.Point(12, 421);
            this.Pic_Large.Name = "Pic_Large";
            this.Pic_Large.Size = new System.Drawing.Size(300, 370);
            this.Pic_Large.TabIndex = 14;
            this.Pic_Large.TabStop = false;
            this.Pic_Large.Tag = "Lrg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 88);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Pic_Mid
            // 
            this.Pic_Mid.Location = new System.Drawing.Point(318, 566);
            this.Pic_Mid.Name = "Pic_Mid";
            this.Pic_Mid.Size = new System.Drawing.Size(300, 225);
            this.Pic_Mid.TabIndex = 25;
            this.Pic_Mid.TabStop = false;
            this.Pic_Mid.Tag = "Mid";
            // 
            // pic_Ban
            // 
            this.pic_Ban.Location = new System.Drawing.Point(404, 95);
            this.pic_Ban.Name = "pic_Ban";
            this.pic_Ban.Size = new System.Drawing.Size(780, 465);
            this.pic_Ban.TabIndex = 26;
            this.pic_Ban.TabStop = false;
            this.pic_Ban.Tag = "Ban";
            // 
            // Lauren
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 818);
            this.Controls.Add(this.pic_Ban);
            this.Controls.Add(this.Pic_Mid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicSmallest);
            this.Controls.Add(this.PicSmaller);
            this.Controls.Add(this.PicOrig);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pic_Large);
            this.Name = "Lauren";
            this.Text = "Lauren - Largely AUtomated REsiziNg tool";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageResizer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ImageResizer_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.PicOrig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmaller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSmallest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Large)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Mid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox PicOrig;
        private System.Windows.Forms.PictureBox PicSmaller;
        private System.Windows.Forms.PictureBox PicSmallest;
        private System.Windows.Forms.PictureBox Pic_Large;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Pic_Mid;
        private System.Windows.Forms.PictureBox pic_Ban;
    }
}

