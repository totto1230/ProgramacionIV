using System;
using System.Windows.Forms;
using Tarea4_Joseph_Granados.Clases;

namespace Tarea4_Joseph_Granados
{
    public partial class frm_tarea4 : Form
    {
        public frm_tarea4()
        {
            InitializeComponent();
        }

        int totalesC, totalDolares;
        int[] billetesColonesUser = new int[5], billetesDolaresUser = new int[5];

        private void b_limpiarr_cajero_Click_1(object sender, EventArgs e)
        {
            num_bill_colo_cien.ResetText();
            num_bill_colo_cincuenta.ResetText();
            num_bill_colo_diez.ResetText();
            num_bill_colo_doscientos.ResetText();
            num_bill_colo_veinte.ResetText();
            num_bill_doll_cien.ResetText();
            num_bill_doll_cincuenta.ResetText();
            num_bill_doll_diez.ResetText();
            num_bill_doll_doscientos.ResetText();
            num_bill_doll_veinte.ResetText();
            num_bill_colo_diez.Focus();
            totalesC = 0; totalDolares = 0;
        }

        private void b_limpiar_retiroo_Click(object sender, EventArgs e)
        {
            tx_retirarr.Clear();
            tx_retiro_b10.Clear();
            tx_retiro_b20.Clear();
            tx_retiro_b50.Clear();
            tx_retiro_b100.Clear();
            tx_retiro_b200.Clear();
            tx_retirarr.Focus();
        }

        private void b_ingresarr_colones_Click(object sender, EventArgs e)
        {
            IngresoCajero ingreso = new IngresoCajero();

            billetesColonesUser = ingreso.CalcularValor(Convert.ToInt32(num_bill_colo_diez.Value.ToString()), Convert.ToInt32(num_bill_colo_veinte.Value.ToString()), Convert.ToInt32(num_bill_colo_cincuenta.Value.ToString()), Convert.ToInt32(num_bill_colo_cien.Value.ToString()), Convert.ToInt32(num_bill_colo_doscientos.Value.ToString()));

            totalesC = ingreso.Saldo(billetesColonesUser);
            MessageBox.Show("INGRESO APLICADO CORRECTAMENTE! Total Cuenta en Colones: " + totalesC.ToString());
        }

        private void b_ingresarr_dol_Click_1(object sender, EventArgs e)
        {
            IngresoCajero ingreso = new IngresoCajero();

            billetesDolaresUser = ingreso.CalcularValor(Convert.ToInt32(num_bill_doll_diez.Value.ToString()), Convert.ToInt32(num_bill_doll_veinte.Value.ToString()), Convert.ToInt32(num_bill_doll_cincuenta.Value.ToString()), Convert.ToInt32(num_bill_doll_cien.Value.ToString()), Convert.ToInt32(num_bill_doll_doscientos.Value.ToString()));


            totalDolares = ingreso.Saldo(billetesDolaresUser);
            MessageBox.Show("INGRESO APLICADO CORRECTAMENTE! Total Cuenta en Dólares: " + totalDolares.ToString());
        }

        private void groupBox4_Enter_Enter (object sender, EventArgs e)
        {

        }

        private void tx_retirarr_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO NUMS
            e.Handled = ! char.IsNumber(e.KeyChar);
        }

        private void b_aceptarr_Click_1(object sender, EventArgs e)
        {
            
            int retirarCantidad = 0;
            int[] billeteColones = new int[billetesColonesUser.Length], billeteDolares = new int[billetesDolaresUser.Length];
           
            //CLASES
            RetiroCajero retiro = new RetiroCajero();
  
            try
            {
                retirarCantidad = Convert.ToInt32(tx_retirarr.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY QUE RETIRAR O NO SELECCIONASTE LA DIVISA");
            }

            //COLONES
            if (rb_coloness.Checked)
            {
                if (retirarCantidad > totalesC)
                {
                    MessageBox.Show("NO TIENES ESE DINERO, CUENTA CON: " + totalesC.ToString() + " COLONES.");
                }
                else
                {

                    if (retirarCantidad > 100000)
                    {
                        MessageBox.Show("RETIRE MENOS DE 100000");
                    }
                    else
                    {
                        billeteColones = retiro.NumBilletes(billetesColonesUser, retirarCantidad);
                        tx_retiro_b10.Text = billeteColones[0].ToString();
                        tx_retiro_b20.Text = billeteColones[1].ToString();
                        tx_retiro_b50.Text = billeteColones[2].ToString();
                        tx_retiro_b100.Text = billeteColones[3].ToString();
                        tx_retiro_b200.Text = billeteColones[4].ToString();
                        totalesC = totalesC - retirarCantidad;
                        MessageBox.Show("NUEVO SALDO DESPUÉS DEL RETIRO: " + totalesC.ToString());

                    }
                }

            }
            //DOLARES
            else if (rb_dolaress.Checked)
            {
                if (retirarCantidad > totalDolares)
                {
                    MessageBox.Show("NO TIENES ESE DINERO, CUENTA CON: " + totalDolares.ToString() + " DOLARES.");
                }
                else
                {
                    if (retirarCantidad > 100000)
                    {
                        MessageBox.Show("RETIRE MENOS DE 100000");
                    }
                    else
                    {
                        billeteDolares = retiro.NumBilletes(billetesDolaresUser, retirarCantidad);
                        tx_retiro_b10.Text = billeteDolares[0].ToString();
                        tx_retiro_b20.Text = billeteDolares[1].ToString();
                        tx_retiro_b50.Text = billeteDolares[2].ToString();
                        tx_retiro_b100.Text = billeteDolares[3].ToString();
                        tx_retiro_b200.Text = billeteDolares[4].ToString();
                        totalDolares = totalDolares - retirarCantidad;
                        MessageBox.Show("NUEVO SALDO DESPUÉS DEL RETIRO: " + totalDolares.ToString());
                    }
                }
            }
        }
    }
}

