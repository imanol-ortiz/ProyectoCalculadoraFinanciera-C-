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
    public partial class Valor_Futuro2 : Form
    {
        public Valor_Futuro2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1;
            Double n2;
            if (double.TryParse(textBox1.Text, out n1) && double.TryParse(textBox2.Text, out n2))
            {
                textBox3.Text = (n1+n2).ToString();
            }
            else MessageBox.Show("Datos incorrectos");
        }
    }
}
