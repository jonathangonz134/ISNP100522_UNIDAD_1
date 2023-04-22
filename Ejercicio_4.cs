using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP100522_UNIDAD_1
{
    internal class Ejercicio_4
    {
        //Escriba un programa que lea 5 números desde teclado y presente
        //la sumatoria de los mismos(usar Do-While). 
        public Ejercicio_4() 
        {
            int num1, num2, num3, num4, num5, total;

            do
            {
                Console.WriteLine("Ingrese el Primer numero a sumar: ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Segundo numero a sumar: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Tercer numero a sumar: ");
                num3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Cuarto numero a sumar: ");
                num4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el Quinto numero a sumar: ");
                num5 = int.Parse(Console.ReadLine());


                total = num1 + num2 + num3 + num4 + num5;
                Console.WriteLine("El Resultado de la suma es: " + total);
                Console.ReadKey();
            }
            while (total > 0);
        }
    }
}
