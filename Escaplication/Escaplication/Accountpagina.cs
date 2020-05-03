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

namespace Escaplication
{
    public partial class Accountpagina : Form
    {
        public string[] lines, lines2, lines3;
        public Accountpagina()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons; tabControl1.ItemSize = new Size(0, 1); tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt"))
            {
                if (passwordregtxtbox.Text == passwordrepeattxtbox.Text)
                {
                    StreamWriter ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt");
                    ab.WriteLine(usernameregtxtbox.Text);
                    ab.WriteLine(passwordregtxtbox.Text);
                    ab.Close();
                    MessageBox.Show("Registreren voltooid");
                    using (StreamWriter af = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + "Accounts" + ".txt"))
                    {
                        af.WriteLine(usernameregtxtbox.Text + ".txt");
                        af.Close();
                    }
                }
                else
                {
                    MessageBox.Show("De wachtwoorden komen niet overeen");
                }
            }
            else
            {
                MessageBox.Show("Deze gebruikersnaam bestaat al");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Gebruikers\\" + usernamelogintxtbox.Text + ".txt";
            if (File.Exists(path))
            {
                lines = File.ReadAllLines(path);
                {
                    if (lines[0] == usernamelogintxtbox.Text && lines[1] == passlogintxtbox.Text && usernamelogintxtbox.Text != "Admin")
                    {
                        tabControl1.SelectTab(1);
                        this.label6.Text = "Welkom " + usernamelogintxtbox.Text;
                        if (lines.Length != 0)
                        {
                            for (int i = 2, j = 1, k = 1, LocPointGB = 0, LocPointLabel = 10, LocPointGB2 = 0, LocPointLabel2 = 10; i < lines.Length - 6; i += 7)
                            {
                                DateTime date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                                DateTime date2 = new DateTime(Int32.Parse(lines[i + 2]), Int32.Parse(lines[i + 3]), Int32.Parse(lines[i + 4]));
                                int datecomparinson = DateTime.Compare(date1, date2);
                                if (datecomparinson <= 0)
                                {
                                    GroupBox recensiegb = new GroupBox();
                                    recensiegb.Name = "";
                                    recensiegb.Size = new Size(220, 90);
                                    recensiegb.Location = new Point(0, LocPointGB);

                                    Label naamkamer = new Label();
                                    naamkamer.AutoSize = true;
                                    naamkamer.Location = new Point(5, LocPointLabel);
                                    naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                    naamkamer.Text = j + ".\nEscaperoom: " + lines[i] + "\nAantal personen: " + lines[i + 1] + "\nDatum: " + lines[i + 4] + "-" + lines[i + 3] + "-" + lines[i + 2] + "\nTijd: " + lines[i+5] + ":" + lines[i+6];

                                    panel1.Controls.Add(naamkamer);
                                    panel1.Controls.Add(recensiegb);
                                    LocPointGB += 100;
                                    LocPointLabel += 100;
                                    j++;
                                }
                                else
                                {
                                    GroupBox recensiegb = new GroupBox();
                                    recensiegb.Name = "";
                                    recensiegb.Size = new Size(220, 90);
                                    recensiegb.Location = new Point(0, LocPointGB2);

                                    Label naamkamer = new Label();
                                    naamkamer.AutoSize = true;
                                    naamkamer.Location = new Point(5, LocPointLabel2);
                                    naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                    naamkamer.Text = k + ".\nEscaperoom: " + lines[i] + "\nAantal personen: " + lines[i + 1] + "\nDatum: " + lines[i + 4] + "-" + lines[i + 3] + "-" + lines[i + 2] + "\nTijd: " + lines[i + 5] + ":" + lines[i + 6];

                                    panel3.Controls.Add(naamkamer);
                                    panel3.Controls.Add(recensiegb);
                                    LocPointGB2 += 100;
                                    LocPointLabel2 += 100;
                                    k++;
                                }
                            }
                        }
                    }
                    else if ("Admin" == usernamelogintxtbox.Text && "Admin" == passlogintxtbox.Text)
                    {
                        lines2 = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Accounts.txt");
                        tabControl1.SelectTab(2);
                        for (int k = 0, LocPointGB = 0, LocPointLabel = 10; k < lines2.Length; k++)
                        {
                            Console.WriteLine(lines2[k]);
                            lines3 = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + lines2[k]);
                            if (lines3.Length != 0)
                            {
                                for (int i = 2, j = 1; i < lines3.Length - 6; i += 7, j++)
                                {
                                    DateTime date1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                                    DateTime date2 = new DateTime(Int32.Parse(lines3[i + 2]), Int32.Parse(lines3[i + 3]), Int32.Parse(lines3[i + 4]));
                                    int datecomparinson = DateTime.Compare(date1, date2);
                                    Console.WriteLine(date2);
                                    if (datecomparinson < 0)
                                    {
                                        GroupBox recensiegb = new GroupBox();
                                        recensiegb.Name = "";
                                        recensiegb.Size = new Size(220, 100);
                                        recensiegb.Location = new Point(0, LocPointGB);

                                        Label naamkamer = new Label();
                                        naamkamer.AutoSize = true;
                                        naamkamer.Location = new Point(5, LocPointLabel);
                                        naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                        naamkamer.Text = j + ".\nNaam: " + lines3[0] + "\nEscaperoom: " + lines3[i] + "\nAantal personen: " + lines3[i + 1] + "\nDatum: " + lines3[i + 4] + "-" + lines3[i + 3] + "-" + lines3[i + 2] + "\nTijd: " + lines3[i+5] + ":" + lines3[i+6];
                                         

                                        panel2.Controls.Add(naamkamer);
                                        panel2.Controls.Add(recensiegb);
                                        LocPointGB += 100;
                                        LocPointLabel += 100;
                                    }
                                }
                            }
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

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
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

        private void Contact_Click(object sender, EventArgs e)
        {
            var Login = new Contact_Tab();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StreamWriter ae = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernamelogintxtbox.Text + ".txt");
            decimal k = numericUpDown1.Value;
            int n = (int)k;
            lines[(n-1) * 7+2] = "";
            lines[((n - 1) * 7 + 2)+1] = "";
            lines[((n - 1) * 7 + 2)+2] = "";
            lines[((n - 1) * 7 + 2) + 3] = "";
            lines[((n - 1) * 7 + 2) + 4] = "";
            lines[((n - 1) * 7 + 2) + 5] = "";
            lines[((n - 1) * 7 + 2) + 6] = "";
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    ae.WriteLine(lines[i]);
                }
            }
            ae.Close();
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
