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
        public string[] userinfolines, accountlines, adminlines, checkpassword;
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

                if ((passwordregtxtbox.Text == passwordrepeattxtbox.Text) && (usernameregtxtbox.Text.Length > 0))
                {
                    var regstreamwriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt");
                    regstreamwriter.WriteLine(usernameregtxtbox.Text);
                    regstreamwriter.WriteLine(passwordregtxtbox.Text);
                    regstreamwriter.Close();
                    MessageBox.Show("Registreren voltooid");
                    using (var accstreamwriter = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + "Accounts" + ".txt"))
                    {
                        accstreamwriter.WriteLine(usernameregtxtbox.Text + ".txt");
                        accstreamwriter.Close();
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
                userinfolines = File.ReadAllLines(path);
                {
                    if ((userinfolines[0] == usernamelogintxt) && (userinfolines[1] == passlogintxt) && (usernamelogintxt != "Admin"))
                    {
                        // Als de gebruiker het wachtwoord wilt onthouden zorgt deze code daarvoor

                        if (Convert.ToBoolean(checkpassword[0]) == false)
                        {
                            var loginstreamwriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                            if (remembertxtbox.Checked)
                            {
                                loginstreamwriter.WriteLine("true");
                            }
                            else
                            {
                                loginstreamwriter.WriteLine("false");
                            }
                            loginstreamwriter.WriteLine(usernamelogintxt);
                            loginstreamwriter.WriteLine(passlogintxt);
                            loginstreamwriter.Close();
                        }
                        Paginatabs.SelectTab(1);
                        checkpassword = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                        this.usertabtitel.Text = "Welkom " + usernamelogintxt;
                        if (userinfolines.Length != 0)
                        {
                            var i = 2;
                            var j = 1;
                            var k = 1;
                            var LocPointGB = 0;
                            var LocPointLabel = 10;
                            var LocPointGB2 = 0;
                            var LocPointLabel2 = 10;
                            while (i < userinfolines.Length - 5)
                            {
                                var date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                                var date2 = new DateTime(Int32.Parse(userinfolines[i + 2]), Int32.Parse(userinfolines[i + 3]), Int32.Parse(userinfolines[i + 4]));
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
                                    naamkamer.Text = $"{k}.\nEscaperoom: {userinfolines[i]}\nAantal personen: {userinfolines[i + 1]}\nDatum: {userinfolines[i + 4]}-{userinfolines[i + 3]}-{userinfolines[i + 2]}\nTijd: {userinfolines[i + 5]}";

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
                                    naamkamer.Text = $"{k}.\nEscaperoom: {userinfolines[i]}\nAantal personen: {userinfolines[i + 1]}\nDatum: {userinfolines[i + 4]}-{userinfolines[i + 3]}-{userinfolines[i + 2]}\nTijd: {userinfolines[i + 5]}";

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
                    else if (("Admin" == usernamelogintxt) && ("Admin" == passlogintxt))
                    {
                        accountlines = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Accounts.txt");
                        Paginatabs.SelectTab(2);
                        int k = 0;
                        var LocPointGB = 0;
                        var LocPointLabel = 10;
                        var LocPointGB2 = 0;
                        var LocPointLabel2 = 10;
                        while ( k < accountlines.Length)
                        {
                            adminlines = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + accountlines[k]);
                            if (adminlines.Length != 0)
                            {
                                for (int i = 2, j = 1; i < adminlines.Length - 5; i += 6, j++)
                                {
                                    var date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                                    var date2 = new DateTime(Int32.Parse(adminlines[i + 2]), Int32.Parse(adminlines[i + 3]), Int32.Parse(adminlines[i + 4]));
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
                                        naamkamer.Text = $"{j}.\nNaam: {adminlines[0]}\nEscaperoom: {adminlines[i]}\nAantal personen: {adminlines[i + 1]}\nDatum: {adminlines[i + 4]}-{adminlines[i + 3]}-{adminlines[i + 2]}\nTijd: {adminlines[i+5]}";
                                         

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
                                        naamkamer.Text = $"{j}.\nNaam: {adminlines[0]}\nEscaperoom: {adminlines[i]}\nAantal personen: {adminlines[i + 1]}\nDatum: {adminlines[i + 4]}-{adminlines[i + 3]}-{adminlines[i + 2]}\nTijd: {adminlines[i + 5]}";

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
            var Homepage = new HoofdMenu();
            this.Hide();
            Homepage.ShowDialog();
            this.Close();
        }

        private void Thema_Click(object sender, EventArgs e)
        {
            var Thema = new Informatie();
            this.Hide();
            Thema.ShowDialog();
            this.Close();
        }

        private void Tarieven_Click(object sender, EventArgs e)
        {
            var Tarieven = new Tarieven_Tab();
            this.Hide();
            Tarieven.ShowDialog();
            this.Close();
        }

        private void Reserveren_Click(object sender, EventArgs e)
        {
            var Reserveren = new Reserveren();
            this.Hide();
            Reserveren.ShowDialog();
            this.Close();
        }

        private void Recenties_Click(object sender, EventArgs e)
        {
            var Recensies = new Recensie();
            this.Hide();
            Recensies.ShowDialog();
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
            userinfolines = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + textBox1.Text + ".txt");
            var path = Application.StartupPath + "\\Gebruikers\\" + textBox1.Text + ".txt";
            if (File.Exists(path))
            {
                int i = 2, j = 1, LocPointGB = 0, LocPointLabel = 10;
                while (i < userinfolines.Length - 6)
                {
                    var recensiegb = new GroupBox();
                    recensiegb.Name = "";
                    recensiegb.Size = new Size(220, 110);
                    recensiegb.Location = new Point(0, LocPointGB);

                    var naamkamer = new Label();
                    naamkamer.AutoSize = true;
                    naamkamer.Location = new Point(5, LocPointLabel);
                    naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                    naamkamer.Text = $"{j}.\nEscaperoom: {userinfolines[i]}\nAantal personen: {userinfolines[i + 1]}\nDatum: {userinfolines[i + 4]}-{userinfolines[i + 3]}-{userinfolines[i + 2]}\nTijd: {userinfolines[i + 5]}";

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
            var Contact = new Contact_Tab();
            this.Hide();
            Contact.ShowDialog();
            this.Close();
        }

        private void Loguitbtn_Click(object sender, EventArgs e)
        {
            Paginatabs.SelectTab(0);
            countres = 0;
            var logoutstreamwriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            logoutstreamwriter.WriteLine("false");
            logoutstreamwriter.Close();
        }

        // Deze code zorgt ervoor dat de gebruiker een reserveringen kan verwijderen

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wil je deze reservering echt verwijderen?", "Verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                if (countres != 0)
            {
                var n = 0;
                var deletestreamwriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + checkpassword[1] + ".txt");
                Console.WriteLine(checkpassword[1]);
                for (int i = 2, g = 0; i < userinfolines.Length - 5; i += 6)
                {
                    n = i;
                    var date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    var date2 = new DateTime(Int32.Parse(userinfolines[i + 2]), Int32.Parse(userinfolines[i + 3]), Int32.Parse(userinfolines[i + 4]));
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
                userinfolines[n] = "";
                userinfolines[n + 1] = "";
                userinfolines[n + 2] = "";
                userinfolines[n + 3] = "";
                userinfolines[n + 4] = "";
                userinfolines[n + 5] = "";
                for (int i = 0; i < userinfolines.Length; i++)
                {
                    if (userinfolines[i] != "")
                    {
                        deletestreamwriter.WriteLine(userinfolines[i]);
                    }
                }
                deletestreamwriter.Close();
                    var Login = new Accountpagina();
                    this.Hide();
                    Login.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
