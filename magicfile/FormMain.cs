/*
    magicfile is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Foobar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Foobar.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Reflection;

namespace magicfile
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        internal string InputFile;
        private void analyzefile(string filename)
        {
            string origExt = string.Empty;
            try
            {
                txtFile.Text = filename;
                FileInfo fi = new FileInfo(filename);
                FileInfo fiapp = new FileInfo(System.Windows.Forms.Application.ExecutablePath);
                origExt = Path.GetExtension(filename).Trim('.');
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = fiapp.Directory.FullName + "\\routines\\file.exe";
                    psi.Arguments = "-b -m " + "\"" + fiapp.Directory.FullName + "\\routines\\magic.mgc\" " + "\"" + fi.FullName + "\"";
                    psi.RedirectStandardOutput = true;
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;
                    // psi.WorkingDirectory = fi.Directory.FullName;
                    Process p = Process.Start(psi);
                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                    if (0 != p.ExitCode)
                    {
                        MessageBox.Show(string.Format(Properties.Resources.COMMAN_LINE_END_WITH_ERROR + "\r\n" + "error:{0}", p.ExitCode),
                            Application.ProductName,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        return;
                    }
                    output = output.Trim();
                    txtMagic.Text = output;
                }
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = fiapp.Directory.FullName + "\\routines\\file.exe";
                    psi.Arguments = "-b --mime-type -m " + "\"" + fiapp.Directory.FullName + "\\routines\\magic.mgc\" " + "\"" + fi.FullName + "\"";
                    psi.RedirectStandardOutput = true;
                    psi.UseShellExecute = false;
                    psi.CreateNoWindow = true;
                    // psi.WorkingDirectory = fi.Directory.FullName;
                    Process p = Process.Start(psi);
                    string output = p.StandardOutput.ReadToEnd();
                    p.WaitForExit();
                    if (0 != p.ExitCode)
                    {
                        MessageBox.Show(string.Format("error:{0}", p.ExitCode));
                        return;
                    }
                    output = output.Trim();
                    txtMime.Text = output;
                }

                if (txtMime.Text.Length != 0)
                {
                    object oext = Microsoft.Win32.Registry.GetValue(
                        @"HKEY_CLASSES_ROOT\MIME\Database\Content Type\" + txtMime.Text,
                        @"Extension", string.Empty);
                    if (oext != null)
                    {
                        string s = oext.ToString();
                        if (s.Length != 0)
                        {
                            s = s.Trim('.');
                            txtExt.Text = s;
                        }
                    }
                    else
                    {
                        txtExt.Text = string.Empty;
                    }
                }
                else
                {
                    txtExt.Text = string.Empty;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }

            if (txtMime.Text.Length != 0)
            {
                string ext = Program.getExtension(txtMime.Text, txtExt.Text);
                if (!string.IsNullOrEmpty(ext))
                {
                    ext = ext.Trim('.');
                    txtExt.Text += " " + ext;
                    txtExt.Text = txtExt.Text.Trim();
                }
            }

            string text = txtExt.Text;
            text = text.Split(' ')[0];
            if (txtExt.Text.Length != 0 && (string.Compare(text, origExt, true) != 0))
            {
                btnChangeExt.Enabled = true;
            }
            else
            {
                btnChangeExt.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object[] os = (object[])e.Data.GetData(DataFormats.FileDrop);
                foreach (object o in os)
                {
                    BeginInvoke(new MyDelegate(analyzefile), new object[] { InputFile= o.ToString() });
                    // analyzefile(o.ToString());
                    return;
                }
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FormMain_DragOver(object sender, DragEventArgs e)
        {
            FormMain_DragEnter(sender, e);
        }

        public delegate void MyDelegate(string myArg2);
        private void btnNavigate_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (DialogResult.OK != d.ShowDialog())
                return;


            analyzefile(d.FileName);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputFile))
                analyzefile(InputFile);
        }

        // private readonly List<string> generalExt_ = new List<string>( "bin","txt","xml");
        private string beforeChangeFilename;
        System.IO.StreamReader srBeforeChangeFile;
        private void btnChangeExt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(beforeChangeFilename))
                {
                    string src = InputFile;
                    FileInfo srcinfo = new FileInfo(src);
                    int extlen = srcinfo.Extension.Length;
                    if (extlen >= 5)
                        extlen = 0;

                    string srcwithoutext = srcinfo.FullName.Substring(0, srcinfo.FullName.Length - extlen);
                    string ext = txtExt.Text;
                    ext = ext.Split(' ')[0];

                    string dstname = srcwithoutext + '.' + ext;
                    if (DialogResult.Yes != MessageBox.Show(
                        Properties.Resources.Q_RENAME_EXTENSION,
                        Application.ProductName,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2))
                    {
                        return;
                    }

                    srcinfo.MoveTo(dstname);
                    beforeChangeFilename = InputFile;
                    srBeforeChangeFile = new StreamReader(dstname);
                    InputFile = dstname;
                    analyzefile(dstname);
                    btnChangeExt.Text = "bbb";
                }
                else
                {
                    srBeforeChangeFile.Close();
                    srBeforeChangeFile = null;
                    System.IO.File.Move(InputFile, beforeChangeFilename);
                    InputFile = beforeChangeFilename;
                    beforeChangeFilename = null;
                    analyzefile(InputFile);
                    btnChangeExt.Text = "bbb";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Application.ProductName);
            sb.Append(" ");
            sb.Append("version");
            sb.Append(" ");
            sb.Append(Assembly.GetExecutingAssembly().GetName().Version.Major.ToString());
            sb.Append(".");
            sb.Append(Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString());

            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine(
            "This program is free software: you can redistribute it and/or modify" + "\r\n" +
            "it under the terms of the GNU General Public License as published by" + "\r\n" +
            "the Free Software Foundation, either version 3 of the License, or" + "\r\n" +
            "(at your option) any later version." + "\r\n" +
            "" + "\r\n" +
            "This program is distributed in the hope that it will be useful," + "\r\n" +
            "but WITHOUT ANY WARRANTY; without even the implied warranty of" + "\r\n" +
            "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the" + "\r\n" +
            "GNU General Public License for more details." + "\r\n" +
            "" + "\r\n" +
            "You should have received a copy of the GNU General Public License" + "\r\n" +
            "along with this program.  If not, see <http://www.gnu.org/licenses/>."
            );

            Ambiesoft.CenteredMessageBox.Show(
                this,
                sb.ToString(),
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}