using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea3_Joseph_Granadoos
{
    public partial class frm_tablas_multiplicar : Form
    {
        public frm_tablas_multiplicar()
        {
            InitializeComponent();
            
        }

        int tablaAMultiplicar;

        private void b_cerrar_tablas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_limpiar_tablas_Click(object sender, EventArgs e)
        {
            cb_tablas.Items.Clear();
            num_al.ResetText();
            num_del.ResetText();
            lb_tabla_final.Items.Clear();
            num_al.Focus();
        }

        private void b_cargar_Click(object sender, EventArgs e)
        {
            lb_tabla_final.Items.Clear();
            int al = Convert.ToInt32(num_al.Value.ToString());
            if (cb_tablas.Items.Count < al)
            {
                this.llenar();
                cb_tablas.SelectedIndex = 0;
            }
            cb_tablas.SelectedIndexChanged += cb_tablas_SelectedIndexChanged;
            this.multiplicacion(tablaAMultiplicar);
            /*
             *             
            indexSeleccionado = Convert.ToInt32(cb_tablas.SelectedIndex);
            if (indexSeleccionado >= 0)
            {
                int tabla = Convert.ToInt32(cb_tablas.SelectedItem.ToString());
                this.multiplicacion(tabla);
            }*/
        }

        private void llenar ()
        {
            int del = Convert.ToInt32(num_del.Value.ToString()), al = Convert.ToInt32(num_al.Value.ToString()), i = del;  

            if ( al < del || al > 20)
            {
                MessageBox.Show("ERROR, NO PUEDE SUPERAR EL MÁXIMO Y/O DEBE SER MENOR A 20");
            }
            else
            {
                while (i <= al)
                {
                    cb_tablas.Items.Add(i);
                    i++;
                }
            }
            
        }
        private void multiplicacion (int tabla)
        {
            int[] arrayBases = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 0, resultado = 0;
            
            while (i < arrayBases.Length)
            {
                resultado = tabla * arrayBases[i];
                string result = tabla.ToString() + " x " + arrayBases[i].ToString() + " = " + resultado.ToString() + Environment.NewLine;
                lb_tabla_final.Items.Add(result);
                i++;
            }


        }

        private void cb_tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablaAMultiplicar = Convert.ToInt32(cb_tablas.SelectedItem.ToString());
        }
    }
}
