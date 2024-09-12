namespace SQLForm
{
    partial class LinkForm
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            TIP = new System.Windows.Forms.TextBox();
            TUID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            TPWD = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            TDS = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(124, 267);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(87, 29);
            button1.TabIndex = 0;
            button1.Text = "Test Link";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(217, 267);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(89, 29);
            button2.TabIndex = 1;
            button2.Text = "Ok";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TIP
            // 
            TIP.Location = new System.Drawing.Point(104, 82);
            TIP.Name = "TIP";
            TIP.Size = new System.Drawing.Size(258, 23);
            TIP.TabIndex = 2;
            // 
            // TUID
            // 
            TUID.Location = new System.Drawing.Point(104, 127);
            TUID.Name = "TUID";
            TUID.Size = new System.Drawing.Size(258, 23);
            TUID.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(60, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 17);
            label1.TabIndex = 4;
            label1.Text = "IP :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(61, 133);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 17);
            label2.TabIndex = 5;
            label2.Text = "UID :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(55, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 17);
            label3.TabIndex = 7;
            label3.Text = "PWD :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TPWD
            // 
            TPWD.Location = new System.Drawing.Point(104, 177);
            TPWD.Name = "TPWD";
            TPWD.Size = new System.Drawing.Size(258, 23);
            TPWD.TabIndex = 6;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(55, 224);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 17);
            label4.TabIndex = 9;
            label4.Text = "DS :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TDS
            // 
            TDS.Location = new System.Drawing.Point(104, 218);
            TDS.Name = "TDS";
            TDS.Size = new System.Drawing.Size(258, 23);
            TDS.TabIndex = 8;
            // 
            // LinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(427, 361);
            Controls.Add(label4);
            Controls.Add(TDS);
            Controls.Add(label3);
            Controls.Add(TPWD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TUID);
            Controls.Add(TIP);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LinkForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LinkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TIP;
        private System.Windows.Forms.TextBox TUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TPWD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TDS;
    }
}