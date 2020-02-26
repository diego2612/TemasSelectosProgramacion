using System;
using MathG;

namespace PruebasDistNormal
{
    class LinspaceDistNorm
    {
        static void Main()
        {
            Console.WriteLine("\t\t\t~~~~~~~~~~~~FACULTAD DE INGENIERIA~~~~~~~~~~~~");
            Console.WriteLine("\t\t\tSanchez Catedra Diego Issac\n\t\t\tTemas Selectos de Programacion\n");
            Console.WriteLine("\t\t\tPRUEBAS DISTRIBUCION NORMAL");
                Statistics estadistico = new Statistics();
            int tamaño = (int)(((10+10) / 1) + 1);
            double[] vector = new double[tamaño];
            double[] vectorimagen = new double[tamaño];
            vector = estadistico.LinspaceX(-10, 10, 1);
            vectorimagen = estadistico.Normpdf(vector,2,3);
            
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine(vector[i]+ "   -   " + vectorimagen[i] + "\n");
            }
            Console.ReadLine();
        }
    }
}
