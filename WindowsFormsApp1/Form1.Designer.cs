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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelNeighbor = new System.Windows.Forms.RadioButton();
            this.SelLum = new System.Windows.Forms.RadioButton();
            this.SelNaiveFirst = new System.Windows.Forms.RadioButton();
            this.SelNaiveLast = new System.Windows.Forms.RadioButton();
            this.SelNaiveMid = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorCanvas)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.31805F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.4613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2521, 487);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // colorCanvas
            // 
            this.colorCanvas.Location = new System.Drawing.Point(3, 3);
            this.colorCanvas.Name = "colorCanvas";
            this.colorCanvas.Size = new System.Drawing.Size(2397, 114);
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
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 209);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(2515, 117);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelNeighbor);
            this.groupBox1.Controls.Add(this.SelLum);
            this.groupBox1.Controls.Add(this.SelNaiveFirst);
            this.groupBox1.Controls.Add(this.SelNaiveLast);
            this.groupBox1.Controls.Add(this.SelNaiveMid);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2515, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order By:";
            // 
            // SelNeighbor
            // 
            this.SelNeighbor.AutoSize = true;
            this.SelNeighbor.Location = new System.Drawing.Point(27, 138);
            this.SelNeighbor.Name = "SelNeighbor";
            this.SelNeighbor.Size = new System.Drawing.Size(360, 36);
            this.SelNeighbor.TabIndex = 0;
            this.SelNeighbor.TabStop = true;
            this.SelNeighbor.Text = "Nearest Neighbor (RGB)";
            this.SelNeighbor.UseVisualStyleBackColor = true;
            this.SelNeighbor.CheckedChanged += new System.EventHandler(this.SelNeighbor_CheckedChanged);
            // 
            // SelLum
            // 
            this.SelLum.AutoSize = true;
            this.SelLum.Location = new System.Drawing.Point(27, 96);
            this.SelLum.Name = "SelLum";
            this.SelLum.Size = new System.Drawing.Size(189, 36);
            this.SelLum.TabIndex = 0;
            this.SelLum.TabStop = true;
            this.SelLum.Text = "Luminosity";
            this.SelLum.UseVisualStyleBackColor = true;
            this.SelLum.CheckedChanged += new System.EventHandler(this.SelLum_CheckedChanged);
            // 
            // SelNaiveFirst
            // 
            this.SelNaiveFirst.AutoSize = true;
            this.SelNaiveFirst.Location = new System.Drawing.Point(27, 54);
            this.SelNaiveFirst.Name = "SelNaiveFirst";
            this.SelNaiveFirst.Size = new System.Drawing.Size(211, 36);
            this.SelNaiveFirst.TabIndex = 1;
            this.SelNaiveFirst.Text = "Naive (RGB)";
            this.SelNaiveFirst.UseVisualStyleBackColor = true;
            this.SelNaiveFirst.CheckedChanged += new System.EventHandler(this.SelNaiveFirst_CheckedChanged);
            // 
            // SelNaiveLast
            // 
            this.SelNaiveLast.AutoSize = true;
            this.SelNaiveLast.Location = new System.Drawing.Point(519, 54);
            this.SelNaiveLast.Name = "SelNaiveLast";
            this.SelNaiveLast.Size = new System.Drawing.Size(211, 36);
            this.SelNaiveLast.TabIndex = 3;
            this.SelNaiveLast.Text = "Naive (RBG)";
            this.SelNaiveLast.UseVisualStyleBackColor = true;
            this.SelNaiveLast.CheckedChanged += new System.EventHandler(this.SelNaiveLast_CheckedChanged);
            // 
            // SelNaiveMid
            // 
            this.SelNaiveMid.AutoSize = true;
            this.SelNaiveMid.Location = new System.Drawing.Point(268, 54);
            this.SelNaiveMid.Name = "SelNaiveMid";
            this.SelNaiveMid.Size = new System.Drawing.Size(211, 36);
            this.SelNaiveMid.TabIndex = 2;
            this.SelNaiveMid.Text = "Naive (BGR)";
            this.SelNaiveMid.UseVisualStyleBackColor = true;
            this.SelNaiveMid.CheckedChanged += new System.EventHandler(this.SelNaiveMid_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.colorCanvas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 332);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2515, 152);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2521, 487);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Experience Color Ordering";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorCanvas)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox colorCanvas;
        private System.Windows.Forms.RadioButton SelNaiveFirst;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SelRGB;
        private System.Windows.Forms.RadioButton SelHSV;
        private System.Windows.Forms.RadioButton SelNaiveMid;
        private System.Windows.Forms.RadioButton SelNaiveLast;
        private System.Windows.Forms.RadioButton SelYUV;
        private System.Windows.Forms.RadioButton SelLum;
        private System.Windows.Forms.RadioButton SelNeighbor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

