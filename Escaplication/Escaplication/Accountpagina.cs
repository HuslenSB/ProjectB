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
            tabPage1.Enabled = true;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter ab = new StreamWriter(Application.StartupPath + "\\Gebruikers\\" + usernameregtxtbox.Text + ".txt");
            ab.WriteLine(usernameregtxtbox.Text);
            ab.WriteLine(passwordregtxtbox.Text);
            ab.Close();
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
                        tabPage1.Enabled = false;
                        tabPage2.Enabled = true;
                        tabPage3.Enabled = false;
                        this.label6.Text = "Welkom " + usernamelogintxtbox.Text;
                        if (lines.Length != 0)
                        {
                            for (int i = 2, j=1, LocPointGB = 0, LocPointLabel = 10; i < lines.Length-2; i+=3, j++, LocPointGB += 70, LocPointLabel += 70)
                            {
                                GroupBox recensiegb = new GroupBox();
                                recensiegb.Name = "";
                                recensiegb.Size = new Size(200, 70);
                                recensiegb.Location = new Point(0, LocPointGB);

                                Label naamkamer = new Label();
                                naamkamer.AutoSize = true;
                                naamkamer.Location = new Point(5, LocPointLabel);
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
                        tabPage1.Enabled = false;
                        tabPage2.Enabled = false;
                        tabPage3.Enabled = true;
                        if (lines.Length != 0)
                        {
                            for (int i = 0, j=0, LocPointGB = 0, LocPointLabel = 10; i < lines2.Length-3; i += 4, j++, LocPointGB += 80, LocPointLabel += 80)
                            {
                                GroupBox recensiegb = new GroupBox();
                                recensiegb.Name = "";
                                recensiegb.Size = new Size(210, 80);
                                recensiegb.Location = new Point(0, LocPointGB);

                                Label naamkamer = new Label();
                                naamkamer.AutoSize = true;
                                naamkamer.Location = new Point(5, LocPointLabel);
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
            tabPage1.Enabled = true;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            tabPage1.Enabled = true;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
        }
    }
}
