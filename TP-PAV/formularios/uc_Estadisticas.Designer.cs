namespace TP_PAV.formularios
{
    partial class uc_Estadisticas
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_EstadisticaVendedorPedidos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_EstadisticaFranquiciaPedidos = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(73, 154);
            this.grafico.Name = "grafico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(651, 300);
            this.grafico.TabIndex = 68;
            // 
            // btn_EstadisticaVendedorPedidos
            // 
            this.btn_EstadisticaVendedorPedidos.Location = new System.Drawing.Point(73, 78);
            this.btn_EstadisticaVendedorPedidos.Name = "btn_EstadisticaVendedorPedidos";
            this.btn_EstadisticaVendedorPedidos.Size = new System.Drawing.Size(262, 70);
            this.btn_EstadisticaVendedorPedidos.TabIndex = 67;
            this.btn_EstadisticaVendedorPedidos.Text = "Vendedores con mas pedidos entregados";
            this.btn_EstadisticaVendedorPedidos.UseVisualStyleBackColor = true;
            this.btn_EstadisticaVendedorPedidos.Click += new System.EventHandler(this.btn_EstadisticaVendedorPedidos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Reportes y Estadísticas";
            // 
            // btn_EstadisticaFranquiciaPedidos
            // 
            this.btn_EstadisticaFranquiciaPedidos.Location = new System.Drawing.Point(392, 78);
            this.btn_EstadisticaFranquiciaPedidos.Name = "btn_EstadisticaFranquiciaPedidos";
            this.btn_EstadisticaFranquiciaPedidos.Size = new System.Drawing.Size(262, 70);
            this.btn_EstadisticaFranquiciaPedidos.TabIndex = 69;
            this.btn_EstadisticaFranquiciaPedidos.Text = "Franquicias con mas pedidos entregados";
            this.btn_EstadisticaFranquiciaPedidos.UseVisualStyleBackColor = true;
            this.btn_EstadisticaFranquiciaPedidos.Click += new System.EventHandler(this.btn_EstadisticaFranquiciaPedidos_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(112, 486);
            this.lbl_mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(0, 25);
            this.lbl_mensaje.TabIndex = 70;
            // 
            // uc_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.btn_EstadisticaFranquiciaPedidos);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btn_EstadisticaVendedorPedidos);
            this.Controls.Add(this.label5);
            this.Name = "uc_Estadisticas";
            this.Size = new System.Drawing.Size(1243, 584);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btn_EstadisticaVendedorPedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_EstadisticaFranquiciaPedidos;
        private System.Windows.Forms.Label lbl_mensaje;
    }
}
