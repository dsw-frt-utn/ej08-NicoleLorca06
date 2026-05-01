using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int Contador = 0;

            int n1 = nota1 ?? -1;
            if (n1 >= 0 && n1 <=10)
            {
                suma += n1;
                Contador++;
            }

            int n2 = nota2 ?? -1;
            if (n2 >= 0 && n2 <= 10)
            {
                suma += n2;
                Contador++;
            }

            int n3 = nota3 ?? -1;
            if (n3 >= 0 && n3 <= 10)
            {
                suma += n3;
                Contador++;
            }

            return Contador == 0 ? 0 : suma / Contador;

        }

    }
}
