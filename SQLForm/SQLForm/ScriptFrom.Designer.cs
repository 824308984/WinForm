namespace SQLForm
{
    partial class ScriptFrom
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
            txtProcName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtContent = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtProcName
            // 
            txtProcName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtProcName.Location = new System.Drawing.Point(91, 12);
            txtProcName.Name = "txtProcName";
            txtProcName.Size = new System.Drawing.Size(697, 23);
            txtProcName.TabIndex = 0;
            txtProcName.Text = "SCRIPT_WCJ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 17);
            label1.TabIndex = 1;
            label1.Text = "Proc Name";
            // 
            // txtContent
            // 
            txtContent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtContent.Location = new System.Drawing.Point(12, 67);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new System.Drawing.Size(776, 337);
            txtContent.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.Location = new System.Drawing.Point(695, 439);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(82, 28);
            button1.TabIndex = 3;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ScriptFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 491);
            Controls.Add(button1);
            Controls.Add(txtContent);
            Controls.Add(label1);
            Controls.Add(txtProcName);
            MinimizeBox = false;
            Name = "ScriptFrom";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ScriptFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtProcName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button button1;
    }
}