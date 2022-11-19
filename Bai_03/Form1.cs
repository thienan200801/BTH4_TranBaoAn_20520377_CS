using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_03
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            
            t.Start();
        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
