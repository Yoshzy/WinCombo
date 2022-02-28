using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCombo
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/andre.deh.3975");
        }

        private void btngit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Yoshzy");
        
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/5544988426516");
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Joonathancortez");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Yoshzy");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/556183839323");
        }
    }
}
