using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea4_Joseph_Granados.Clases
{
    public class IngresoCajero
    {

        public int[] CalcularValor(int a, int b , int c , int d , int e)
        {
            int[] valoresBilletes = { 10, 20, 50, 100, 200 }, totales = new int[valoresBilletes.Length] , cantidadBilletes = new int[valoresBilletes.Length];
            int i = 0;

            cantidadBilletes[0] = a;
            cantidadBilletes[1] = b;
            cantidadBilletes[2] = c;
            cantidadBilletes[3] = d;
            cantidadBilletes[4] = e;

            while (i < valoresBilletes.Length)
            {
                totales[i] = valoresBilletes[i] * cantidadBilletes[i];
                i++;
            }
            return totales;
        }

        public virtual int Saldo(int[] billetes)
        {
            int i = 0, suma = 0;
            while(i < billetes.Length)
            {
                suma += billetes[i];
                i++;
            }
            return suma;
        }
    }
}
