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
if (!Directory.Exists(Application.StartupPath + "\\Gebruikers\\") && !Directory.Exists(Environment.CurrentDirectory + "/Recensies/") && !Directory.Exists(Environment.CurrentDirectory + "//Gebruikers//" + "Loggedincheck")&& !Directory.Exists(Environment.CurrentDirectory + "//Gebruikers//" + "Admin"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Gebruikers\\");
                Directory.CreateDirectory(Environment.CurrentDirectory + "/Recensies/");
                StreamWriter StrWriter = new StreamWriter(Application.StartupPath + "/Recensies/" + "Test.txt");
                StrWriter.WriteLine("Huslen");
                StrWriter.WriteLine("Sparta");
                StrWriter.WriteLine("Leuke kamer!");
                StrWriter.WriteLine("5");
                StrWriter.Close();
                StreamWriter StrWriter2 = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                StrWriter2.WriteLine("false");
                StrWriter2.Close();
                StreamWriter StrWriter4 = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Admin.txt");
                StrWriter4.WriteLine("Admin");
                StrWriter4.WriteLine("Admin");
                StrWriter4.Close();
            }
            StreamWriter StrWriter3 = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            StrWriter3.WriteLine("false");
            StrWriter3.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HoofdMenu());
        }
    }
}
