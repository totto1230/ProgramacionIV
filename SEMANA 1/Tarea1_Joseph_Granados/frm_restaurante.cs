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
    public partial class frm_restaurante : Form
    {
        public frm_restaurante()
        {
            InitializeComponent();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b_limpiar_Click(object sender, EventArgs e)
        {
            tx_cerveza_cantidad.Clear();
            tx_ensalada_cantidad.Clear();
            tx_gaseosa_cantidad.Clear();
            tx_hamburguesa_cantidad.Clear();
            tx_postre_cantidad.Clear();
            tx_refresco_cantidad.Clear();
            tx_salchichas_cantidad.Clear();
            tx_sopa_cantidad.Clear();
            tx_cerveza_precio.Clear();
            tx_ensalada_precio.Clear();
            tx_gaseosa_precio.Clear();
            tx_hamburguesa_precio.Clear();
            tx_postre_precio.Clear();
            tx_refresco_precio.Clear();
            tx_salchichas_precio.Clear();
            tx_sopa_precio.Clear();
            tx_total.Clear();
            tx_hamburguesa_cantidad.Focus();

        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            int i = 0;
            double cantidadHamburguesas = Convert.ToDouble(tx_hamburguesa_cantidad.Text);
            double cantidadCervezas = Convert.ToDouble(tx_cerveza_cantidad.Text);
            double cantidadGaseosas = Convert.ToDouble(tx_gaseosa_cantidad.Text);
            double cantidadEnsalada = Convert.ToDouble(tx_ensalada_cantidad.Text);
            double cantidadSalchichas = Convert.ToDouble(tx_salchichas_cantidad.Text);
            double cantidadRefresco = Convert.ToDouble(tx_refresco_cantidad.Text);
            double cantidadSopa = Convert.ToDouble(tx_sopa_cantidad.Text);
            double cantidadPostre = Convert.ToDouble(tx_postre_cantidad.Text);
            double[] arrayCantidad = { cantidadHamburguesas, cantidadCervezas, cantidadGaseosas, cantidadEnsalada, cantidadSalchichas, cantidadRefresco, cantidadSopa, cantidadPostre };

            double precioHamburguesas = Convert.ToDouble(tx_hamburguesa_precio.Text);
            double precioCervezas = Convert.ToDouble(tx_cerveza_precio.Text);
            double precioGaseosas = Convert.ToDouble(tx_gaseosa_precio.Text);
            double precioEnsalada = Convert.ToDouble(tx_ensalada_precio.Text);
            double precioSalchichas = Convert.ToDouble(tx_salchichas_precio.Text);
            double precioRefresco = Convert.ToDouble(tx_refresco_precio.Text);
            double precioSopa = Convert.ToDouble(tx_sopa_precio.Text);
            double precioPostre = Convert.ToDouble(tx_postre_precio.Text);
            double[] arrayPrecio = { precioHamburguesas, precioCervezas, precioGaseosas, precioEnsalada, precioSalchichas, precioRefresco, precioSopa, precioPostre };
            double sum = 0;

            while (i < arrayPrecio.Length)
            {
                sum += arrayPrecio[i] * arrayCantidad[i];
                i++;
            }
            tx_total.Text = sum.ToString();
        }    
    }
}
