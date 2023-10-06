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
    public partial class frm_trabajo_hileras : Form
    {
        public frm_trabajo_hileras()
        {
            InitializeComponent();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_limpiar_hileras_Click(object sender, EventArgs e)
        {
            tx_consonantes.Clear();
            tx_largo.Clear();
            tx_no_alfa.Clear();
            tx_vocales.Clear();
            tx_hilera.Clear();
            tx_hilera.Focus();
        }

        private void tx_hilera_TextChanged(object sender, EventArgs e)
        {
            tx_hilera.TextAlign = HorizontalAlignment.Center;
            if (ckb_contenido.Checked)
            {
                tx_hilera.PasswordChar = '\0';
            }
            else
            {
                tx_hilera.PasswordChar = '*';
            }

        }

        private void b_ver_Click(object sender, EventArgs e)
        {
            tx_largo.Text = this.largoHilera().ToString();
            tx_vocales.Text = this.vocales().ToString();
            tx_consonantes.Text = this.consonantes().ToString();   
            tx_no_alfa.Text = this.noNumericos().ToString();
        }

        private int largoHilera()
        {
            int tamanioHilera = tx_hilera.TextLength;
            return tamanioHilera;

        }

        private int vocales()
        {
            int vocales = 0, i = 0;
            string hilera = tx_hilera.Text;
            char[] charHileraArray = hilera.ToCharArray();

            while (i < charHileraArray.Length)
            {
                if (charHileraArray[i] == 'a' || charHileraArray[i] == 'e' || charHileraArray[i] == 'i' || charHileraArray[i] == 'o' || charHileraArray[i] == 'u')
                {
                    vocales += 1;
                }

                i++;
            }

            return vocales;
        }

        private int consonantes ()
        {
            int consonantes = 0, i = 0;
            string hilera = tx_hilera.Text;
            char[] charHileraArray = hilera.ToCharArray();

            while (i < charHileraArray.Length)
            {
                if (charHileraArray[i] != 'a' && charHileraArray[i] != 'e' && charHileraArray[i] != 'i' && charHileraArray[i] != 'o' && charHileraArray[i] != 'u' && charHileraArray[i] != '!' && charHileraArray[i] != '@' && charHileraArray[i] != '^' && charHileraArray[i] != '$' && charHileraArray[i] != '*' && charHileraArray[i] != '(' && charHileraArray[i] != ')' && charHileraArray[i] != '_')
                {
                    consonantes += 1;
                }

                i++;
            }

            return consonantes;
        }

        private int noNumericos ()
        {
            int noNumericos = 0 , i = 0;
            string hilera = tx_hilera.Text;
            char[] charHileraArray = hilera.ToCharArray();

            while (i < charHileraArray.Length)
            {
                if (charHileraArray[i] == '!' || charHileraArray[i] == '@' || charHileraArray[i] == '^' || charHileraArray[i] == '$' || charHileraArray[i] == '*' || charHileraArray[i] == '(' || charHileraArray[i] == ')' || charHileraArray[i] == '_' || charHileraArray[i] == '%' || charHileraArray[i] == '#' || charHileraArray[i] == '-' || charHileraArray[i] == '&')
                {
                    noNumericos += 1;
                }

                i++;
            }
            return noNumericos;
        }
    }
}
