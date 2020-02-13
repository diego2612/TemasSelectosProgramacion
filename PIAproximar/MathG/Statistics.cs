using System;

namespace MathG
{
    public class Statistics
    {
        ///<summary>
        ///Suma de los elementos de un array dado "sum en matlab"
        ///</summary>
        ///<param name="entrada"> Un arreglo con valores numericos </param>

        public static double Suma(double[] entrada)
        {
            double salida = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                salida = salida + entrada[i];
            }
            return 0;
        }


        /// <summary>
        /// Obtener promedio de un conjunto de datos
        /// </summary>
        /// <param name="Arreglo de datos"></param>
        public double MediaAritmetica(double [] Datos)
        {
            double suma = 0;
            for (int j = 0; j <= Datos.Length; j++)
            {
                suma = (Datos[j] + suma);
            }
            double media = suma / Datos.Length;
            return media;
        }
    }
}
