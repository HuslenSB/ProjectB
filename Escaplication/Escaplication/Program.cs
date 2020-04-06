using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaplication
{
    public static class Program
    {
        //Zorgt ervoor dat hij weet naar welke pagina het programma moet gaan.
        public static int pagina = 0;
        public static bool active = true; 

        /// <summary>
        /// Het startpunt van de applicatie.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            while (active)
            {
                //Start hoofmenu
                if (pagina == 0)
                {
                    //Hoofdmenu wordt aangeroepen
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new HoofdMenu());
                }
                //Als op de link escape room informatie is geklikt
                if (pagina == 1)
                {
                    //hier komt straks het aanroeppunt voor de windows form van escape room information
                    Debug.WriteLine("Escape room Information");
                }
                //Als op de link locatie en contactgevens is geklikt
                if (pagina == 2)
                {
                    //hier komt straks het aanroeppunt voor de windows form van locatie en contactgegevens
                    Debug.WriteLine("Escape room Information");
                }
                //Als op de link escape room reserveren is geklikt
                if (pagina == 3)
                {
                    //hier komt straks het aanroeppunt voor de windows form van Escape room reserveren
                    Debug.WriteLine("Escape room Reserveren");
                }
                //Als op de link recencies is geklikt
                if (pagina == 4)
                {
                    //hier komt straks het aanroeppunt voor de windows form van Escape room Recensies
                    Debug.WriteLine("Recensies");
                }
                Debug.WriteLine(active);
            }
        }
    }
}
