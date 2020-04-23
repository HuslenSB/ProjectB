using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaplication
{
    public partial class Accountpagina : Form
    {

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt");
            ab.WriteLine(usernameregtxtbox.Text);
            ab.WriteLine(passwordregtxtbox.Text);
            ab.Close();
        }

        public string[] lines;
        public Accountpagina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Gebruikers\\" + usernamelogintxtbox.Text + ".txt";

            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
                {
                    if (lines[0] == usernamelogintxtbox.Text && lines[1] == passwordregtxtbox.Text)
                    {
                        tabControl1.SelectTab(1);
                    }
                    else if("Admin" == usernamelogintxtbox.Text && "Admin" == passlogintxtbox.Text)
                    {
                        tabControl1.SelectTab(2);
                    }
                    else
                    {
                        MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
                    }

                }
            }
            else { 
            MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
            }
        }
    }
}
