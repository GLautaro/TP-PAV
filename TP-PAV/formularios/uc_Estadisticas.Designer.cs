﻿namespace TP_PAV.formularios
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
            this.btn_franquiciaMasPedidosHistorico = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.grp_estadisticas = new System.Windows.Forms.GroupBox();
            this.btn_franquiciaMenosPedidosEnPeriodo = new System.Windows.Forms.Button();
            this.btn_franquiciaMasPedidosEnPeriodo = new System.Windows.Forms.Button();
            this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btn_franquiciaMenosPedidosHistorico = new System.Windows.Forms.Button();
            this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaHasta = new System.Windows.Forms.Label();
            this.lbl_fechaDesde = new System.Windows.Forms.Label();
            this.btn_cerrarGrupo = new System.Windows.Forms.Button();
            this.btn_productoMasVendido = new System.Windows.Forms.Button();
            this.btn_EstadisticaCantPedidosPend = new System.Windows.Forms.Button();
            this.btn_productoMasVendidoPeriodo = new System.Windows.Forms.Button();
            this.btn_estVendedores = new System.Windows.Forms.Button();
            this.btn_estFranquicias = new System.Windows.Forms.Button();
            this.btn_estProductos = new System.Windows.Forms.Button();
            this.btn_estPedidos = new System.Windows.Forms.Button();
            this.btn_EstadisticaCantPedidosEnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.grp_estadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(97, 225);
            this.grafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafico.Name = "grafico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(868, 369);
            this.grafico.TabIndex = 68;
            // 
            // btn_EstadisticaVendedorPedidos
            // 
            this.btn_EstadisticaVendedorPedidos.Location = new System.Drawing.Point(75, 44);
            this.btn_EstadisticaVendedorPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EstadisticaVendedorPedidos.Name = "btn_EstadisticaVendedorPedidos";
            this.btn_EstadisticaVendedorPedidos.Size = new System.Drawing.Size(349, 86);
            this.btn_EstadisticaVendedorPedidos.TabIndex = 67;
            this.btn_EstadisticaVendedorPedidos.Text = "Vendedores con mas pedidos entregados";
            this.btn_EstadisticaVendedorPedidos.UseVisualStyleBackColor = true;
            this.btn_EstadisticaVendedorPedidos.Visible = false;
            this.btn_EstadisticaVendedorPedidos.Click += new System.EventHandler(this.btn_EstadisticaVendedorPedidos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 32);
            this.label5.TabIndex = 66;
            this.label5.Text = "Reportes y Estadísticas";
            // 
            // btn_franquiciaMasPedidosHistorico
            // 
            this.btn_franquiciaMasPedidosHistorico.Location = new System.Drawing.Point(75, 138);
            this.btn_franquiciaMasPedidosHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_franquiciaMasPedidosHistorico.Name = "btn_franquiciaMasPedidosHistorico";
            this.btn_franquiciaMasPedidosHistorico.Size = new System.Drawing.Size(349, 86);
            this.btn_franquiciaMasPedidosHistorico.TabIndex = 69;
            this.btn_franquiciaMasPedidosHistorico.Text = "Franquicias con mas pedidos entregados";
            this.btn_franquiciaMasPedidosHistorico.UseVisualStyleBackColor = true;
            this.btn_franquiciaMasPedidosHistorico.Visible = false;
            this.btn_franquiciaMasPedidosHistorico.Click += new System.EventHandler(this.btn_franquiciaMasPedidosHistorico_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(149, 598);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(0, 32);
            this.lbl_mensaje.TabIndex = 70;
            // 
            // grp_estadisticas
            // 
            this.grp_estadisticas.Controls.Add(this.btn_EstadisticaCantPedidosEnt);
            this.grp_estadisticas.Controls.Add(this.btn_franquiciaMenosPedidosEnPeriodo);
            this.grp_estadisticas.Controls.Add(this.btn_franquiciaMasPedidosEnPeriodo);
            this.grp_estadisticas.Controls.Add(this.btn_EstadisticaCantPedidosPend);
            this.grp_estadisticas.Controls.Add(this.dtp_fechaHasta);
            this.grp_estadisticas.Controls.Add(this.btn_franquiciaMenosPedidosHistorico);
            this.grp_estadisticas.Controls.Add(this.dtp_fechaDesde);
            this.grp_estadisticas.Controls.Add(this.lbl_fechaHasta);
            this.grp_estadisticas.Controls.Add(this.lbl_fechaDesde);
            this.grp_estadisticas.Controls.Add(this.btn_cerrarGrupo);
            this.grp_estadisticas.Controls.Add(this.btn_franquiciaMasPedidosHistorico);
            this.grp_estadisticas.Controls.Add(this.btn_EstadisticaVendedorPedidos);
            this.grp_estadisticas.Controls.Add(this.btn_productoMasVendido);
            this.grp_estadisticas.Location = new System.Drawing.Point(1039, 57);
            this.grp_estadisticas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_estadisticas.Name = "grp_estadisticas";
            this.grp_estadisticas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grp_estadisticas.Size = new System.Drawing.Size(493, 638);
            this.grp_estadisticas.TabIndex = 71;
            this.grp_estadisticas.TabStop = false;
            this.grp_estadisticas.Visible = false;
            // 
            // btn_franquiciaMenosPedidosEnPeriodo
            // 
            this.btn_franquiciaMenosPedidosEnPeriodo.Location = new System.Drawing.Point(75, 231);
            this.btn_franquiciaMenosPedidosEnPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_franquiciaMenosPedidosEnPeriodo.Name = "btn_franquiciaMenosPedidosEnPeriodo";
            this.btn_franquiciaMenosPedidosEnPeriodo.Size = new System.Drawing.Size(349, 86);
            this.btn_franquiciaMenosPedidosEnPeriodo.TabIndex = 82;
            this.btn_franquiciaMenosPedidosEnPeriodo.Text = "Franquicias con menos pedidos entregados en un periodo";
            this.btn_franquiciaMenosPedidosEnPeriodo.UseVisualStyleBackColor = true;
            this.btn_franquiciaMenosPedidosEnPeriodo.Visible = false;
            this.btn_franquiciaMenosPedidosEnPeriodo.Click += new System.EventHandler(this.btn_franquiciaMenosPedidosEnPeriodo_Click);
            // 
            // btn_franquiciaMasPedidosEnPeriodo
            // 
            this.btn_franquiciaMasPedidosEnPeriodo.Location = new System.Drawing.Point(75, 325);
            this.btn_franquiciaMasPedidosEnPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_franquiciaMasPedidosEnPeriodo.Name = "btn_franquiciaMasPedidosEnPeriodo";
            this.btn_franquiciaMasPedidosEnPeriodo.Size = new System.Drawing.Size(349, 86);
            this.btn_franquiciaMasPedidosEnPeriodo.TabIndex = 80;
            this.btn_franquiciaMasPedidosEnPeriodo.Text = "Franquicias con mas pedidos entregados en un periodo";
            this.btn_franquiciaMasPedidosEnPeriodo.UseVisualStyleBackColor = true;
            this.btn_franquiciaMasPedidosEnPeriodo.Visible = false;
            this.btn_franquiciaMasPedidosEnPeriodo.Click += new System.EventHandler(this.btn_franquiciaMasPedidosEnPeriodo_Click);
            // 
            // dtp_fechaHasta
            // 
            this.dtp_fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechaHasta.Location = new System.Drawing.Point(232, 516);
            this.dtp_fechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_fechaHasta.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaHasta.Name = "dtp_fechaHasta";
            this.dtp_fechaHasta.Size = new System.Drawing.Size(133, 22);
            this.dtp_fechaHasta.TabIndex = 79;
            this.dtp_fechaHasta.Visible = false;
            // 
            // btn_franquiciaMenosPedidosHistorico
            // 
            this.btn_franquiciaMenosPedidosHistorico.Location = new System.Drawing.Point(75, 44);
            this.btn_franquiciaMenosPedidosHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_franquiciaMenosPedidosHistorico.Name = "btn_franquiciaMenosPedidosHistorico";
            this.btn_franquiciaMenosPedidosHistorico.Size = new System.Drawing.Size(349, 86);
            this.btn_franquiciaMenosPedidosHistorico.TabIndex = 81;
            this.btn_franquiciaMenosPedidosHistorico.Text = "Franquicias con menos pedidos entregados";
            this.btn_franquiciaMenosPedidosHistorico.UseVisualStyleBackColor = true;
            this.btn_franquiciaMenosPedidosHistorico.Visible = false;
            this.btn_franquiciaMenosPedidosHistorico.Click += new System.EventHandler(this.btn_franquiciaMenosPedidosHistorico_Click);
            // 
            // dtp_fechaDesde
            // 
            this.dtp_fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechaDesde.Location = new System.Drawing.Point(232, 464);
            this.dtp_fechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_fechaDesde.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaDesde.Name = "dtp_fechaDesde";
            this.dtp_fechaDesde.Size = new System.Drawing.Size(133, 22);
            this.dtp_fechaDesde.TabIndex = 78;
            this.dtp_fechaDesde.Visible = false;
            // 
            // lbl_fechaHasta
            // 
            this.lbl_fechaHasta.AutoSize = true;
            this.lbl_fechaHasta.Location = new System.Drawing.Point(120, 519);
            this.lbl_fechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaHasta.Name = "lbl_fechaHasta";
            this.lbl_fechaHasta.Size = new System.Drawing.Size(90, 17);
            this.lbl_fechaHasta.TabIndex = 75;
            this.lbl_fechaHasta.Text = "Fecha hasta:";
            this.lbl_fechaHasta.Visible = false;
            // 
            // lbl_fechaDesde
            // 
            this.lbl_fechaDesde.AutoSize = true;
            this.lbl_fechaDesde.Location = new System.Drawing.Point(117, 468);
            this.lbl_fechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaDesde.Name = "lbl_fechaDesde";
            this.lbl_fechaDesde.Size = new System.Drawing.Size(94, 17);
            this.lbl_fechaDesde.TabIndex = 74;
            this.lbl_fechaDesde.Text = "Fecha desde:";
            this.lbl_fechaDesde.Visible = false;
            // 
            // btn_cerrarGrupo
            // 
            this.btn_cerrarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarGrupo.Location = new System.Drawing.Point(356, 570);
            this.btn_cerrarGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrarGrupo.Name = "btn_cerrarGrupo";
            this.btn_cerrarGrupo.Size = new System.Drawing.Size(116, 48);
            this.btn_cerrarGrupo.TabIndex = 70;
            this.btn_cerrarGrupo.Text = "Cerrar";
            this.btn_cerrarGrupo.UseVisualStyleBackColor = true;
            this.btn_cerrarGrupo.Click += new System.EventHandler(this.btn_cerrarGrupo_Click);
            // 
            // btn_productoMasVendido
            // 
            this.btn_productoMasVendido.Location = new System.Drawing.Point(75, 44);
            this.btn_productoMasVendido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_productoMasVendido.Name = "btn_productoMasVendido";
            this.btn_productoMasVendido.Size = new System.Drawing.Size(349, 86);
            this.btn_productoMasVendido.TabIndex = 77;
            this.btn_productoMasVendido.Text = "Productos mas vendidos";
            this.btn_productoMasVendido.UseVisualStyleBackColor = true;
            this.btn_productoMasVendido.Visible = false;
            this.btn_productoMasVendido.Click += new System.EventHandler(this.btn_productoMasVendido_Click);
            // 
            // btn_EstadisticaCantPedidosPend
            // 
            this.btn_EstadisticaCantPedidosPend.Location = new System.Drawing.Point(75, 44);
            this.btn_EstadisticaCantPedidosPend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EstadisticaCantPedidosPend.Name = "btn_EstadisticaCantPedidosPend";
            this.btn_EstadisticaCantPedidosPend.Size = new System.Drawing.Size(349, 86);
            this.btn_EstadisticaCantPedidosPend.TabIndex = 80;
            this.btn_EstadisticaCantPedidosPend.Text = "Cantidad de Pedidos Solicitados en un periodo";
            this.btn_EstadisticaCantPedidosPend.UseVisualStyleBackColor = true;
            this.btn_EstadisticaCantPedidosPend.Visible = false;
            this.btn_EstadisticaCantPedidosPend.Click += new System.EventHandler(this.btn_EstadisticaCantPedidosPend_Click);
            // 
            // btn_productoMasVendidoPeriodo
            // 
            this.btn_productoMasVendidoPeriodo.Location = new System.Drawing.Point(748, 193);
            this.btn_productoMasVendidoPeriodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_productoMasVendidoPeriodo.Name = "btn_productoMasVendidoPeriodo";
            this.btn_productoMasVendidoPeriodo.Size = new System.Drawing.Size(349, 86);
            this.btn_productoMasVendidoPeriodo.TabIndex = 76;
            this.btn_productoMasVendidoPeriodo.Text = "Productos mas vendidos en un periodo";
            this.btn_productoMasVendidoPeriodo.UseVisualStyleBackColor = true;
            this.btn_productoMasVendidoPeriodo.Visible = false;
            this.btn_productoMasVendidoPeriodo.Click += new System.EventHandler(this.btn_productoMasVendidoPeriodo_Click);
            // 
            // btn_estVendedores
            // 
            this.btn_estVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estVendedores.Location = new System.Drawing.Point(81, 116);
            this.btn_estVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_estVendedores.Name = "btn_estVendedores";
            this.btn_estVendedores.Size = new System.Drawing.Size(177, 57);
            this.btn_estVendedores.TabIndex = 72;
            this.btn_estVendedores.Text = "Estadisticas de Vendedores";
            this.btn_estVendedores.UseVisualStyleBackColor = true;
            this.btn_estVendedores.Click += new System.EventHandler(this.btn_estVendedores_Click);
            // 
            // btn_estFranquicias
            // 
            this.btn_estFranquicias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estFranquicias.Location = new System.Drawing.Point(323, 116);
            this.btn_estFranquicias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_estFranquicias.Name = "btn_estFranquicias";
            this.btn_estFranquicias.Size = new System.Drawing.Size(177, 57);
            this.btn_estFranquicias.TabIndex = 73;
            this.btn_estFranquicias.Text = "Estadisticas de Franquicias";
            this.btn_estFranquicias.UseVisualStyleBackColor = true;
            this.btn_estFranquicias.Click += new System.EventHandler(this.btn_estFranquicias_Click);
            // 
            // btn_estProductos
            // 
            this.btn_estProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estProductos.Location = new System.Drawing.Point(564, 116);
            this.btn_estProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_estProductos.Name = "btn_estProductos";
            this.btn_estProductos.Size = new System.Drawing.Size(177, 57);
            this.btn_estProductos.TabIndex = 74;
            this.btn_estProductos.Text = "Estadisticas de Productos";
            this.btn_estProductos.UseVisualStyleBackColor = true;
            this.btn_estProductos.Click += new System.EventHandler(this.btn_estProductos_Click);
            // 
            // btn_estPedidos
            // 
            this.btn_estPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estPedidos.Location = new System.Drawing.Point(805, 116);
            this.btn_estPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_estPedidos.Name = "btn_estPedidos";
            this.btn_estPedidos.Size = new System.Drawing.Size(177, 57);
            this.btn_estPedidos.TabIndex = 75;
            this.btn_estPedidos.Text = "Estadisticas de Pedidos";
            this.btn_estPedidos.UseVisualStyleBackColor = true;
            this.btn_estPedidos.Click += new System.EventHandler(this.btn_estPedidos_Click);
            // 
            // btn_EstadisticaCantPedidosEnt
            // 
            this.btn_EstadisticaCantPedidosEnt.Location = new System.Drawing.Point(75, 138);
            this.btn_EstadisticaCantPedidosEnt.Name = "btn_EstadisticaCantPedidosEnt";
            this.btn_EstadisticaCantPedidosEnt.Size = new System.Drawing.Size(349, 86);
            this.btn_EstadisticaCantPedidosEnt.TabIndex = 83;
            this.btn_EstadisticaCantPedidosEnt.Text = "Cantidad de Pedidos Entregados en un periodo";
            this.btn_EstadisticaCantPedidosEnt.UseVisualStyleBackColor = true;
            this.btn_EstadisticaCantPedidosEnt.Visible = false;
            this.btn_EstadisticaCantPedidosEnt.Click += new System.EventHandler(this.btn_EstadisticaCantPedidosEnt_Click);
            // 
            // uc_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_estPedidos);
            this.Controls.Add(this.btn_productoMasVendidoPeriodo);
            this.Controls.Add(this.btn_estProductos);
            this.Controls.Add(this.btn_estFranquicias);
            this.Controls.Add(this.btn_estVendedores);
            this.Controls.Add(this.grp_estadisticas);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uc_Estadisticas";
            this.Size = new System.Drawing.Size(1657, 719);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.grp_estadisticas.ResumeLayout(false);
            this.grp_estadisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btn_EstadisticaVendedorPedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_franquiciaMasPedidosHistorico;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.GroupBox grp_estadisticas;
        private System.Windows.Forms.Button btn_estVendedores;
        private System.Windows.Forms.Button btn_estFranquicias;
        private System.Windows.Forms.Button btn_estProductos;
        private System.Windows.Forms.Button btn_estPedidos;
        private System.Windows.Forms.Button btn_cerrarGrupo;
        private System.Windows.Forms.Label lbl_fechaHasta;
        private System.Windows.Forms.Label lbl_fechaDesde;
        private System.Windows.Forms.Button btn_productoMasVendidoPeriodo;
        private System.Windows.Forms.Button btn_productoMasVendido;
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Button btn_EstadisticaCantPedidosPend;
        private System.Windows.Forms.Button btn_franquiciaMasPedidosEnPeriodo;
        private System.Windows.Forms.Button btn_franquiciaMenosPedidosHistorico;
        private System.Windows.Forms.Button btn_franquiciaMenosPedidosEnPeriodo;
        private System.Windows.Forms.Button btn_EstadisticaCantPedidosEnt;
    }
}
