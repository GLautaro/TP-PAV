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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_EstadisticaVendedorPedidos = new System.Windows.Forms.Button();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.grp_estadisticas = new System.Windows.Forms.GroupBox();
            this.btn_EstadisticaCantPedidosEnt = new System.Windows.Forms.Button();
            this.btn_productosMenosVendidos = new System.Windows.Forms.Button();
            this.btn_vendedoresConMenosPedidos = new System.Windows.Forms.Button();
            this.btn_cantFranquiciasXVendedor = new System.Windows.Forms.Button();
            this.cmb_franquicias = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.lbl_franquicia_producto = new System.Windows.Forms.Label();
            this.btn_productoPorFranquicia = new System.Windows.Forms.Button();
            this.btn_franquiciaMenosPedidosEnPeriodo = new System.Windows.Forms.Button();
            this.btn_franquiciaMasPedidosEnPeriodo = new System.Windows.Forms.Button();
            this.btn_productoMasVendidoPeriodo = new System.Windows.Forms.Button();
            this.btn_cerrarGrupo = new System.Windows.Forms.Button();
            this.dtp_fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btn_EstadisticaCantPedidosPend = new System.Windows.Forms.Button();
            this.lbl_fechaHasta = new System.Windows.Forms.Label();
            this.lbl_fechaDesde = new System.Windows.Forms.Label();
            this.btn_estVendedores = new System.Windows.Forms.Button();
            this.btn_estFranquicias = new System.Windows.Forms.Button();
            this.btn_estProductos = new System.Windows.Forms.Button();
            this.btn_estPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.grp_estadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafico
            // 
            this.grafico.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(73, 183);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(651, 300);
            this.grafico.TabIndex = 68;
            // 
            // btn_EstadisticaVendedorPedidos
            // 
            this.btn_EstadisticaVendedorPedidos.Location = new System.Drawing.Point(65, 190);
            this.btn_EstadisticaVendedorPedidos.Name = "btn_EstadisticaVendedorPedidos";
            this.btn_EstadisticaVendedorPedidos.Size = new System.Drawing.Size(262, 70);
            this.btn_EstadisticaVendedorPedidos.TabIndex = 67;
            this.btn_EstadisticaVendedorPedidos.Text = "Vendedores con mas pedidos entregados";
            this.btn_EstadisticaVendedorPedidos.UseVisualStyleBackColor = true;
            this.btn_EstadisticaVendedorPedidos.Visible = false;
            this.btn_EstadisticaVendedorPedidos.Click += new System.EventHandler(this.btn_EstadisticaVendedorPedidos_Click);
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(79, 501);
            this.lbl_mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(0, 18);
            this.lbl_mensaje.TabIndex = 70;
            // 
            // grp_estadisticas
            // 
            this.grp_estadisticas.Controls.Add(this.btn_EstadisticaCantPedidosEnt);
            this.grp_estadisticas.Controls.Add(this.btn_productosMenosVendidos);
            this.grp_estadisticas.Controls.Add(this.btn_vendedoresConMenosPedidos);
            this.grp_estadisticas.Controls.Add(this.btn_cantFranquiciasXVendedor);
            this.grp_estadisticas.Controls.Add(this.cmb_franquicias);
            this.grp_estadisticas.Controls.Add(this.lbl_franquicia_producto);
            this.grp_estadisticas.Controls.Add(this.btn_productoPorFranquicia);
            this.grp_estadisticas.Controls.Add(this.btn_franquiciaMenosPedidosEnPeriodo);
            this.grp_estadisticas.Controls.Add(this.btn_franquiciaMasPedidosEnPeriodo);
            this.grp_estadisticas.Controls.Add(this.btn_productoMasVendidoPeriodo);
            this.grp_estadisticas.Controls.Add(this.btn_cerrarGrupo);
            this.grp_estadisticas.Controls.Add(this.dtp_fechaHasta);
            this.grp_estadisticas.Controls.Add(this.dtp_fechaDesde);
            this.grp_estadisticas.Controls.Add(this.btn_EstadisticaCantPedidosPend);
            this.grp_estadisticas.Controls.Add(this.lbl_fechaHasta);
            this.grp_estadisticas.Controls.Add(this.lbl_fechaDesde);
            this.grp_estadisticas.Controls.Add(this.btn_EstadisticaVendedorPedidos);
            this.grp_estadisticas.Location = new System.Drawing.Point(767, 46);
            this.grp_estadisticas.Name = "grp_estadisticas";
            this.grp_estadisticas.Size = new System.Drawing.Size(368, 483);
            this.grp_estadisticas.TabIndex = 71;
            this.grp_estadisticas.TabStop = false;
            this.grp_estadisticas.Visible = false;
            // 
            // btn_EstadisticaCantPedidosEnt
            // 
            this.btn_EstadisticaCantPedidosEnt.Location = new System.Drawing.Point(65, 267);
            this.btn_EstadisticaCantPedidosEnt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EstadisticaCantPedidosEnt.Name = "btn_EstadisticaCantPedidosEnt";
            this.btn_EstadisticaCantPedidosEnt.Size = new System.Drawing.Size(262, 70);
            this.btn_EstadisticaCantPedidosEnt.TabIndex = 83;
            this.btn_EstadisticaCantPedidosEnt.Text = "Cantidad de Pedidos Entregados en un periodo";
            this.btn_EstadisticaCantPedidosEnt.UseVisualStyleBackColor = true;
            this.btn_EstadisticaCantPedidosEnt.Visible = false;
            this.btn_EstadisticaCantPedidosEnt.Click += new System.EventHandler(this.btn_EstadisticaCantPedidosEnt_Click);
            // 
            // btn_productosMenosVendidos
            // 
            this.btn_productosMenosVendidos.Location = new System.Drawing.Point(65, 265);
            this.btn_productosMenosVendidos.Name = "btn_productosMenosVendidos";
            this.btn_productosMenosVendidos.Size = new System.Drawing.Size(262, 70);
            this.btn_productosMenosVendidos.TabIndex = 85;
            this.btn_productosMenosVendidos.Text = "Productos menos vendidos en un periodo";
            this.btn_productosMenosVendidos.UseVisualStyleBackColor = true;
            this.btn_productosMenosVendidos.Visible = false;
            this.btn_productosMenosVendidos.Click += new System.EventHandler(this.btn_productosMenosVendidos_Click);
            // 
            // btn_vendedoresConMenosPedidos
            // 
            this.btn_vendedoresConMenosPedidos.Location = new System.Drawing.Point(65, 264);
            this.btn_vendedoresConMenosPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_vendedoresConMenosPedidos.Name = "btn_vendedoresConMenosPedidos";
            this.btn_vendedoresConMenosPedidos.Size = new System.Drawing.Size(262, 70);
            this.btn_vendedoresConMenosPedidos.TabIndex = 84;
            this.btn_vendedoresConMenosPedidos.Text = "Vendedores con menos pedidos entregados";
            this.btn_vendedoresConMenosPedidos.UseVisualStyleBackColor = true;
            this.btn_vendedoresConMenosPedidos.Visible = false;
            this.btn_vendedoresConMenosPedidos.Click += new System.EventHandler(this.btn_vendedoresConMenosPedidos_Click);
            // 
            // btn_cantFranquiciasXVendedor
            // 
            this.btn_cantFranquiciasXVendedor.Location = new System.Drawing.Point(65, 343);
            this.btn_cantFranquiciasXVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cantFranquiciasXVendedor.Name = "btn_cantFranquiciasXVendedor";
            this.btn_cantFranquiciasXVendedor.Size = new System.Drawing.Size(262, 70);
            this.btn_cantFranquiciasXVendedor.TabIndex = 84;
            this.btn_cantFranquiciasXVendedor.Text = "Cantidad de franquicias por vendedor";
            this.btn_cantFranquiciasXVendedor.UseVisualStyleBackColor = true;
            this.btn_cantFranquiciasXVendedor.Visible = false;
            this.btn_cantFranquiciasXVendedor.Click += new System.EventHandler(this.btn_cantFranquiciasXVendedor_Click);
            // 
            // cmb_franquicias
            // 
            this.cmb_franquicias._campo = "id_franquicia";
            this.cmb_franquicias._mensaje_error = "No se seleccionó una franquicia";
            this.cmb_franquicias._nombre_tabla = "franquicia";
            this.cmb_franquicias._validable = false;
            this.cmb_franquicias.FormattingEnabled = true;
            this.cmb_franquicias.Location = new System.Drawing.Point(166, 64);
            this.cmb_franquicias.Name = "cmb_franquicias";
            this.cmb_franquicias.Size = new System.Drawing.Size(135, 21);
            this.cmb_franquicias.TabIndex = 85;
            this.cmb_franquicias.Visible = false;
            this.cmb_franquicias.SelectionChangeCommitted += new System.EventHandler(this.estadistica_productoPorFranquicia);
            // 
            // lbl_franquicia_producto
            // 
            this.lbl_franquicia_producto.AutoSize = true;
            this.lbl_franquicia_producto.Location = new System.Drawing.Point(48, 67);
            this.lbl_franquicia_producto.Name = "lbl_franquicia_producto";
            this.lbl_franquicia_producto.Size = new System.Drawing.Size(112, 13);
            this.lbl_franquicia_producto.TabIndex = 84;
            this.lbl_franquicia_producto.Text = "Seleccione franquicia:";
            this.lbl_franquicia_producto.Visible = false;
            // 
            // btn_productoPorFranquicia
            // 
            this.btn_productoPorFranquicia.Location = new System.Drawing.Point(65, 343);
            this.btn_productoPorFranquicia.Name = "btn_productoPorFranquicia";
            this.btn_productoPorFranquicia.Size = new System.Drawing.Size(262, 70);
            this.btn_productoPorFranquicia.TabIndex = 82;
            this.btn_productoPorFranquicia.Text = "Productos más comprados por una franquicia en un período";
            this.btn_productoPorFranquicia.UseVisualStyleBackColor = true;
            this.btn_productoPorFranquicia.Visible = false;
            this.btn_productoPorFranquicia.Click += new System.EventHandler(this.btn_productoPorFranquicia_Click);
            // 
            // btn_franquiciaMenosPedidosEnPeriodo
            // 
            this.btn_franquiciaMenosPedidosEnPeriodo.Location = new System.Drawing.Point(65, 265);
            this.btn_franquiciaMenosPedidosEnPeriodo.Name = "btn_franquiciaMenosPedidosEnPeriodo";
            this.btn_franquiciaMenosPedidosEnPeriodo.Size = new System.Drawing.Size(262, 70);
            this.btn_franquiciaMenosPedidosEnPeriodo.TabIndex = 82;
            this.btn_franquiciaMenosPedidosEnPeriodo.Text = "Franquicias con menos pedidos entregados en un periodo";
            this.btn_franquiciaMenosPedidosEnPeriodo.UseVisualStyleBackColor = true;
            this.btn_franquiciaMenosPedidosEnPeriodo.Visible = false;
            this.btn_franquiciaMenosPedidosEnPeriodo.Click += new System.EventHandler(this.btn_franquiciaMenosPedidosEnPeriodo_Click);
            // 
            // btn_franquiciaMasPedidosEnPeriodo
            // 
            this.btn_franquiciaMasPedidosEnPeriodo.Location = new System.Drawing.Point(65, 192);
            this.btn_franquiciaMasPedidosEnPeriodo.Name = "btn_franquiciaMasPedidosEnPeriodo";
            this.btn_franquiciaMasPedidosEnPeriodo.Size = new System.Drawing.Size(262, 70);
            this.btn_franquiciaMasPedidosEnPeriodo.TabIndex = 80;
            this.btn_franquiciaMasPedidosEnPeriodo.Text = "Franquicias con más pedidos entregados en un periodo";
            this.btn_franquiciaMasPedidosEnPeriodo.UseVisualStyleBackColor = true;
            this.btn_franquiciaMasPedidosEnPeriodo.Visible = false;
            this.btn_franquiciaMasPedidosEnPeriodo.Click += new System.EventHandler(this.btn_franquiciaMasPedidosEnPeriodo_Click);
            // 
            // btn_productoMasVendidoPeriodo
            // 
            this.btn_productoMasVendidoPeriodo.Location = new System.Drawing.Point(65, 192);
            this.btn_productoMasVendidoPeriodo.Name = "btn_productoMasVendidoPeriodo";
            this.btn_productoMasVendidoPeriodo.Size = new System.Drawing.Size(262, 70);
            this.btn_productoMasVendidoPeriodo.TabIndex = 76;
            this.btn_productoMasVendidoPeriodo.Text = "Productos más vendidos en un periodo";
            this.btn_productoMasVendidoPeriodo.UseVisualStyleBackColor = true;
            this.btn_productoMasVendidoPeriodo.Visible = false;
            this.btn_productoMasVendidoPeriodo.Click += new System.EventHandler(this.btn_productoMasVendidoPeriodo_Click);
            // 
            // btn_cerrarGrupo
            // 
            this.btn_cerrarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarGrupo.Location = new System.Drawing.Point(261, 19);
            this.btn_cerrarGrupo.Name = "btn_cerrarGrupo";
            this.btn_cerrarGrupo.Size = new System.Drawing.Size(87, 39);
            this.btn_cerrarGrupo.TabIndex = 70;
            this.btn_cerrarGrupo.Text = "Cerrar";
            this.btn_cerrarGrupo.UseVisualStyleBackColor = true;
            this.btn_cerrarGrupo.Click += new System.EventHandler(this.btn_cerrarGrupo_Click);
            // 
            // dtp_fechaHasta
            // 
            this.dtp_fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechaHasta.Location = new System.Drawing.Point(175, 145);
            this.dtp_fechaHasta.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaHasta.Name = "dtp_fechaHasta";
            this.dtp_fechaHasta.Size = new System.Drawing.Size(101, 20);
            this.dtp_fechaHasta.TabIndex = 79;
            this.dtp_fechaHasta.Visible = false;
            // 
            // dtp_fechaDesde
            // 
            this.dtp_fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechaDesde.Location = new System.Drawing.Point(175, 103);
            this.dtp_fechaDesde.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtp_fechaDesde.Name = "dtp_fechaDesde";
            this.dtp_fechaDesde.Size = new System.Drawing.Size(101, 20);
            this.dtp_fechaDesde.TabIndex = 78;
            this.dtp_fechaDesde.Visible = false;
            // 
            // btn_EstadisticaCantPedidosPend
            // 
            this.btn_EstadisticaCantPedidosPend.Location = new System.Drawing.Point(65, 190);
            this.btn_EstadisticaCantPedidosPend.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EstadisticaCantPedidosPend.Name = "btn_EstadisticaCantPedidosPend";
            this.btn_EstadisticaCantPedidosPend.Size = new System.Drawing.Size(262, 70);
            this.btn_EstadisticaCantPedidosPend.TabIndex = 80;
            this.btn_EstadisticaCantPedidosPend.Text = "Cantidad de pedidos solicitados dentro de un período";
            this.btn_EstadisticaCantPedidosPend.UseVisualStyleBackColor = true;
            this.btn_EstadisticaCantPedidosPend.Visible = false;
            this.btn_EstadisticaCantPedidosPend.Click += new System.EventHandler(this.btn_EstadisticaCantPedidosPend_Click);
            // 
            // lbl_fechaHasta
            // 
            this.lbl_fechaHasta.AutoSize = true;
            this.lbl_fechaHasta.Location = new System.Drawing.Point(91, 148);
            this.lbl_fechaHasta.Name = "lbl_fechaHasta";
            this.lbl_fechaHasta.Size = new System.Drawing.Size(69, 13);
            this.lbl_fechaHasta.TabIndex = 75;
            this.lbl_fechaHasta.Text = "Fecha hasta:";
            this.lbl_fechaHasta.Visible = false;
            // 
            // lbl_fechaDesde
            // 
            this.lbl_fechaDesde.AutoSize = true;
            this.lbl_fechaDesde.Location = new System.Drawing.Point(89, 106);
            this.lbl_fechaDesde.Name = "lbl_fechaDesde";
            this.lbl_fechaDesde.Size = new System.Drawing.Size(72, 13);
            this.lbl_fechaDesde.TabIndex = 74;
            this.lbl_fechaDesde.Text = "Fecha desde:";
            this.lbl_fechaDesde.Visible = false;
            // 
            // btn_estVendedores
            // 
            this.btn_estVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estVendedores.Location = new System.Drawing.Point(61, 94);
            this.btn_estVendedores.Name = "btn_estVendedores";
            this.btn_estVendedores.Size = new System.Drawing.Size(133, 46);
            this.btn_estVendedores.TabIndex = 72;
            this.btn_estVendedores.Text = "Estadisticas de Vendedores";
            this.btn_estVendedores.UseVisualStyleBackColor = true;
            this.btn_estVendedores.Click += new System.EventHandler(this.btn_estVendedores_Click);
            // 
            // btn_estFranquicias
            // 
            this.btn_estFranquicias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estFranquicias.Location = new System.Drawing.Point(242, 94);
            this.btn_estFranquicias.Name = "btn_estFranquicias";
            this.btn_estFranquicias.Size = new System.Drawing.Size(133, 46);
            this.btn_estFranquicias.TabIndex = 73;
            this.btn_estFranquicias.Text = "Estadisticas de Franquicias";
            this.btn_estFranquicias.UseVisualStyleBackColor = true;
            this.btn_estFranquicias.Click += new System.EventHandler(this.btn_estFranquicias_Click);
            // 
            // btn_estProductos
            // 
            this.btn_estProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estProductos.Location = new System.Drawing.Point(423, 94);
            this.btn_estProductos.Name = "btn_estProductos";
            this.btn_estProductos.Size = new System.Drawing.Size(133, 46);
            this.btn_estProductos.TabIndex = 74;
            this.btn_estProductos.Text = "Estadisticas de Productos";
            this.btn_estProductos.UseVisualStyleBackColor = true;
            this.btn_estProductos.Click += new System.EventHandler(this.btn_estProductos_Click);
            // 
            // btn_estPedidos
            // 
            this.btn_estPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estPedidos.Location = new System.Drawing.Point(604, 94);
            this.btn_estPedidos.Name = "btn_estPedidos";
            this.btn_estPedidos.Size = new System.Drawing.Size(133, 46);
            this.btn_estPedidos.TabIndex = 75;
            this.btn_estPedidos.Text = "Estadisticas de Pedidos";
            this.btn_estPedidos.UseVisualStyleBackColor = true;
            this.btn_estPedidos.Click += new System.EventHandler(this.btn_estPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "                              ESTADÍSTICAS                               ";
            // 
            // uc_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_estPedidos);
            this.Controls.Add(this.btn_estProductos);
            this.Controls.Add(this.btn_estFranquicias);
            this.Controls.Add(this.btn_estVendedores);
            this.Controls.Add(this.grp_estadisticas);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.grafico);
            this.Name = "uc_Estadisticas";
            this.Size = new System.Drawing.Size(1243, 584);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.grp_estadisticas.ResumeLayout(false);
            this.grp_estadisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btn_EstadisticaVendedorPedidos;
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
        private System.Windows.Forms.DateTimePicker dtp_fechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Button btn_EstadisticaCantPedidosPend;
        private System.Windows.Forms.Button btn_franquiciaMasPedidosEnPeriodo;
        private System.Windows.Forms.Button btn_franquiciaMenosPedidosEnPeriodo;
        private System.Windows.Forms.Button btn_EstadisticaCantPedidosEnt;
        private System.Windows.Forms.Label lbl_franquicia_producto;
        private System.Windows.Forms.Button btn_productoPorFranquicia;
        private clases.ComboBoxPersonal cmb_franquicias;
        private System.Windows.Forms.Button btn_cantFranquiciasXVendedor;
        private System.Windows.Forms.Button btn_vendedoresConMenosPedidos;
        private System.Windows.Forms.Button btn_productosMenosVendidos;
        private System.Windows.Forms.Label label1;
    }
}
