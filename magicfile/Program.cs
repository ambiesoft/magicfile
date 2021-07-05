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
        static bool processArgs(string[] args, out string inputFile)
        {
            inputFile = string.Empty;
            if (args.Length > 1)
            {
                foreach (string arg in args)
                {
                    if (!File.Exists(arg))
                    {
                        CppUtils.Fatal(string.Format(Properties.Resources.INTPUFILE_NOT_FOUND, arg));
                        continue;
                    }

                    try
                    {
                        Process.Start(Application.ExecutablePath, AmbLib.doubleQuoteIfSpace(arg));
                    }
                    catch (Exception ex)
                    {
                        CppUtils.Alert(ex);
                        continue;
                    }
                }
                return false;
            }
            else if (args.Length == 1)
            {
                inputFile = args[0];
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            Ambiesoft.CppUtils.AmbSetProcessDPIAware();

            string inputFile;
            if (!processArgs(args, out inputFile))
                return 0;

            thread_ = new Thread(new ThreadStart(theOtherWork));
            thread_.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain f = new FormMain();
            f.InputFile = inputFile;
            Application.Run(f);
            return 0;
        }
        internal static Thread thread_;
        static System.Collections.Generic.Dictionary<string,string> dic_ = new Dictionary<string,string>();

        static private void theOtherWork2(string file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line) || line[0] == '#')
                        continue;

                    string[] sepped = line.Split(new char[] { ' ', '\t' }, 2);
                    if (sepped.Length < 2)
                        continue;

                    string mime = sepped[0];
                    if (dic_.ContainsKey(mime))
                        continue;

                    string[] exts = sepped[1].Split(new char[] { ' ', '\t', ',' });
                    if (exts.Length < 1)
                        continue;

                    string ext = string.Join(" ", exts);
                    dic_.Add(mime, ext);
                }
            }
        }
        static private void theOtherWork()
        {
            try
            {
                FileInfo fiMime = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string folderRoutime = Path.Combine(fiMime.Directory.FullName, "routines");
                string fileMime = Path.Combine(folderRoutime, "mime.txt");

                theOtherWork2(fileMime);            

                // extra
                string fileExtra = Path.Combine(folderRoutime, "extramime.txt");
                theOtherWork2(fileExtra);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Application.ProductName);
            }
        }

        public static string GetFirstExtension(string ext)
        {
            if (string.IsNullOrEmpty(ext))
                return string.Empty;
            return ext.Split(' ')[0];
        }
        public static string RemoveDotFromExt(string ext)
        {
            return ext.TrimStart('.');
        }
        static string RemoveExtFromSpaceseparedString(string exts, string toRemove)
        {
            string[] all = exts.Split(' ');
            List<string> allResult = new List<string>();
            foreach(string s in all)
            {
                if (string.Compare(RemoveDotFromExt(s), RemoveDotFromExt(toRemove), true) == 0)
                    continue;
                allResult.Add(s);
            }
            return string.Join(" ", allResult);
        }
        internal static string getExtension(string mime, string reigai)
        {
            try
            {
                thread_.Join();
                string ret = RemoveExtFromSpaceseparedString(dic_[mime], reigai);
                return ret;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}