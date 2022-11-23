using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_06
{
    public partial class Form1 : Form
    {
        private String fromPath;
        private String destPath;

        public Form1()
        {
            InitializeComponent();
            DangSaoChepStatus.Text = "Đang chờ";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDg = new OpenFileDialog();
            if (fileDg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fromPath = fileDg.FileName;
                    textBox1.Text = fromPath;

                }
                catch
                {
                    MessageBox.Show($"Open error.");
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDg = new FolderBrowserDialog();
            if (folderDg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    destPath = folderDg.SelectedPath;
                    textBox2.Text = destPath;
                }
                catch
                {
                    MessageBox.Show($"Open error.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            if (CopyTask())
            {
                DangSaoChepStatus.Text = "Đang sao chép: " + textBox1.Text;
                for (int i = 0; i <= 100; i++)
                {
                    progressBar1.Value = i;
                }
                MessageBox.Show("Copy thanh cong!");
            }
            else
            {
                DangSaoChepStatus.Text = "Đang chờ";
                MessageBox.Show("Copy khong thanh cong!");
            }
        }


        private bool CopyTask()
        {
            string fileToCopy = textBox1.Text;
            string destinationDirectory = textBox2.Text;

            if (!String.IsNullOrEmpty(fileToCopy) && !String.IsNullOrEmpty(destinationDirectory))
            {
                try
                {
                    File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("File da ton tai");
                }
                return false;

            }
            else
            {
                return false;
            }

        }
    }
}
