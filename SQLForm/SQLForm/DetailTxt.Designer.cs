namespace SQLForm
{
    partial class DetailTxt
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
            textBox1 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            tableCb = new System.Windows.Forms.ComboBox();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            button5 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            button6 = new System.Windows.Forms.Button();
            opd = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBox1.Location = new System.Drawing.Point(74, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(524, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button1.Location = new System.Drawing.Point(603, 23);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(140, 23);
            button1.TabIndex = 1;
            button1.Text = "选择文件";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox2.Location = new System.Drawing.Point(74, 92);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox2.Size = new System.Drawing.Size(669, 257);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button2.Location = new System.Drawing.Point(668, 355);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "下一个";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button3.Location = new System.Drawing.Point(587, 355);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "上一个";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button4.Location = new System.Drawing.Point(506, 355);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "跳转到";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tableCb
            // 
            tableCb.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tableCb.FormattingEnabled = true;
            tableCb.Location = new System.Drawing.Point(256, 353);
            tableCb.Name = "tableCb";
            tableCb.Size = new System.Drawing.Size(244, 25);
            tableCb.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "opd";
            openFileDialog1.Filter = "文本(*.txt)|*.txt";
            // 
            // button5
            // 
            button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button5.Enabled = false;
            button5.Location = new System.Drawing.Point(74, 355);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(157, 23);
            button5.TabIndex = 7;
            button5.Text = "直接替换PDM";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            textBox3.Location = new System.Drawing.Point(74, 52);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(524, 23);
            textBox3.TabIndex = 8;
            // 
            // button6
            // 
            button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            button6.Location = new System.Drawing.Point(603, 54);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(140, 23);
            button6.TabIndex = 9;
            button6.Text = "选择PDM";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // opd
            // 
            opd.FileName = "openFileDialog2";
            opd.Filter = "PDM(*.PDM)|*.pdm";
            // 
            // DetailTxt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button6);
            Controls.Add(textBox3);
            Controls.Add(button5);
            Controls.Add(tableCb);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "DetailTxt";
            Text = "DetailTxt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox tableCb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog opd;
    }
}