namespace SQLForm
{
    partial class ResultForm
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
            txtContent = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            LIP = new System.Windows.Forms.Label();
            LDS = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtContent.Location = new System.Drawing.Point(12, 47);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtContent.Size = new System.Drawing.Size(776, 334);
            txtContent.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(643, 404);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 23);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(524, 404);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(113, 23);
            button2.TabIndex = 2;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button3.Location = new System.Drawing.Point(411, 404);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(107, 23);
            button3.TabIndex = 3;
            button3.Text = "Link";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LIP
            // 
            LIP.AutoSize = true;
            LIP.Location = new System.Drawing.Point(38, 15);
            LIP.Name = "LIP";
            LIP.Size = new System.Drawing.Size(0, 17);
            LIP.TabIndex = 4;
            // 
            // LDS
            // 
            LDS.AutoSize = true;
            LDS.Location = new System.Drawing.Point(287, 19);
            LDS.Name = "LDS";
            LDS.Size = new System.Drawing.Size(0, 17);
            LDS.TabIndex = 5;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(LDS);
            Controls.Add(LIP);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtContent);
            Name = "ResultForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LIP;
        private System.Windows.Forms.Label LDS;
    }
}