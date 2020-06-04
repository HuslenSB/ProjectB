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
        public Reserveren()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons; tabControl1.ItemSize = new Size(0, 1); tabControl1.SizeMode = TabSizeMode.Fixed;
            checkpassword = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
            if (Convert.ToBoolean(checkpassword[0]) == true)
            {
                label7.Dispose();
                label8.Dispose();
                checkBox.Dispose();
                usernametxtbox.Dispose();
                passwordtxtbox.Dispose();
            }

        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            this.label1.Text = "Leuk dat je hebt gekozen voor de Sparta escape room!";
            chosenroom = "Sparta";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            this.label1.Text = "Leuk dat je hebt gekozen voor de Last run escape room!";
            chosenroom = "The last run";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            this.label1.Text = "Leuk dat je hebt gekozen voor de Haunted escape, escape room!";
            chosenroom = "Haunted escape";
        }

        private void PageTitle_Click(object sender, EventArgs e)
        {

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

        private void Account_Click(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Acount" drukt, deze doorgaat naar het login scherm.

            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Account_Click_1(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat als de gebruiker op de knop "Acount" drukt, deze doorgaat naar het login scherm.

            var Accountpagina = new Accountpagina();
            this.Hide();
            Accountpagina.ShowDialog();
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

        public void checkdate()
        {
            if ((int)monthbox.Value == 4 || (int)monthbox.Value == 6 || (int)monthbox.Value == 9 || (int)monthbox.Value == 11)
            {
                daybox.Maximum = 30;
            }
            else if ((int)monthbox.Value == 1 || (int)monthbox.Value == 3 || (int)monthbox.Value == 5 || (int)monthbox.Value == 7 || (int)monthbox.Value == 8 || (int)monthbox.Value == 10 || (int)monthbox.Value == 12)
            {
                daybox.Maximum = 31;
            }
            if (((int)yearbox.Value % 4 == 0 || (int)yearbox.Value % 100 == 0 && (int)yearbox.Value % 400 == 0) && (int)monthbox.Value == 2)
            {
                daybox.Maximum = 29;
            }
            else if ((int)monthbox.Value == 2)
            {
                daybox.Maximum = 28;
            }

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

        private void toaccountbtn_Click(object sender, EventArgs e)
        {
            var Login = new Accountpagina();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void passwordtxtbox_TextChanged(object sender, EventArgs e)
        {
            passwordtxtbox.PasswordChar = '●';
        }

        private void Korting_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Reserveren1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Reserveren3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Reserveren2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void minutebox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hourbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void peoplenumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Korting1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox_antwoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button4_Click(object sender, EventArgs e)
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

        public void reserveren(string usernametxt, string passwordtxt) { 
            peopletxt = peoplenumeric.Text;
            string path = Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt";

            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
                {
                    DateTime date1 = new DateTime((int)yearbox.Value, (int)monthbox.Value, (int)daybox.Value);
                    DateTime date2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    int datecomparinson = DateTime.Compare(date1, date2);
                    if (datecomparinson > 0 && TimeBox.Text != "") {
                        if (lines[0] == usernametxt && lines[1] == passwordtxt)
                        {
                            if (Convert.ToBoolean(checkpassword[0]) == false)
                            {
                                StreamWriter ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Loggedincheck.txt");
                                if (checkBox.Checked)
                                {
                                    ab.WriteLine("true");
                                }
                                else
                                {
                                    ab.WriteLine("false");
                                }
                                ab.WriteLine(usernametxt);
                                ab.WriteLine(passwordtxt);
                                ab.Close();
                            }
                            using (StreamWriter ac = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt"))
                            {
                                ac.WriteLine(chosenroom);
                                ac.WriteLine(peopletxt);
                                ac.WriteLine(yearbox.Value);
                                ac.WriteLine(monthbox.Value);
                                ac.WriteLine(daybox.Value);
                                ac.WriteLine(TimeBox.Text);
                            }
                            tabControl1.SelectTab(2);
                        }
                    }
                    else
                    {
                        MessageBox.Show("De datum die je hebt gekozen is niet beschikbaar");
                    }
                    if(lines[0] != usernametxt || lines[1] != passwordtxt)
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
