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
    public partial class frm_evaluacion : Form
    {
        public frm_evaluacion()
        {
            InitializeComponent();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra la ventana actual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_porc_tareas.Focus();
            //Guardar porcentajes
            decimal porcentajeTareas = (Convert.ToDecimal(tx_porc_tareas.Text) / 100);
            decimal porcentajeQuizzes = (Convert.ToDecimal(tx_porc_quizzes.Text) / 100);
            decimal porcentajeParcial1 = (Convert.ToDecimal(tx_porc_parcial1.Text) / 100);
            decimal porcentajeParcial2 = (Convert.ToDecimal(tx_porc_parcial2.Text) / 100);
            decimal porcentajeParcial3 = (Convert.ToDecimal(tx_porc_parcial3.Text) / 100);

            //Calculo nota quiz
            decimal quiz1 = Convert.ToDecimal(tx_quiz1.Text);
            decimal quiz2 = Convert.ToDecimal(tx_quiz2.Text);
            decimal quiz3 = Convert.ToDecimal(tx_quiz3.Text);
            decimal notaQuiz = ((quiz1 + quiz2 + quiz3) / 3);
            tx_quiz_total.Text = notaQuiz.ToString();

            //Calculo nota tareas
            decimal tarea1 = Convert.ToDecimal(tx_tarea1.Text);
            decimal tarea2 = Convert.ToDecimal(tx_tarea2.Text);
            decimal tarea3 = Convert.ToDecimal(tx_tarea3.Text);
            decimal tarea4 = Convert.ToDecimal(tx_tarea4.Text);
            decimal notaTarea = ((tarea1+tarea2+tarea3+tarea4)/4);
            tx_nota_tareas.Text = notaTarea.ToString();

            //Calculo Nota Final
            decimal notaTareaFinal = notaTarea * porcentajeTareas;
            decimal notaQuizFinal = notaQuiz * porcentajeQuizzes;
            decimal parcial1Final = (Convert.ToDecimal(tx_parcial1.Text) * porcentajeParcial1);
            decimal parcial2Final = (Convert.ToDecimal(tx_parcial2.Text) * porcentajeParcial2);
            decimal parcial3Final = (Convert.ToDecimal(tx_parcial3.Text) * porcentajeParcial3);
            decimal notaFinal = notaTareaFinal + notaQuizFinal + parcial1Final + parcial2Final + parcial3Final;
            tx_nota_final.Text = notaFinal.ToString();


        }
    }
}
