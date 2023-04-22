using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ISNP100522_UNIDAD_1
{
    internal class Ejercicio_3
    {
        //Desarrolle un programa que pida números positivos al usuario
        //y vaya calculando la suma de todos ellos
        //(terminará cuando se teclea un número negativo o cero (usar Do-While).
        public Ejercicio_3()
        {
            int num1, num2, resultado;

            do
            {
                Console.WriteLine("Ingrese el Primer numero Positivo: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el Segundo numero Positivo ");
                num2= int.Parse(Console.ReadLine());

                resultado = num1 + num2;

                Console.WriteLine("El Resultado de la Suma es: " + resultado);
                Console.ReadKey();
            }

            while (num1 <= 0);
            {
                
            }
            if (num2 <= 0)
            {
                
            }
            else
            {
                
            }
        }
    }
}
