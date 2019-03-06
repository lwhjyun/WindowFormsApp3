namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btSourceFile = new System.Windows.Forms.Button();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.txtFillIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFillIn = new System.Windows.Forms.Button();
            this.btSplitFile = new System.Windows.Forms.Button();
            this.btChoice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.btTrueOrFalse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrueOrFalse = new System.Windows.Forms.TextBox();
            this.btCalculation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalculation = new System.Windows.Forms.TextBox();
            this.groupBoxOpen = new System.Windows.Forms.GroupBox();
            this.btnPasteAfter = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBoxOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 419);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(671, 161);
            this.textBox1.TabIndex = 0;
            // 
            // btSourceFile
            // 
            this.btSourceFile.Location = new System.Drawing.Point(489, 21);
            this.btSourceFile.Name = "btSourceFile";
            this.btSourceFile.Size = new System.Drawing.Size(75, 23);
            this.btSourceFile.TabIndex = 2;
            this.btSourceFile.Text = "浏览";
            this.btSourceFile.UseVisualStyleBackColor = true;
            this.btSourceFile.Click += new System.EventHandler(this.btSourceFile_Click);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(98, 21);
            this.txtSourceFile.Multiline = true;
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSourceFile.Size = new System.Drawing.Size(385, 88);
            this.txtSourceFile.TabIndex = 3;
            // 
            // txtFillIn
            // 
            this.txtFillIn.Location = new System.Drawing.Point(98, 122);
            this.txtFillIn.Multiline = true;
            this.txtFillIn.Name = "txtFillIn";
            this.txtFillIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFillIn.Size = new System.Drawing.Size(385, 42);
            this.txtFillIn.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "原文件：";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "填空题文件：";
            // 
            // btFillIn
            // 
            this.btFillIn.Location = new System.Drawing.Point(489, 122);
            this.btFillIn.Name = "btFillIn";
            this.btFillIn.Size = new System.Drawing.Size(75, 23);
            this.btFillIn.TabIndex = 7;
            this.btFillIn.Text = "浏览";
            this.btFillIn.UseVisualStyleBackColor = true;
            this.btFillIn.Click += new System.EventHandler(this.btFillIn_Click);
            // 
            // btSplitFile
            // 
            this.btSplitFile.Location = new System.Drawing.Point(489, 374);
            this.btSplitFile.Name = "btSplitFile";
            this.btSplitFile.Size = new System.Drawing.Size(75, 23);
            this.btSplitFile.TabIndex = 8;
            this.btSplitFile.Text = "提取题目";
            this.btSplitFile.UseVisualStyleBackColor = true;
            this.btSplitFile.Click += new System.EventHandler(this.btSplitFile_Click);
            // 
            // btChoice
            // 
            this.btChoice.Location = new System.Drawing.Point(489, 187);
            this.btChoice.Name = "btChoice";
            this.btChoice.Size = new System.Drawing.Size(75, 23);
            this.btChoice.TabIndex = 11;
            this.btChoice.Text = "浏览";
            this.btChoice.UseVisualStyleBackColor = true;
            this.btChoice.Click += new System.EventHandler(this.btChoice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "选择题文件：";
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(98, 187);
            this.txtChoice.Multiline = true;
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChoice.Size = new System.Drawing.Size(385, 44);
            this.txtChoice.TabIndex = 9;
            // 
            // btTrueOrFalse
            // 
            this.btTrueOrFalse.Location = new System.Drawing.Point(489, 249);
            this.btTrueOrFalse.Name = "btTrueOrFalse";
            this.btTrueOrFalse.Size = new System.Drawing.Size(75, 23);
            this.btTrueOrFalse.TabIndex = 14;
            this.btTrueOrFalse.Text = "浏览";
            this.btTrueOrFalse.UseVisualStyleBackColor = true;
            this.btTrueOrFalse.Click += new System.EventHandler(this.btTrueOrFalse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "判断题文件：";
            // 
            // txtTrueOrFalse
            // 
            this.txtTrueOrFalse.Location = new System.Drawing.Point(98, 249);
            this.txtTrueOrFalse.Multiline = true;
            this.txtTrueOrFalse.Name = "txtTrueOrFalse";
            this.txtTrueOrFalse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrueOrFalse.Size = new System.Drawing.Size(385, 47);
            this.txtTrueOrFalse.TabIndex = 12;
            // 
            // btCalculation
            // 
            this.btCalculation.Location = new System.Drawing.Point(489, 320);
            this.btCalculation.Name = "btCalculation";
            this.btCalculation.Size = new System.Drawing.Size(75, 23);
            this.btCalculation.TabIndex = 17;
            this.btCalculation.Text = "浏览";
            this.btCalculation.UseVisualStyleBackColor = true;
            this.btCalculation.Click += new System.EventHandler(this.btCalculation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "计算题文件：";
            // 
            // txtCalculation
            // 
            this.txtCalculation.Location = new System.Drawing.Point(98, 320);
            this.txtCalculation.Multiline = true;
            this.txtCalculation.Name = "txtCalculation";
            this.txtCalculation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCalculation.Size = new System.Drawing.Size(385, 52);
            this.txtCalculation.TabIndex = 15;
            // 
            // groupBoxOpen
            // 
            this.groupBoxOpen.Controls.Add(this.btnPasteAfter);
            this.groupBoxOpen.Controls.Add(this.btnOpen);
            this.groupBoxOpen.Location = new System.Drawing.Point(596, 69);
            this.groupBoxOpen.Name = "groupBoxOpen";
            this.groupBoxOpen.Size = new System.Drawing.Size(95, 141);
            this.groupBoxOpen.TabIndex = 22;
            this.groupBoxOpen.TabStop = false;
            this.groupBoxOpen.Text = "打开&测试";
            // 
            // btnPasteAfter
            // 
            this.btnPasteAfter.Location = new System.Drawing.Point(6, 46);
            this.btnPasteAfter.Name = "btnPasteAfter";
            this.btnPasteAfter.Size = new System.Drawing.Size(89, 23);
            this.btnPasteAfter.TabIndex = 1;
            this.btnPasteAfter.Text = "末尾添加复制内容";
            this.btnPasteAfter.UseVisualStyleBackColor = true;
            this.btnPasteAfter.Click += new System.EventHandler(this.btnPasteAfter_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(3, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开使用";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 605);
            this.Controls.Add(this.groupBoxOpen);
            this.Controls.Add(this.btCalculation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCalculation);
            this.Controls.Add(this.btTrueOrFalse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrueOrFalse);
            this.Controls.Add(this.btChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.btSplitFile);
            this.Controls.Add(this.btFillIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFillIn);
            this.Controls.Add(this.txtSourceFile);
            this.Controls.Add(this.btSourceFile);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOpen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btSourceFile;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.TextBox txtFillIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFillIn;
        private System.Windows.Forms.Button btSplitFile;
        private System.Windows.Forms.Button btChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Button btTrueOrFalse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrueOrFalse;
        private System.Windows.Forms.Button btCalculation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalculation;
        private System.Windows.Forms.GroupBox groupBoxOpen;
        private System.Windows.Forms.Button btnPasteAfter;
        private System.Windows.Forms.Button btnOpen;
    }
}

