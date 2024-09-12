namespace SQLForm
{
    partial class ShowTableForm
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
            lv = new System.Windows.Forms.ListView();
            button1 = new System.Windows.Forms.Button();
            txtContent = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lv
            // 
            lv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.HideSelection = false;
            lv.Location = new System.Drawing.Point(12, 158);
            lv.Name = "lv";
            lv.Size = new System.Drawing.Size(845, 307);
            lv.TabIndex = 0;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(756, 490);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new System.Drawing.Point(12, 12);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(845, 140);
            txtContent.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(664, 490);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "运行";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(544, 490);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(114, 23);
            button3.TabIndex = 4;
            button3.Text = "连接测试";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ShowTableForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(869, 525);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtContent);
            Controls.Add(button1);
            Controls.Add(lv);
            Name = "ShowTableForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ShowTableForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}