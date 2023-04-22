using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP100522_UNIDAD_1
{
    internal class Ejercicio_1
    {

        //Desarrolle un programa que muestre si cada número que se teclea es positivo o negativo
        //y que se detenga cuando al teclear el número 0(usar While)

        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                Console.WriteLine("Ingresa un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Tu numero es Negativo");
                   
                }
                else if (num > 0)
                {
                    Console.WriteLine("Tu numero es Positivo");
                }
                else
                {
                    break;
                }

            }
            
        }

     }
 }

