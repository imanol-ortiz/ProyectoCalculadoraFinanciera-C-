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
    public partial class Despejando1 : Form
    {
        public Despejando1()
        {
            InitializeComponent();
        }

        private void Despejando1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1;
            Double n2;
            Double n3;
            if (double.TryParse(textBox1.Text, out n1) && double.TryParse(textBox2.Text, out n2) && double.TryParse(textBox3.Text, out n3))
            {
                textBox4.Text = (n1 / (n2 * n3)).ToString();
            }
            else MessageBox.Show("Datos incorrectos");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
