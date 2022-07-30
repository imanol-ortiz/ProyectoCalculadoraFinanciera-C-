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
    public partial class Despejando4 : Form
    {
        public Despejando4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1;
            Double n2;
            Double n3;
            if (double.TryParse(textBox1.Text, out n1) && double.TryParse(textBox2.Text, out n2) && double.TryParse(textBox3.Text, out n3))
            {
                textBox4.Text = (((n1 / n2) - 1) / n3).ToString();
            }
            else MessageBox.Show("Datos incorrectos");
        }
    }
}
