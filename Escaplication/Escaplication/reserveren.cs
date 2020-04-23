﻿using System;
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
    public partial class Reserveren : Form
    {
        public string usernametxt, passwordtxt, peopletxt, chosenroom;
        public string[] lines;
        public Reserveren()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Accountpagina f1 = new Accountpagina();
            f1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            usernametxt = usernametxtbox.Text;
            passwordtxt = passwordtxtbox.Text;
            peopletxt = peopletxtbox.Text;
            string path = Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt";

            if (System.IO.File.Exists(path))
            {
                lines = System.IO.File.ReadAllLines(path);
                {
                    if (lines[0] == usernametxt && lines[1] == passwordtxt)
                    {
                        using (StreamWriter ac = File.AppendText(Application.StartupPath + "\\Gebruikers\\" + usernametxt + ".txt"))
                        {
                            ac.WriteLine(chosenroom);
                        }
                        lines = File.ReadAllLines(path);
                        Console.WriteLine(lines.Length);
                    }
                    else
                    {
                        MessageBox.Show("Verkeerde gebruikersnaam of wachtwoord");
                    }

                }
            }

        }
    }
}
