using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_Joseph_Granadoos
{
    public partial class frm_trabajo_fechas : Form
    {
        public frm_trabajo_fechas()
        {
            InitializeComponent();
        }

        private void b_cerrar_fechas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_extraer_Click(object sender, EventArgs e)
        {
            int[] fechaArray = this.calculoFechas().ToArray();
            this.determinarSigno(fechaArray);
        }

        private int[] calculoFechas()
        {
            string fecha = Convert.ToString(tx_fecha.Text), formatoFecha = "MM/dd/yyyy";
            //Metodo que valida la fecha y retorna una variable que sirve para sacar los dias, meses y anios
            DateTime.TryParseExact(fecha, formatoFecha, null, System.Globalization.DateTimeStyles.None, out DateTime fechaOrdenada);
            int day = fechaOrdenada.Day, month = fechaOrdenada.Month, year = fechaOrdenada.Year;
            tx_anio.Text = year.ToString();
            if (day <= 31 && month <= 12)
            {
                tx_dia.Text = day.ToString();
                tx_mes.Text = month.ToString();
            }
            else {
                MessageBox.Show("INVALID DATE");
            }
            string diaSemana = fechaOrdenada.DayOfWeek.ToString();
            tx_dia_semana.Text = diaSemana.ToString();
            int[] fechaArray = {day, month, year};
            return fechaArray;
        }

        private void determinarSigno(int[] fechasArray)
        {
            string[] signosZodiacales = { "Aries", "Tauro", "Géminis", "Cáncer", "Leo", "Virgo", "Libra", "Escorpio", "Sagitario", "Capricornio", "Acuario", "Piscis" };
           
            if ((fechasArray[0] >= 21 && fechasArray[1] == 3) || (fechasArray[0] <= 19 && fechasArray[1] == 4))
            {
                tx_signo.Text = signosZodiacales[0].ToString();
            }
            else if ((fechasArray[0] >= 20 && fechasArray[1] == 4) || (fechasArray[0] <= 20 && fechasArray[1] == 5))
            {
                tx_signo.Text = signosZodiacales[1].ToString();
            }
            else if ((fechasArray[0] >= 21 && fechasArray[1] == 5) || (fechasArray[0] <= 20 && fechasArray[1] == 6))
            {
                tx_signo.Text = signosZodiacales[2].ToString();
            }
            else if ((fechasArray[0] >= 21 && fechasArray[1] == 6) || (fechasArray[0] <= 22 && fechasArray[1] == 7))
            {
                tx_signo.Text = signosZodiacales[3].ToString();
            }
            else if ((fechasArray[0] >= 23 && fechasArray[1] == 7) || (fechasArray[0] <= 22 && fechasArray[1] == 8))
            {
                tx_signo.Text = signosZodiacales[4].ToString();
            }
            else if ((fechasArray[0] >= 23 && fechasArray[1] == 8) || (fechasArray[0] <= 22 && fechasArray[1] == 9))
            {
                tx_signo.Text = signosZodiacales[5].ToString();
            }
            else if ((fechasArray[0] >= 23 && fechasArray[1] == 9) || (fechasArray[0] <= 22 && fechasArray[1] == 10))
            {
                tx_signo.Text = signosZodiacales[6].ToString();
            }
            else if ((fechasArray[0] >= 23 && fechasArray[1] == 10) || (fechasArray[0] <= 21 && fechasArray[1] == 11))
            {
                tx_signo.Text = signosZodiacales[7].ToString();
            }
            else if ((fechasArray[0] >= 22 && fechasArray[1] == 11) || (fechasArray[0] <= 21 && fechasArray[1] == 12))
            {
                tx_signo.Text = signosZodiacales[8].ToString();
            }
            else if ((fechasArray[0] >= 22 && fechasArray[1] == 12) || (fechasArray[0] <= 19 && fechasArray[1] == 1))
            {
                tx_signo.Text = signosZodiacales[9].ToString();
            }
            else if ((fechasArray[0] >= 20 && fechasArray[1] == 1) || (fechasArray[0] <= 18 && fechasArray[1] == 2))
            {
                tx_signo.Text = signosZodiacales[10].ToString();
            }
            else if ((fechasArray[0] >= 19 && fechasArray[1] == 2) || (fechasArray[0] <= 20 && fechasArray[1] == 3))
            {
                tx_signo.Text = signosZodiacales[11].ToString();
            }
        }

        private void b_ver_Click(object sender, EventArgs e)
        {
            this.diferenciaFechas();
        }

        private void diferenciaFechas()
        {
            string fechaInicio = Convert.ToString(tx_fecha_inicio.Text), fechaFinal = Convert.ToString(tx_fecha_final.Text), formatoFecha = "MM/dd/yyyy HH:mm:ss";
            //Metodo que valida la fecha y retorna una variable que sirve para sacar los dias, meses y anios
            DateTime.TryParseExact(fechaInicio, formatoFecha, null, System.Globalization.DateTimeStyles.None, out DateTime fechaInicioOrdenada);
            DateTime.TryParseExact(fechaFinal, formatoFecha, null, System.Globalization.DateTimeStyles.None, out DateTime fechaFinalOrdenada);

            if (fechaInicioOrdenada <= fechaFinalOrdenada)
            {
                TimeSpan fechaDiferencia = fechaFinalOrdenada - fechaInicioOrdenada;
                tx_dias.Text = fechaDiferencia.Days.ToString();
                tx_horas.Text = (fechaDiferencia.Days * 24).ToString();
                tx_mins.Text = (fechaDiferencia.Days * 60 * 24).ToString();
            }
            else
            {
                MessageBox.Show("ERROR, INGRESE UNA FECHA VALIDA");
            }

        }
    }
}
