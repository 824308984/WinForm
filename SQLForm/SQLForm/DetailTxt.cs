using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using SQLForm.Base;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLForm
{
    public partial class DetailTxt : Form
    {
        public DetailTxt()
        {
            InitializeComponent();
        }

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
        List<string> indexArr = new List<string>();
        List<string> tableNames = new List<string>();
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dic = new Dictionary<string, List<string>>();

                textBox1.Text = openFileDialog1.FileName;
                DetailEnumTxt();
            }
        }

        /// <summary>
        /// 枚举文件处理方法，如果枚举文件格式不一样，需要重写此方法
        /// </summary>
        private void DetailEnumTxt()
        {
            string[] lines = File.ReadAllLines(textBox1.Text);
            string dxTabelName = "";
            string tableName = "";
            List<string> columns = new List<string>();
            foreach (string line in lines)
            {
                if (line.IndexOf(" is table ") > -1)
                {
                    dxTabelName = line.Substring(0, line.IndexOf(" is table ")).Trim();
                    tableName = line.Substring(line.IndexOf(" is table ") + 10).Trim();

                    var dt = SqlHelper.ExecuteDataTable($"select * from {tableName} where 1=2");
                    foreach (DataColumn item in dt.Columns)
                    {
                        columns.Add(item.ColumnName);
                    }
                    continue;
                }
                if (line.IndexOf("---------------------") > -1)
                {
                    dxTabelName = "";
                    tableName = "";
                    columns.Clear();
                    continue;
                }
                if (dxTabelName != "" && tableName != "" && line.IndexOf(dxTabelName) > -1)
                {
                    string key = dxTabelName + "-";
                    var sp = line.Split("=>");
                    if (sp != null && sp.Length == 3)
                    {
                        key += sp[1].Trim();
                        if (columns.IndexOf(sp[1].Trim()) == -1) continue;

                        if (!dic.ContainsKey(key))
                        {
                            dic.Add(key, new List<string>());
                            indexArr.Add(key);
                            tableNames.Add(tableName);
                        }
                        sp[2].Split(",").ToList().ForEach(x => dic[key].Add(x.Trim()));
                    }

                }
            }

            InitCombox();
            ShowData();
        }


        private void InitCombox()
        {
            tableCb.Items.Clear();

            if (dic != null)
            {
                List<string> tbItem = new List<string>();
                foreach (var item in dic)
                {
                    tbItem.Add(item.Key.Split("-")[0]);
                }
                foreach (var item in tbItem.Distinct())
                {
                    tableCb.Items.Add(item);
                }
                tableCb.SelectedItem = tableCb.Items[0];
            }
        }

        private void ShowData()
        {
            if (dic != null && indexArr.Count > 0)
            {
                var data = dic[indexArr[index]];
                textBox2.Text = tableNames[index].TrimStart('[').TrimEnd(']') + "\r\n\r\n";
                textBox2.Text += $"{index}/{indexArr.Count()}";
                textBox2.Text += indexArr[index].Split('-')[1] + ":\r\n\r\n";
                foreach (var item in data)
                {
                    textBox2.Text += item + "\r\n";
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (index < indexArr.Count - 1)
            {
                index++;
            }
            ShowData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
            }
            ShowData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tableCb.SelectedItem == null)
            {
                index = 0;
            }
            foreach (var item in indexArr)
            {
                if (item.IndexOf(tableCb.SelectedItem?.ToString() ?? "") > -1)
                {
                    index = indexArr.IndexOf(item);
                    break;
                }
            }
            ShowData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PDMHelper pdm = new PDMHelper(opd.FileName);
            for (var i = 0; i < dic.Count; i++)
            {
                string tableName = tableNames[i].TrimStart('[').TrimEnd(']');
                string column = indexArr[i].Split('-')[1];
                string comment = string.Join("\r\n", dic[indexArr[i]]);
                pdm.SetComment(tableName, column, comment);
            }

            pdm.Save();
            MessageBox.Show("OK");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (opd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = opd.FileName;
                if (string.IsNullOrEmpty(textBox3.Text))
                    button5.Enabled = false;
                else
                    button5.Enabled = true;
            }
        }
    }
}
