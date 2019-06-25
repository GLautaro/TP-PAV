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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_productosPendientes = new System.Windows.Forms.Button();
            this.cmb_estadoPedido = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.dt_fechaSolicitada = new TP_PAV.clases.DateTimePickerPersonal(this.components);
            this.txt_legajoVendedor = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_franquicia = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.grp_crearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
            this.grp_modificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pedidos Pendientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalle Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nro Franquicia:";
            // 
            // btn_addPedido
            // 
            this.btn_addPedido.Location = new System.Drawing.Point(252, 190);
            this.btn_addPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addPedido.Name = "btn_addPedido";
            this.btn_addPedido.Size = new System.Drawing.Size(124, 34);
            this.btn_addPedido.TabIndex = 10;
            this.btn_addPedido.Text = "Crear Pedido";
            this.btn_addPedido.UseVisualStyleBackColor = true;
            this.btn_addPedido.Click += new System.EventHandler(this.btn_addPedido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
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
            this.grp_crearPedido.Location = new System.Drawing.Point(840, 231);
            this.grp_crearPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_crearPedido.Name = "grp_crearPedido";
            this.grp_crearPedido.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_crearPedido.Size = new System.Drawing.Size(381, 231);
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
            // dgv_pedidos
            // 
            this.dgv_pedidos.AllowUserToAddRows = false;
            this.dgv_pedidos.AllowUserToDeleteRows = false;
            this.dgv_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pedidos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pedidos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.Column3,
            this.Column4,
            this.Column2,
            this.monto_final,
            this.id_estado});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_pedidos.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv_pedidos.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_pedidos.Location = new System.Drawing.Point(57, 148);
            this.dgv_pedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pedidos.MultiSelect = false;
            this.dgv_pedidos.Name = "dgv_pedidos";
            this.dgv_pedidos.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv_pedidos.RowHeadersVisible = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_pedidos.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pedidos.Size = new System.Drawing.Size(748, 272);
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv_detallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detallePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detallePedido.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_detallePedido.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_detallePedido.Location = new System.Drawing.Point(57, 466);
            this.dgv_detallePedido.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_detallePedido.MultiSelect = false;
            this.dgv_detallePedido.Name = "dgv_detallePedido";
            this.dgv_detallePedido.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detallePedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_detallePedido.RowHeadersVisible = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_detallePedido.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_detallePedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detallePedido.Size = new System.Drawing.Size(748, 225);
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
            this.label_error.Location = new System.Drawing.Point(836, 198);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 20);
            this.label_error.TabIndex = 54;
            // 
            // grp_modificar
            // 
            this.grp_modificar.Controls.Add(this.btn_modificarEstado);
            this.grp_modificar.Controls.Add(this.cmb_estadoPedido);
            this.grp_modificar.Controls.Add(this.label6);
            this.grp_modificar.Location = new System.Drawing.Point(844, 481);
            this.grp_modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_modificar.Name = "grp_modificar";
            this.grp_modificar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_modificar.Size = new System.Drawing.Size(379, 204);
            this.grp_modificar.TabIndex = 55;
            this.grp_modificar.TabStop = false;
            this.grp_modificar.Text = "Modificar estado pedido";
            // 
            // btn_modificarEstado
            // 
            this.btn_modificarEstado.Location = new System.Drawing.Point(232, 97);
            this.btn_modificarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificarEstado.Name = "btn_modificarEstado";
            this.btn_modificarEstado.Size = new System.Drawing.Size(124, 34);
            this.btn_modificarEstado.TabIndex = 16;
            this.btn_modificarEstado.Text = "Cambiar Estado";
            this.btn_modificarEstado.UseVisualStyleBackColor = true;
            this.btn_modificarEstado.Click += new System.EventHandler(this.btn_modificarEstado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado Pedido:";
            // 
            // btn_productosPendientes
            // 
            this.btn_productosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productosPendientes.Location = new System.Drawing.Point(880, 148);
            this.btn_productosPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_productosPendientes.Name = "btn_productosPendientes";
            this.btn_productosPendientes.Size = new System.Drawing.Size(255, 34);
            this.btn_productosPendientes.TabIndex = 56;
            this.btn_productosPendientes.Text = "Ver productos pendientes";
            this.btn_productosPendientes.UseVisualStyleBackColor = true;
            this.btn_productosPendientes.Click += new System.EventHandler(this.btn_productosPendientes_Click);
            // 
            // cmb_estadoPedido
            // 
            this.cmb_estadoPedido._campo = null;
            this.cmb_estadoPedido._mensaje_error = "Necesita seleccionar un estado para el pedido";
            this.cmb_estadoPedido._nombre_tabla = null;
            this.cmb_estadoPedido._validable = true;
            this.cmb_estadoPedido.FormattingEnabled = true;
            this.cmb_estadoPedido.Location = new System.Drawing.Point(116, 34);
            this.cmb_estadoPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_estadoPedido.Name = "cmb_estadoPedido";
            this.cmb_estadoPedido.Size = new System.Drawing.Size(240, 24);
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
            this.dt_fechaSolicitada.Location = new System.Drawing.Point(128, 128);
            this.dt_fechaSolicitada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_fechaSolicitada.Name = "dt_fechaSolicitada";
            this.dt_fechaSolicitada.Size = new System.Drawing.Size(128, 22);
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
            this.txt_legajoVendedor.Location = new System.Drawing.Point(120, 86);
            this.txt_legajoVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cmb_franquicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_franquicia.Name = "cmb_franquicia";
            this.cmb_franquicia.Size = new System.Drawing.Size(256, 24);
            this.cmb_franquicia.TabIndex = 9;
            this.cmb_franquicia.SelectedIndexChanged += new System.EventHandler(this.cmb_franquicia_SelectedIndexChanged);
            this.cmb_franquicia.Click += new System.EventHandler(this.cmb_franquicia_Click);
            // 
            // uc_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_productosPendientes);
            this.Controls.Add(this.grp_modificar);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.dgv_detallePedido);
            this.Controls.Add(this.dgv_pedidos);
            this.Controls.Add(this.grp_crearPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_Pedido";
            this.Size = new System.Drawing.Size(1349, 780);
            this.Load += new System.EventHandler(this.uc_Pedido_Load);
            this.grp_crearPedido.ResumeLayout(false);
            this.grp_crearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
            this.grp_modificar.ResumeLayout(false);
            this.grp_modificar.PerformLayout();
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
        private System.Windows.Forms.Button btn_productosPendientes;
    }
}
