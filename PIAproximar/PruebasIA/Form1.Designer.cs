namespace PruebasIA
{
    partial class AproximarPI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.IniciarDetener = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAproximacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Iterador = new System.Windows.Forms.Timer(this.components);
            this.lblErrorAbs = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.GraficaError = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaError)).BeginInit();
            this.SuspendLayout();
            // 
            // IniciarDetener
            // 
            this.IniciarDetener.AutoSize = true;
            this.IniciarDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarDetener.Location = new System.Drawing.Point(112, 274);
            this.IniciarDetener.Name = "IniciarDetener";
            this.IniciarDetener.Size = new System.Drawing.Size(148, 49);
            this.IniciarDetener.TabIndex = 0;
            this.IniciarDetener.Text = "INICIAR";
            this.IniciarDetener.UseVisualStyleBackColor = true;
            this.IniciarDetener.Click += new System.EventHandler(this.IniciarDetener_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iteraciones de aproximar a PI:";
            // 
            // lblAproximacion
            // 
            this.lblAproximacion.AutoSize = true;
            this.lblAproximacion.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblAproximacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAproximacion.Location = new System.Drawing.Point(468, 33);
            this.lblAproximacion.Name = "lblAproximacion";
            this.lblAproximacion.Size = new System.Drawing.Size(32, 32);
            this.lblAproximacion.TabIndex = 2;
            this.lblAproximacion.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Error de aproximación :";
            // 
            // Iterador
            // 
            this.Iterador.Interval = 500;
            this.Iterador.Tick += new System.EventHandler(this.Iterador_Tick);
            // 
            // lblErrorAbs
            // 
            this.lblErrorAbs.AutoSize = true;
            this.lblErrorAbs.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblErrorAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAbs.Location = new System.Drawing.Point(400, 84);
            this.lblErrorAbs.Name = "lblErrorAbs";
            this.lblErrorAbs.Size = new System.Drawing.Size(32, 32);
            this.lblErrorAbs.TabIndex = 4;
            this.lblErrorAbs.Text = "0";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.Location = new System.Drawing.Point(400, 136);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(32, 32);
            this.lblIteraciones.TabIndex = 6;
            this.lblIteraciones.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(37, 136);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(346, 32);
            this.label.TabIndex = 5;
            this.label.Text = "Numero de iteraciones : ";
            // 
            // GraficaError
            // 
            this.GraficaError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea3.AxisX.Title = "Iteracion";
            chartArea3.AxisY.Title = "Error Aproximación";
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea3.Name = "ChartArea1";
            this.GraficaError.ChartAreas.Add(chartArea3);
            this.GraficaError.Location = new System.Drawing.Point(406, 171);
            this.GraficaError.Name = "GraficaError";
            series3.ChartArea = "ChartArea1";
            series3.Name = "ErrorAproximación";
            this.GraficaError.Series.Add(series3);
            this.GraficaError.Size = new System.Drawing.Size(581, 315);
            this.GraficaError.TabIndex = 7;
            this.GraficaError.Text = "chart1";
            // 
            // AproximarPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(999, 498);
            this.Controls.Add(this.GraficaError);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblErrorAbs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAproximacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IniciarDetener);
            this.Name = "AproximarPI";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.GraficaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IniciarDetener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAproximacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Iterador;
        private System.Windows.Forms.Label lblErrorAbs;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaError;
    }
}

