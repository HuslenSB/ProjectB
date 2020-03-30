using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaplication
{
    public partial class Reserveren : Form
    {
        public string var1;
        public Reserveren()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reserveren2 f1 = new Reserveren2();
            var1 = "Leuk dat je hebt gekozen voor de Sparta escape room!";
            f1.label1.Text = var1;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reserveren2 f1 = new Reserveren2();
            var1 = "Leuk dat je hebt gekozen voor de Last run escape room!";
            f1.label1.Text = var1;
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reserveren2 f1 = new Reserveren2();
            var1 = "Leuk dat je hebt gekozen voor de Haunted escape, escape room!";
            f1.label1.Text = var1;
            f1.Show();
        }
    }
}
