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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form interesSimple = new InteresSimple();
            interesSimple.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form valorActual = new ValorActual();
            valorActual.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form I_VF_VA = new I_VF_VA();
            I_VF_VA.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form interes3 = new VA_n_i();
            interes3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form valorFuturo2 = new Valor_Futuro2();
            valorFuturo2.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form descuento2 = new Descuento2();
            descuento2.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form descuento = new Descuento();
            descuento.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form interesSimple = new Despejando1();
            interesSimple.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form unidadTiempo = new Despejando2();
            unidadTiempo.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form interesSimple2 = new Despejando3();
            interesSimple2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form unidadTiempo2 = new Despejando4();
            unidadTiempo2.Show();
        }
    }
}
