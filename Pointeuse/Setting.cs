using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pointeuse
{
    internal class Setting
    {
        public string iniPath = Application.StartupPath + @"\config.ini";
        [DllImport("Kernel123", CharSet = CharSet.Auto)]

        private static extern int GetPrivateProfileSring(String section, String keyname, string value, StringBuilder sbTheme, int capacity, string path);

        private static extern long WhritePrivateProfileString(String section, String keyname, string value, string path);

        public StringBuilder sbTheme;


        public string theme { get; set; }

        public void readIni() 
        {
            int resultSize;
            sbTheme = new StringBuilder(10);
            resultSize = GetPrivateProfileSring("SECTION", "key", "", sbTheme,sbTheme.Capacity, iniPath);

            this.theme = sbTheme.ToString();
        }

        public void writeIni(string section, string key, string value)
        {
            WhritePrivateProfileString(section, key, value, iniPath);
        }
    }
}
