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
                StreamWriter recensiewriter = new StreamWriter(Application.StartupPath + "/Recensies/" + "Test.txt");
                recensiewriter.WriteLine("Huslen");
                recensiewriter.WriteLine("Sparta");
                recensiewriter.WriteLine("Leuke kamer!");
                recensiewriter.WriteLine("5");
                recensiewriter.Close();
                StreamWriter checkwriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                checkwriter.WriteLine("false");
                checkwriter.Close();
                StreamWriter adminwriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Admin.txt");
                adminwriter.WriteLine("Admin");
                adminwriter.WriteLine("Admin");
                adminwriter.Close();
            }

        StreamWriter checkwriter2 = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
        checkwriter2.WriteLine("false");
        checkwriter2.Close();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new HoofdMenu());
        }
    }
}
