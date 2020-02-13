using System;
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
            double[] arreglo2 = new double[5] { 1, 2, 3, 4, 5 };
            //Obtener la suma de los elementos del arreglo
            double s = Statistics.Suma(arreglo);
            //Obtiene el promedio
            double prom = s / args.Length;
            Console.WriteLine("Promedio: {0}", prom);
            Console.WriteLine("Suma de arreglos {1}", 5);
            Console.ReadLine();
        }


        /*
        Primero se probó el metodo dentro de Sumatorias, luego se exportó a la libreria. 
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
