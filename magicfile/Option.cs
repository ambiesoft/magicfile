using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace magicfile
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (Aboutcs about = new Aboutcs())
            {
                about.ShowDialog(this);
            }
        }
    }
}
