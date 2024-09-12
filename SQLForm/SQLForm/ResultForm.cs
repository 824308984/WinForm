using SQLForm.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLForm
{
    public partial class ResultForm : Form
    {
        public ResultForm(string rString)
        {
            InitializeComponent();
            Bind(rString);
        }

        void Bind(string rString)
        {
            var link = SingleLink.Init();
            LIP.Text = link.IP;
            LDS.Text = link.DataSource;
            txtContent.Text = rString;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkForm linkForm = new LinkForm();
            linkForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                return;
            }
            try
            {
                var sqlStr = new SqlString(txtContent.Text);
                SqlHelper.ExecuteNonQuery(sqlStr);
                MessageBox.Show("执行完毕！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
