using System;


namespace AproximarPi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t~~~~~~~~~~~~FACULTAD DE INGENIERIA~~~~~~~~~~~~");
            Console.WriteLine("\t\t\tSanchez Catedra Diego Issac\n\t\t\tTemas Selectos de Programacion\n");
            Console.WriteLine("\t\t\tAproximar a pi");

            Console.WriteLine("Ingrese el numero de iteraciones para aproximar a PI");
            int iteraciones = int.Parse(Console.ReadLine());
            double aproximacion = 0;
            for (int indice = 0; indice <= iteraciones; indice++)
            {
                aproximacion = (4 * Math.Pow(-1, indice)) / (2*indice+1)+aproximacion;
                Console.WriteLine("\nLa aproximacion a pi es:  {0}", aproximacion);
                double ErrorAbs = (Math.PI - aproximacion) / Math.PI; ;
                Console.WriteLine("Error experimental de: {0}", ErrorAbs);
            }
            Console.ReadLine();
        }
    }
}
