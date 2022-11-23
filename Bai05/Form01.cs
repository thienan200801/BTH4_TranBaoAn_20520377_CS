using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucHanh4___Bai_5;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Cau5;

namespace ThucHanh4___Bai_5
{
    public partial class Form1 : Form
    {

        private DataTable Table = new DataTable();

        public Form1()
        {
            InitializeComponent();
            Table.Columns.Add("STT", typeof(int));
            Table.Columns.Add("MSSV", typeof(string));
            Table.Columns.Add("Name", typeof(string));
            Table.Columns.Add("Khoa", typeof(string));
            Table.Columns.Add("Diem", typeof(string));
            dataGridView1.DataSource = Table;

        }


        private void label1_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2(this);
            form.ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.ShowDialog(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void addRow(string mssv, string name, string khoa, double diem)
        {
            DataRow row = Table.NewRow();
            row["STT"] = Table.Rows.Count + 1;
            row["MSSV"] = mssv;
            row["Name"] = name;
            row["Khoa"] = khoa;
            row["Diem"] = diem;
            Table.Rows.Add(row);
            dataGridView1.DataSource = Table;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var text = textBox2.Text.ToLower();
            if (text.Length > 0)
            {
                DataTable newTB = new DataTable();
                newTB.Columns.Add("STT", typeof(int));
                newTB.Columns.Add("MSSV", typeof(string));
                newTB.Columns.Add("Name", typeof(string));
                newTB.Columns.Add("Khoa", typeof(string));
                newTB.Columns.Add("Diem", typeof(string));

                foreach (DataRow row in Table.Rows)
                {

                    if (row["Name"].ToString().Contains(text) == true)
                    {
                        DataRow newRow = newTB.NewRow();
                        newRow["STT"] = (int)row["STT"];
                        newRow["MSSV"] = row["MSSV"].ToString();
                        newRow["Name"] = row["Name"].ToString();
                        newRow["Khoa"] = row["Khoa"].ToString();
                        newRow["Diem"] = row["Diem"].ToString();

                        newTB.Rows.Add(newRow);

                    }
                }
                dataGridView1.DataSource = newTB;
            }
            else
            {
                dataGridView1.DataSource = Table;

            }

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
