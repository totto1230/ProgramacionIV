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
    public partial class frm_hipotenusa : Form
    {
        public frm_hipotenusa()
        {
            InitializeComponent();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra la ventana actual
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            double lado1 = Math.Pow(Convert.ToDouble(tx_lado1.Text),2);
            double lado2 = Math.Pow(Convert.ToDouble(tx_lado2.Text),2);
            double resultado = Math.Sqrt(lado1 + lado2);
            tx_hipotenusa.Text = resultado.ToString();

        }

        private void b_limpiar_Click(object sender, EventArgs e)
        {
            tx_lado1.Clear();
            tx_lado2.Clear();
            tx_hipotenusa.Clear();
            //Pone el cursor en la caja de texto valor 1
            tx_lado1.Focus();
        }
    }
}
