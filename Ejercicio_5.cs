using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP100522_UNIDAD_1
{
    internal class Ejercicio_5
    {
        //Desarrolle un programa que pida una serie de números y al finalizar
        //que calcule el promedio de dichos números(0 para finalizar) (usar While).
        public Ejercicio_5()
        {
            int num, sum = 0, count = 0;

            Console.WriteLine("Introduce una serie de números (0 para finalizar):");

            while (true)
            {
                Console.Write("Introduce un número: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                sum += num;
                count++;
            }

            if (count > 0)
            {
                double avg = (double)sum / count;
                Console.WriteLine("El promedio de los números introducidos es: " + avg);
            }
            else
            {
                Console.WriteLine("No se han introducido números para calcular el promedio.");
            }
        }
    }
}
