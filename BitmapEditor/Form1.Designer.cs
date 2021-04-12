namespace BitmapEditor
{
    partial class Form1
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
            this.txt_bftype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bfoffbits = new System.Windows.Forms.TextBox();
            this.txt_bfreserved2 = new System.Windows.Forms.TextBox();
            this.txt_bfreserved1 = new System.Windows.Forms.TextBox();
            this.txt_bfsize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_biclrimportant = new System.Windows.Forms.TextBox();
            this.txt_biclrused = new System.Windows.Forms.TextBox();
            this.txt_biypelspermeter = new System.Windows.Forms.TextBox();
            this.txt_bixpelspermeter = new System.Windows.Forms.TextBox();
            this.txt_bisizeimage = new System.Windows.Forms.TextBox();
            this.txt_bicompression = new System.Windows.Forms.TextBox();
            this.txt_bibitcount = new System.Windows.Forms.TextBox();
            this.txt_biplanes = new System.Windows.Forms.TextBox();
            this.txt_biheight = new System.Windows.Forms.TextBox();
            this.txt_biwidth = new System.Windows.Forms.TextBox();
            this.txt_bisize = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_bftype
            // 
            this.txt_bftype.Location = new System.Drawing.Point(161, 19);
            this.txt_bftype.Name = "txt_bftype";
            this.txt_bftype.Size = new System.Drawing.Size(33, 20);
            this.txt_bftype.TabIndex = 0;
            this.txt_bftype.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "bfType";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_bfoffbits);
            this.groupBox1.Controls.Add(this.txt_bfreserved2);
            this.groupBox1.Controls.Add(this.txt_bfreserved1);
            this.groupBox1.Controls.Add(this.txt_bfsize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_bftype);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitmap file header";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "bfOffBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "bfReserved2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "bfReserved1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "bfSize";
            // 
            // txt_bfoffbits
            // 
            this.txt_bfoffbits.Location = new System.Drawing.Point(136, 123);
            this.txt_bfoffbits.Name = "txt_bfoffbits";
            this.txt_bfoffbits.Size = new System.Drawing.Size(58, 20);
            this.txt_bfoffbits.TabIndex = 5;
            this.txt_bfoffbits.TextChanged += new System.EventHandler(this.txt_bfoffbits_TextChanged);
            // 
            // txt_bfreserved2
            // 
            this.txt_bfreserved2.Location = new System.Drawing.Point(161, 97);
            this.txt_bfreserved2.Name = "txt_bfreserved2";
            this.txt_bfreserved2.Size = new System.Drawing.Size(33, 20);
            this.txt_bfreserved2.TabIndex = 4;
            this.txt_bfreserved2.TextChanged += new System.EventHandler(this.tx_bfreserved2_TextChanged);
            // 
            // txt_bfreserved1
            // 
            this.txt_bfreserved1.Location = new System.Drawing.Point(161, 71);
            this.txt_bfreserved1.Name = "txt_bfreserved1";
            this.txt_bfreserved1.Size = new System.Drawing.Size(33, 20);
            this.txt_bfreserved1.TabIndex = 3;
            this.txt_bfreserved1.TextChanged += new System.EventHandler(this.txt_bfreserved1_TextChanged);
            // 
            // txt_bfsize
            // 
            this.txt_bfsize.Location = new System.Drawing.Point(136, 45);
            this.txt_bfsize.Name = "txt_bfsize";
            this.txt_bfsize.Size = new System.Drawing.Size(58, 20);
            this.txt_bfsize.TabIndex = 2;
            this.txt_bfsize.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Citire fisier bmp ca text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Salvare ca fisier bmp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 153);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_biclrimportant);
            this.groupBox2.Controls.Add(this.txt_biclrused);
            this.groupBox2.Controls.Add(this.txt_biypelspermeter);
            this.groupBox2.Controls.Add(this.txt_bixpelspermeter);
            this.groupBox2.Controls.Add(this.txt_bisizeimage);
            this.groupBox2.Controls.Add(this.txt_bicompression);
            this.groupBox2.Controls.Add(this.txt_bibitcount);
            this.groupBox2.Controls.Add(this.txt_biplanes);
            this.groupBox2.Controls.Add(this.txt_biheight);
            this.groupBox2.Controls.Add(this.txt_biwidth);
            this.groupBox2.Controls.Add(this.txt_bisize);
            this.groupBox2.Location = new System.Drawing.Point(270, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 312);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bitmap info header";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "biClrImportant";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "biClrUsed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "biYPelsPerMeter";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "biXPelsPerMeter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "biSizeImage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "biCompression";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "biBitCount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "biPlanes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "biHeight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "biWidth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "biSize";
            // 
            // txt_biclrimportant
            // 
            this.txt_biclrimportant.Location = new System.Drawing.Point(139, 279);
            this.txt_biclrimportant.Name = "txt_biclrimportant";
            this.txt_biclrimportant.Size = new System.Drawing.Size(55, 20);
            this.txt_biclrimportant.TabIndex = 10;
            this.txt_biclrimportant.TextChanged += new System.EventHandler(this.txt_biclrimportant_TextChanged);
            // 
            // txt_biclrused
            // 
            this.txt_biclrused.Location = new System.Drawing.Point(139, 253);
            this.txt_biclrused.Name = "txt_biclrused";
            this.txt_biclrused.Size = new System.Drawing.Size(55, 20);
            this.txt_biclrused.TabIndex = 9;
            this.txt_biclrused.TextChanged += new System.EventHandler(this.txt_biclrused_TextChanged);
            // 
            // txt_biypelspermeter
            // 
            this.txt_biypelspermeter.Location = new System.Drawing.Point(139, 227);
            this.txt_biypelspermeter.Name = "txt_biypelspermeter";
            this.txt_biypelspermeter.Size = new System.Drawing.Size(55, 20);
            this.txt_biypelspermeter.TabIndex = 8;
            this.txt_biypelspermeter.TextChanged += new System.EventHandler(this.txt_biypelspermeter_TextChanged);
            // 
            // txt_bixpelspermeter
            // 
            this.txt_bixpelspermeter.Location = new System.Drawing.Point(139, 201);
            this.txt_bixpelspermeter.Name = "txt_bixpelspermeter";
            this.txt_bixpelspermeter.Size = new System.Drawing.Size(55, 20);
            this.txt_bixpelspermeter.TabIndex = 7;
            this.txt_bixpelspermeter.TextChanged += new System.EventHandler(this.txt_bixpelspermeter_TextChanged);
            // 
            // txt_bisizeimage
            // 
            this.txt_bisizeimage.Location = new System.Drawing.Point(139, 175);
            this.txt_bisizeimage.Name = "txt_bisizeimage";
            this.txt_bisizeimage.Size = new System.Drawing.Size(55, 20);
            this.txt_bisizeimage.TabIndex = 6;
            this.txt_bisizeimage.TextChanged += new System.EventHandler(this.txt_bisizeimage_TextChanged);
            // 
            // txt_bicompression
            // 
            this.txt_bicompression.Location = new System.Drawing.Point(139, 149);
            this.txt_bicompression.Name = "txt_bicompression";
            this.txt_bicompression.Size = new System.Drawing.Size(55, 20);
            this.txt_bicompression.TabIndex = 5;
            this.txt_bicompression.TextChanged += new System.EventHandler(this.txt_bicompression_TextChanged);
            // 
            // txt_bibitcount
            // 
            this.txt_bibitcount.Location = new System.Drawing.Point(163, 123);
            this.txt_bibitcount.Name = "txt_bibitcount";
            this.txt_bibitcount.Size = new System.Drawing.Size(31, 20);
            this.txt_bibitcount.TabIndex = 4;
            this.txt_bibitcount.TextChanged += new System.EventHandler(this.txt_bibitcount_TextChanged);
            // 
            // txt_biplanes
            // 
            this.txt_biplanes.Location = new System.Drawing.Point(163, 97);
            this.txt_biplanes.Name = "txt_biplanes";
            this.txt_biplanes.Size = new System.Drawing.Size(31, 20);
            this.txt_biplanes.TabIndex = 3;
            this.txt_biplanes.TextChanged += new System.EventHandler(this.txt_biplanes_TextChanged);
            // 
            // txt_biheight
            // 
            this.txt_biheight.Location = new System.Drawing.Point(139, 71);
            this.txt_biheight.Name = "txt_biheight";
            this.txt_biheight.Size = new System.Drawing.Size(55, 20);
            this.txt_biheight.TabIndex = 2;
            this.txt_biheight.TextChanged += new System.EventHandler(this.txt_biheight_TextChanged);
            // 
            // txt_biwidth
            // 
            this.txt_biwidth.Location = new System.Drawing.Point(139, 45);
            this.txt_biwidth.Name = "txt_biwidth";
            this.txt_biwidth.Size = new System.Drawing.Size(55, 20);
            this.txt_biwidth.TabIndex = 1;
            this.txt_biwidth.TextChanged += new System.EventHandler(this.txt_biwidth_TextChanged);
            // 
            // txt_bisize
            // 
            this.txt_bisize.Location = new System.Drawing.Point(139, 19);
            this.txt_bisize.Name = "txt_bisize";
            this.txt_bisize.Size = new System.Drawing.Size(55, 20);
            this.txt_bisize.TabIndex = 0;
            this.txt_bisize.TextChanged += new System.EventHandler(this.txt_bisize_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Location = new System.Drawing.Point(476, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 311);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color table";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(206, 302);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 362);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_bftype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_bfoffbits;
        private System.Windows.Forms.TextBox txt_bfreserved2;
        private System.Windows.Forms.TextBox txt_bfreserved1;
        private System.Windows.Forms.TextBox txt_bfsize;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_biclrimportant;
        private System.Windows.Forms.TextBox txt_biclrused;
        private System.Windows.Forms.TextBox txt_biypelspermeter;
        private System.Windows.Forms.TextBox txt_bixpelspermeter;
        private System.Windows.Forms.TextBox txt_bisizeimage;
        private System.Windows.Forms.TextBox txt_bicompression;
        private System.Windows.Forms.TextBox txt_bibitcount;
        private System.Windows.Forms.TextBox txt_biplanes;
        private System.Windows.Forms.TextBox txt_biheight;
        private System.Windows.Forms.TextBox txt_biwidth;
        private System.Windows.Forms.TextBox txt_bisize;
    }
}

