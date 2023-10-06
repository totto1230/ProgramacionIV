using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_Joseph_Granadoos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_trabajo_hileras ventana_hileras = new frm_trabajo_hileras();
            ventana_hileras.Show();
        }

            private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void li_la_num_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           frm_numeric_up_down ventana_numeric = new frm_numeric_up_down();
            ventana_numeric.Show();
        }

        private void li_la_tabla_multi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_tablas_multiplicar ventana_multi = new frm_tablas_multiplicar();
            ventana_multi.Show();
        }

        private void li_la_masked_fechas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_trabajo_fechas ventana_fechas = new frm_trabajo_fechas();
            ventana_fechas.Show();  
           
        }
    }
}
