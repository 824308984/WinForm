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
    public partial class ShowTableForm : Form
    {
        public ShowTableForm()
        {
            InitializeComponent();
        }

        public void Bind(string sql)
        {
            var dt = SqlHelper.ExecuteDataTable(sql);

            if (dt.Columns.Count == 0)
            {
                MessageBox.Show("Sql Error.");
                return;
            }

            lv.Items.Clear();
            lv.Columns.Clear();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                var ch = new ColumnHeader(i);
                ch.Text = dt.Columns[i].ColumnName;
                ch.Name = dt.Columns[i].ColumnName;
                lv.Columns.Add(ch);
            }
            lv.BeginUpdate();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dt.Rows[i][0].ToString();
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    item.SubItems.Add(dt.Rows[i][j].ToString());
                }

                lv.Items.Add(item);
            }
            lv.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bind(txtContent.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinkForm linkForm = new LinkForm();
            linkForm.ShowDialog();
        }
    }
}
