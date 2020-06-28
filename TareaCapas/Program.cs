using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaCapas
{
    class Capas
    {
        public static void Main(string[] args)
        {
            // Números pares e impares
            int num;
            Console.Write("Ingrese el numero: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("El número es par");
            else
                Console.WriteLine("El número es impar");
            Console.WriteLine();

            // Nombre del mes ingresado por paramtro
            int mes;
            Console.Write("Ingrese el valor de mes: ");
            mes = int.Parse(Console.ReadLine());
            if (mes == 1)
                Console.WriteLine("Enero");
            if (mes == 2)
                Console.WriteLine("Febrero");
            if (mes == 3)
                Console.WriteLine("Marzo");
            if (mes == 4)
                Console.WriteLine("Abril");
            if (mes == 5)
                Console.WriteLine("Mayo");
            if (mes == 6)
                Console.WriteLine("Junio");
            if (mes == 7)
                Console.WriteLine("Julio");
            if (mes == 8)
                Console.WriteLine("Agosto");
            if (mes == 9)
                Console.WriteLine("Septiembre");
            if (mes == 10)
                Console.WriteLine("Octubre");
            if (mes == 11)
                Console.WriteLine("Noviembre");
            if (mes == 12)
                Console.WriteLine("Diciembre");
            else if (mes < 1 || mes > 12)
                Console.WriteLine("Valor fuera de rango...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
