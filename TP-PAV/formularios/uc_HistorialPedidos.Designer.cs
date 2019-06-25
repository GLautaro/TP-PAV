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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.fecha_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_franquicia = new System.Windows.Forms.CheckBox();
            this.lbl_franquicia = new System.Windows.Forms.Label();
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
            this.cmb_vendedores = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.txt_hasta_monto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_desde_monto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_franquicias = new TP_PAV.clases.ComboBoxPersonal(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            this.grp_busquedaAvanzadaPedido.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_detallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detallePedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detallePedido.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_detallePedido.Location = new System.Drawing.Point(41, 354);
            this.dgv_detallePedido.MultiSelect = false;
            this.dgv_detallePedido.Name = "dgv_detallePedido";
            this.dgv_detallePedido.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_detallePedido.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_detallePedido.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.Column3,
            this.Column4,
            this.Column2,
            this.monto_final,
            this.fecha_entrega,
            this.nombre_estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pedidos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_pedidos.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.Location = new System.Drawing.Point(41, 95);
            this.dgv_pedidos.MultiSelect = false;
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_pedidos.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_pedidos.RowsDefaultCellStyle = dataGridViewCellStyle8;
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
            // fecha_entrega
            // 
            this.fecha_entrega.DataPropertyName = "fecha_entrega";
            this.fecha_entrega.HeaderText = "Fecha entrega";
            this.fecha_entrega.Name = "fecha_entrega";
            this.fecha_entrega.ReadOnly = true;
            // 
            // nombre_estado
            // 
            this.nombre_estado.DataPropertyName = "nombre_estado";
            this.nombre_estado.HeaderText = "Estado";
            this.nombre_estado.Name = "nombre_estado";
            this.nombre_estado.ReadOnly = true;
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
            // lbl_franquicia
            // 
            this.lbl_franquicia.AutoSize = true;
            this.lbl_franquicia.Location = new System.Drawing.Point(86, 64);
            this.lbl_franquicia.Name = "lbl_franquicia";
            this.lbl_franquicia.Size = new System.Drawing.Size(66, 13);
            this.lbl_franquicia.TabIndex = 2;
            this.lbl_franquicia.Text = "Seleccionar:";
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
            this.btn_cerrarBusquedaAvanzada.Click += new System.EventHandler(this.btn_cerrarBusquedaAvanzada_Click);
            // 
            // btn_BuscarBusquedaAvanzada
            // 
            this.btn_BuscarBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarBusquedaAvanzada.Location = new System.Drawing.Point(149, 357);
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
            this.lbl_msjErrorBusquedaAv.Location = new System.Drawing.Point(17, 283);
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
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.lbl_franquicia);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_franquicia);
            this.grp_busquedaAvanzadaPedido.Location = new System.Drawing.Point(644, 95);
            this.grp_busquedaAvanzadaPedido.Name = "grp_busquedaAvanzadaPedido";
            this.grp_busquedaAvanzadaPedido.Size = new System.Drawing.Size(362, 471);
            this.grp_busquedaAvanzadaPedido.TabIndex = 93;
            this.grp_busquedaAvanzadaPedido.TabStop = false;
            this.grp_busquedaAvanzadaPedido.Text = "Busqueda Avanzada | Productos";
            this.grp_busquedaAvanzadaPedido.Visible = false;
            // 
            // cmb_vendedores
            // 
            this.cmb_vendedores._campo = "legajo_vendedor";
            this.cmb_vendedores._mensaje_error = "No se seleccionó vendedor";
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
            this.cmb_franquicias._mensaje_error = "No se seleccionó una franquicia";
            this.cmb_franquicias._nombre_tabla = "franquicia";
            this.cmb_franquicias._validable = false;
            this.cmb_franquicias.Enabled = false;
            this.cmb_franquicias.FormattingEnabled = true;
            this.cmb_franquicias.Location = new System.Drawing.Point(174, 61);
            this.cmb_franquicias.Name = "cmb_franquicias";
            this.cmb_franquicias.Size = new System.Drawing.Size(167, 21);
            this.cmb_franquicias.TabIndex = 3;
            // 
            // uc_HistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "uc_HistorialPedidos";
            this.Size = new System.Drawing.Size(1006, 601);
            this.Load += new System.EventHandler(this.uc_HistorialPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            this.grp_busquedaAvanzadaPedido.ResumeLayout(false);
            this.grp_busquedaAvanzadaPedido.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_franquicia;
        private System.Windows.Forms.Label lbl_franquicia;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_estado;

    }
}
