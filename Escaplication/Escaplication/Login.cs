using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            StreamWriter ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + RegisterGebruikersnaam.Text + ".txt");
            ab.WriteLine(RegisterGebruikersnaam.Text);
            ab.WriteLine(RegisterWW.Text);
            ab.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Gebruikers\\" + Gebruikersnaamtxt.Text + ".txt";
            string gbnaam = Gebruikersnaamtxt.Text;
            string password = Wachtwoordtxt.Text;
            string passwordcheck;
            if (!File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        passwordcheck = sr.ReadLine();
                        if (passwordcheck == password)
                        {
                            Application.Run(new Form1());
                        }
                        else
                        {
                            MessageBox.Show("Nope");
                        }
                        
                    }
                    
                }
            }

        }
    }
}
