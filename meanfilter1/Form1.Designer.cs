namespace meanfilter1
{
    partial class meanFilterForm
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
            this.openTxtFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectFileTxt = new System.Windows.Forms.TextBox();
            this.meanBtn = new System.Windows.Forms.Button();
            this.wMeanBtn = new System.Windows.Forms.Button();
            this.outputMean = new System.Windows.Forms.RichTextBox();
            this.outputWeighted = new System.Windows.Forms.RichTextBox();
            this.outputBase1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.distBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openTxtFileBtn
            // 
            this.openTxtFileBtn.Location = new System.Drawing.Point(13, 25);
            this.openTxtFileBtn.Name = "openTxtFileBtn";
            this.openTxtFileBtn.Size = new System.Drawing.Size(169, 23);
            this.openTxtFileBtn.TabIndex = 0;
            this.openTxtFileBtn.Text = "Open measurements file";
            this.openTxtFileBtn.UseVisualStyleBackColor = true;
            this.openTxtFileBtn.Click += new System.EventHandler(this.openTxtFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectFileTxt
            // 
            this.selectFileTxt.Location = new System.Drawing.Point(13, 54);
            this.selectFileTxt.Name = "selectFileTxt";
            this.selectFileTxt.Size = new System.Drawing.Size(246, 20);
            this.selectFileTxt.TabIndex = 1;
            // 
            // meanBtn
            // 
            this.meanBtn.Location = new System.Drawing.Point(315, 51);
            this.meanBtn.Name = "meanBtn";
            this.meanBtn.Size = new System.Drawing.Size(75, 23);
            this.meanBtn.TabIndex = 3;
            this.meanBtn.Text = "Mean";
            this.meanBtn.UseVisualStyleBackColor = true;
            this.meanBtn.Click += new System.EventHandler(this.meanBtn_Click);
            // 
            // wMeanBtn
            // 
            this.wMeanBtn.Location = new System.Drawing.Point(455, 51);
            this.wMeanBtn.Name = "wMeanBtn";
            this.wMeanBtn.Size = new System.Drawing.Size(118, 23);
            this.wMeanBtn.TabIndex = 4;
            this.wMeanBtn.Text = "Weighted Mean";
            this.wMeanBtn.UseVisualStyleBackColor = true;
            this.wMeanBtn.Click += new System.EventHandler(this.wMeanBtn_Click);
            // 
            // outputMean
            // 
            this.outputMean.Location = new System.Drawing.Point(315, 84);
            this.outputMean.Name = "outputMean";
            this.outputMean.Size = new System.Drawing.Size(134, 271);
            this.outputMean.TabIndex = 5;
            this.outputMean.Text = "";
            this.outputMean.WordWrap = false;
            // 
            // outputWeighted
            // 
            this.outputWeighted.Location = new System.Drawing.Point(455, 84);
            this.outputWeighted.Name = "outputWeighted";
            this.outputWeighted.Size = new System.Drawing.Size(135, 273);
            this.outputWeighted.TabIndex = 6;
            this.outputWeighted.Text = "";
            this.outputWeighted.WordWrap = false;
            // 
            // outputBase1
            // 
            this.outputBase1.Location = new System.Drawing.Point(13, 84);
            this.outputBase1.Name = "outputBase1";
            this.outputBase1.Size = new System.Drawing.Size(278, 273);
            this.outputBase1.TabIndex = 7;
            this.outputBase1.Text = "";
            this.outputBase1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Actual -  Noise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Actual Mean";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Actual - Weighted";
            // 
            // tb1
            // 
            this.tb1.Enabled = false;
            this.tb1.Location = new System.Drawing.Point(12, 443);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(159, 20);
            this.tb1.TabIndex = 11;
            // 
            // tb2
            // 
            this.tb2.Enabled = false;
            this.tb2.Location = new System.Drawing.Point(238, 446);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(134, 20);
            this.tb2.TabIndex = 12;
            // 
            // tb3
            // 
            this.tb3.Enabled = false;
            this.tb3.Location = new System.Drawing.Point(439, 446);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(154, 20);
            this.tb3.TabIndex = 13;
            // 
            // distBtn
            // 
            this.distBtn.Location = new System.Drawing.Point(12, 401);
            this.distBtn.Name = "distBtn";
            this.distBtn.Size = new System.Drawing.Size(140, 23);
            this.distBtn.TabIndex = 14;
            this.distBtn.Text = "Calclulate Distance";
            this.distBtn.UseVisualStyleBackColor = true;
            this.distBtn.Click += new System.EventHandler(this.distBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputMean);
            this.groupBox1.Controls.Add(this.outputWeighted);
            this.groupBox1.Controls.Add(this.wMeanBtn);
            this.groupBox1.Controls.Add(this.meanBtn);
            this.groupBox1.Controls.Add(this.outputBase1);
            this.groupBox1.Controls.Add(this.selectFileTxt);
            this.groupBox1.Controls.Add(this.openTxtFileBtn);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 371);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mean Filter";
            // 
            // meanFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.distBtn);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "meanFilterForm";
            this.Text = "Mean Filter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openTxtFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox selectFileTxt;
        private System.Windows.Forms.Button meanBtn;
        private System.Windows.Forms.Button wMeanBtn;
        private System.Windows.Forms.RichTextBox outputMean;
        private System.Windows.Forms.RichTextBox outputWeighted;
        private System.Windows.Forms.RichTextBox outputBase1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button distBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

