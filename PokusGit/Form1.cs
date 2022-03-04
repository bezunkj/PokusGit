using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            MessageBox.Show("Soucet: " + a + b + "\nRozdil: " + (a - b) + "\nPodil: " + ((double)a / b) + "\nSoucin: " + a * b);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ITA2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32( textBox3.Text );
            int f = 1;
            for(int i = x; i > 0; i--)
            {
                f *= i;
            }
            MessageBox.Show("Faktorial: " + f);
        }
    }
}
