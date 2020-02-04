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
            Console.WriteLine("Este programa te permite ubicar el punto en que una carga presenta F = 0\t");
            Console.WriteLine("Presiona enter");
            Console.ReadLine();

            for (double i = 0.01; i < d; i += 0.01)
            {
                double Fuerza13 = Fuerza(q1, q3, i);
                double Fuerza23 = Fuerza(q2,q3,d-i);
                double Fresultante = Fuerza13 - Fuerza23;
                //Con esta condicional se sabe que q3 ha sobrepasado el punto en que su fuerza resultante es negativa 
                if (Fresultante < 0)
                {
                    break;
                }
                Console.WriteLine("Fuerza en q3 debido a q1 = {0} [N],  Fuerza en q3 debido a q2 {1} [N]",Fuerza13,Fuerza23);
                
                Console.WriteLine("La fuerza resultantes es: {0} [N]", Fresultante);
                Console.WriteLine(" En una distancia de {0}\n", i);
                
                
            }
            Console.ReadLine();
        }

        public static double Fuerza(double q1, double q2, double d)
        {
            double output = (K * q1 * q2) / (d * d);
            return output;
        }
    }
}
