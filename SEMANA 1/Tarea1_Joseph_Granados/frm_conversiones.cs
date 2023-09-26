using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_Joseph_Granados
{
    public partial class frm_conversiones : Form
    {
        public frm_conversiones()
        {
            InitializeComponent();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra la ventana actual
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_limpiar_Click(object sender, EventArgs e)
        {
            tx_decimal.Clear();
            tx_int.Clear();
            tx_short.Clear();
            tx_long.Clear();
            tx_float.Clear();
            tx_double.Clear();
            //Pone el cursor en la caja de texto valor 1
            tx_decimal.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_decimal_TextChanged(object sender, EventArgs e)
        {
            tx_decimal.Focus();
        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            decimal decimalI = Convert.ToDecimal(tx_decimal.Text);
            int dInt = (int) decimalI;
            short dShort = (short) decimalI;
            long dLong = (long) decimalI;
            float dFloat = (float) decimalI;
            double dDouble = (double) decimalI;
            tx_int.Text = dInt.ToString();
            tx_short.Text = dShort.ToString();
            tx_long.Text = dLong.ToString();
            tx_float.Text = dFloat.ToString();
            tx_double.Text = dDouble.ToString();
        }
    }
}
