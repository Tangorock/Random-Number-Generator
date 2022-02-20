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

        // deklarace proměnných
        int A;
        int B;
        int C;
        int D;
        int F;
        int final;

        private void Form1_Load(object sender, EventArgs e)
        {
            // povolení časovače
            timer1.Enabled = true;
            // nastavení intervalu časovače (100ms)
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // proměnná now obsahuje lokální čas
            DateTime now = DateTime.Now;

            // výpočet pomocných čísel pomocí času
            A = now.Millisecond + 9 * (now.Second + 9);
            B = now.Millisecond * 8 / (now.Second + 6) * 5;
            C = now.Millisecond * now.Second * 11;
            D = (now.Millisecond * (now.Second + 1) * 68) / 24;
            F = (now.Millisecond * (now.Second + 2) * 74) / 51;

            // vypsání pomocných čísel do textboxů
            textBox_A.Text = A.ToString();
            textBox_B.Text = B.ToString();
            textBox_C.Text = C.ToString();
            textBox_D.Text = D.ToString();
            textBox_F.Text = F.ToString();
        }


        private void button_random_cisla_Click(object sender, EventArgs e)
        {
            // smazaní obsahu LisBox_dec
            listBox_dec.Items.Clear();
            // smazaní obsahu LisBox_bin
            listBox_bin.Items.Clear();
            // smazaní obsahu LisBox_hex
            listBox_hex.Items.Clear();

            // výpis náhodnoých čísel
            for (int i = 0; i < 36; i++)
            {
                // zastavení procesu na 100ms
                Thread.Sleep(100);

                // výpočet finálního čísla
                final = (((C * B + D) - A) % (F + 1)) * 3;
                // výpis finálního číslo do ListBox_dec
                listBox_dec.Items.Add(final.ToString());

                // převedení čísla final do desítkové soustavy
                string bin = Convert.ToString(final, 2);
                // výpis finálního čísla do ListBox_bin
                listBox_bin.Items.Add(bin);

                // převedení čísla final do šestnáctkové soustavy
                string hex = Convert.ToString(final, 16);
                // výpis finálního čísla do ListBox_hex
                listBox_hex.Items.Add(hex);

                // dokončení procesu před opakováním cyklu
                Application.DoEvents();
            }
        }
    }
}
