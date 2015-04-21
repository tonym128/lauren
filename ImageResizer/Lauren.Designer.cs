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
            this.Orig_Size = new System.Windows.Forms.TextBox();
            this.Smaller_Size = new System.Windows.Forms.TextBox();
            this.Smaller_X = new System.Windows.Forms.TextBox();
            this.Orig_Y = new System.Windows.Forms.TextBox();
            this.Orig_X = new System.Windows.Forms.TextBox();
            this.Smaller_Y = new System.Windows.Forms.TextBox();
            this.Smallest_Y = new System.Windows.Forms.TextBox();
            this.Smallest_X = new System.Windows.Forms.TextBox();
            this.Smallest_Size = new System.Windows.Forms.TextBox();
            this.Large_Y = new System.Windows.Forms.TextBox();
            this.Large_X = new System.Windows.Forms.TextBox();
            this.Large_Size = new System.Windows.Forms.TextBox();
            this.Pic_Large = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.PicSmallest.Size = new System.Drawing.Size(64, 64);
            this.PicSmallest.TabIndex = 4;
            this.PicSmallest.TabStop = false;
            this.PicSmallest.Tag = "Smallest";
            // 
            // Orig_Size
            // 
            this.Orig_Size.Location = new System.Drawing.Point(64, 133);
            this.Orig_Size.Name = "Orig_Size";
            this.Orig_Size.Size = new System.Drawing.Size(100, 20);
            this.Orig_Size.TabIndex = 5;
            this.Orig_Size.Visible = false;
            // 
            // Smaller_Size
            // 
            this.Smaller_Size.Location = new System.Drawing.Point(27, 325);
            this.Smaller_Size.Name = "Smaller_Size";
            this.Smaller_Size.Size = new System.Drawing.Size(100, 20);
            this.Smaller_Size.TabIndex = 6;
            this.Smaller_Size.Visible = false;
            // 
            // Smaller_X
            // 
            this.Smaller_X.Location = new System.Drawing.Point(27, 351);
            this.Smaller_X.Name = "Smaller_X";
            this.Smaller_X.Size = new System.Drawing.Size(100, 20);
            this.Smaller_X.TabIndex = 7;
            this.Smaller_X.Text = "190";
            this.Smaller_X.Visible = false;
            // 
            // Orig_Y
            // 
            this.Orig_Y.Location = new System.Drawing.Point(64, 185);
            this.Orig_Y.Name = "Orig_Y";
            this.Orig_Y.Size = new System.Drawing.Size(100, 20);
            this.Orig_Y.TabIndex = 9;
            this.Orig_Y.Visible = false;
            // 
            // Orig_X
            // 
            this.Orig_X.Location = new System.Drawing.Point(64, 159);
            this.Orig_X.Name = "Orig_X";
            this.Orig_X.Size = new System.Drawing.Size(100, 20);
            this.Orig_X.TabIndex = 8;
            this.Orig_X.Visible = false;
            // 
            // Smaller_Y
            // 
            this.Smaller_Y.Location = new System.Drawing.Point(27, 379);
            this.Smaller_Y.Name = "Smaller_Y";
            this.Smaller_Y.Size = new System.Drawing.Size(100, 20);
            this.Smaller_Y.TabIndex = 10;
            this.Smaller_Y.Text = "100";
            this.Smaller_Y.Visible = false;
            // 
            // Smallest_Y
            // 
            this.Smallest_Y.Location = new System.Drawing.Point(24, 472);
            this.Smallest_Y.Name = "Smallest_Y";
            this.Smallest_Y.Size = new System.Drawing.Size(100, 20);
            this.Smallest_Y.TabIndex = 13;
            this.Smallest_Y.Text = "65";
            this.Smallest_Y.Visible = false;
            // 
            // Smallest_X
            // 
            this.Smallest_X.Location = new System.Drawing.Point(24, 444);
            this.Smallest_X.Name = "Smallest_X";
            this.Smallest_X.Size = new System.Drawing.Size(100, 20);
            this.Smallest_X.TabIndex = 12;
            this.Smallest_X.Text = "65";
            this.Smallest_X.Visible = false;
            // 
            // Smallest_Size
            // 
            this.Smallest_Size.Location = new System.Drawing.Point(24, 418);
            this.Smallest_Size.Name = "Smallest_Size";
            this.Smallest_Size.Size = new System.Drawing.Size(100, 20);
            this.Smallest_Size.TabIndex = 11;
            this.Smallest_Size.Visible = false;
            // 
            // Large_Y
            // 
            this.Large_Y.Location = new System.Drawing.Point(24, 286);
            this.Large_Y.Name = "Large_Y";
            this.Large_Y.Size = new System.Drawing.Size(100, 20);
            this.Large_Y.TabIndex = 17;
            this.Large_Y.Text = "370";
            this.Large_Y.Visible = false;
            // 
            // Large_X
            // 
            this.Large_X.Location = new System.Drawing.Point(24, 258);
            this.Large_X.Name = "Large_X";
            this.Large_X.Size = new System.Drawing.Size(100, 20);
            this.Large_X.TabIndex = 16;
            this.Large_X.Text = "300";
            this.Large_X.Visible = false;
            // 
            // Large_Size
            // 
            this.Large_Size.Location = new System.Drawing.Point(24, 232);
            this.Large_Size.Name = "Large_Size";
            this.Large_Size.Size = new System.Drawing.Size(100, 20);
            this.Large_Size.TabIndex = 15;
            this.Large_Size.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "File Size";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "X";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Y";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Large";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Smaller";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Smallest";
            this.label6.Visible = false;
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Large_Y);
            this.Controls.Add(this.Large_X);
            this.Controls.Add(this.Large_Size);
            this.Controls.Add(this.Smallest_Y);
            this.Controls.Add(this.Smallest_X);
            this.Controls.Add(this.Smallest_Size);
            this.Controls.Add(this.Smaller_Y);
            this.Controls.Add(this.Orig_Y);
            this.Controls.Add(this.Orig_X);
            this.Controls.Add(this.Smaller_X);
            this.Controls.Add(this.Smaller_Size);
            this.Controls.Add(this.Orig_Size);
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
        private System.Windows.Forms.TextBox Orig_Size;
        private System.Windows.Forms.TextBox Smaller_Size;
        private System.Windows.Forms.TextBox Smaller_X;
        private System.Windows.Forms.TextBox Orig_Y;
        private System.Windows.Forms.TextBox Orig_X;
        private System.Windows.Forms.TextBox Smaller_Y;
        private System.Windows.Forms.TextBox Smallest_Y;
        private System.Windows.Forms.TextBox Smallest_X;
        private System.Windows.Forms.TextBox Smallest_Size;
        private System.Windows.Forms.TextBox Large_Y;
        private System.Windows.Forms.TextBox Large_X;
        private System.Windows.Forms.TextBox Large_Size;
        private System.Windows.Forms.PictureBox Pic_Large;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Pic_Mid;
        private System.Windows.Forms.PictureBox pic_Ban;
    }
}

