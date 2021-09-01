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
        bool dirty_ = false;
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

        public bool IsCloseAfterRenaming
        {
            get { return chkCloseAfterRenaming.Checked; }
            set
            {
                if (chkCloseAfterRenaming.Checked != value)
                    dirty_ = true;
                chkCloseAfterRenaming.Checked = value;
            }
        }
        public bool IsSkipWarning
        {
            get { return chkSkipWarning.Checked; }
            set
            {
                if (chkSkipWarning.Checked != value)
                    dirty_ = true;
                chkSkipWarning.Checked = value;
            }
        }
        public bool Dirty
        {
            get { return dirty_; }
        }

        private void chkCloseAfterRenaming_CheckedChanged(object sender, EventArgs e)
        {
            dirty_ = true;
        }

        private void chkSkipWarning_CheckedChanged(object sender, EventArgs e)
        {
            dirty_ = true;
        }

        internal void ClearDirty()
        {
            dirty_ = false;
        }
    }
}
