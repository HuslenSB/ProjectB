using System;
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
    
    public Recensie()
        {
            InitializeComponent();

        }


        public static string pathh = Application.StartupPath + "\\Recensies\\";
        public static string[] RecensiePath = Directory.GetFiles(pathh);

        public void Form1_Load(object sender, EventArgs e)
        {
            int totalfiles = Directory.GetFiles(pathh).Length;

            // Recensie lijst

            if (totalfiles > 0)
            {


                for (int i = 0, LocPointGB = 333, LocPointTB = 390, LocPointLabel = 359, LocPointSter = 32; i < totalfiles; i++, LocPointGB += 150, LocPointTB += 150, LocPointLabel += 150)
                {
                    string[] ArrayRecensies = File.ReadAllLines(Convert.ToString(RecensiePath[i]));

                    // Groupbox

                    GroupBox recensiegb = new GroupBox();
                    recensiegb.Name = "";
                    recensiegb.Size = new Size(432, 145);
                    recensiegb.Location = new Point(3, LocPointGB);
                    recensiegb.TabIndex = 0;
                    recensiegb.TabStop = false;
                    recensiegb.Text = ArrayRecensies[0];



                    // Commentaar

                    RichTextBox commentaar = new RichTextBox();
                    commentaar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                    commentaar.Text = ArrayRecensies[2];
                    commentaar.Location = new Point(91, LocPointTB);
                    commentaar.Size = new Size(270, 52);

                    // Naam van kamer

                    Label naamkamer = new Label();
                    naamkamer.AutoSize = true;
                    naamkamer.Location = new Point(166, LocPointLabel);
                    naamkamer.Size = new Size(103, 13);
                    naamkamer.Name = "Kamernaam";
                    naamkamer.Text = ArrayRecensies[1];

                    // Sterren

                    Label ster = new Label();
                    ster.AutoSize = true;
                    ster.Location = new System.Drawing.Point(8, LocPointSter);
                    ster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    ster.Name = "label5";
                    ster.Size = new System.Drawing.Size(79, 17);
                    ster.TabIndex = 6;
                    ster.Text = "Sterren " + ArrayRecensies[3] + "/5";

                    panel1.Controls.Add(naamkamer);
                    panel1.Controls.Add(commentaar);
                    panel1.Controls.Add(recensiegb);
                    recensiegb.Controls.Add(ster);
                }
            }

        }

     

        private void Recensiebtn_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Gebruikers\\" + Gebruikersnaamtxt.Text + ".txt";
            int ster = Int32.Parse(sterrentxt.Text);

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lines[0] == Gebruikersnaamtxt.Text)
                {
                    if (lines[1] == Wachtwoordtxt.Text)
                    {
                        if (ster >= 0 && ster <= 5)
                        {
                            StreamWriter StrWriter = new StreamWriter(Application.StartupPath + "\\Recensies\\" + Gebruikersnaamtxt.Text + ".txt");
                            StrWriter.WriteLine(Gebruikersnaamtxt.Text);
                            StrWriter.WriteLine(kamertxt.Text);
                            StrWriter.WriteLine(commentaartxt.Text);
                            StrWriter.WriteLine(sterrentxt.Text);
                            StrWriter.Close();
                            MessageBox.Show("Recensie voltooid");
                        }
                        else
                        {
                            MessageBox.Show("Typ een getal tussen 0-5 bij sterren");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Wachtwoord onjuist");
                    }
                }


            }
            else
            {
                MessageBox.Show("Gebruikersnaam onjuist");
            }






        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Homepage" drukt, deze teruggaat naar het begin scherm.

            var Hoofd = new HoofdMenu();
            this.Hide();
            Hoofd.ShowDialog();
            this.Close();
        }
        private void Thema_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Thema" drukt, deze doorgaat naar het informatie scherm.

            var thema = new Informatie();
            this.Hide();
            thema.ShowDialog();
            this.Close();
        }



        private void Tarieven_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Tarieven" drukt, deze doorgaat naar het Tarieven scherm.

            var tarief = new Tarieven_Tab();
            this.Hide();
            tarief.ShowDialog();
            this.Close();
        }


        private void Reserveren_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Reserveren" drukt, deze doorgaat naar het reservatie scherm.

            var Reserveer = new Reserveren();
            this.Hide();
            Reserveer.ShowDialog();
            this.Close();
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Contact" drukt, deze doorgaat naar het contact scherm.

            var Contacten = new Contact_Tab();
            this.Hide();
            Contacten.ShowDialog();
            this.Close();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Acount" drukt, deze doorgaat naar het login scherm.

            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }
    }
}
