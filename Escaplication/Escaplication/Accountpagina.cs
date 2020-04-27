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
        public string[] lines;
        public string[] lines2;
        public Accountpagina()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons; tabControl1.ItemSize = new Size(0, 1); tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt"))
            {
                StreamWriter ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt");
                ab.WriteLine(usernameregtxtbox.Text);
                ab.WriteLine(passwordregtxtbox.Text);
                ab.Close();
                MessageBox.Show("Registreren voltooid");
                StreamWriter af = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + "Accounts.txt");
                af.WriteLine(usernameregtxtbox.Text);
                af.Close();
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
                            for (int i = 2, j=1, LocPointGB = 0, LocPointLabel = 10; i < lines.Length-2; i+=3, j++, LocPointGB += 90, LocPointLabel += 90)
                            {
                                GroupBox recensiegb = new GroupBox();
                                recensiegb.Name = "";
                                recensiegb.Size = new Size(220, 90);
                                recensiegb.Location = new Point(0, LocPointGB);

                                Label naamkamer = new Label();
                                naamkamer.AutoSize = true;
                                naamkamer.Location = new Point(5, LocPointLabel);
                                naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                naamkamer.Text = j + ".\nEscaperoom: " + lines[i] + "\nAantal personen: " + lines[i+1] + "\nDatum: " + lines[i+2];

                                panel1.Controls.Add(naamkamer);
                                panel1.Controls.Add(recensiegb);

                            }
                        }
                    }
                    else if("Admin" == usernamelogintxtbox.Text && "Admin" == passlogintxtbox.Text)
                    {
                        lines2 = File.ReadAllLines(Application.StartupPath + "\\Gebruikers\\" + "Reserveringen.txt");
                        tabControl1.SelectTab(2);
                        if (lines.Length != 0)
                        {
                            for (int i = 0, j=0, LocPointGB = 0, LocPointLabel = 10; i < lines2.Length-3; i += 4, j++, LocPointGB += 100, LocPointLabel += 100)
                            {
                                GroupBox recensiegb = new GroupBox();
                                recensiegb.Name = "";
                                recensiegb.Size = new Size(220, 100);
                                recensiegb.Location = new Point(0, LocPointGB);

                                Label naamkamer = new Label();
                                naamkamer.AutoSize = true;
                                naamkamer.Location = new Point(5, LocPointLabel);
                                naamkamer.Font = new Font("Microsoft Sans Serif", 10.0f);
                                naamkamer.Text = j + ".\nNaam: " + lines2[i] + "\nEscaperoom: " + lines2[i+1] + "\nAantal personen: " + lines2[i+2] + "\nDatum: " + lines2[i+3];

                                panel2.Controls.Add(naamkamer);
                                panel2.Controls.Add(recensiegb);
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

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StreamWriter ae = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernamelogintxtbox.Text + ".txt");
            decimal k = numericUpDown1.Value;
            int n = (int)k;
            lines[n*2] = "";
            lines[n * 2+1] = "";
            lines[n * 2+2] = "";
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
