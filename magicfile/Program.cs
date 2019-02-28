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
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

using Ambiesoft;

namespace magicfile
{
    static class Program
    {
        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            Ambiesoft.CppUtils.AmbSetProcessDPIAware();

            thread_ = new Thread(new ThreadStart(theOtherWork));
            thread_.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FormMain f = new FormMain();
            if (args.Length == 1)
            {
                f.InputFile = args[0];
            }
            else if (args.Length > 1)
            {
                foreach (string arg in args)
                {
                    if (!File.Exists(arg))
                    {
                        CppUtils.Fatal(string.Format(Properties.Resources.INTPUFILE_NOT_FOUND, args[0]));
                        continue;
                    }

                    try
                    {
                        Process.Start(Application.ExecutablePath, arg);
                    }
                    catch (Exception ex)
                    {
                        CppUtils.Alert(ex);
                        continue;
                    }
                }
                return 0;
            }
            Application.Run(f);
            return 0;
        }
        internal static Thread thread_;
        static System.Collections.Generic.Dictionary<string,string> dic_ = new Dictionary<string,string>();
        static private void theOtherWork()
        {
            try
            {
                FileInfo fi = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string file = fi.Directory.FullName + "\\routines" + "\\mime.txt";
            
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] seped = line.Split(' ');
                        if (seped.Length > 1)
                        {
                            dic_.Add(seped[0], seped[1]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName);
            }
        }
        internal static string getExtension(string mime, string reigai)
        {
            try
            {
                thread_.Join();
                string ret = dic_[mime];
                if (!string.IsNullOrEmpty(reigai))
                {
                    ret = ret.Replace(reigai, "");
                    ret = ret.Replace("  ", " ");
                }
                return ret;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}