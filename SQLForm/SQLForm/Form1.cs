using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SQLForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScriptFrom fma = new ScriptFrom();
            fma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sqlString = "SELECT name FROM sys.tables\r\nSELECT TABLE_NAME,COLUMN_NAME,DATA_TYPE FROM information_schema.columns WHERE TABLE_NAME= '***'";
            ShowForm sf = new ShowForm(sqlString);
            sf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var str = "https://zentao.whyiqingtech.com/my/\r\nchangjun.wang\r\nLumin921027/\r\n\r\nhttp://192.168.1.111\r\ncj.wang@whyiqingtech.com\r\nlumin921027\r\n\r\nhttp://gl.yulian.net:11280\r\nwangcj\r\nLumin921027/\r\n\r\nhttps://script.yulian.net/\r\ncj.wang\r\n111111";
            ShowForm sf = new ShowForm(str);
            sf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowTableForm sf = new ShowTableForm();
            sf.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var str = "$.each(Page_Validators,function(index,item){\r\n    if(!item.isvalid) console.log(item)\r\n})";
            ShowForm sf = new ShowForm(str);
            sf.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                strList.Add(Guid.NewGuid().ToString().ToUpper());
            }
            string str = string.Join("\r\n", strList);
            ShowForm sf = new ShowForm(str);
            sf.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            InputForm rfm = new InputForm(0);
            rfm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GDIForm gDIForm = new GDIForm();
            gDIForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetailTxt detailTxt = new DetailTxt();
            detailTxt.ShowDialog();
        }
    }
}
