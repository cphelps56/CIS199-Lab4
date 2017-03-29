namespace Lab4
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
            this.calculateScoresBtn = new System.Windows.Forms.Button();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.rejectedLabel = new System.Windows.Forms.Label();
            this.testScoreLabel = new System.Windows.Forms.Label();
            this.acceptedLabel = new System.Windows.Forms.Label();
            this.gpaTextbox = new System.Windows.Forms.TextBox();
            this.testScoreTextbox = new System.Windows.Forms.TextBox();
            this.rejectedAmountLabel = new System.Windows.Forms.Label();
            this.acceptedAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateScoresBtn
            // 
            this.calculateScoresBtn.Location = new System.Drawing.Point(109, 238);
            this.calculateScoresBtn.Name = "calculateScoresBtn";
            this.calculateScoresBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateScoresBtn.TabIndex = 2;
            this.calculateScoresBtn.Text = "Calculate";
            this.calculateScoresBtn.UseVisualStyleBackColor = true;
            this.calculateScoresBtn.Click += new System.EventHandler(this.calculateScoresBtn_Click);
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(89, 32);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(32, 13);
            this.gpaLabel.TabIndex = 8;
            this.gpaLabel.Text = "GPA:";
            // 
            // rejectedLabel
            // 
            this.rejectedLabel.AutoSize = true;
            this.rejectedLabel.Location = new System.Drawing.Point(41, 197);
            this.rejectedLabel.Name = "rejectedLabel";
            this.rejectedLabel.Size = new System.Drawing.Size(80, 13);
            this.rejectedLabel.TabIndex = 5;
            this.rejectedLabel.Text = "Total Rejected:";
            // 
            // testScoreLabel
            // 
            this.testScoreLabel.AutoSize = true;
            this.testScoreLabel.Location = new System.Drawing.Point(59, 96);
            this.testScoreLabel.Name = "testScoreLabel";
            this.testScoreLabel.Size = new System.Drawing.Size(62, 13);
            this.testScoreLabel.TabIndex = 7;
            this.testScoreLabel.Text = "Test Score:";
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(35, 155);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(86, 13);
            this.acceptedLabel.TabIndex = 6;
            this.acceptedLabel.Text = "Total Accepted: ";
            // 
            // gpaTextbox
            // 
            this.gpaTextbox.Location = new System.Drawing.Point(133, 29);
            this.gpaTextbox.Name = "gpaTextbox";
            this.gpaTextbox.Size = new System.Drawing.Size(100, 20);
            this.gpaTextbox.TabIndex = 0;
            // 
            // testScoreTextbox
            // 
            this.testScoreTextbox.Location = new System.Drawing.Point(133, 93);
            this.testScoreTextbox.Name = "testScoreTextbox";
            this.testScoreTextbox.Size = new System.Drawing.Size(100, 20);
            this.testScoreTextbox.TabIndex = 1;
            // 
            // rejectedAmountLabel
            // 
            this.rejectedAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedAmountLabel.Location = new System.Drawing.Point(133, 193);
            this.rejectedAmountLabel.Name = "rejectedAmountLabel";
            this.rejectedAmountLabel.Size = new System.Drawing.Size(100, 20);
            this.rejectedAmountLabel.TabIndex = 3;
            this.rejectedAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptedAmountLabel
            // 
            this.acceptedAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedAmountLabel.Location = new System.Drawing.Point(133, 151);
            this.acceptedAmountLabel.Name = "acceptedAmountLabel";
            this.acceptedAmountLabel.Size = new System.Drawing.Size(100, 20);
            this.acceptedAmountLabel.TabIndex = 4;
            this.acceptedAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.acceptedAmountLabel);
            this.Controls.Add(this.rejectedAmountLabel);
            this.Controls.Add(this.testScoreTextbox);
            this.Controls.Add(this.gpaTextbox);
            this.Controls.Add(this.acceptedLabel);
            this.Controls.Add(this.testScoreLabel);
            this.Controls.Add(this.rejectedLabel);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.calculateScoresBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateScoresBtn;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label rejectedLabel;
        private System.Windows.Forms.Label testScoreLabel;
        private System.Windows.Forms.Label acceptedLabel;
        private System.Windows.Forms.TextBox gpaTextbox;
        private System.Windows.Forms.TextBox testScoreTextbox;
        private System.Windows.Forms.Label rejectedAmountLabel;
        private System.Windows.Forms.Label acceptedAmountLabel;
    }
}

