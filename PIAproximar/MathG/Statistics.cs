using System;

namespace MathG
{
    public class Statistics
    {
        /// <summary>
        /// Obtener promedio de un conjunto de datos
        /// </summary>
        /// <param name="Arreglo de datos"></param>
        public  double Mean(double [] input)
        {
            double output = Aritmetica.Sum(input)/(input.Length);
            
            return output;
        }

        /// <summary>
        /// Obtener promedio varianza muestral de un conjunto de datos
        /// </summary>
        /// <param name="input">arreglo de datos</param>
        public double VarS(double[] input)
        {
            double[] vectorVariable = new double[input.Length];

            vectorVariable = Aritmetica.Minus(input, Mean(input));
            vectorVariable = Aritmetica.PowArreglo(vectorVariable,2 );
            double output = Aritmetica.Sum(vectorVariable) / (input.Length-1);
            return output;
        }

        /// <summary>
        /// Obtener promedio varianza muestral de un conjunto de datos
        /// </summary>
        /// <param name="input">arreglo de datos</param>
        public double DesviacionEstandarS(double[] input)
        {
            double desviacionEstandar = Math.Sqrt(VarS(input));
            return desviacionEstandar;
        }

        /// <summary>
        /// Define el rango de normalidad de los datos
        /// </summary>
        /// <param name="input">arreglo de datos</param>
        public double[] RangoEstadistico (double [] input)
        {
            double[] output = new double[4];
            output[0] = Mean(input) + 2*DesviacionEstandarS(input);
            output[1] = Mean(input) + DesviacionEstandarS(input);
            output[2] = Mean(input) - DesviacionEstandarS(input);
            output[3] = Mean(input) + 2*DesviacionEstandarS(input);
            return output;
        }

        /// <summary>
        /// Crea un vector desde a hasta b con n elementos igualmente espaciados
        /// </summary>
        /// <param name="a">arreglo de datos</param>
        /// /// <param name="b">arreglo de datos</param>
        /// /// <param name="n">arreglo de datos</param>
        public float[] Linspace(float a,float b, int n)
        {
            float [] output = new float[n];
            float incremento = (((b - a)) / (n-1));
            int indice = 0;
            for (float i=a;i<=b;i+=incremento)
            {
                    output[indice] = i;
                    indice++;
            }
            return output ;
        }
    }
}
