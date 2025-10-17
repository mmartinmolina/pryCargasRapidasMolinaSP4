namespace pryCargasRapidasMolinaSP4
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblverificacionEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKMporCamion = new System.Windows.Forms.Button();
            this.btnGastosCamion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViaticosCamion = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTituloTipoGrafico = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.btnKMporCamion.Location = new System.Drawing.Point(53, 116);
            this.btnKMporCamion.Name = "btnKMporCamion";
            this.btnKMporCamion.Size = new System.Drawing.Size(113, 55);
            this.btnKMporCamion.TabIndex = 1;
            this.btnKMporCamion.Text = "Kilometro por Camion";
            this.btnKMporCamion.UseVisualStyleBackColor = true;
            // 
            // btnGastosCamion
            // 
            this.btnGastosCamion.Location = new System.Drawing.Point(53, 173);
            this.btnGastosCamion.Name = "btnGastosCamion";
            this.btnGastosCamion.Size = new System.Drawing.Size(113, 55);
            this.btnGastosCamion.TabIndex = 2;
            this.btnGastosCamion.Text = "Gastos por Camión";
            this.btnGastosCamion.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnViaticosCamion
            // 
            this.btnViaticosCamion.Location = new System.Drawing.Point(53, 287);
            this.btnViaticosCamion.Name = "btnViaticosCamion";
            this.btnViaticosCamion.Size = new System.Drawing.Size(113, 55);
            this.btnViaticosCamion.TabIndex = 4;
            this.btnViaticosCamion.Text = "Gastos/Viaticos por camion";
            this.btnViaticosCamion.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(181, 69);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(395, 309);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblTituloTipoGrafico
            // 
            this.lblTituloTipoGrafico.AutoSize = true;
            this.lblTituloTipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTipoGrafico.Location = new System.Drawing.Point(50, 45);
            this.lblTituloTipoGrafico.Name = "lblTituloTipoGrafico";
            this.lblTituloTipoGrafico.Size = new System.Drawing.Size(125, 18);
            this.lblTituloTipoGrafico.TabIndex = 7;
            this.lblTituloTipoGrafico.Text = "Tipo de Grafico";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 446);
            this.Controls.Add(this.lblTituloTipoGrafico);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnViaticosCamion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGastosCamion);
            this.Controls.Add(this.btnKMporCamion);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblverificacionEstado;
        private System.Windows.Forms.Button btnKMporCamion;
        private System.Windows.Forms.Button btnGastosCamion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnViaticosCamion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTituloTipoGrafico;
    }
}

