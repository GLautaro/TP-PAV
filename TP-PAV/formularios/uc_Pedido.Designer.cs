namespace TP_PAV.formularios
{
    partial class uc_Pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addPedido = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grp_crearPedido = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_detallePedido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_error = new System.Windows.Forms.Label();
            this.grp_modificar = new System.Windows.Forms.GroupBox();
            this.btn_modificarEstado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_busquedaAvanzadaPedido = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_fechaEntrega = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_fechaSolicitud = new System.Windows.Forms.CheckBox();
            this.rbtn_cancelado = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_vendedor = new System.Windows.Forms.CheckBox();
            this.lbl_msjErrorBusquedaAv = new System.Windows.Forms.Label();
            this.btn_BuscarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btn_cerrarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.rbtn_pendiente = new System.Windows.Forms.RadioButton();
            this.rbtn_entregado = new System.Windows.Forms.RadioButton();
            this.lbl_busquedaPrecioHasta = new System.Windows.Forms.Label();
            this.lbl_busquedaPrecioDesde = new System.Windows.Forms.Label();
            this.cbx_monto = new System.Windows.Forms.CheckBox();
            this.lbl_busquedaAvSeleccionTipo = new System.Windows.Forms.Label();
            this.cbx_franquicia = new System.Windows.Forms.CheckBox();
            this.btn_busquedaAvanzadaProducto = new System.Windows.Forms.Button();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.txt_busquedaProducto = new System.Windows.Forms.TextBox();
            this.lbl_buscarProducto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_estado = new System.Windows.Forms.CheckBox();
            this.dtp_hasta_fechaEntrega = new TP_PAV.clases.DateTimePickerPersonal(this.components);
            this.dtp_desde_fechaEntrega = new TP_PAV.clases.DateTimePickerPersonal(this.components);
            this.dtp_hasta_fechaSolicitud = new TP_PAV.clases.DateTimePickerPersonal(this.components);
            this.dtp_desde_fechaSolicitud = new TP_PAV.clases.DateTimePickerPersonal(this.components);
            this.cmb_vendedores = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.txt_hasta_monto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_desde_monto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_franquicias = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.cmb_estadoPedido = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.dt_fechaSolicitada = new TP_PAV.clases.DateTimePickerPersonal(this.components);
            this.txt_legajoVendedor = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_franquicia = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.grp_crearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
            this.grp_modificar.SuspendLayout();
            this.grp_busquedaAvanzadaPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pedidos Pendientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalle Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Franquicia:";
            // 
            // btn_addPedido
            // 
            this.btn_addPedido.Location = new System.Drawing.Point(189, 154);
            this.btn_addPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addPedido.Name = "btn_addPedido";
            this.btn_addPedido.Size = new System.Drawing.Size(93, 28);
            this.btn_addPedido.TabIndex = 10;
            this.btn_addPedido.Text = "Crear Pedido";
            this.btn_addPedido.UseVisualStyleBackColor = true;
            this.btn_addPedido.Click += new System.EventHandler(this.btn_addPedido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Solicitada:";
            // 
            // grp_crearPedido
            // 
            this.grp_crearPedido.Controls.Add(this.dt_fechaSolicitada);
            this.grp_crearPedido.Controls.Add(this.txt_legajoVendedor);
            this.grp_crearPedido.Controls.Add(this.label9);
            this.grp_crearPedido.Controls.Add(this.label4);
            this.grp_crearPedido.Controls.Add(this.cmb_franquicia);
            this.grp_crearPedido.Controls.Add(this.label5);
            this.grp_crearPedido.Controls.Add(this.btn_addPedido);
            this.grp_crearPedido.Location = new System.Drawing.Point(623, 85);
            this.grp_crearPedido.Margin = new System.Windows.Forms.Padding(2);
            this.grp_crearPedido.Name = "grp_crearPedido";
            this.grp_crearPedido.Padding = new System.Windows.Forms.Padding(2);
            this.grp_crearPedido.Size = new System.Drawing.Size(286, 188);
            this.grp_crearPedido.TabIndex = 20;
            this.grp_crearPedido.TabStop = false;
            this.grp_crearPedido.Text = "Crear Pedido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Legajo Vendedor:";
            // 
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToDeleteRows = false;
            this.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedidos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pedidos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.Column3,
            this.Column4,
            this.Column2,
            this.monto_final,
            this.id_estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pedidos.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.Location = new System.Drawing.Point(43, 120);
            this.dgv_pedidos.MultiSelect = false;
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pedidos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_pedidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedidos.Size = new System.Drawing.Size(561, 221);
            this.dgv_pedidos.TabIndex = 52;
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
            // dgv_detallePedido
            // 
            this.dgv_detallePedido.AllowUserToAddRows = false;
            this.dgv_detallePedido.AllowUserToDeleteRows = false;
            this.dgv_detallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detallePedido.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_detallePedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_detallePedido.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_detallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detallePedido.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_detallePedido.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_detallePedido.Location = new System.Drawing.Point(43, 379);
            this.dgv_detallePedido.MultiSelect = false;
            this.dgv_detallePedido.Name = "dgv_detallePedido";
            this.dgv_detallePedido.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_detallePedido.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_detallePedido.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_detallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detallePedido.Size = new System.Drawing.Size(561, 221);
            this.dgv_detallePedido.TabIndex = 53;
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
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(620, 58);
            this.label_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 17);
            this.label_error.TabIndex = 54;
            // 
            // grp_modificar
            // 
            this.grp_modificar.Controls.Add(this.btn_modificarEstado);
            this.grp_modificar.Controls.Add(this.cmb_estadoPedido);
            this.grp_modificar.Controls.Add(this.label6);
            this.grp_modificar.Location = new System.Drawing.Point(626, 288);
            this.grp_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.grp_modificar.Name = "grp_modificar";
            this.grp_modificar.Padding = new System.Windows.Forms.Padding(2);
            this.grp_modificar.Size = new System.Drawing.Size(284, 108);
            this.grp_modificar.TabIndex = 55;
            this.grp_modificar.TabStop = false;
            this.grp_modificar.Text = "Modificar estado pedido";
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
            // grp_busquedaAvanzadaPedido
            // 
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.dtp_hasta_fechaEntrega);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.dtp_desde_fechaEntrega);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.dtp_hasta_fechaSolicitud);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.dtp_desde_fechaSolicitud);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_estado);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.label12);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.label13);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_fechaEntrega);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.label10);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.label11);
            this.grp_busquedaAvanzadaPedido.Controls.Add(this.cbx_fechaSolicitud);
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
            this.grp_busquedaAvanzadaPedido.Location = new System.Drawing.Point(623, 84);
            this.grp_busquedaAvanzadaPedido.Name = "grp_busquedaAvanzadaPedido";
            this.grp_busquedaAvanzadaPedido.Size = new System.Drawing.Size(361, 547);
            this.grp_busquedaAvanzadaPedido.TabIndex = 78;
            this.grp_busquedaAvanzadaPedido.TabStop = false;
            this.grp_busquedaAvanzadaPedido.Text = "Busqueda Avanzada | Productos";
            this.grp_busquedaAvanzadaPedido.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Hasta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "Desde:";
            // 
            // cbx_fechaEntrega
            // 
            this.cbx_fechaEntrega.AutoSize = true;
            this.cbx_fechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fechaEntrega.Location = new System.Drawing.Point(17, 285);
            this.cbx_fechaEntrega.Name = "cbx_fechaEntrega";
            this.cbx_fechaEntrega.Size = new System.Drawing.Size(142, 19);
            this.cbx_fechaEntrega.TabIndex = 79;
            this.cbx_fechaEntrega.Text = "Fecha de entrega:";
            this.cbx_fechaEntrega.UseVisualStyleBackColor = true;
            this.cbx_fechaEntrega.CheckedChanged += new System.EventHandler(this.cbx_fechaEntrega_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Hasta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Desde:";
            // 
            // cbx_fechaSolicitud
            // 
            this.cbx_fechaSolicitud.AutoSize = true;
            this.cbx_fechaSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fechaSolicitud.Location = new System.Drawing.Point(14, 211);
            this.cbx_fechaSolicitud.Name = "cbx_fechaSolicitud";
            this.cbx_fechaSolicitud.Size = new System.Drawing.Size(127, 19);
            this.cbx_fechaSolicitud.TabIndex = 74;
            this.cbx_fechaSolicitud.Text = "Fecha solicitud:";
            this.cbx_fechaSolicitud.UseVisualStyleBackColor = true;
            this.cbx_fechaSolicitud.CheckedChanged += new System.EventHandler(this.cbx_fechaSolicitud_CheckedChanged);
            // 
            // rbtn_cancelado
            // 
            this.rbtn_cancelado.AutoSize = true;
            this.rbtn_cancelado.Enabled = false;
            this.rbtn_cancelado.Location = new System.Drawing.Point(255, 377);
            this.rbtn_cancelado.Name = "rbtn_cancelado";
            this.rbtn_cancelado.Size = new System.Drawing.Size(76, 17);
            this.rbtn_cancelado.TabIndex = 73;
            this.rbtn_cancelado.TabStop = true;
            this.rbtn_cancelado.Text = "Cancelado";
            this.rbtn_cancelado.UseVisualStyleBackColor = true;
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
            // lbl_msjErrorBusquedaAv
            // 
            this.lbl_msjErrorBusquedaAv.AutoSize = true;
            this.lbl_msjErrorBusquedaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msjErrorBusquedaAv.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjErrorBusquedaAv.Location = new System.Drawing.Point(131, 407);
            this.lbl_msjErrorBusquedaAv.Name = "lbl_msjErrorBusquedaAv";
            this.lbl_msjErrorBusquedaAv.Size = new System.Drawing.Size(135, 16);
            this.lbl_msjErrorBusquedaAv.TabIndex = 69;
            this.lbl_msjErrorBusquedaAv.Text = "Mensajes de Error";
            this.lbl_msjErrorBusquedaAv.Visible = false;
            // 
            // btn_BuscarBusquedaAvanzada
            // 
            this.btn_BuscarBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarBusquedaAvanzada.Location = new System.Drawing.Point(165, 441);
            this.btn_BuscarBusquedaAvanzada.Name = "btn_BuscarBusquedaAvanzada";
            this.btn_BuscarBusquedaAvanzada.Size = new System.Drawing.Size(67, 30);
            this.btn_BuscarBusquedaAvanzada.TabIndex = 68;
            this.btn_BuscarBusquedaAvanzada.Text = "Buscar";
            this.btn_BuscarBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btn_BuscarBusquedaAvanzada.Click += new System.EventHandler(this.btn_BuscarBusquedaAvanzada_Click);
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
            // rbtn_pendiente
            // 
            this.rbtn_pendiente.AutoSize = true;
            this.rbtn_pendiente.Enabled = false;
            this.rbtn_pendiente.Location = new System.Drawing.Point(99, 377);
            this.rbtn_pendiente.Name = "rbtn_pendiente";
            this.rbtn_pendiente.Size = new System.Drawing.Size(73, 17);
            this.rbtn_pendiente.TabIndex = 12;
            this.rbtn_pendiente.TabStop = true;
            this.rbtn_pendiente.Text = "Pendiente";
            this.rbtn_pendiente.UseVisualStyleBackColor = true;
            // 
            // rbtn_entregado
            // 
            this.rbtn_entregado.AutoSize = true;
            this.rbtn_entregado.Enabled = false;
            this.rbtn_entregado.Location = new System.Drawing.Point(175, 377);
            this.rbtn_entregado.Name = "rbtn_entregado";
            this.rbtn_entregado.Size = new System.Drawing.Size(74, 17);
            this.rbtn_entregado.TabIndex = 11;
            this.rbtn_entregado.TabStop = true;
            this.rbtn_entregado.Text = "Entregado";
            this.rbtn_entregado.UseVisualStyleBackColor = true;
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
            // lbl_busquedaPrecioDesde
            // 
            this.lbl_busquedaPrecioDesde.AutoSize = true;
            this.lbl_busquedaPrecioDesde.Location = new System.Drawing.Point(111, 164);
            this.lbl_busquedaPrecioDesde.Name = "lbl_busquedaPrecioDesde";
            this.lbl_busquedaPrecioDesde.Size = new System.Drawing.Size(41, 13);
            this.lbl_busquedaPrecioDesde.TabIndex = 7;
            this.lbl_busquedaPrecioDesde.Text = "Desde:";
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
            // lbl_busquedaAvSeleccionTipo
            // 
            this.lbl_busquedaAvSeleccionTipo.AutoSize = true;
            this.lbl_busquedaAvSeleccionTipo.Location = new System.Drawing.Point(86, 64);
            this.lbl_busquedaAvSeleccionTipo.Name = "lbl_busquedaAvSeleccionTipo";
            this.lbl_busquedaAvSeleccionTipo.Size = new System.Drawing.Size(66, 13);
            this.lbl_busquedaAvSeleccionTipo.TabIndex = 2;
            this.lbl_busquedaAvSeleccionTipo.Text = "Seleccionar:";
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
            // btn_busquedaAvanzadaProducto
            // 
            this.btn_busquedaAvanzadaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedaAvanzadaProducto.Location = new System.Drawing.Point(513, 41);
            this.btn_busquedaAvanzadaProducto.Name = "btn_busquedaAvanzadaProducto";
            this.btn_busquedaAvanzadaProducto.Size = new System.Drawing.Size(146, 30);
            this.btn_busquedaAvanzadaProducto.TabIndex = 82;
            this.btn_busquedaAvanzadaProducto.Text = "Busqueda avanzada";
            this.btn_busquedaAvanzadaProducto.UseVisualStyleBackColor = true;
            this.btn_busquedaAvanzadaProducto.Click += new System.EventHandler(this.btn_busquedaAvanzadaPedido_Click);
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarProducto.Location = new System.Drawing.Point(440, 41);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(67, 30);
            this.btn_buscarProducto.TabIndex = 81;
            this.btn_buscarProducto.Text = "Buscar";
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            // 
            // txt_busquedaProducto
            // 
            this.txt_busquedaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaProducto.Location = new System.Drawing.Point(159, 45);
            this.txt_busquedaProducto.Name = "txt_busquedaProducto";
            this.txt_busquedaProducto.Size = new System.Drawing.Size(260, 22);
            this.txt_busquedaProducto.TabIndex = 80;
            // 
            // lbl_buscarProducto
            // 
            this.lbl_buscarProducto.AutoSize = true;
            this.lbl_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscarProducto.Location = new System.Drawing.Point(100, 48);
            this.lbl_buscarProducto.Name = "lbl_buscarProducto";
            this.lbl_buscarProducto.Size = new System.Drawing.Size(53, 16);
            this.lbl_buscarProducto.TabIndex = 79;
            this.lbl_buscarProducto.Text = "Buscar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(231, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "Búsqueda por ID";
            // 
            // cbx_estado
            // 
            this.cbx_estado.AutoSize = true;
            this.cbx_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado.Location = new System.Drawing.Point(17, 353);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(74, 19);
            this.cbx_estado.TabIndex = 84;
            this.cbx_estado.Text = "Estado:";
            this.cbx_estado.UseVisualStyleBackColor = true;
            this.cbx_estado.CheckedChanged += new System.EventHandler(this.cbx_estado_CheckedChanged);
            // 
            // dtp_hasta_fechaEntrega
            // 
            this.dtp_hasta_fechaEntrega._campo = "fecha_entrega";
            this.dtp_hasta_fechaEntrega._mensaje_error = "Necesita ingresar una fecha de entrega";
            this.dtp_hasta_fechaEntrega._nombre_tabla = "pedido";
            this.dtp_hasta_fechaEntrega._validable = true;
            this.dtp_hasta_fechaEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtp_hasta_fechaEntrega.Enabled = false;
            this.dtp_hasta_fechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hasta_fechaEntrega.Location = new System.Drawing.Point(174, 336);
            this.dtp_hasta_fechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_hasta_fechaEntrega.Name = "dtp_hasta_fechaEntrega";
            this.dtp_hasta_fechaEntrega.Size = new System.Drawing.Size(168, 20);
            this.dtp_hasta_fechaEntrega.TabIndex = 84;
            // 
            // dtp_desde_fechaEntrega
            // 
            this.dtp_desde_fechaEntrega._campo = "fecha_entrega";
            this.dtp_desde_fechaEntrega._mensaje_error = "Necesita ingresar una fecha de entrega";
            this.dtp_desde_fechaEntrega._nombre_tabla = "pedido";
            this.dtp_desde_fechaEntrega._validable = true;
            this.dtp_desde_fechaEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtp_desde_fechaEntrega.Enabled = false;
            this.dtp_desde_fechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_desde_fechaEntrega.Location = new System.Drawing.Point(174, 305);
            this.dtp_desde_fechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_desde_fechaEntrega.Name = "dtp_desde_fechaEntrega";
            this.dtp_desde_fechaEntrega.Size = new System.Drawing.Size(168, 20);
            this.dtp_desde_fechaEntrega.TabIndex = 85;
            // 
            // dtp_hasta_fechaSolicitud
            // 
            this.dtp_hasta_fechaSolicitud._campo = "fecha_solicitud";
            this.dtp_hasta_fechaSolicitud._mensaje_error = "Necesita ingresar una fecha de solicitud";
            this.dtp_hasta_fechaSolicitud._nombre_tabla = "pedido";
            this.dtp_hasta_fechaSolicitud._validable = true;
            this.dtp_hasta_fechaSolicitud.CustomFormat = "dd/MM/yyyy";
            this.dtp_hasta_fechaSolicitud.Enabled = false;
            this.dtp_hasta_fechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_hasta_fechaSolicitud.Location = new System.Drawing.Point(173, 258);
            this.dtp_hasta_fechaSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_hasta_fechaSolicitud.Name = "dtp_hasta_fechaSolicitud";
            this.dtp_hasta_fechaSolicitud.Size = new System.Drawing.Size(168, 20);
            this.dtp_hasta_fechaSolicitud.TabIndex = 84;
            // 
            // dtp_desde_fechaSolicitud
            // 
            this.dtp_desde_fechaSolicitud._campo = "fecha_solicitud";
            this.dtp_desde_fechaSolicitud._mensaje_error = "Necesita ingresar una fecha de solicitud";
            this.dtp_desde_fechaSolicitud._nombre_tabla = "pedido";
            this.dtp_desde_fechaSolicitud._validable = true;
            this.dtp_desde_fechaSolicitud.CustomFormat = "dd/MM/yyyy";
            this.dtp_desde_fechaSolicitud.Enabled = false;
            this.dtp_desde_fechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_desde_fechaSolicitud.Location = new System.Drawing.Point(173, 230);
            this.dtp_desde_fechaSolicitud.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_desde_fechaSolicitud.Name = "dtp_desde_fechaSolicitud";
            this.dtp_desde_fechaSolicitud.Size = new System.Drawing.Size(168, 20);
            this.dtp_desde_fechaSolicitud.TabIndex = 16;
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
            // dt_fechaSolicitada
            // 
            this.dt_fechaSolicitada._campo = "fecha_solicitud";
            this.dt_fechaSolicitada._mensaje_error = "Necesita ingresar una Fecha Solicitada";
            this.dt_fechaSolicitada._nombre_tabla = "pedido";
            this.dt_fechaSolicitada._validable = true;
            this.dt_fechaSolicitada.CustomFormat = "yyyy/MM/dd";
            this.dt_fechaSolicitada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_fechaSolicitada.Location = new System.Drawing.Point(96, 104);
            this.dt_fechaSolicitada.Margin = new System.Windows.Forms.Padding(2);
            this.dt_fechaSolicitada.Name = "dt_fechaSolicitada";
            this.dt_fechaSolicitada.Size = new System.Drawing.Size(97, 20);
            this.dt_fechaSolicitada.TabIndex = 15;
            // 
            // txt_legajoVendedor
            // 
            this.txt_legajoVendedor._campo = "id_vendedor";
            this.txt_legajoVendedor._mensaje_error = "Error";
            this.txt_legajoVendedor._nombre_tabla = "pedido";
            this.txt_legajoVendedor._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_legajoVendedor._validable = false;
            this.txt_legajoVendedor.Enabled = false;
            this.txt_legajoVendedor.Location = new System.Drawing.Point(90, 70);
            this.txt_legajoVendedor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_legajoVendedor.Name = "txt_legajoVendedor";
            this.txt_legajoVendedor.Size = new System.Drawing.Size(193, 20);
            this.txt_legajoVendedor.TabIndex = 14;
            // 
            // cmb_franquicia
            // 
            this.cmb_franquicia._campo = "id_franquicia";
            this.cmb_franquicia._mensaje_error = "Necesita seleccionar una Franquicia";
            this.cmb_franquicia._nombre_tabla = "pedido";
            this.cmb_franquicia._validable = true;
            this.cmb_franquicia.FormattingEnabled = true;
            this.cmb_franquicia.Location = new System.Drawing.Point(90, 38);
            this.cmb_franquicia.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_franquicia.Name = "cmb_franquicia";
            this.cmb_franquicia.Size = new System.Drawing.Size(193, 21);
            this.cmb_franquicia.TabIndex = 9;
            this.cmb_franquicia.SelectedIndexChanged += new System.EventHandler(this.cmb_franquicia_SelectedIndexChanged);
            this.cmb_franquicia.Click += new System.EventHandler(this.cmb_franquicia_Click);
            // 
            // uc_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_busquedaAvanzadaProducto);
            this.Controls.Add(this.btn_buscarProducto);
            this.Controls.Add(this.txt_busquedaProducto);
            this.Controls.Add(this.lbl_buscarProducto);
            this.Controls.Add(this.grp_busquedaAvanzadaPedido);
            this.Controls.Add(this.grp_modificar);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.dgv_detallePedido);
            this.Controls.Add(this.dgv_pedidos);
            this.Controls.Add(this.grp_crearPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_Pedido";
            this.Size = new System.Drawing.Size(1012, 634);
            this.Load += new System.EventHandler(this.uc_Pedido_Load);
            this.grp_crearPedido.ResumeLayout(false);
            this.grp_crearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
            this.grp_modificar.ResumeLayout(false);
            this.grp_modificar.PerformLayout();
            this.grp_busquedaAvanzadaPedido.ResumeLayout(false);
            this.grp_busquedaAvanzadaPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private clases.ComboBoxPersonal cmb_franquicia;
        private System.Windows.Forms.Button btn_addPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grp_crearPedido;
        private clases.TextBoxPersonal txt_legajoVendedor;
        private System.Windows.Forms.Label label9;
        private clases.DateTimePickerPersonal dt_fechaSolicitada;
        private System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.DataGridView dgv_detallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.Label label_error;
        private System.Windows.Forms.GroupBox grp_modificar;
        private System.Windows.Forms.Button btn_modificarEstado;
        private clases.ComboBoxPersonal cmb_estadoPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.GroupBox grp_busquedaAvanzadaPedido;
        private clases.ComboBoxPersonal cmb_vendedores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbx_vendedor;
        private System.Windows.Forms.Label lbl_msjErrorBusquedaAv;
        private System.Windows.Forms.Button btn_BuscarBusquedaAvanzada;
        private System.Windows.Forms.Button btn_cerrarBusquedaAvanzada;
        private System.Windows.Forms.RadioButton rbtn_pendiente;
        private System.Windows.Forms.RadioButton rbtn_entregado;
        private System.Windows.Forms.Label lbl_busquedaPrecioHasta;
        private System.Windows.Forms.Label lbl_busquedaPrecioDesde;
        private clases.TextBoxPersonal txt_hasta_monto;
        private clases.TextBoxPersonal txt_desde_monto;
        private System.Windows.Forms.CheckBox cbx_monto;
        private clases.ComboBoxPersonal cmb_franquicias;
        private System.Windows.Forms.Label lbl_busquedaAvSeleccionTipo;
        private System.Windows.Forms.CheckBox cbx_franquicia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbx_fechaEntrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbx_fechaSolicitud;
        private System.Windows.Forms.RadioButton rbtn_cancelado;
        private System.Windows.Forms.Button btn_busquedaAvanzadaProducto;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.TextBox txt_busquedaProducto;
        private System.Windows.Forms.Label lbl_buscarProducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbx_estado;
        private clases.DateTimePickerPersonal dtp_desde_fechaSolicitud;
        private clases.DateTimePickerPersonal dtp_hasta_fechaEntrega;
        private clases.DateTimePickerPersonal dtp_desde_fechaEntrega;
        private clases.DateTimePickerPersonal dtp_hasta_fechaSolicitud;
    }
}
