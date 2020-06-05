using Project_B_informatie;
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
using System.Diagnostics;

namespace Escaplication
{
    public partial class Accountpagina : Form
    {
        public string[] lines, lines2, lines3, checkpassword;
        public int countres;

        public Accountpagina()
        {
            InitializeComponent();
            Paginatabs.Appearance = TabAppearance.FlatButtons;
            Paginatabs.ItemSize = new Size(0, 1); 
            Paginatabs.SizeMode = TabSizeMode.Fixed;
            checkpassword = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            //Deze methode checkt of er al is ingelogd
            if (Convert.ToBoolean(checkpassword[0]) == true)
            {
                this.login(checkpassword[1], checkpassword[2]);
            }
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            // Deze code kijkt of de gebruikersnaam bruikbaar is

            if (!File.Exists(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt"))
            {
                // Deze code kijkt of de wachtwoorden overeenkomen

                if (passwordregtxtbox.Text == passwordrepeattxtbox.Text && usernameregtxtbox.Text.Length > 0)
                {
                    var ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt");
                    ab.WriteLine(usernameregtxtbox.Text);
                    ab.WriteLine(passwordregtxtbox.Text);
                    ab.Close();
                    MessageBox.Show("Registreren voltooid");
                    using (var af = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + "Accounts" + ".txt"))
                    {
                        af.WriteLine(usernameregtxtbox.Text + ".txt");
                        af.Close();
                    }
                }
                else
                {
                    MessageBox.Show("De wachtwoorden komen niet overeen of je hebt geen gebruikersnaam ingevoerd");
                }
            }
            else
            {
                MessageBox.Show("Deze gebruikersnaam bestaat al");
            }
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            this.login(usernamelogintxtbox.Text, passlogintxtbox.Text);
        }

        // Deze methode logt de gebruiker in.

        public void login(string usernamelogintxt, string passlogintxt) { 
            var path = Application.StartupPath + "\\Gebruikers\\" + usernamelogintxt + ".txt";
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
                {
                    if (lines[0] == usernamelogintxt && lines[1] == passlogintxt && usernamelogintxt != "Admin")
                    {
                        // Als de gebruiker het wachtwoord wilt onthouden zorgt deze code daarvoor

                        if (Convert.ToBoolean(checkpassword[0]) == false)
                        {
                            var ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                            if (remembertxtbox.Checked)
                            {
                                ab.WriteLine("true");
                            }
                            else
                            {
                                ab.WriteLine("false");
                            }
                            ab.WriteLine(usernamelogintxt);
                            ab.WriteLine(passlogintxt);
                            ab.Close();
                        }
                        Paginatabs.SelectTab(1);
                        checkpassword = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                        this.usertabtitel.Text = "Welkom " + usernamelogintxt;
                        if (lines.Length != 0)
                        {
                            int i = 2, j = 1, k = 1, LocPointGB = 0, LocPointLabel = 10, LocPointGB2 = 0, LocPointLabel2 = 10;
                            while (i < lines.Length - 5)
                            {
                                var date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                                var date2 = new DateTime(Int32.Parse(lines[i + 2]), Int32.Parse(lines[i + 3]), Int32.Parse(lines[i + 4]));
                                var datecomparinson = DateTime.Compare(date1, date2);
                                // Deze code zorgt ervoor dat de nieuwe reserveringen van de user worden weergegeven

                                if (datecomparinson <= 0)
                                {
                                    var recensiegb = new GroupBox();
                                    recensiegb.Name = "";
                                    recensiegb.Size = new Size(220, 110);
                                    recensiegb.Location = new Point(0, LocPointGB);

                                    var naamkamer = new Label();
                                    naamkamer.AutoSize = true;
                                    naamkamer.Location = new Point(5, LocPointLabel);
                                    naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                    naamkamer.Text = j + ".\nEscaperoom: " + lines[i] + "\nAantal personen: " + lines[i + 1] + "\nDatum: " + lines[i + 4] + "-" + lines[i + 3] + "-" + lines[i + 2] + "\nTijd: " + lines[i+5];

                                    Reserveringpnl.Controls.Add(naamkamer);
                                    Reserveringpnl.Controls.Add(recensiegb);
                                    LocPointGB += 110;
                                    LocPointLabel += 110;
                                    j++;
                                    countres++;
                                }
                                // Deze code zorgt ervoor dat de oude reserveringen van de user worden weergegeven

                                else
                                {
                                    var recensiegb = new GroupBox();
                                    recensiegb.Name = "";
                                    recensiegb.Size = new Size(220, 110);
                                    recensiegb.Location = new Point(0, LocPointGB2);

                                    var naamkamer = new Label();
                                    naamkamer.AutoSize = true;
                                    naamkamer.Location = new Point(5, LocPointLabel2);
                                    naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                    naamkamer.Text = k + ".\nEscaperoom: " + lines[i] + "\nAantal personen: " + lines[i + 1] + "\nDatum: " + lines[i + 4] + "-" + lines[i + 3] + "-" + lines[i + 2] + "\nTijd: " + lines[i + 5] + ":" + lines[i + 6];

                                    oldreserverpnl.Controls.Add(naamkamer);
                                    oldreserverpnl.Controls.Add(recensiegb);
                                    LocPointGB2 += 110;
                                    LocPointLabel2 += 110;
                                    k++;
                                }
                                i += 6;
                            }
                        }
                        deletenumericbox.Maximum = countres;
                    }
                    else if ("Admin" == usernamelogintxt && "Admin" == passlogintxt)
                    {
                        lines2 = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Accounts.txt");
                        Paginatabs.SelectTab(2);
                        int k = 0, LocPointGB = 0, LocPointLabel = 10, LocPointGB2 = 0, LocPointLabel2 = 10;
                        while ( k < lines2.Length)
                        {
                            lines3 = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + lines2[k]);
                            if (lines3.Length != 0)
                            {
                                for (int i = 2, j = 1; i < lines3.Length - 5; i += 6, j++)
                                {
                                    var date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                                    var date2 = new DateTime(Int32.Parse(lines3[i + 2]), Int32.Parse(lines3[i + 3]), Int32.Parse(lines3[i + 4]));
                                    var datecomparinson = DateTime.Compare(date1, date2);
                                    // Deze functie zorgt ervoor dat de admin alle nieuwe reserveringen ziet

                                    if (datecomparinson < 0)
                                    {
                                        var recensiegb = new GroupBox();
                                        recensiegb.Name = "";
                                        recensiegb.Size = new Size(220, 120);
                                        recensiegb.Location = new Point(0, LocPointGB);

                                        var naamkamer = new Label();
                                        naamkamer.AutoSize = true;
                                        naamkamer.Location = new Point(5, LocPointLabel);
                                        naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                        naamkamer.Text = j + ".\nNaam: " + lines3[0] + "\nEscaperoom: " + lines3[i] + "\nAantal personen: " + lines3[i + 1] + "\nDatum: " + lines3[i + 4] + "-" + lines3[i + 3] + "-" + lines3[i + 2] + "\nTijd: " + lines3[i+5] + ":" + lines3[i+6];
                                         

                                        reservpnl.Controls.Add(naamkamer);
                                        reservpnl.Controls.Add(recensiegb);
                                        LocPointGB += 120;
                                        LocPointLabel += 120;
                                    }
                                    //Deze functie zorgt ervoor dat de admin alle oude reserveringen ziet

                                    else
                                    {
                                        var recensiegb = new GroupBox();
                                        recensiegb.Name = "";
                                        recensiegb.Size = new Size(220, 120);
                                        recensiegb.Location = new Point(0, LocPointGB2);

                                        var naamkamer = new Label();
                                        naamkamer.AutoSize = true;
                                        naamkamer.Location = new Point(5, LocPointLabel2);
                                        naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                        naamkamer.Text = j + ".\nNaam: " + lines3[0] + ".\nEscaperoom: " + lines3[i] + "\nAantal personen: " + lines3[i + 1] + "\nDatum: " + lines3[i + 4] + "-" + lines3[i + 3] + "-" + lines3[i + 2] + "\nTijd: " + lines3[i + 5] + ":" + lines3[i + 6];

                                        oldreservpnl.Controls.Add(naamkamer);
                                        oldreservpnl.Controls.Add(recensiegb);
                                        LocPointGB2 += 120;
                                        LocPointLabel2 += 120;
                                    }
                                }
                            }
                            k++;
                        }
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

        private void logoutbtn2_Click(object sender, EventArgs e)
        {
            Paginatabs.SelectTab(0);
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            var Login = new HoofdMenu();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Thema_Click(object sender, EventArgs e)
        {
            var Login = new Informatie();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Tarieven_Click(object sender, EventArgs e)
        {
            var Login = new Tarieven_Tab();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var Login = new Reserveren();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Recenties_Click(object sender, EventArgs e)
        {
            var Login = new Recensie();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        // Deze stukken code zorgen ervoor dat het wachtwoord verborgen blijft

        private void passlogintxtbox_TextChanged(object sender, EventArgs e)
        {
            passlogintxtbox.PasswordChar = '●';
        }

        private void passwordregtxtbox_TextChanged(object sender, EventArgs e)
        {
            passwordregtxtbox.PasswordChar = '●';
        }

        private void passwordrepeattxtbox_TextChanged(object sender, EventArgs e)
        {
            passwordrepeattxtbox.PasswordChar = '●';
        }

        // Deze code zorgt ervoor dat de admin specifieke gebruikers kan zoeken

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            resultspnl.Controls.Clear();
            lines = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + textBox1.Text + ".txt");
            var path = Application.StartupPath + "\\Gebruikers\\" + textBox1.Text + ".txt";
            if (File.Exists(path))
            {
                int i = 2, j = 1, LocPointGB = 0, LocPointLabel = 10;
                while (i < lines.Length - 6)
                {
                    var recensiegb = new GroupBox();
                    recensiegb.Name = "";
                    recensiegb.Size = new Size(220, 110);
                    recensiegb.Location = new Point(0, LocPointGB);

                    var naamkamer = new Label();
                    naamkamer.AutoSize = true;
                    naamkamer.Location = new Point(5, LocPointLabel);
                    naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                    naamkamer.Text = j + ".\nEscaperoom: " + lines[i] + "\nAantal personen: " + lines[i + 1] + "\nDatum: " + lines[i + 4] + "-" + lines[i + 3] + "-" + lines[i + 2] + "\nTijd: " + lines[i + 5] + ":" + lines[i + 6];

                    resultspnl.Controls.Add(naamkamer);
                    resultspnl.Controls.Add(recensiegb);
                    LocPointGB += 110;
                    LocPointLabel += 110;
                    j++;
                    countres++;
                    i += 7;
                }
            }
        }

        private void Contact_Click(object sender, EventArgs e)
        {
            var Login = new Contact_Tab();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Loguitbtn_Click(object sender, EventArgs e)
        {
            Paginatabs.SelectTab(0);
            countres = 0;
            var ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            ab.WriteLine("false");
            ab.Close();
        }

        // Deze code zorgt ervoor dat de gebruiker een reserveringen kan verwijderen

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wil je deze reservering echt verwijderen?", "Verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                if (countres != 0)
            {
                var n = 0;
                var ae = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + checkpassword[1] + ".txt");
                Console.WriteLine(checkpassword[1]);
                for (int i = 2, g = 0; i < lines.Length - 5; i += 6)
                {
                    n = i;
                    var date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    var date2 = new DateTime(Int32.Parse(lines[i + 2]), Int32.Parse(lines[i + 3]), Int32.Parse(lines[i + 4]));
                    var datecomparinson = DateTime.Compare(date1, date2);
                    if (datecomparinson <= 0)
                    {
                        g++;
                        if (g == (int)deletenumericbox.Value)
                        {
                            break;
                        }
                    }
                }
                lines[n] = "";
                lines[n + 1] = "";
                lines[n + 2] = "";
                lines[n + 3] = "";
                lines[n + 4] = "";
                lines[n + 5] = "";
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] != "")
                    {
                        ae.WriteLine(lines[i]);
                    }
                }
                ae.Close();
                    var Login = new Accountpagina();
                    this.Hide();
                    Login.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
