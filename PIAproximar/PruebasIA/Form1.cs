using System;
using System.Windows.Forms;

namespace PruebasIA
{
    public partial class AproximarPI : Form
    {
        private double aproximacion;
        private int indice;
        private bool EstadoBoton;
        public AproximarPI()
        {
            indice = 0;
            EstadoBoton = false;
            InitializeComponent();
        }

        private void IniciarDetener_Click(object sender, EventArgs e)
        {
            
            if (EstadoBoton == false)
            {
                Iterador.Start();
                EstadoBoton = true;
                IniciarDetener.Text="DETENER";
            } 
            else
            {
                Iterador.Stop();
                EstadoBoton = false;
                IniciarDetener.Text = "INICIAR";
            }
        }
        private void Iterador_Tick(object sender, EventArgs e)
        {
                aproximacion = (4 * Math.Pow(-1, indice)) / (2 * indice + 1) + aproximacion;
                lblAproximacion.Text = aproximacion.ToString();
                double ErrorAbs = (Math.PI - aproximacion) / Math.PI; ;
                lblErrorAbs.Text = ErrorAbs.ToString() ;
                indice++;
                lblIteraciones.Text = indice.ToString();
                GraficaError.Series["ErrorAproximación"].Points.AddXY(indice, ErrorAbs);
        }
    }
}
