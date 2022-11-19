using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Left) label_Event.Text = "Bạn vừa click chuột trái";
            else if (e.Button == MouseButtons.Right) label_Event.Text = "Bạn vừa click chuột phải";
            label_value.Text = $"Tọa độ chuột: ({e.X} - {e.Y})";
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            label_Event.Text = "Bạn vừa nhấn phím";
            label_value.Text = $"Phím: {e.KeyCode}, ASCII: {e.KeyValue}";
        }
    }
}
