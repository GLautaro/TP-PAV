﻿namespace TP_PAV.formularios
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_addProductoPedido = new System.Windows.Forms.Button();
            this.grp_crearPedido = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_pedidos = new System.Windows.Forms.DataGridView();
            this.dgv_detallePedido = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cantidad = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_tipoProducto = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.cmb_Producto = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.dt_fechaSolicitada = new TP_PAV.clases.DateTimePickerPersonal(this.components);
            this.txt_legajoVendedor = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_franquicia = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_crearPedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pedidos Pendientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalle Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Franquicia:";
            // 
            // btn_addPedido
            // 
            this.btn_addPedido.Location = new System.Drawing.Point(252, 190);
            this.btn_addPedido.Name = "btn_addPedido";
            this.btn_addPedido.Size = new System.Drawing.Size(124, 35);
            this.btn_addPedido.TabIndex = 10;
            this.btn_addPedido.Text = "Crear Pedido";
            this.btn_addPedido.UseVisualStyleBackColor = true;
            this.btn_addPedido.Click += new System.EventHandler(this.btn_addPedido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Solicitada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad:";
            // 
            // btn_addProductoPedido
            // 
            this.btn_addProductoPedido.Location = new System.Drawing.Point(197, 188);
            this.btn_addProductoPedido.Name = "btn_addProductoPedido";
            this.btn_addProductoPedido.Size = new System.Drawing.Size(150, 35);
            this.btn_addProductoPedido.TabIndex = 19;
            this.btn_addProductoPedido.Text = "Agregar Producto";
            this.btn_addProductoPedido.UseVisualStyleBackColor = true;
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
            this.grp_crearPedido.Location = new System.Drawing.Point(823, 163);
            this.grp_crearPedido.Name = "grp_crearPedido";
            this.grp_crearPedido.Size = new System.Drawing.Size(382, 231);
            this.grp_crearPedido.TabIndex = 20;
            this.grp_crearPedido.TabStop = false;
            this.grp_crearPedido.Text = "Crear Pedido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Legajo Vendedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addProductoPedido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.cmb_tipoProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_Producto);
            this.groupBox1.Location = new System.Drawing.Point(823, 472);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 247);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Productos al Pedido";
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
            this.monto_final});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pedidos.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.Location = new System.Drawing.Point(57, 155);
            this.dgv_pedidos.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgv_pedidos.Size = new System.Drawing.Size(748, 272);
            this.dgv_pedidos.TabIndex = 52;
            this.dgv_pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pedidos_CellClick);
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
            this.dgv_detallePedido.Location = new System.Drawing.Point(57, 473);
            this.dgv_detallePedido.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgv_detallePedido.Size = new System.Drawing.Size(748, 272);
            this.dgv_detallePedido.TabIndex = 53;
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
            // txt_cantidad
            // 
            this.txt_cantidad._campo = null;
            this.txt_cantidad._mensaje_error = null;
            this.txt_cantidad._nombre_tabla = null;
            this.txt_cantidad._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.texto;
            this.txt_cantidad._validable = false;
            this.txt_cantidad.Location = new System.Drawing.Point(147, 134);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(200, 22);
            this.txt_cantidad.TabIndex = 18;
            // 
            // cmb_tipoProducto
            // 
            this.cmb_tipoProducto._campo = "cmb_tipoProducto";
            this.cmb_tipoProducto._mensaje_error = "Necesita seleccionar un tipo de Producto";
            this.cmb_tipoProducto._nombre_tabla = null;
            this.cmb_tipoProducto._validable = false;
            this.cmb_tipoProducto.FormattingEnabled = true;
            this.cmb_tipoProducto.Location = new System.Drawing.Point(147, 33);
            this.cmb_tipoProducto.Name = "cmb_tipoProducto";
            this.cmb_tipoProducto.Size = new System.Drawing.Size(200, 24);
            this.cmb_tipoProducto.TabIndex = 15;
            // 
            // cmb_Producto
            // 
            this.cmb_Producto._campo = null;
            this.cmb_Producto._mensaje_error = null;
            this.cmb_Producto._nombre_tabla = null;
            this.cmb_Producto._validable = false;
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(147, 81);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Size = new System.Drawing.Size(200, 24);
            this.cmb_Producto.TabIndex = 16;
            // 
            // dt_fechaSolicitada
            // 
            this.dt_fechaSolicitada._campo = "fecha_solicitud";
            this.dt_fechaSolicitada._mensaje_error = "Necesita ingresar una Fecha Solicitada";
            this.dt_fechaSolicitada._nombre_tabla = "pedido";
            this.dt_fechaSolicitada._validable = true;
            this.dt_fechaSolicitada.CustomFormat = "yyyy/MM/dd";
            this.dt_fechaSolicitada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_fechaSolicitada.Location = new System.Drawing.Point(128, 128);
            this.dt_fechaSolicitada.Name = "dt_fechaSolicitada";
            this.dt_fechaSolicitada.Size = new System.Drawing.Size(128, 22);
            this.dt_fechaSolicitada.TabIndex = 15;
            // 
            // txt_legajoVendedor
            // 
            this.txt_legajoVendedor._campo = "id_vendedor";
            this.txt_legajoVendedor._mensaje_error = null;
            this.txt_legajoVendedor._nombre_tabla = "pedido";
            this.txt_legajoVendedor._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.texto;
            this.txt_legajoVendedor._validable = false;
            this.txt_legajoVendedor.Enabled = false;
            this.txt_legajoVendedor.Location = new System.Drawing.Point(120, 86);
            this.txt_legajoVendedor.Name = "txt_legajoVendedor";
            this.txt_legajoVendedor.Size = new System.Drawing.Size(256, 22);
            this.txt_legajoVendedor.TabIndex = 14;
            // 
            // cmb_franquicia
            // 
            this.cmb_franquicia._campo = "id_franquicia";
            this.cmb_franquicia._mensaje_error = "Necesita seleccionar una Franquicia";
            this.cmb_franquicia._nombre_tabla = "pedido";
            this.cmb_franquicia._validable = true;
            this.cmb_franquicia.FormattingEnabled = true;
            this.cmb_franquicia.Location = new System.Drawing.Point(120, 47);
            this.cmb_franquicia.Name = "cmb_franquicia";
            this.cmb_franquicia.Size = new System.Drawing.Size(256, 24);
            this.cmb_franquicia.TabIndex = 9;
            this.cmb_franquicia.SelectedIndexChanged += new System.EventHandler(this.cmb_franquicia_SelectedIndexChanged);
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
            // uc_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_detallePedido);
            this.Controls.Add(this.dgv_pedidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_crearPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uc_Pedido";
            this.Size = new System.Drawing.Size(1223, 780);
            this.Load += new System.EventHandler(this.uc_Pedido_Load);
            this.grp_crearPedido.ResumeLayout(false);
            this.grp_crearPedido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private clases.ComboBoxPersonal cmb_tipoProducto;
        private clases.ComboBoxPersonal cmb_Producto;
        private System.Windows.Forms.Label label8;
        private clases.TextBoxPersonal txt_cantidad;
        private System.Windows.Forms.Button btn_addProductoPedido;
        private System.Windows.Forms.GroupBox grp_crearPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private clases.TextBoxPersonal txt_legajoVendedor;
        private System.Windows.Forms.Label label9;
        private clases.DateTimePickerPersonal dt_fechaSolicitada;
        private System.Windows.Forms.DataGridView dgv_pedidos;
        private System.Windows.Forms.DataGridView dgv_detallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}