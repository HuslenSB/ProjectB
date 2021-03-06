﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project_B_informatie;

namespace Escaplication
{
    public partial class Recensie : Form
    {

        public string[] checkpassword;
        public static string RecensiePath = Application.StartupPath + "\\Recensies\\";
        public static string[] RecensieArray = Directory.GetFiles(RecensiePath);

        public Recensie()
        {
            InitializeComponent();
            checkpassword = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            if (Convert.ToBoolean(checkpassword[0]) == true)
            {
                Gbnaam.Dispose();
                Wachtwoord.Dispose();
                checkBox.Dispose();
                Gebruikersnaamtxt.Dispose();
                Wachtwoordtxt.Dispose();
            }

        }

        public void RecensieLoad(object sender, EventArgs e)
        {
            int totalfiles = Directory.GetFiles(RecensiePath).Length;

            if (totalfiles > 0)
            {
                RecensieMaker(totalfiles);
            }

        }

        // Controleert of gebruikersnaam en wachtwoord correct zijn bij het schrijven van een recensie. 
        // Checkt en onthoudt of de gebruiker "Ingelogd blijven" heeft aangevinkt.
        public void RecensieUser(string Gebruikersnaamtext, string Wachtwoordtext)
        {
            string pathGebruikers = Application.StartupPath + "\\Gebruikers\\" + Gebruikersnaamtext + ".txt";
            var ster = Int32.Parse(sterrentxt.Text);

            if (File.Exists(pathGebruikers))
            {
                string[] lines = File.ReadAllLines(pathGebruikers);
                if (lines[0] == Gebruikersnaamtext)
                {
                    if (lines[1] == Wachtwoordtext)
                    {
                        if ((Convert.ToBoolean(checkpassword[0]) == false) && (Gebruikersnaamtext != "Admin"))
                        {
                            StreamWriter WriteText = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                            if (checkBox.Checked)
                            {
                                WriteText.WriteLine("true");
                            }

                            else
                            {
                                WriteText.WriteLine("false");
                            }

                            WriteText.WriteLine(Gebruikersnaamtext);
                            WriteText.WriteLine(Wachtwoordtext);
                            WriteText.Close();
                        }
                        if (ster >= 0 && ster <= 5)
                        {
                            WriteRecensieFile(Gebruikersnaamtext);
                        }
                        else
                        {
                            messagebox("Typ een getal tussen 0-5 bij sterren");
                        }
                    }
                    else
                    {
                        messagebox("Wachtwoord onjuist");
                    }
                }
            }
            else
            {
                messagebox("Gebruikersnaam niet gevonden");
            }
        }

        // Functie die de recensie opslaat in een txt file.

        public void WriteRecensieFile(string usernametext)
        {
            StreamWriter WriteText = new StreamWriter(Application.StartupPath + "\\Recensies\\" + usernametext + ".txt");
            WriteText.WriteLine(usernametext);
            WriteText.WriteLine(kamertxt.Text);
            WriteText.WriteLine(commentaartxt.Text);
            WriteText.WriteLine(sterrentxt.Text);
            WriteText.Close();
            messagebox("Recensie voltooid");
        }


        // Functie die de opgeslagen recensies weergeeft in de recensielijst.
        public void RecensieMaker(int totalfiles)
        {
            for (int i = 0, LocPointGB = 15, LocPointTB = 51, LocPointLabel = 18, LocPointSter = 24; i < totalfiles; i++, LocPointGB += 150, LocPointTB += 150, LocPointLabel += 150)
            {
                RecensieArray = Directory.GetFiles(RecensiePath);
                string[] ArrayRecensies = File.ReadAllLines(Convert.ToString(RecensieArray[i]));

                GroupBox recensiegb = new GroupBox();
                recensiegb.Name = "";
                recensiegb.Size = new Size(432, 145);
                recensiegb.Location = new Point(3, LocPointGB);
                recensiegb.TabIndex = 0;
                recensiegb.TabStop = false;
                recensiegb.Text = ArrayRecensies[0];

                RichTextBox commentaar = new RichTextBox();
                commentaar.Text = ArrayRecensies[2];
                commentaar.Location = new Point(91, LocPointTB);
                commentaar.Size = new Size(270, 49);

                Label naamkamer = new Label();
                naamkamer.AutoSize = true;
                naamkamer.Location = new Point(182, LocPointLabel);
                naamkamer.Size = new Size(63, 13);
                naamkamer.Name = "Kamernaam";
                naamkamer.Text = ArrayRecensies[1];

                Label ster = new Label();
                ster.AutoSize = true;
                ster.Location = new Point(8, LocPointSter);
                ster.Margin = new Padding(4, 0, 4, 0);
                ster.Name = "label5";
                ster.Size = new Size(63, 13);
                ster.TabIndex = 6;
                ster.Text = "Sterren " + ArrayRecensies[3] + "/5";

                ScrollRecensielijst.Controls.Add(naamkamer);
                ScrollRecensielijst.Controls.Add(commentaar);
                ScrollRecensielijst.Controls.Add(recensiegb);
                recensiegb.Controls.Add(ster);
            }
        }

        // De buttons om van pagina te wisselen.

        private void Homepage_Click(object sender, EventArgs e)
        {
            HoofdmenuClick();
        }
        private void Thema_Click(object sender, EventArgs e)
        {
            ThemaClick();
        }
        private void Tarieven_Click(object sender, EventArgs e)
        {
            TarievenClick();
        }
        private void Reserveren_Click(object sender, EventArgs e)
        {
            ReserveerClick();
        }
        private void Contact_Click(object sender, EventArgs e)
        {
            ContactClick();
        }
        private void AccountPagina_Click(object sender, EventArgs e)
        {
            AccountpaginaClick();
        }
        private void Wachtwoordverberger(object sender, EventArgs e)
        {
            Wachtwoordtxt.PasswordChar = '●';
        }

        // Functie voor messagebox popup.

        public void messagebox(string text)
        {
            MessageBox.Show(text);
        }

        // Functies voor het veranderen van de pagina met de knoppen.

        public void ThemaClick()
        {
            var thema = new Informatie();
            this.Hide();
            thema.ShowDialog();
            this.Close();
        }
        public void TarievenClick()
        {
            var tarief = new Tarieven_Tab();
            this.Hide();
            tarief.ShowDialog();
            this.Close();
        }
        public void ContactClick()
        {
            var Contacten = new Contact_Tab();
            this.Hide();
            Contacten.ShowDialog();
            this.Close();
        }
        public void ReserveerClick()
        {
            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();
        }
        public void HoofdmenuClick()
        {
            var HoofdMenu = new HoofdMenu();
            this.Hide();
            HoofdMenu.ShowDialog();
            this.Close();
        }
        public void AccountpaginaClick()
        {
            var Accountpagina = new Accountpagina();
            this.Hide();
            Accountpagina.ShowDialog();
            this.Close();
        }

        private void Recensiebtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(checkpassword[0]) == false)
            {
                RecensieUser(Gebruikersnaamtxt.Text, Wachtwoordtxt.Text);
            }
            else
            {
                RecensieUser(checkpassword[1], checkpassword[2]);
            }
            var Recensie = new Recensie();
            this.Hide();
            Recensie.ShowDialog();
            this.Close();
        }
    }
}
