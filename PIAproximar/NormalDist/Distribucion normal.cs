using System;
using System.Windows.Forms;
using MathG;

namespace NormalDist
{

    public partial class Form1 : Form
    {
        Statistics estadistico = new Statistics();
        public Form1()
        {
            InitializeComponent();
        }

        private void Graficar_Click(object sender, EventArgs e)
        {
            GraficaNorm.Series["Distribucion normal"].Points.Clear();
            double a = double.Parse(txtInicio.Text);
            double b = double.Parse(txtFin.Text);
            double incremento = double.Parse(txtIncremento.Text);
            double media = double.Parse(txtMedia.Text);
            double desviacionEstandar = double.Parse(txtDesviacion.Text);

            int tamaño = (int)(((b-a) / incremento) + 1);
            double[] vector = new double[tamaño];
            double[] vectorimagen = new double[tamaño];
            vector = estadistico.LinspaceX(a, b, incremento);
            vectorimagen = estadistico.Normpdf(vector, media, desviacionEstandar);

            for (int i = 0; i < tamaño; i++)
            {
                GraficaNorm.Series["Distribucion normal"].Points.AddXY(vector[i], vectorimagen[i]);
            }
        }
    }

}
