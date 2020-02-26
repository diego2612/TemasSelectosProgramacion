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
        /// <param name="a">inicio</param>
        /// /// <param name="b">fin</param>
        /// /// <param name="n">numero de elementos</param>
        public float[] LinspaceN(float a,float b, int n)
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

        /// <summary>
        /// Crea un vector desde a hasta b con un valor de incremento igual a X
        /// </summary>
        /// <param name="a">inicio</param>
        /// /// <param name="b">fin</param>
        /// /// <param name="x">valor de incremento</param>
        public double[] LinspaceX(double a, double b, double x)
        {
            //Definir vector a devolver con los incrementos deseados
            int tamaño = (int)(((b - a) / x) + 1);
            double[] output = new double[tamaño];
            //Crear vector
            int indice = 0;
            output[0] = a;
            output[tamaño - 1] = b;
            for (double i=a;i<=b;i+=x)
            {
                output[indice] = i;
                indice++;
            }
            return output;
        }


        /// <summary>
        /// Obtiene la funcion de densidad de probabilidad normal de los elementos de un vector
        /// </summary>
        /// <param name="input">Elementos a evaluar en f. probabilidad</param>
        /// /// <param name="m">media muestral </param>
        /// /// <param name="G">Desviacion estandar muestral</param>
        public double[] Normpdf(double[] input, double m, double G)
        {
            double[] output = new double[input.Length];
            for (int i=0;i<input.Length;i++)
            {
                output[i] =(1/(Math.Sqrt(2*Math.PI)*G))*(Math.Exp(-0.5*Math.Pow((input[i]-m)/G,2)));
            }
            return output;
        } 
    }
}
