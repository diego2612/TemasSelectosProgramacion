using System;
using System.Collections.Generic;



namespace MathG
{
    //A continuacion se presentan metodos aritméticos listos para usarse
    class Aritmetica
    {
        ///<summary>
        ///Suma de dos arreglos "plus en matlab"
        ///</summary>
        ///<param name="arregloEntrada"Un arreglo ></param>
        /// 
        static double[] SumaArreglos(double[] arreglo1Entrada,double [] arreglo2Entrada)
        {
            double[] ArregloResultante =new double[arreglo1Entrada.Length];
            for (int i= 0;i<=arreglo1Entrada.Length;i++)
            {
                ArregloResultante[i] =arreglo1Entrada[i] +arreglo2Entrada[i];
            }
            return ArregloResultante;
        }

        ///<summary>
        ///Suma de dos numeros reales "plus en matlab"
        ///</summary>
        ///<param name="Real 1">Un numero real </param>
        ///<param name="Real 2">Un numero real </param>
        
        public double SumaAritmetica(double real1, double real2)
        {
            double[] numeros = new double[2]{ real1, real2};
            double resultado = Statistics.Suma(numeros);
            return resultado;
        }

        ///<summary>
        ///Diferencia y derivados aproximados "diff en matlab"
        ///</summary>
        ///<param name = "VectorExponentes">Los exponentes del polinomio a derivar</param>

        public double[] DerivadaNumerica(double[ ] VectorExponentes )
        {
            double[] VectorDerivada = new double[VectorExponentes.Length - 1];
            for (int i=0;i<=VectorExponentes.Length-1;i++)
            {
                VectorDerivada[i] =(VectorExponentes[i+1]-VectorExponentes[i]);
            }
            return VectorDerivada;
        }

        ///<summary>
        ///Producto de los elementos de un arreglo
        ///</summary>
        ///<param name="ArregloEntrada ">Entrada de arreglo  de tamaño n </param>
        public double ProductoElementosArreglo(double[] ArregloEntrada)
        {
            double Resultado=1 ;
            for (int i=0;i<=ArregloEntrada.Length;i++)
            {
                Resultado = ArregloEntrada[i] * Resultado;
            }
            return Resultado;
        }

        ///<summary>
        ///Elevar los elementos de un arreglo a la potencia indicada
        /// </summary>
        /// <param name="ArregloElevar"></param>
        /// <param name="PotenciaElevar"></param>
        
        public double[] PotenciarArreglo(double[] ArregloElevar, double PotenciaElevar)
        {
            double[] ArregloPotenciado = new double[ArregloElevar.Length];

            for (int j=0;j<=ArregloElevar.Length;j++)
            {
                ArregloPotenciado[j] = Math.Pow(ArregloElevar[j], PotenciaElevar);
            }
            return ArregloPotenciado;
        }
    }
}
