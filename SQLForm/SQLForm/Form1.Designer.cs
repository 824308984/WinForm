namespace SQLForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(67, 143);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(151, 23);
            button1.TabIndex = 0;
            button1.Text = "通用版生成脚本";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(67, 103);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(151, 23);
            button2.TabIndex = 1;
            button2.Text = "表查询脚本";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(67, 61);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(151, 23);
            button3.TabIndex = 2;
            button3.Text = "个人信息";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(241, 61);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(150, 23);
            button4.TabIndex = 3;
            button4.Text = "查询脚本";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(241, 103);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(150, 23);
            button5.TabIndex = 4;
            button5.Text = "ASPX验证控件前端验证";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(241, 143);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(150, 23);
            button6.TabIndex = 5;
            button6.Text = "GUID 生成";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(67, 185);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(151, 23);
            button7.TabIndex = 6;
            button7.Text = "格式化JSON";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(241, 185);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(150, 23);
            button8.TabIndex = 7;
            button8.Text = "GDI+";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(67, 214);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(151, 23);
            button9.TabIndex = 8;
            button9.Text = "处理PDM文件枚举";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(473, 270);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SQLForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}
