namespace WindowsFormsApp1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.colorCanvas = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SelRGB = new System.Windows.Forms.RadioButton();
            this.SelHSV = new System.Windows.Forms.RadioButton();
            this.SelYUV = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Box1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SelNaiveFirst = new System.Windows.Forms.RadioButton();
            this.SelNaiveMid = new System.Windows.Forms.RadioButton();
            this.SelNaiveLast = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SelLum = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorCanvas)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Box1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.94937F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.05063F));
            this.tableLayoutPanel1.Controls.Add(this.colorCanvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1679, 933);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // colorCanvas
            // 
            this.colorCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorCanvas.Location = new System.Drawing.Point(3, 3);
            this.colorCanvas.Name = "colorCanvas";
            this.tableLayoutPanel1.SetRowSpan(this.colorCanvas, 3);
            this.colorCanvas.Size = new System.Drawing.Size(244, 927);
            this.colorCanvas.TabIndex = 0;
            this.colorCanvas.TabStop = false;
            this.colorCanvas.Click += new System.EventHandler(this.colorCanvas_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.SelRGB);
            this.flowLayoutPanel2.Controls.Add(this.SelHSV);
            this.flowLayoutPanel2.Controls.Add(this.SelYUV);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(253, 318);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1423, 309);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order On:";
            // 
            // SelRGB
            // 
            this.SelRGB.AutoSize = true;
            this.SelRGB.Location = new System.Drawing.Point(149, 3);
            this.SelRGB.Name = "SelRGB";
            this.SelRGB.Size = new System.Drawing.Size(113, 36);
            this.SelRGB.TabIndex = 1;
            this.SelRGB.TabStop = true;
            this.SelRGB.Text = "RGB";
            this.SelRGB.UseVisualStyleBackColor = true;
            this.SelRGB.CheckedChanged += new System.EventHandler(this.SelRGB_CheckedChanged);
            // 
            // SelHSV
            // 
            this.SelHSV.AutoSize = true;
            this.SelHSV.Location = new System.Drawing.Point(268, 3);
            this.SelHSV.Name = "SelHSV";
            this.SelHSV.Size = new System.Drawing.Size(110, 36);
            this.SelHSV.TabIndex = 2;
            this.SelHSV.TabStop = true;
            this.SelHSV.Text = "HSV";
            this.SelHSV.UseVisualStyleBackColor = true;
            this.SelHSV.CheckedChanged += new System.EventHandler(this.selHSV_CheckedChanged);
            // 
            // SelYUV
            // 
            this.SelYUV.AutoSize = true;
            this.SelYUV.Location = new System.Drawing.Point(384, 3);
            this.SelYUV.Name = "SelYUV";
            this.SelYUV.Size = new System.Drawing.Size(110, 36);
            this.SelYUV.TabIndex = 3;
            this.SelYUV.TabStop = true;
            this.SelYUV.Text = "YUV";
            this.SelYUV.UseVisualStyleBackColor = true;
            this.SelYUV.CheckedChanged += new System.EventHandler(this.SelYUV_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Box1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(253, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.24242F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.75758F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1423, 309);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.label1);
            this.Box1.Controls.Add(this.SelNaiveFirst);
            this.Box1.Controls.Add(this.SelNaiveMid);
            this.Box1.Controls.Add(this.SelNaiveLast);
            this.Box1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box1.Location = new System.Drawing.Point(3, 3);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(1417, 67);
            this.Box1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order By:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelNaiveFirst
            // 
            this.SelNaiveFirst.AutoSize = true;
            this.SelNaiveFirst.Location = new System.Drawing.Point(144, 3);
            this.SelNaiveFirst.Name = "SelNaiveFirst";
            this.SelNaiveFirst.Size = new System.Drawing.Size(211, 36);
            this.SelNaiveFirst.TabIndex = 1;
            this.SelNaiveFirst.Text = "Naive (RGB)";
            this.SelNaiveFirst.UseVisualStyleBackColor = true;
            this.SelNaiveFirst.CheckedChanged += new System.EventHandler(this.SelNaiveFirst_CheckedChanged);
            // 
            // SelNaiveMid
            // 
            this.SelNaiveMid.AutoSize = true;
            this.SelNaiveMid.Location = new System.Drawing.Point(361, 3);
            this.SelNaiveMid.Name = "SelNaiveMid";
            this.SelNaiveMid.Size = new System.Drawing.Size(211, 36);
            this.SelNaiveMid.TabIndex = 2;
            this.SelNaiveMid.Text = "Naive (BGR)";
            this.SelNaiveMid.UseVisualStyleBackColor = true;
            this.SelNaiveMid.CheckedChanged += new System.EventHandler(this.SelNaiveMid_CheckedChanged);
            // 
            // SelNaiveLast
            // 
            this.SelNaiveLast.AutoSize = true;
            this.SelNaiveLast.Location = new System.Drawing.Point(578, 3);
            this.SelNaiveLast.Name = "SelNaiveLast";
            this.SelNaiveLast.Size = new System.Drawing.Size(211, 36);
            this.SelNaiveLast.TabIndex = 3;
            this.SelNaiveLast.Text = "Naive (RBG)";
            this.SelNaiveLast.UseVisualStyleBackColor = true;
            this.SelNaiveLast.CheckedChanged += new System.EventHandler(this.SelNaiveLast_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.02117F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.97883F));
            this.tableLayoutPanel3.Controls.Add(this.SelLum, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1417, 70);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // SelLum
            // 
            this.SelLum.AutoSize = true;
            this.SelLum.Location = new System.Drawing.Point(144, 3);
            this.SelLum.Name = "SelLum";
            this.SelLum.Size = new System.Drawing.Size(189, 36);
            this.SelLum.TabIndex = 0;
            this.SelLum.TabStop = true;
            this.SelLum.Text = "Luminosity";
            this.SelLum.UseVisualStyleBackColor = true;
            this.SelLum.CheckedChanged += new System.EventHandler(this.SelLum_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 933);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Experience Color Ordering";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorCanvas)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox colorCanvas;
        private System.Windows.Forms.FlowLayoutPanel Box1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton SelNaiveFirst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SelRGB;
        private System.Windows.Forms.RadioButton SelHSV;
        private System.Windows.Forms.RadioButton SelNaiveMid;
        private System.Windows.Forms.RadioButton SelNaiveLast;
        private System.Windows.Forms.RadioButton SelYUV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton SelLum;
    }
}

