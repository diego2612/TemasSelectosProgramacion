using System;


namespace BarridoFuerza
{
    class Program
    {
        const float q1 = (float)6E-06;
        const float q2 = (float)6E-06;
        const float q3 = (float)3E-06;
        const float d= (float)0.4;
        const long K = 9000000000;
        static void Main()
        {
            /* Console.Write("Para las cargas se tiene una distancia:,ingresa un espacio");
             Console.ReadLine();*/
            for (double i = 0.001; i < d; i += 0.001)
            {
                double Fuerza13 = Fuerza(q1, q2, i);
                double Fuerza23 = Fuerza(q2,q3,d-i);
                Console.WriteLine("Fuerza3 debido a 1 = {0} [N],  Fuerza 3 debido a 2 {1}    En una distancia de {2}",Fuerza13,Fuerza23, i);
            }

            double f = Fuerza(q1, q2, d);
                Console.WriteLine(f);
            Console.ReadLine();
        }

        public static double Fuerza(double q1, double q2, double d)
        {
            double output = (K * q1 * q2) / (d * d);
            return output;
        }
    }
}
