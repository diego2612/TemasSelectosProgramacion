using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathG;

namespace Sumatorias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t~~~~~~~~~~~~FACULTAD DE INGENIERIA~~~~~~~~~~~~");
            Console.WriteLine("\t\t\tSanchez Catedra Diego Issac\n\t\t\tTemas Selectos de Programacion\n");
            Console.WriteLine("\t\t\tSUMATORIAS");


            double[] arreglo = new double[5] { 1,2,3,4,5};
            double s = Statistics.Sum(arreglo);
            double prom = s / args.Length;
            Console.WriteLine("{ 0}", prom);
            Console.ReadLine();
            double suma = Statistics.Sum(arreglo);

        }

        static double Suma(double[] input)
        {
            //Metodo para sumar los arreglos 
            double SumaArreglos = Statistics.Sum(input);
            return SumaArreglos;
        }

        /*
        static double Sum(double[] entrada)
        {
            double salida = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                 salida = salida + entrada[i];
            }
            return 0;
        }
        */
    }
}
