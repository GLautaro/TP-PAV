namespace TP_PAV.formularios
{
    partial class uc_HistorialPedidos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_busquedaAvanzadaProducto = new System.Windows.Forms.Button();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.txt_busquedaProducto = new System.Windows.Forms.TextBox();
            this.lbl_buscarProducto = new System.Windows.Forms.Label();
            this.dgv_detallePedido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_franquicia = new System.Windows.Forms.CheckBox();
            this.lbl_busquedaAvSeleccionTipo = new System.Windows.Forms.Label();
            this.cbx_monto = new System.Windows.Forms.CheckBox();
            this.lbl_busquedaPrecioDesde = new System.Windows.Forms.Label();
            this.lbl_busquedaPrecioHasta = new System.Windows.Forms.Label();
            this.rbtn_entregado = new System.Windows.Forms.RadioButton();
            this.rbtn_pendiente = new System.Windows.Forms.RadioButton();
            this.btn_cerrarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btn_BuscarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.lbl_msjErrorBusquedaAv = new System.Windows.Forms.Label();
            this.cbx_vendedor = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtn_cancelado = new System.Windows.Forms.RadioButton();
            this.cbx_estado = new System.Windows.Forms.CheckBox();
            this.grp_busquedaAvanzadaPedido = new System.Windows.Forms.GroupBox();
            this.grp_modificar = new System.Windows.Forms.GroupBox();
            this.label_error = new System.Windows.Forms.Label();
            this.btn_modificarEstado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_vendedores = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.txt_hasta_monto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_desde_monto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_franquicias = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.cmb_estadoPedido = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.error_buscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            this.grp_busquedaAvanzadaPedido.SuspendLayout();
            this.grp_modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Búsqueda por ID";
            // 
            // btn_busquedaAvanzadaProducto
            // 
            this.btn_busquedaAvanzadaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedaAvanzadaProducto.Location = new System.Drawing.Point(496, 42);
            this.btn_busquedaAvanzadaProducto.Name = "btn_busquedaAvanzadaProducto";
            this.btn_busquedaAvanzadaProducto.Size = new System.Drawing.Size(146, 30);
            this.btn_busquedaAvanzadaProducto.TabIndex = 91;
            this.btn_busquedaAvanzadaProducto.Text = "Busqueda avanzada";
            this.btn_busquedaAvanzadaProducto.UseVisualStyleBackColor = true;
            this.btn_busquedaAvanzadaProducto.Click += new System.EventHandler(this.btn_busquedaAvanzadaPedido_Click);
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarProducto.Location = new System.Drawing.Point(423, 42);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(67, 30);
            this.btn_buscarProducto.TabIndex = 90;
            this.btn_buscarProducto.Text = "Buscar";
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            this.btn_buscarProducto.Click += new System.EventHandler(this.btn_buscarProducto_Click);
            // 
            // txt_busquedaProducto
            // 
            this.txt_busquedaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaProducto.Location = new System.Drawing.Point(157, 46);
            this.txt_busquedaProducto.Name = "txt_busquedaProducto";
            this.txt_busquedaProducto.Size = new System.Drawing.Size(260, 22);
            this.txt_busquedaProducto.TabIndex = 89;
            // 
            // lbl_buscarProducto
            // 
            this.lbl_buscarProducto.AutoSize = true;
            this.lbl_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscarProducto.Location = new System.Drawing.Point(98, 49);
            this.lbl_buscarProducto.Name = "lbl_buscarProducto";
            this.lbl_buscarProducto.Size = new System.Drawing.Size(53, 16);
            this.lbl_buscarProducto.TabIndex = 88;
            this.lbl_buscarProducto.Text = "Buscar:";
            // 
            // dgv_detallePedido
            // 
            this.dgv_detallePedido.AllowUserToAddRows = false;
            this.dgv_detallePedido.AllowUserToDeleteRows = false;
            this.dgv_detallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detallePedido.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_detallePedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detallePedido.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_detallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detallePedido.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_detallePedido.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_detallePedido.Location = new System.Drawing.Point(41, 354);
            this.dgv_detallePedido.MultiSelect = false;
            this.dgv_detallePedido.Name = "dgv_detallePedido";
            this.dgv_detallePedido.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_detallePedido.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_detallePedido.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_detallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detallePedido.Size = new System.Drawing.Size(561, 212);
            this.dgv_detallePedido.TabIndex = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "montoTotal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Monto Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID PRODUCTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToDeleteRows = false;
            this.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedidos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pedidos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.Column3,
            this.Column4,
            this.Column2,
            this.monto_final,
            this.id_estado});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pedidos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_pedidos.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.Location = new System.Drawing.Point(41, 95);
            this.dgv_pedidos.MultiSelect = false;
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_pedidos.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_pedidos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedidos.Size = new System.Drawing.Size(561, 221);
            this.dgv_pedidos.TabIndex = 86;
            this.dgv_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellClick);
            // 
            // id_pedido
            // 
            this.id_pedido.DataPropertyName = "id_pedido";
            this.id_pedido.HeaderText = "ID Pedido";
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.ReadOnly = true;
            this.id_pedido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_franquicia";
            this.Column3.HeaderText = "ID Franquicia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id_vendedor";
            this.Column4.HeaderText = "Legajo Vendedor";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "fecha_solicitud";
            this.Column2.HeaderText = "Fecha Solicitud";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // monto_final
            // 
            this.monto_final.DataPropertyName = "monto_final";
            this.monto_final.HeaderText = "Monto Total";
            this.monto_final.Name = "monto_final";
            this.monto_final.ReadOnly = true;
            this.monto_final.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id_estado
            // 
            this.id_estado.DataPropertyName = "id_estado";
            this.id_estado.HeaderText = "id_estado";
            this.id_estado.Name = "id_estado";
            this.id_estado.ReadOnly = true;
            this.id_estado.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 85;
            this.label3.Text = "Detalle Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 86;
            this.label1.Text = "Historial de pedidos";
            // 
            // cbx_franquicia
            // 
            this.cbx_franquicia.AutoSize = true;
            this.cbx_franquicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_franquicia.Location = new System.Drawing.Point(16, 31);
            this.cbx_franquicia.Name = "cbx_franquicia";
            this.cbx_franquicia.Size = new System.Drawing.Size(98, 19);
            this.cbx_franquicia.TabIndex = 0;
            this.cbx_franquicia.Text = "Franquicia:";
            this.cbx_franquicia.UseVisualStyleBackColor = true;
            this.cbx_franquicia.CheckedChanged += new System.EventHandler(this.cbx_franquicia_CheckedChanged);
            // 
            // lbl_busquedaAvSeleccionTipo
            // 
            this.lbl_busquedaAvSeleccionTipo.AutoSize = true;
            this.lbl_busquedaAvSeleccionTipo.Location = new System.Drawing.Point(86, 64);
            this.lbl_busquedaAvSeleccionTipo.Name = "lbl_busquedaAvSeleccionTipo";
            this.lbl_busquedaAvSeleccionTipo.Size = new System.Drawing.Size(66, 13);
            this.lbl_busquedaAvSeleccionTipo.TabIndex = 2;
            this.lbl_busquedaAvSeleccionTipo.Text = "Seleccionar:";
            // 
            // cbx_monto
            // 
            this.cbx_monto.AutoSize = true;
            this.cbx_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_monto.Location = new System.Drawing.Point(16, 148);
            this.cbx_monto.Name = "cbx_monto";
            this.cbx_monto.Size = new System.Drawing.Size(70, 19);
            this.cbx_monto.TabIndex = 4;
            this.cbx_monto.Text = "Monto:";
            this.cbx_monto.UseVisualStyleBackColor = true;
            this.cbx_monto.CheckedChanged += new System.EventHandler(this.cbx_monto_CheckedChanged);
            // 
            // lbl_busquedaPrecioDesde
            // 
            this.lbl_busquedaPrecioDesde.AutoSize = true;
            this.lbl_busquedaPrecioDesde.Location = new System.Drawing.Point(111, 164);
            this.lbl_busquedaPrecioDesde.Name = "lbl_busquedaPrecioDesde";
            this.lbl_busquedaPrecioDesde.Size = new System.Drawing.Size(41, 13);
            this.lbl_busquedaPrecioDesde.TabIndex = 7;
            this.lbl_busquedaPrecioDesde.Text = "Desde:";
            // 
            // lbl_busquedaPrecioHasta
            // 
            this.lbl_busquedaPrecioHasta.AutoSize = true;
            this.lbl_busquedaPrecioHasta.Location = new System.Drawing.Point(111, 188);
            this.lbl_busquedaPrecioHasta.Name = "lbl_busquedaPrecioHasta";
            this.lbl_busquedaPrecioHasta.Size = new System.Drawing.Size(38, 13);
            this.lbl_busquedaPrecioHasta.TabIndex = 8;
            this.lbl_busquedaPrecioHasta.Text = "Hasta:";
            // 
            // rbtn_entregado
            // 
            this.rbtn_entregado.AutoSize = true;
            this.rbtn_entregado.Enabled = false;
            this.rbtn_entregado.Location = new System.Drawing.Point(174, 239);
            this.rbtn_entregado.Name = "rbtn_entregado";
            this.rbtn_entregado.Size = new System.Drawing.Size(74, 17);
            this.rbtn_entregado.TabIndex = 11;
            this.rbtn_entregado.TabStop = true;
            this.rbtn_entregado.Text = "Entregado";
            this.rbtn_entregado.UseVisualStyleBackColor = true;
            // 
            // rbtn_pendiente
            // 
            this.rbtn_pendiente.AutoSize = true;
            this.rbtn_pendiente.Enabled = false;
            this.rbtn_pendiente.Location = new System.Drawing.Point(98, 239);
            this.rbtn_pendiente.Name = "rbtn_pendiente";
            this.rbtn_pendiente.Size = new System.Drawing.Size(73, 17);
            this.rbtn_pendiente.TabIndex = 12;
            this.rbtn_pendiente.TabStop = true;
            this.rbtn_pendiente.Text = "Pendiente";
            this.rbtn_pendiente.UseVisualStyleBackColor = true;
            // 
            // btn_cerrarBusquedaAvanzada
            // 
            this.btn_cerrarBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarBusquedaAvanzada.Location = new System.Drawing.Point(293, 16);
            this.btn_cerrarBusquedaAvanzada.Name = "btn_cerrarBusquedaAvanzada";
            this.btn_cerrarBusquedaAvanzada.Size = new System.Drawing.Size(62, 23);
            this.btn_cerrarBusquedaAvanzada.TabIndex = 67;
            this.btn_cerrarBusquedaAvanzada.Text = "Cerrar";
            this.btn_cerrarBusquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarBusquedaAvanzada
            // 
            this.btn_BuscarBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarBusquedaAvanzada.Location = new System.Drawing.Point(158, 312);
            this.btn_BuscarBusquedaAvanzada.Name = "btn_BuscarBusquedaAvanzada";
            this.btn_BuscarBusquedaAvanzada.Size = new System.Drawing.Size(67, 30);
            this.btn_BuscarBusquedaAvanzada.TabIndex = 68;
            this.btn_BuscarBusquedaAvanzada.Text = "Buscar";
            this.btn_BuscarBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btn_BuscarBusquedaAvanzada.Click += new System.EventHandler(this.btn_BuscarBusquedaAvanzada_Click);
            // 
            // lbl_msjErrorBusquedaAv
            // 
            this.lbl_msjErrorBusquedaAv.AutoSize = true;
            this.lbl_msjErrorBusquedaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msjErrorBusquedaAv.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjErrorBusquedaAv.Location = new System.Drawing.Point(130, 269);
            this.lbl_msjErrorBusquedaAv.Name = "lbl_msjErrorBusquedaAv";
            this.lbl_msjErrorBusquedaAv.Size = new System.Drawing.Size(135, 16);
            this.lbl_msjErrorBusquedaAv.TabIndex = 69;
            this.lbl_msjErrorBusquedaAv.Text = "Mensajes de Error";
            this.lbl_msjErrorBusquedaAv.Visible = false;
            // 
            // cbx_vendedor
            // 
            this.cbx_vendedor.AutoSize = true;
            this.cbx_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_vendedor.Location = new System.Drawing.Point(16, 88);
            this.cbx_vendedor.Name = "cbx_vendedor";
            this.cbx_vendedor.Size = new System.Drawing.Size(91, 19);
            this.cbx_vendedor.TabIndex = 70;
            this.cbx_vendedor.Text = "Vendedor:";
            this.cbx_vendedor.UseVisualStyleBackColor = true;
            this.cbx_vendedor.CheckedChanged += new System.EventHandler(this.cbx_vendedor_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Seleccionar:";
            // 
            // rbtn_cancelado
            // 
            this.rbtn_cancelado.AutoSize = true;
            this.rbtn_cancelado.Enabled = false;
            this.rbtn_cancelado.Location = new System.Drawing.Point(254, 239);
            this.rbtn_cancelado.Name = "rbtn_cancelado";
            this.rbtn_cancelado.Size = new System.Drawing.Size(76, 17);
            this.rbtn_cancelado.TabIndex = 73;
            this.rbtn_cancelado.TabStop = true;
            this.rbtn_cancelado.Text = "Cancelado";
            this.rbtn_cancelado.UseVisualStyleBackColor = true;
            // 
            // cbx_estado
            // 
            this.cbx_estado.AutoSize = true;
            this.cbx_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado.Location = new System.Drawing.Point(16, 215);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(74, 19);
            this.cbx_estado.TabIndex = 84;
            this.cbx_estado.Text = "Estado:";
            this.cbx_estado.UseVisualStyleBackColor = true;
            this.cbx_estado.CheckedChanged += new System.EventHandler(this.cbx_estado_CheckedChanged);
            // 
            // grp_busquedaAvanzadaPedido
            // 
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_estado);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.rbtn_cancelado);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cmb_vendedores);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.label8);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_vendedor);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.lbl_msjErrorBusquedaAv);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.btn_BuscarBusquedaAvanzada);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.btn_cerrarBusquedaAvanzada);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.rbtn_pendiente);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.rbtn_entregado);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.lbl_busquedaPrecioHasta);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.lbl_busquedaPrecioDesde);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.txt_hasta_monto);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.txt_desde_monto);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_monto);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cmb_franquicias);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.lbl_busquedaAvSeleccionTipo);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_franquicia);
            this.grp_busquedaAvanzadaPedido.Location = new System.Drawing.Point(625, 95);
            this.grp_busquedaAvanzadaPedido.Name = "grp_busquedaAvanzadaPedido";
            this.grp_busquedaAvanzadaPedido.Size = new System.Drawing.Size(362, 471);
            this.grp_busquedaAvanzadaPedido.TabIndex = 93;
            this.grp_busquedaAvanzadaPedido.TabStop = false;
            this.grp_busquedaAvanzadaPedido.Text = "Busqueda Avanzada | Productos";
            this.grp_busquedaAvanzadaPedido.Visible = false;
            // 
            // grp_modificar
            // 
            this.grp_modificar.Controls.Add(this.label_error);
            this.grp_modificar.Controls.Add(this.btn_modificarEstado);
            this.grp_modificar.Controls.Add(this.cmb_estadoPedido);
            this.grp_modificar.Controls.Add(this.label6);
            this.grp_modificar.Location = new System.Drawing.Point(670, 113);
            this.grp_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.grp_modificar.Name = "grp_modificar";
            this.grp_modificar.Padding = new System.Windows.Forms.Padding(2);
            this.grp_modificar.Size = new System.Drawing.Size(284, 108);
            this.grp_modificar.TabIndex = 96;
            this.grp_modificar.TabStop = false;
            this.grp_modificar.Text = "Modificar estado pedido";
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Green;
            this.label_error.Location = new System.Drawing.Point(10, 70);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(161, 13);
            this.label_error.TabIndex = 18;
            this.label_error.Text = "Estado moficado con éxito.";
            this.label_error.Visible = false;
            // 
            // btn_modificarEstado
            // 
            this.btn_modificarEstado.Location = new System.Drawing.Point(174, 65);
            this.btn_modificarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificarEstado.Name = "btn_modificarEstado";
            this.btn_modificarEstado.Size = new System.Drawing.Size(93, 28);
            this.btn_modificarEstado.TabIndex = 16;
            this.btn_modificarEstado.Text = "Cambiar Estado";
            this.btn_modificarEstado.UseVisualStyleBackColor = true;
            this.btn_modificarEstado.Click += new System.EventHandler(this.btn_modificarEstado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado Pedido:";
            // 
            // cmb_vendedores
            // 
            this.cmb_vendedores._campo = "legajo_vendedor";
            this.cmb_vendedores._mensaje_error = "No se selecciono vendedor";
            this.cmb_vendedores._nombre_tabla = "vendedor";
            this.cmb_vendedores._validable = false;
            this.cmb_vendedores.Enabled = false;
            this.cmb_vendedores.FormattingEnabled = true;
            this.cmb_vendedores.Location = new System.Drawing.Point(174, 118);
            this.cmb_vendedores.Name = "cmb_vendedores";
            this.cmb_vendedores.Size = new System.Drawing.Size(167, 21);
            this.cmb_vendedores.TabIndex = 72;
            // 
            // txt_hasta_monto
            // 
            this.txt_hasta_monto._campo = "monto_final";
            this.txt_hasta_monto._mensaje_error = null;
            this.txt_hasta_monto._nombre_tabla = "pedido";
            this.txt_hasta_monto._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_hasta_monto._validable = false;
            this.txt_hasta_monto.Enabled = false;
            this.txt_hasta_monto.Location = new System.Drawing.Point(174, 185);
            this.txt_hasta_monto.Name = "txt_hasta_monto";
            this.txt_hasta_monto.Size = new System.Drawing.Size(167, 20);
            this.txt_hasta_monto.TabIndex = 6;
            // 
            // txt_desde_monto
            // 
            this.txt_desde_monto._campo = "monto_final";
            this.txt_desde_monto._mensaje_error = null;
            this.txt_desde_monto._nombre_tabla = "pedido";
            this.txt_desde_monto._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_desde_monto._validable = false;
            this.txt_desde_monto.Enabled = false;
            this.txt_desde_monto.Location = new System.Drawing.Point(174, 160);
            this.txt_desde_monto.Name = "txt_desde_monto";
            this.txt_desde_monto.Size = new System.Drawing.Size(167, 20);
            this.txt_desde_monto.TabIndex = 5;
            // 
            // cmb_franquicias
            // 
            this.cmb_franquicias._campo = "id_franquicia";
            this.cmb_franquicias._mensaje_error = "No se selecciono una franquicia";
            this.cmb_franquicias._nombre_tabla = "franquicia";
            this.cmb_franquicias._validable = false;
            this.cmb_franquicias.Enabled = false;
            this.cmb_franquicias.FormattingEnabled = true;
            this.cmb_franquicias.Location = new System.Drawing.Point(174, 61);
            this.cmb_franquicias.Name = "cmb_franquicias";
            this.cmb_franquicias.Size = new System.Drawing.Size(167, 21);
            this.cmb_franquicias.TabIndex = 3;
            // 
            // cmb_estadoPedido
            // 
            this.cmb_estadoPedido._campo = null;
            this.cmb_estadoPedido._mensaje_error = "Necesita seleccionar un estado para el pedido";
            this.cmb_estadoPedido._nombre_tabla = null;
            this.cmb_estadoPedido._validable = true;
            this.cmb_estadoPedido.FormattingEnabled = true;
            this.cmb_estadoPedido.Location = new System.Drawing.Point(87, 28);
            this.cmb_estadoPedido.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_estadoPedido.Name = "cmb_estadoPedido";
            this.cmb_estadoPedido.Size = new System.Drawing.Size(181, 21);
            this.cmb_estadoPedido.TabIndex = 17;
            // 
            // error_buscar
            // 
            this.error_buscar.AutoSize = true;
            this.error_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_buscar.ForeColor = System.Drawing.Color.Red;
            this.error_buscar.Location = new System.Drawing.Point(317, 72);
            this.error_buscar.Name = "error_buscar";
            this.error_buscar.Size = new System.Drawing.Size(79, 16);
            this.error_buscar.TabIndex = 97;
            this.error_buscar.Text = "Ingrese ID";
            this.error_buscar.Visible = false;
            // 
            // uc_HistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_busquedaAvanzadaPedido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_busquedaAvanzadaProducto);
            this.Controls.Add(this.btn_buscarProducto);
            this.Controls.Add(this.txt_busquedaProducto);
            this.Controls.Add(this.lbl_buscarProducto);
            this.Controls.Add(this.dgv_detallePedido);
            this.Controls.Add(this.dgv_pedidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grp_modificar);
            this.Name = "uc_HistorialPedidos";
            this.Size = new System.Drawing.Size(1006, 601);
            this.Load += new System.EventHandler(this.uc_HistorialPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            this.grp_busquedaAvanzadaPedido.ResumeLayout(false);
            this.grp_busquedaAvanzadaPedido.PerformLayout();
            this.grp_modificar.ResumeLayout(false);
            this.grp_modificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_busquedaAvanzadaProducto;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.TextBox txt_busquedaProducto;
        private System.Windows.Forms.Label lbl_buscarProducto;
        private System.Windows.Forms.DataGridView dgv_detallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_franquicia;
        private System.Windows.Forms.Label lbl_busquedaAvSeleccionTipo;
        private clases.ComboBoxPersonal cmb_franquicias;
        private System.Windows.Forms.CheckBox cbx_monto;
        private clases.TextBoxPersonal txt_desde_monto;
        private clases.TextBoxPersonal txt_hasta_monto;
        private System.Windows.Forms.Label lbl_busquedaPrecioDesde;
        private System.Windows.Forms.Label lbl_busquedaPrecioHasta;
        private System.Windows.Forms.RadioButton rbtn_entregado;
        private System.Windows.Forms.RadioButton rbtn_pendiente;
        private System.Windows.Forms.Button btn_cerrarBusquedaAvanzada;
        private System.Windows.Forms.Button btn_BuscarBusquedaAvanzada;
        private System.Windows.Forms.Label lbl_msjErrorBusquedaAv;
        private System.Windows.Forms.CheckBox cbx_vendedor;
        private System.Windows.Forms.Label label8;
        private clases.ComboBoxPersonal cmb_vendedores;
        private System.Windows.Forms.RadioButton rbtn_cancelado;
        private System.Windows.Forms.CheckBox cbx_estado;
        private System.Windows.Forms.GroupBox grp_busquedaAvanzadaPedido;
        private System.Windows.Forms.GroupBox grp_modificar;
        private System.Windows.Forms.Button btn_modificarEstado;
        private clases.ComboBoxPersonal cmb_estadoPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label error_buscar;

    }
}
