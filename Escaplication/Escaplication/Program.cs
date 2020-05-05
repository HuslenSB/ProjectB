using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Escaplication
{
    public static class Program
    {
        /// <summary>
        /// Het startpunt van de applicatie.
        /// </summary>
        [STAThread]
        public static void Main()

        {
            StreamWriter StrWriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            StrWriter.WriteLine("false");
            StrWriter.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HoofdMenu());
        }
    }
}
