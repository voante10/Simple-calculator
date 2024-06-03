using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_COMPLETA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n1;
        int n2;
        int result;
        string skin = "";
        string skin2 = "";
        string tela;
        bool verify = false;
        int conta;


        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (!verify)
            {
                skin += "1";
            }
            else
            {
                skin2 += "1";
            }
            tela +="1";

            textBox1.Text = tela;
            Console.WriteLine(skin2);
            Console.WriteLine(skin);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            verify = true;
            textBox1.Clear();
            tela = "";
            conta =  1;
        }

        private void equal_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            tela = "";
            n1 = Convert.ToInt32(skin2);
            n2 = Convert.ToInt32(skin);
            switch (conta)
            {
                case 1: result = n1+n2;
                    break;
            }
            tela = Convert.ToString(result);
            textBox1.Text = tela;
        }
    }
}
