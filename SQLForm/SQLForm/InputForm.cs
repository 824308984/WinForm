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
    public partial class InputForm : Form
    {
        private int _c;
        public InputForm(int c)
        {
            _c = c;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            switch (_c)
            {
                case 0:
                    str = Util.ConvertJsonString(InputBox.Text);
                    ShowForm sf = new ShowForm(str);
                    sf.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
