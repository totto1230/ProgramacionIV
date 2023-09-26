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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_ecuacion_Click(object sender, EventArgs e)
        {
            frm_ecuaciones ventana_ecuaciones = new frm_ecuaciones();
            ventana_ecuaciones.Show();
        }

        private void b_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void b_hipotenusa_Click(object sender, EventArgs e)
        {
            frm_hipotenusa ventana_hipotenusa = new frm_hipotenusa();
            ventana_hipotenusa.Show();
        }

        private void b_conversiones_Click(object sender, EventArgs e)
        {
            frm_conversiones ventana_conversiones = new frm_conversiones();
            ventana_conversiones.Show();
        }

        private void b_restaurante_Click(object sender, EventArgs e)
        {
            frm_restaurante ventana_restaurante = new frm_restaurante();
            ventana_restaurante.Show();
        }

        private void b_evaluacion_Click(object sender, EventArgs e)
        {
            frm_evaluacion ventana_evaluacion = new frm_evaluacion();
            ventana_evaluacion.Show();
        }
    }
}
