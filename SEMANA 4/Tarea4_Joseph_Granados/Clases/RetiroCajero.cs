using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Joseph_Granados.Clases
{
    public class RetiroCajero
    {
       
        public int[] NumBilletes(int[] cantidadesBilletes, int aRetirar)
        {
            int[] numBilletesRetirar = new int[cantidadesBilletes.Length]; //10,20,50,100,200
            int numBilletesCien = 0, numBilletesCincuenta = 0, numBilletesVeinte = 0, numBilletesDoscientos = 0, numBilletesDiez = 0, resta = 0 , retiro = aRetirar , cantidadRetirada = 0;

            try
            {
                if (aRetirar != 0)
                {
                    resta = retiro - 200;

                    if (resta >= 0 && cantidadesBilletes[4] != 0)
                    {
                        numBilletesDoscientos = retiro / 200;
                        numBilletesRetirar[4] = numBilletesDoscientos;
                        retiro = retiro - (numBilletesRetirar[4] * 200);
                        cantidadRetirada += numBilletesRetirar[4] * 200;
                    }

                    resta = retiro - 100;

                    if (resta >= 0 && cantidadesBilletes[3] != 0)
                    {
                        numBilletesCien = retiro / 100;
                        numBilletesRetirar[3] = numBilletesCien;
                        retiro = retiro - (numBilletesRetirar[3] * 100);
                        cantidadRetirada += numBilletesRetirar[3] * 100;
                    }

                    resta = retiro - 50;

                    if (resta >= 0 && cantidadesBilletes[2] != 0)
                    {
                        numBilletesCincuenta = retiro / 50;
                        numBilletesRetirar[2] = numBilletesCincuenta;
                        retiro = retiro - (numBilletesRetirar[2] * 50);
                        cantidadRetirada += numBilletesRetirar[2] * 50;
                    }

                    resta = retiro - 20;

                    if (resta > 0 && cantidadesBilletes[1] != 0)
                    {
                        numBilletesVeinte = retiro / 20;
                        numBilletesRetirar[1] = numBilletesVeinte;
                        retiro = retiro - (numBilletesRetirar[1] * 20);
                        cantidadRetirada += numBilletesRetirar[1] * 20;
                    }

                    resta = retiro - 10;

                    if (resta > 0 && cantidadesBilletes[0] != 0)
                    {
                        numBilletesDiez = retiro / 10;
                        numBilletesRetirar[0] = numBilletesDiez;
                        retiro = retiro - (numBilletesRetirar[0] * 10);
                        cantidadRetirada += numBilletesRetirar[0] * 10;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un valor a retirar");
            }

            if (retiro == aRetirar)
            {
                MessageBox.Show("NO SE PUDO COMPLETAR EL RETIRO DEBIDO A QUE INGRESÓ UN VALOR QUE NO ES MÚLTIPLO DE LOS BILLETES DISPONIBLES EN EL CAJERO: 10 20 50 100 200");
            }
            else if (retiro != 0)
            {
                MessageBox.Show("SE COMPLETÓ PARCIALMENTE EL RETIRO DEBIDO A QUE LA CANTIDAD NO CUMPLE LOS REQUISITOS, TOTAL RETIRADO: " + cantidadRetirada.ToString() + " DEL TOTAL INGRESADO: " + aRetirar.ToString());
            }
            
            return numBilletesRetirar;
        }
    }
}
