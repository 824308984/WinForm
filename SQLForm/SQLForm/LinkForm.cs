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
    public partial class LinkForm : Form
    {
        public LinkForm()
        {
            InitializeComponent();
            Bind();
        }

        void Bind()
        {
            var link = SingleLink.Init();
            TIP.Text = link.IP;
            TUID.Text = link.UID;
            TDS.Text = link.DataSource;
            TPWD.Text = link.PWD;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var link = SingleLink.Init();
            link.IP = link.TIP;
            link.UID = link.UID;
            link.DataSource = link.DataSource;
            link.PWD = link.PWD;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var link = SingleLink.Init();
            link.TIP = TIP.Text;
            link.TUID = TUID.Text;
            link.TDataSource = TDS.Text;
            link.TPWD = TPWD.Text;
            if (SqlHelper.ConnectionTest())
            {
                MessageBox.Show("连接成功!");
            }
        }
    }
}
