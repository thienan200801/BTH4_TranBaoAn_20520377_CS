using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThucHanh4___Bai_5
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            comboBox1.Items.Add("Khoa học máy tính");
            comboBox1.Items.Add("Kỹ thuật phần mềm");
            comboBox1.Items.Add("Khoa học dữ liệu");
            comboBox1.Items.Add("Công nghệ thông tin");
            comboBox1.SelectedItem = 0;
            //mainForm.MySQLConnect(this, new EventArgs());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double diem = 0;
            bool check = Double.TryParse(textBox3.Text, out diem);
            if (check == false || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Dữ liệu nhập không đúng");
                return;
            }
            mainForm.addRow(textBox1.Text, textBox2.Text, comboBox1.Text.ToString(), Double.Parse(textBox3.Text));
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
