using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFinanciera
{
    public partial class InteresSimple : Form
    {
        public InteresSimple()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void InteresSimple_Load(object sender, EventArgs e)
        {

        }

        private void textBoxVA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Calcular(object sender, EventArgs e)
        {
            Double n1;
            Double n2;
            Double n3;
            if (double.TryParse(textBox1.Text, out n1) && double.TryParse(textBox2.Text, out n2) && double.TryParse(textBox3.Text, out n3))
            {
                textBox4.Text= (n1 * (1 + (n2 * n3))).ToString();
            }
            else MessageBox.Show("Datos incorrectos");



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_cantMeses(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
