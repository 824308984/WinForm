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
    public partial class ShowForm : Form
    {
        public ShowForm(string rString)
        {
            InitializeComponent();
            txtContent.Text = rString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
