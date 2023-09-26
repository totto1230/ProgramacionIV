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
    public partial class frm_ecuaciones : Form
    {
        public frm_ecuaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra la ventana actual
        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tx_a.Text);
            int b = Convert.ToInt32(tx_b.Text);
            int c = Convert.ToInt32(tx_c.Text);
            float d = c - b;
            float resultado = d/a;
            tx_resultado.Text = resultado.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tx_a_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
