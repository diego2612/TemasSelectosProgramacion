using System;
using System.Windows.Forms;
using MathG;

namespace Promedio
{
    public partial class Form1 : Form
    {
        private double [] arreglo;
        private Statistics estadistico;
        double varianza;
        double promedio;
        double desviacionEstandar;
        public Form1()
        {
            estadistico = new Statistics();
            InitializeComponent();
            arreglo = new double[41]{2,9,  1,  13 ,8, 6 , 9 , 15 ,5 , 5 , 13, 1, 15, 7 , 0 , 6,5,  13 ,9,  2 ,10 ,6 ,4 , 7, 1, 15 ,2 , 12, 15, 6, 2, 0, 13, 5, 6, 9, 3, 3, 5, 11, 12};
            
            //Como Media Aritmetica es un metodo estatico debe indicarse la clase
            promedio = Statistics.MediaAritmetica(arreglo);
            lblPromedio.Text = promedio.ToString();

            //Varianza no es metodo estatico entonces debe instanciarse un objeto de ella
            varianza = estadistico.VarianzaS(arreglo);
            lblVarianza.Text = varianza.ToString();

            //Mismo principio que para varianza, se usa el objeto de la clase Statistics
            desviacionEstandar = estadistico.DesviacionEstandarS(arreglo);
            lblDesviacionEstandar.Text = desviacionEstandar.ToString();
             
            for (int i=0;i<arreglo.Length;i++)
            {
                GraficarEstadistica.Series["GraficaEstadistica"].Points.AddXY(i,arreglo[i]);
                GraficarEstadistica.Series["Promedio"].Points.AddXY(i, promedio);
                GraficarEstadistica.Series["Varianza"].Points.AddXY(i, varianza);
                GraficarEstadistica.Series["Desviación estandar"].Points.AddXY(i, desviacionEstandar);
            } 
        }
    }
}
