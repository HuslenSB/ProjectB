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
    public partial class Reserveren : Form
    {
        public string usernametxt, passwordtxt, peopletxt, chosenroom;
        public string[] lines,checkpassword, lines2, lines3;

        //Deze code zorgt ervoor dat de tabbuttons verborgen zijn en dat de code checkt of de gebruiker al was ingelogd.

        public Reserveren()
        {
            InitializeComponent();
            Reservpagetabs.Appearance = TabAppearance.FlatButtons; 
            Reservpagetabs.ItemSize = new Size(0, 1); 
            Reservpagetabs.SizeMode = TabSizeMode.Fixed;
            checkpassword = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            if (Convert.ToBoolean(checkpassword[0]) == true)
            {
                Usernamelbl.Dispose();
                Passwordlbl.Dispose();
                logincheckBox.Dispose();
                usernametxtbox.Dispose();
                passwordtxtbox.Dispose();
            }
        }

        //Deze code vult de combobox met tijden.

        public void TimeBoxFill()
        {
            TimeBox.Items.Clear();
            TimeBox.Items.Add("9:00");
            TimeBox.Items.Add("10:00");
            TimeBox.Items.Add("11:00");
            TimeBox.Items.Add("12:00");
            TimeBox.Items.Add("13:00");
            TimeBox.Items.Add("14:00");
            TimeBox.Items.Add("15:00");
            TimeBox.Items.Add("16:00");
        }

        //Met deze button kies je de sparta escaperoom.

        private void Spartabtn_Click(object sender, EventArgs e)
        {
            Reservpagetabs.SelectTab(1);
            this.Reserverentitlelbl.Text = "Leuk dat je hebt gekozen voor de Sparta escape room!";
            chosenroom = "Sparta";
            TimeBoxFill();
            yearbox.Value = 2020;
            monthbox.Value = 1;
            daybox.Value = 1;
        }

        //Met deze button kies je the last run escaperoom.

        private void TLRbtn_Click(object sender, EventArgs e)
        {
            Reservpagetabs.SelectTab(1);
            this.Reserverentitlelbl.Text = "Leuk dat je hebt gekozen voor de Last run escape room!";
            chosenroom = "The last run";
            TimeBoxFill();
            yearbox.Value = 2020;
            monthbox.Value = 1;
            daybox.Value = 1;
        }

        //Met deze button kies je de haunted escape escaperoom.

        private void Hauntedbtn_Click(object sender, EventArgs e)
        {
            Reservpagetabs.SelectTab(1);
            this.Reserverentitlelbl.Text = "Leuk dat je hebt gekozen voor de Haunted escape, escape room!";
            chosenroom = "Haunted escape";
            TimeBoxFill();
            yearbox.Value = 2020;
            monthbox.Value = 1;
            daybox.Value = 1;
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

        private void Recenties_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Recenties" drukt, deze doorgaat naar het recenties scherm.

            var Recenties = new Recensie();
            this.Hide();
            Recenties.ShowDialog();
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

        private void daybox_ValueChanged(object sender, EventArgs e)
        {
            checkdate();
        }

        private void monthbox_ValueChanged(object sender, EventArgs e)
        {
            checkdate();
        }

        //Deze code zorgt ervoor dat de datum boxes er niet out of index kunnen door bijvoorbeeld schrikkeljaren. 

        public void checkdate()
        {
            if (((int)monthbox.Value == 4) || ((int)monthbox.Value == 6) || ((int)monthbox.Value == 9) || ((int)monthbox.Value == 11))
            {
                daybox.Maximum = 30;
            }
            else if (((int)monthbox.Value == 1) || ((int)monthbox.Value == 3) || ((int)monthbox.Value == 5) || ((int)monthbox.Value == 7) || 
                ((int)monthbox.Value == 8) || ((int)monthbox.Value == 10) || ((int)monthbox.Value == 12))
            {
                daybox.Maximum = 31;
            }
            if ((((int)yearbox.Value % 4 == 0) || ((int)yearbox.Value % 100 == 0) && ((int)yearbox.Value % 400 == 0)) && ((int)monthbox.Value == 2))
            {
                daybox.Maximum = 29;
            }
            else if ((int)monthbox.Value == 2)
            {
                daybox.Maximum = 28;
            }

            //Deze code checkt of er als een reservering staat voor die escaperoom en die dag.

            TimeBoxFill();
            lines2 = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Accounts.txt");
            for (int k = 0; k < lines2.Length; k++)
            {
                lines3 = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + lines2[k]);
                if (lines3.Length != 0)
                {
                    for (int i = 2, j = 1; i < lines3.Length - 5; i += 6, j++)
                    {
                        if (chosenroom == lines3[i]) {
                            if ((int)yearbox.Value == Int32.Parse(lines3[i + 2]))
                            {
                                if ((int)monthbox.Value == Int32.Parse(lines3[i + 3]))
                                {
                                    if ((int)daybox.Value == Int32.Parse(lines3[i + 4]))
                                    {
                                        TimeBox.Items.Remove(lines3[i + 5]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void yearbox_ValueChanged(object sender, EventArgs e)
        {
            checkdate();
        }

        //Deze code brengt de gebruiker naar de accountpagina.

        private void toaccountbtn_Click(object sender, EventArgs e)
        {
            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        //Deze code verbergt het wachtwoord.

        private void passwordtxtbox_TextChanged(object sender, EventArgs e)
        {
            passwordtxtbox.PasswordChar = '●';
        }

        private void Account_Click_1(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Acount" drukt, deze doorgaat naar het login scherm.

            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        //Deze code brengt je naar de kortingspagina.

        private void Korting_Click(object sender, EventArgs e)
        {
            Reservpagetabs.SelectTab(3);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            // Deze code genereert een willekeurige kortingscode

            var characters = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            var code = "";
            for (int i = 0; i < 10; i++)
            {
                code += characters[random.Next(characters.Length)];
            }

            // Als het antwoord goed is, krijgt de klant een kortingscode te zien

            if (textBox_antwoord.Text == "105")
            {
                MessageBox.Show("Correct, uw kortingscode is: " + code);
                var Hoofd = new HoofdMenu();
                this.Hide();
                Hoofd.ShowDialog();
                this.Close();
            }

            // Als het antwoord fout is, krijgt de klant alleen te zien dat het fout is.

            else
            {
                MessageBox.Show("Helaas, het antwoord is niet goed");
                var Hoofd = new HoofdMenu();
                this.Hide();
                Hoofd.ShowDialog();
                this.Close();
            }
        }

        //Deze code brengt de gebruiker terug naar het escaperoom overzicht. 

        private void overzichtbtn_Click(object sender, EventArgs e)
        {
            Reservpagetabs.SelectTab(0);
        }

        //Deze code brengt de gebruiker terug naar het escaperoom overzicht en laadt de form opnieuw in.  

        private void overzicht2btn_Click(object sender, EventArgs e)
        {
            Reservpagetabs.SelectTab(0);
            var Login = new Reserveren();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Reserverenbtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(checkpassword[0]) == false)
            {
                this.reserveren(usernametxtbox.Text, passwordtxtbox.Text);
            }
            else
            {
                this.reserveren(checkpassword[1], checkpassword[2]);
            }
        }

        //Deze code laat de gebruiker een reservering plaatsen. 

        public void reserveren(string usernametxt, string passwordtxt) { 
            peopletxt = peoplenumeric.Text;
            var path = Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt";

            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
                {
                    var date1 = new DateTime((int)yearbox.Value, (int)monthbox.Value, (int)daybox.Value);
                    var date2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    int datecomparinson = DateTime.Compare(date1, date2);
                    if ((datecomparinson > 0) && (TimeBox.Text != "")) {
                        if ((lines[0] == usernametxt) && (lines[1] == passwordtxt) && (usernametxt != "Admin"))
                        {
                            if (Convert.ToBoolean(checkpassword[0]) == false)
                            {
                                StreamWriter checkstrmwriter = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                                if (logincheckBox.Checked)
                                {
                                    checkstrmwriter.WriteLine("true");
                                }
                                else
                                {
                                    checkstrmwriter.WriteLine("false");
                                }
                                checkstrmwriter.WriteLine(usernametxt);
                                checkstrmwriter.WriteLine(passwordtxt);
                                checkstrmwriter.Close();
                            }
                            using (StreamWriter reserverenstrmwriter = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt"))
                            {
                                reserverenstrmwriter.WriteLine(chosenroom);
                                reserverenstrmwriter.WriteLine(peopletxt);
                                reserverenstrmwriter.WriteLine(yearbox.Value);
                                reserverenstrmwriter.WriteLine(monthbox.Value);
                                reserverenstrmwriter.WriteLine(daybox.Value);
                                reserverenstrmwriter.WriteLine(TimeBox.Text);
                            }
                            Reservpagetabs.SelectTab(2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("De datum die je hebt gekozen is niet beschikbaar");
                    }
                    if((lines[0] != usernametxt) || (lines[1] != passwordtxt))
                    {
                        MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
                    }

                }
            }
            else
            {
                MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
            }
        }
    }
}
