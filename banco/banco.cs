using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class buttonDepositar : Form
    {
        cliente cliente;


        public buttonDepositar()
        {
            InitializeComponent();

            this.cliente = new cliente();

            labelValorSaldo.Text = Convert.ToString(cliente.saldo);
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelSaldo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(textBoxDeposito.Text);
                cliente.Creditar(valor);

                textBoxDeposito.Clear();

                MessageBox.Show("deposito realizado com sucesso: ");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                textBoxDeposito.Clear();
            }
            

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void labelValorSaldo_Click(object sender, EventArgs e)
        {

        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {

            try
            {
                double valor = Convert.ToDouble(textoBoxSacar.Text);


                cliente.Debitar(valor);


                labelValorSaldo.Text = cliente.saldo.ToString();

                textoBoxSacar.Clear();
                MessageBox.Show("deposito realizado com sucesso: ");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                textoBoxSacar.Clear();
            }



        }
    }
}
