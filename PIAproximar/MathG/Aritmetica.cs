using System;
using System.Collections.Generic;



namespace MathG
{
    //A continuacion se presentan metodos aritméticos listos para usarse
    public class Aritmetica
    {
        ///<summary>
        ///Suma de los elementos de un array dado "sum en matlab"
        ///</summary>
        ///<param name="entrada"> Un arreglo con valores numericos </param>

        public static double Sum(double[] input)
        {
            double output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                output = output + input[i];
            }
            return output;
        }
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
            double resultado = Sum(numeros);
            return resultado;
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
        ///Elevar los elementos de un arreglo a un exponente entero
        /// </summary>
        /// <param name="ArregloElevar"></param>
        /// <param name="PotenciaElevar"></param>
        
        public static double[] PowArreglo(double[] ArregloElevar, int PotenciaElevar)
        {
            double[] ArregloPotenciado = new double[ArregloElevar.Length];

            for (int j=0;j<ArregloElevar.Length;j++)
            {
                ArregloPotenciado[j] = Power(ArregloElevar[j], PotenciaElevar);
            }
            return ArregloPotenciado;
        }

        ///<summary>
        ///Elevar un numero real a una potencia entera
        /// </summary>
        /// <param name="Numero real Elevar"></param>
        /// <param name="PotenciaElevar"></param>
        public static double Power(double input,int exp)
        {
            double output = 1 ;
            for (int i=0;i<exp;i++)
            {
                output = input * input;
            }
            return output;
        }
        ///<summary>
        ///Resta a cada elemento de un arreglo, un escalar
        /// </summary>
        /// <param name="input"></param>
        /// <param name="escalar"></param>
        /// <returns name="Arreglo restado el escalar"></returns>
        public static double[] Minus(double[] input, double escalar)
        {
            double[] output = new double[input.Length];
            for (int i=0;i<input.Length;i++)
            {
                output[i]= input[i] - escalar;
            }
            return output;
        }


    }
}
