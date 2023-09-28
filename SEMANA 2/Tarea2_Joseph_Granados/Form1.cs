using System.Diagnostics.Metrics;

namespace Tarea2_Joseph_Granados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b_limpiar_Click(object sender, EventArgs e)
        {
            tx_impar.Clear();
            tx_limite.Clear();
            tx_par.Clear();
            tx_resultado_impares.Clear();
            tx_resultado_pares.Clear();
            tx_limite.Focus();
        }

        int[] arregloRandom = new int[0];
        int counter = 0, intervalo, delValue, alValue;

        private void b_calcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_limite.Text))
            {
                MessageBox.Show("Ingrese un valor");
                tx_limite.Focus();
                return;
            }
            double limite = Convert.ToDouble(tx_limite.Text), i = 0, j = 0, sumPar = 0, sumImpar = 0;
            double[] pares = new double[(int)limite], impares = new double[(int)limite];

            while (i < limite)
            {
                if (i % 2 == 0 && i != 0)
                {
                    pares[(int)i] = i;
                    tx_par.Text += pares[(int)i].ToString() + Environment.NewLine;
                }
                else if (i % 2 != 0 || i == 1)
                {
                    impares[(int)i] = i;
                    tx_impar.Text += impares[(int)i].ToString() + Environment.NewLine;
                }
                i++;
            }

            while (j < limite)
            {
                sumPar += pares[(int)j];
                sumImpar += impares[(int)j];
                j++;
            }

            tx_resultado_impares.Text = sumImpar.ToString();
            tx_resultado_pares.Text = sumPar.ToString();
        }

        private void b_limpiarr_Click(object sender, EventArgs e)
        {
            tx_tamanio_arreglo.Clear();
            tx_limite_random.Clear();
            tx_contenido.Clear();
            tx_tamanio_arreglo.Focus();
        }

        public void b_llenar_arreglo_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(tx_tamanio_arreglo.Text), limite = Convert.ToInt32(tx_limite_random.Text), j = 0, i = 0;
            arregloRandom = new int[tamanio];
            Random randomInstance = new Random();
            int numRam = randomInstance.Next(0, limite);

            if (ckb_no_pares.Checked)
            {
                double compareVal = Convert.ToDouble(numRam);
                while (j < tamanio)
                {
                    numRam = randomInstance.Next(0, limite);
                    compareVal = Convert.ToDouble(numRam);
                    if (compareVal % 2 != 0 || compareVal == 1)
                    {
                        arregloRandom[j] = numRam;
                        tx_contenido.Text += arregloRandom[j].ToString() + " ";
                        j++;
                    }
                }
            }
            else
            {
                while (i < tamanio)
                {
                    arregloRandom[i] = numRam;
                    numRam = randomInstance.Next(0, limite);
                    tx_contenido.Text += arregloRandom[i].ToString() + " ";
                    i++;
                }

            }

        }

        public void b_ascendente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_contenido.Text))
            {
                MessageBox.Show("Llene primero el limite y el tamaño");
                tx_tamanio_arreglo.Focus();
                return;
            }
            Array.Sort(arregloRandom);
            int i = 0;
            tx_contenido.Clear();
            while (i < arregloRandom.Length)
            {
                tx_contenido.Text += arregloRandom[i].ToString() + " ";
                i++;
            }
        }

        public void b_descendente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_contenido.Text))
            {
                MessageBox.Show("Llene primero el limite y el tamaño");
                tx_tamanio_arreglo.Focus();
                return;
            }
            Array.Sort(arregloRandom);
            Array.Reverse(arregloRandom);
            int i = 0;
            tx_contenido.Clear();
            while (i < arregloRandom.Length)
            {
                tx_contenido.Text += arregloRandom[i].ToString() + " ";
                i++;
            }
        }

        private void b_limpiar_timer_Click(object sender, EventArgs e)
        {
            tx_del.Clear();
            tx_al.Clear();
            tx_intervalo.Clear();
            tx_del.Focus();
        }

        private void b_iniciar_Click(object sender, EventArgs e)
        {
            intervalo = Convert.ToInt32(tx_intervalo.Text);
            delValue = Convert.ToInt32(tx_del.Text);
            alValue = Convert.ToInt32(tx_al.Text);
            timer.Interval = (intervalo * 100);
            timer.Enabled = true;
            counter = intervalo;
            label16.Text = counter.ToString();

            if (tx_al.Text == string.Empty || tx_del.Text == string.Empty || tx_intervalo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese los valores necesarios");
                tx_al.Focus();
                return;
            }
            else if (delValue > alValue)
            {
                MessageBox.Show("Error, DelValue es mayor que AlValue");
                tx_al.Focus();
                return;
            }
            else if (intervalo > 60)
            {
                MessageBox.Show("Error, Intervalo mayor a 60, ingrese uno menor");
                tx_al.Focus();
                return;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            int[] baseArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            if (delValue <= alValue)
            {
                while (i < baseArray.Length)
                {
                    int resultado = delValue * baseArray[i];

                    tx_resultado_tabla.Text += delValue.ToString() + " * " + baseArray[i].ToString() + " = " + resultado + Environment.NewLine;

                    i++;
                }
            }
            counter--;
            if (counter == 0)
            {
                timer.Stop();
                delValue = delValue + 1;
                counter = intervalo;
                timer.Start();
                tx_resultado_tabla.Clear();
            }

            else if (delValue > alValue)
            {
                counter = intervalo;
                timer.Stop();
                delValue = Convert.ToInt32(tx_del.Text);
                tx_resultado_tabla.Text = "Ciclo completado desde: " + Environment.NewLine + delValue.ToString() + Environment.NewLine + " hasta: " + Environment.NewLine + alValue.ToString();
            }
            label16.Text = counter.ToString();
        }

        private void b_detener_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void cklist_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bo_limpiar_Click(object sender, EventArgs e)
        {
            tx_lim_random.Clear();
            ckb_no_impar.Checked = false;
            rb_num_par.Checked = false;
            rb_num_impar.Checked = false;
            rb_ambos.Checked = false;
            tx_a1.Clear();
            tx_a2.Clear();
            tx_a3.Clear();
            tx_a4.Clear();
            tx_b1.Clear();
            tx_b2.Clear();
            tx_b3.Clear();
            tx_b4.Clear();
            tx_c1.Clear();
            tx_c2.Clear();
            tx_c3.Clear();
            tx_c4.Clear();
            tx_lim_random.Focus();
            b_llenar.Enabled = true;
            ckb_no_impar.Enabled = true;

        }

        private void b_llenar_Click(object sender, EventArgs e)
        {
            /* TextBox name and order:
             *  a1 a2 a3 a4 resulta
             *  b1 b2 b3 b4 resultb
             *  c1 c2 c3 c4 resultc
             *  r1 r2 r3 r4
             */
            int limite = Convert.ToInt32(tx_lim_random.Text), i = 0, numRandom;
            Random randomInstance = new Random();
            int[] randomNumbers = new int[15];
            if (tx_lim_random.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un limite random");
            }
            //Generar randoms
            while (i < randomNumbers.Length)
            {

                if (rb_num_par.Checked)
                {
                    numRandom = randomInstance.Next(1, limite);
                    if (numRandom % 2 == 0)
                    {
                        randomNumbers[i] = numRandom;
                        i++;
                    }
                }
                else if (rb_num_impar.Checked)
                {
                    numRandom = randomInstance.Next(1, limite);
                    if (numRandom % 2 != 0 || numRandom == 1)
                    {
                        randomNumbers[i] = numRandom;
                        i++;
                    }
                }
                else if (rb_ambos.Checked)
                {
                    numRandom = randomInstance.Next(1, limite);
                    randomNumbers[i] = numRandom;
                    i++;
                }
            }

            if (ckb_no_impar.Checked)
            {
                tx_a2.Text = randomNumbers[0].ToString();
                tx_a1.Text = 0.ToString();
                tx_a4.Text = randomNumbers[2].ToString();
                tx_a3.Text = 0.ToString();
                tx_b2.Text = randomNumbers[4].ToString();
                tx_b1.Text = 0.ToString();
                tx_b4.Text = randomNumbers[6].ToString();
                tx_b3.Text = 0.ToString();
                tx_c2.Text = randomNumbers[8].ToString();
                tx_c1.Text = 0.ToString();
                tx_c4.Text = randomNumbers[10].ToString();
                tx_c3.Text = 0.ToString();
                b_llenar.Enabled = false;
                ckb_no_impar.Enabled = false;
            }
            else
            {
                tx_a1.Text = randomNumbers[0].ToString();
                tx_a2.Text = randomNumbers[1].ToString();
                tx_a3.Text = randomNumbers[2].ToString();
                tx_a4.Text = randomNumbers[3].ToString();
                tx_b1.Text = randomNumbers[4].ToString();
                tx_b2.Text = randomNumbers[5].ToString();
                tx_b3.Text = randomNumbers[6].ToString();
                tx_b4.Text = randomNumbers[7].ToString();
                tx_c1.Text = randomNumbers[8].ToString();
                tx_c2.Text = randomNumbers[9].ToString();
                tx_c3.Text = randomNumbers[10].ToString();
                tx_c4.Text = randomNumbers[11].ToString();
                b_llenar.Enabled = false;
                ckb_no_impar.Enabled = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            rb_ambos.Checked = true;
        }

        private void b_ver_resultado_Click(object sender, EventArgs e)
        {

            if (rb_fila_num.Checked)
            {
                int fila = Convert.ToInt32(tx_fila_num.Text);
                tx_fila_num.Focus();
                if (tx_fila_num.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un numero de fila valido");
                }

                switch (fila)
                {
                    case 1:
                        int sumaA = Convert.ToInt32(tx_a1.Text) + Convert.ToInt32(tx_a2.Text) + Convert.ToInt32(tx_a3.Text) + Convert.ToInt32(tx_a4.Text);
                        tx_resulta.Text = sumaA.ToString();
                        break;

                    case 2:
                        int sumaB = Convert.ToInt32(tx_b1.Text) + Convert.ToInt32(tx_b2.Text) + Convert.ToInt32(tx_b3.Text) + Convert.ToInt32(tx_b4.Text);
                        tx_resultb.Text = sumaB.ToString();
                        break;

                    case 3:
                        int sumaC = Convert.ToInt32(tx_c1.Text) + Convert.ToInt32(tx_c2.Text) + Convert.ToInt32(tx_c3.Text) + Convert.ToInt32(tx_c4.Text);
                        tx_resultc.Text = sumaC.ToString();
                        break;

                    default:
                        MessageBox.Show("Ingrese valor valido");
                        break;
                }
            }

            if (rb_columna_num.Checked)
            {
                tx_columna.Enabled = true;
                int columna = Convert.ToInt32(tx_columna.Text);
                tx_columna.Focus();
                if (tx_columna.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un numero de columna valido");
                }

                switch (columna)
                {
                    case 1:
                        int suma1 = Convert.ToInt32(tx_a1.Text) + Convert.ToInt32(tx_b1.Text) + Convert.ToInt32(tx_c1.Text);
                        tx_result1.Text = suma1.ToString();
                        break;

                    case 2:
                        int suma2 = Convert.ToInt32(tx_a2.Text) + Convert.ToInt32(tx_b2.Text) + Convert.ToInt32(tx_c2.Text);
                        tx_result2.Text = suma2.ToString();
                        break;

                    case 3:
                        int suma3 = Convert.ToInt32(tx_a3.Text) + Convert.ToInt32(tx_b3.Text) + Convert.ToInt32(tx_c3.Text);
                        tx_result3.Text = suma3.ToString();
                        break;

                    case 4:
                        int suma4 = Convert.ToInt32(tx_a4.Text) + Convert.ToInt32(tx_b4.Text) + Convert.ToInt32(tx_c4.Text);
                        tx_result4.Text = suma4.ToString();
                        break;

                    default:
                        MessageBox.Show("Ingrese valor valido");
                        break;
                }
            }

            if (rb_todasfilas.Checked)
            {
                int sumaA = Convert.ToInt32(tx_a1.Text) + Convert.ToInt32(tx_a2.Text) + Convert.ToInt32(tx_a3.Text) + Convert.ToInt32(tx_a4.Text);
                tx_resulta.Text = sumaA.ToString();
                int sumaB = Convert.ToInt32(tx_b1.Text) + Convert.ToInt32(tx_b2.Text) + Convert.ToInt32(tx_b3.Text) + Convert.ToInt32(tx_b4.Text);
                tx_resultb.Text = sumaB.ToString();
                int sumaC = Convert.ToInt32(tx_c1.Text) + Convert.ToInt32(tx_c2.Text) + Convert.ToInt32(tx_c3.Text) + Convert.ToInt32(tx_c4.Text);
                tx_resultc.Text = sumaC.ToString();
            }

            if (rb_todas_columnas.Checked)
            {
                int suma1 = Convert.ToInt32(tx_a1.Text) + Convert.ToInt32(tx_b1.Text) + Convert.ToInt32(tx_c1.Text);
                tx_result1.Text = suma1.ToString();
                int suma2 = Convert.ToInt32(tx_a2.Text) + Convert.ToInt32(tx_b2.Text) + Convert.ToInt32(tx_c2.Text);
                tx_result2.Text = suma2.ToString();
                int suma3 = Convert.ToInt32(tx_a3.Text) + Convert.ToInt32(tx_b3.Text) + Convert.ToInt32(tx_c3.Text);
                tx_result3.Text = suma3.ToString();
                int suma4 = Convert.ToInt32(tx_a4.Text) + Convert.ToInt32(tx_b4.Text) + Convert.ToInt32(tx_c4.Text);
                tx_result4.Text = suma4.ToString();
            }

        }

        private void b_limpiar_resultados_Click(object sender, EventArgs e)
        {
            tx_result1.Clear();
            tx_result2.Clear();
            tx_result3.Clear();
            tx_result4.Clear();
            tx_resulta.Clear();
            tx_resultb.Clear();
            tx_resultc.Clear();
            tx_resulta.Clear();
        }

        private void tx_lim_random_TextChanged(object sender, EventArgs e)
        {

        }
    }
}