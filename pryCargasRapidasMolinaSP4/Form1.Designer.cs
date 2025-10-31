namespace pryCargasRapidasMolinaSP4
{
    partial class EstadisticaConsumoLogistico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadisticaConsumoLogistico));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblverificacionEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKMporCamion = new System.Windows.Forms.Button();
            this.btnGastosCamion = new System.Windows.Forms.Button();
            this.btnKilog = new System.Windows.Forms.Button();
            this.btnViaticosCamion = new System.Windows.Forms.Button();
            this.chtCamiones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblverificacionEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(659, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblverificacionEstado
            // 
            this.lblverificacionEstado.Name = "lblverificacionEstado";
            this.lblverificacionEstado.Size = new System.Drawing.Size(106, 17);
            this.lblverificacionEstado.Text = "lblEstadoConexion";
            this.lblverificacionEstado.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // btnKMporCamion
            // 
            this.btnKMporCamion.Location = new System.Drawing.Point(29, 61);
            this.btnKMporCamion.Name = "btnKMporCamion";
            this.btnKMporCamion.Size = new System.Drawing.Size(113, 60);
            this.btnKMporCamion.TabIndex = 1;
            this.btnKMporCamion.Text = "Kilometro por Camion";
            this.btnKMporCamion.UseVisualStyleBackColor = true;
            this.btnKMporCamion.Click += new System.EventHandler(this.btnKMporCamion_Click);
            // 
            // btnGastosCamion
            // 
            this.btnGastosCamion.Location = new System.Drawing.Point(29, 127);
            this.btnGastosCamion.Name = "btnGastosCamion";
            this.btnGastosCamion.Size = new System.Drawing.Size(113, 60);
            this.btnGastosCamion.TabIndex = 2;
            this.btnGastosCamion.Text = "Gastos por Camión";
            this.btnGastosCamion.UseVisualStyleBackColor = true;
            this.btnGastosCamion.Click += new System.EventHandler(this.btnGastosCamion_Click);
            // 
            // btnKilog
            // 
            this.btnKilog.Location = new System.Drawing.Point(29, 193);
            this.btnKilog.Name = "btnKilog";
            this.btnKilog.Size = new System.Drawing.Size(113, 60);
            this.btnKilog.TabIndex = 3;
            this.btnKilog.Text = "Kilogramos por camión";
            this.btnKilog.UseVisualStyleBackColor = true;
            this.btnKilog.Click += new System.EventHandler(this.btnKilog_Click);
            // 
            // btnViaticosCamion
            // 
            this.btnViaticosCamion.Location = new System.Drawing.Point(29, 259);
            this.btnViaticosCamion.Name = "btnViaticosCamion";
            this.btnViaticosCamion.Size = new System.Drawing.Size(113, 60);
            this.btnViaticosCamion.TabIndex = 4;
            this.btnViaticosCamion.Text = "Gastos/Viaticos por camion";
            this.btnViaticosCamion.UseVisualStyleBackColor = true;
            // 
            // chtCamiones
            // 
            chartArea1.AxisX.ScaleView.Size = 5D;
            chartArea1.Name = "ChartArea1";
            this.chtCamiones.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCamiones.Legends.Add(legend1);
            this.chtCamiones.Location = new System.Drawing.Point(186, 45);
            this.chtCamiones.Name = "chtCamiones";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtCamiones.Series.Add(series1);
            this.chtCamiones.Size = new System.Drawing.Size(461, 310);
            this.chtCamiones.TabIndex = 5;
            this.chtCamiones.Text = "chtCaminones";
            // 
            // EstadisticaConsumoLogistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(659, 446);
            this.Controls.Add(this.chtCamiones);
            this.Controls.Add(this.btnViaticosCamion);
            this.Controls.Add(this.btnKilog);
            this.Controls.Add(this.btnGastosCamion);
            this.Controls.Add(this.btnKMporCamion);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EstadisticaConsumoLogistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadistica de consumo por camion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblverificacionEstado;
        private System.Windows.Forms.Button btnKMporCamion;
        private System.Windows.Forms.Button btnGastosCamion;
        private System.Windows.Forms.Button btnKilog;
        private System.Windows.Forms.Button btnViaticosCamion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCamiones;
    }
}

