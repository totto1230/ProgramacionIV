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
    public partial class frm_numeric_up_down : Form
    {
        public frm_numeric_up_down()
        {
            InitializeComponent();
        }

        private void b_cerrar_parqueo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_calcular_Click(object sender, EventArgs e)
        {
            tx_monto_pagar.Text = this.parqueoValor().ToString();
        }

        private int parqueoValor()
        {
            int montoPagar = 0, numHorasEntrada = Convert.ToInt32(num_horas_entrada.Value.ToString()), numMinEntrada = Convert.ToInt32(num_min_entrada.Value.ToString()) , numHorasSalida = Convert.ToInt32(num_horas_salida.Value.ToString()) , numMinSalida = Convert.ToInt32(num_min_salida.Value.ToString()), diferenciaHoras = numHorasSalida - numHorasEntrada;

            if (diferenciaHoras == 0)
            {
                int tiempoMin = numMinSalida - numMinEntrada;
                if (tiempoMin < 30)
                {
                    montoPagar = 250;
                }
                else if (tiempoMin >= 30 && tiempoMin <= 59)
                {
                    montoPagar = 500;
                }

            }
            else if (diferenciaHoras == 1)
            {

                if (numMinEntrada >= 1 && numMinSalida <= 15)
                {
                    montoPagar = 500 + 50;
                }
                else if (numMinEntrada >= 16 && numMinSalida < 30)
                {
                    montoPagar = 500 + 60;
                }
                else if (numMinEntrada >= 30 && numMinSalida <= 59)
                {
                    montoPagar = 500 + 80;
                }
            }
            else
            {
                montoPagar = diferenciaHoras * 100;
            }

            return montoPagar;
        }

        private void b_limpiar_parqueo_Click(object sender, EventArgs e)
        {
            num_min_entrada.ResetText();
            num_horas_salida.ResetText();
            num_horas_entrada.ResetText();
            num_min_salida.ResetText();
            num_horas_entrada.Focus();
            tx_monto_pagar.Clear();
        }
    }
}
