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

using Ambiesoft;

namespace magicfile
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            HashIni ini = Profile.ReadAll(IniFile);

            bool bval;
            Profile.GetBool("Option", "LocationSaved", false, out bval, ini);
            if (bval)
            {
                int x, y, width, height;
                Profile.GetInt("Option", "X", this.Location.X, out x, ini);
                Profile.GetInt("Option", "Y", this.Location.Y, out y, ini);

                Profile.GetInt("Option", "Width", this.Size.Width, out width, ini);
                Profile.GetInt("Option", "Height", this.Size.Height, out height, ini);

                if(AmbLib.IsRectAppearInScreen(new Rectangle(x,y,width,height)))
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(x, y);
                    this.Size = new Size(width, height);
                }
            }            

        }
        internal string InputFile;

        private bool createFileProcessGetResult(string app, string arg,
            out string output, out int exitCode)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = app;
            psi.Arguments = arg;
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            // psi.WorkingDirectory = fi.Directory.FullName;
            Process p = Process.Start(psi);
            string outputTemp = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            exitCode = p.ExitCode;
            output = outputTemp;
            return true;
        }
        private void analyzefile(string filename)
        {
            string origExt = string.Empty;
            string fileexefull = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                "routines", "file.exe");
            string magicfilefull = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                "routines", "magic.mgc");
            if(!File.Exists(fileexefull))
            {
                MessageBox.Show(string.Format(Properties.Resources.FILEEXE_NOT_FOUND, fileexefull),
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            // string filenameshort = Ambiesoft.CppUtils.GetShortFileName(filename);

            try
            {
                txtFile.Text = filename;
                origExt = Path.GetExtension(filename).Trim('.');
                {
                    string arg = "-b -m " + "\"" + magicfilefull + "\" " + "\"" + filename + "\"";
                    string output;
                    int exitCode;
                    if(!createFileProcessGetResult(fileexefull, arg, out output, out exitCode) || exitCode != 0)
                    {
                        MessageBox.Show(
                            string.Format(Properties.Resources.COMMAN_LINE_END_WITH_ERROR + "\r\n" + "error:{0}", exitCode),
                            Application.ProductName,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        return;
                    }
                    output = output.Trim();
                    txtMagic.Text = output;
                }
                {
                    string arg = "-b --mime-type -m " + "\"" + magicfilefull + "\" " + "\"" + filename + "\"";
                    string output;
                    int exitCode;
                    if (!createFileProcessGetResult(fileexefull, arg, out output, out exitCode) || exitCode != 0)
                    {
                        MessageBox.Show(string.Format("error:{0}", exitCode));
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
            if( string.IsNullOrEmpty(origExt) || ( 
                (txtExt.Text.Length != 0 && (string.Compare(text, origExt, true) != 0)) &&
                !IsWellknownExtension(text)))
            {
                btnChangeExt.Enabled = true;
            }
            else
            {
                btnChangeExt.Enabled = false;
            }
        }
        bool IsWellknownExtension(string ext)
        {
            return string.Compare(ext, "bin", true) == 0 ||
                string.Compare(ext, "txt", true) == 0;
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
                    if (DialogResult.Yes != Ambiesoft.CppUtils.CenteredMessageBox(
                        this,
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
                    /// btnChangeExt.Text = "bbb";
                }
                else
                {
                    srBeforeChangeFile.Close();
                    srBeforeChangeFile = null;
                    System.IO.File.Move(InputFile, beforeChangeFilename);
                    InputFile = beforeChangeFilename;
                    beforeChangeFilename = null;
                    analyzefile(InputFile);
                    /// btnChangeExt.Text = "bbb";
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
            //Ambiesoft.CppUtils.CenteredMessageBox(
            //    this,
            //    sb.ToString(),
            //    Application.ProductName,
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);

            using( Aboutcs about = new Aboutcs())
            {
                about.ShowDialog(this);
            }
        }

        string IniFile
        {
            get
            {
                return Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".ini";
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                HashIni ini = Profile.ReadAll(IniFile);

                Profile.WriteInt("Option", "X", this.Location.X, ini);
                Profile.WriteInt("Option", "Y", this.Location.Y, ini);
                Profile.WriteInt("Option", "Width", this.Size.Width, ini);
                Profile.WriteInt("Option", "Height", this.Size.Height, ini);
                Profile.WriteBool("Option", "LocationSaved", true, ini);

                if(!Profile.WriteAll(ini,IniFile))
                {
                    Ambiesoft.CppUtils.Alert(this, Properties.Resources.FAILED_TO_SAVE_INIFILE);
                }
            }
        }
    }
}