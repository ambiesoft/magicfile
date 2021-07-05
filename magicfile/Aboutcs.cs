using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace magicfile
{
    public partial class Aboutcs : Form
    {
        public Aboutcs()
        {
            InitializeComponent();


            // txtMagic
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Application.ProductName);
                sb.Append(" ");
                sb.Append("version");
                sb.Append(" ");

                sb.Append(Ambiesoft.AmbLib.getAssemblyVersion(Assembly.GetExecutingAssembly(),3));

                sb.AppendLine();
                sb.AppendLine(Ambiesoft.AmbLib.getAssemblyCopyright(Assembly.GetExecutingAssembly()));// "Copyright 2017 Ambiesoft");
                sb.AppendLine("https://ambiesoft.github.io/webjumper/?target=magicfile");


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

                sb.AppendLine("---");
                sb.AppendLine("Icons made by Roundicons from www.flaticon.com is licensed by CC 3.0 BY");
                txtMagicFile.Text = sb.ToString();
            }

            // file
            {
                StringBuilder sb=new StringBuilder();
                string fileexe = Path.Combine(
                    Path.GetDirectoryName(Application.ExecutablePath),
                    "routines",
                    "file.exe");
                if (File.Exists(fileexe))
                {
                    int retval;
                    string output, error;
                    string arg = "--version";
                    sb.AppendLine("> " + Ambiesoft.AmbLib.doubleQuoteIfSpace(fileexe) + " " + arg);
                    Ambiesoft.AmbLib.OpenCommandGetResult(fileexe,
                        arg,
                        Encoding.UTF8,
                        out retval,
                        out output,
                        out error);
                    sb.AppendLine(output);
                    sb.AppendLine("> ");
                    txtFile.Text = sb.ToString();
                }
                else
                {
                    // fileexe not found
                    txtFile.Text = string.Format(Properties.Resources.FILEEXE_NOT_FOUND, fileexe);
                }
            }

            // donate
            {
                
            }
        }

        private void Aboutcs_Load(object sender, EventArgs e)
        {

        }
    }
}
