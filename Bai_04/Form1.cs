using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_04
{

    public partial class Form1 : Form
    {
        private string filePath;
        private FontStyle myFontStyle = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
            InitialtizeContext();
        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitialtizeContext();
        }
        private void InitialtizeContext()
        {
            FontFamily[] fontFamilies;
            InstalledFontCollection ifc = new InstalledFontCollection();
            fontFamilies = ifc.Families;
            foreach (var font in fontFamilies)
            {
                toolStripComboBox_FontFamily.Items.Add(font.Name);
            }
            toolStripComboBox_FontFamily.SelectedItem = "Tahoma";

            for (int size = 8; size < 72; size++)
            {
                toolStripComboBox_FontsSize.Items.Add(size);
            }
            toolStripComboBox_FontsSize.SelectedItem = 14;
            richTextBox1.Clear();
            filePath = "";

            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Text file (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                richTextBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(filePath))
            {
                File.WriteAllText(filePath, richTextBox1.Text);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllText(filePath, richTextBox1.Text);

                    this.Text = Path.GetFileNameWithoutExtension(filePath);
                }
            }
        }

        private void FormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = richTextBox1.Font = new Font(fontDialog1.Font, fontDialog1.Font.Style);
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void toolStripComboBox_FontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            var font = toolStripComboBox_FontFamily.SelectedItem.ToString();
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(font, (int)toolStripComboBox_FontsSize.SelectedItem, myFontStyle);
            }

            else
            {
                richTextBox1.Font = new Font(font, 14, FontStyle.Regular);
            }
        }

        private void toolStripComboBox_FontsSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var font = (int)toolStripComboBox_FontsSize.SelectedItem;
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox_FontsSize.SelectedItem.ToString(), font, myFontStyle);
            }
            else
            {
                richTextBox1.Font = new Font(toolStripComboBox_FontsSize.SelectedItem.ToString(), 14, myFontStyle);
            }
        }

        private void toolStripButton_Bold_Click(object sender, EventArgs e)
        {
            var font = (int)toolStripComboBox_FontsSize.SelectedItem;
            myFontStyle = FontStyle.Bold;
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox_FontFamily.SelectedItem.ToString(), font, myFontStyle);
            }
            //else
            //{
            //    richTextBox1.Font = new Font(toolStripComboBox_FontFamily.SelectedItem.ToString(), font, myFontStyle);
            //}
        }

        private void toolStripButton_Italic_Click(object sender, EventArgs e)
        {
            var font = (int)toolStripComboBox_FontsSize.SelectedItem;
            myFontStyle = FontStyle.Italic;
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox_FontFamily.SelectedItem.ToString(), font, myFontStyle);
            }
            else
            {
                richTextBox1.Font = new Font(toolStripComboBox_FontFamily.SelectedItem.ToString(), font, myFontStyle);
            }
        }

        private void toolStripButton_Underline_Click(object sender, EventArgs e)
        {
            var font = (int)toolStripComboBox_FontsSize.SelectedItem;
            myFontStyle = FontStyle.Underline;
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.SelectionFont = new Font(toolStripComboBox_FontFamily.SelectedItem.ToString(), font, myFontStyle);
            }
            else
            {
                richTextBox1.Font = new Font(toolStripComboBox_FontFamily.SelectedItem.ToString(), font, myFontStyle);
            }
        }

        private void toolStripComboBox_FontsSize_Click(object sender, EventArgs e)
        {

        }
    }
}
