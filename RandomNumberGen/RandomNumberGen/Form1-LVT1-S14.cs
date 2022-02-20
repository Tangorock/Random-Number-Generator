using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace RandomNumberGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {       
            InitializeComponent();
        }

        // deklarace proměných
        int A;
        int B;
        int C;
        int D;
        int F;
        int final;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            DateTime now = DateTime.Now;

            A = now.Millisecond + 9 * (now.Second + 9);
            B = now.Millisecond * 8 / (now.Second + 6) * 5;
            C = now.Millisecond * now.Second * 11;
            D = (now.Millisecond * (now.Second + 1) * 68) / 24;
            F = (now.Millisecond * (now.Second + 2) * 74) / 51;

            textBox_A.Text = A.ToString();
            textBox_B.Text = B.ToString();
            textBox_C.Text = C.ToString();
            textBox_D.Text = D.ToString();
            textBox_F.Text = F.ToString();
        }
        private void button_random_cisla_Click(object sender, EventArgs e)
        {
            listBox_dec.Items.Clear();
            listBox_bin.Items.Clear();
            listBox_hex.Items.Clear();

            // výpis náhodnoých čísel
            for (int i = 0; i < 36; i++)
            {
                Thread.Sleep(100);

                final = (((C * B + D) - A) % (F + 1)) * 3;
                listBox_dec.Items.Add(final.ToString());

                string bin = Convert.ToString(final, 2);
                listBox_bin.Items.Add(bin);

                string hex = Convert.ToString(final, 16);
                listBox_hex.Items.Add(hex);

                Application.DoEvents();
            }
        }


    }
}
