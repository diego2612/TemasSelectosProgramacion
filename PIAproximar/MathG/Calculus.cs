using System;
using System.Collections.Generic;
using System.Text;

namespace MathG
{
    class Calculus
    {
        ///<summary>
        ///Diferencia y derivados aproximados "diff en matlab"
        ///</summary>
        ///<param name = "input">Los elementos del polinomio a derivar</param>

        public double[] Diff(double[] input)
        {
            //Dado que a cada elemento le resta el siguiente, son diferencias hacia adelante
            //El vector devuelto es de tamaño N-1 
            double[] VectorDiferenciasFinitas = new double[input.Length - 1];
            for (int i = 0; i <= input.Length - 1; i++)
            {
                VectorDiferenciasFinitas[i] = (input[i + 1] - input[i]);
            }
            return VectorDiferenciasFinitas;
            /*Si al vector salida se le divide entre el incremento del vector X(generalmente el vector de linspace)
            se obtiene la primer derivada evaluada en dichos elementos*/
        }

    }
}
