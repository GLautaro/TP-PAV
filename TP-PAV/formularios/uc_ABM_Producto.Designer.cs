namespace TP_PAV.formularios
{
    partial class uc_ABM_Producto
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
            this.lbl_IdProducto = new System.Windows.Forms.Label();
            this.lbl_NomProducto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_unidadMedida = new System.Windows.Forms.Label();
            this.lbl_estadoProducto = new System.Windows.Forms.Label();
            this.btn_agregarUdeMedida = new System.Windows.Forms.Button();
            this.btn_agregarTipo = new System.Windows.Forms.Button();
            this.btn_cancelarModProducto = new System.Windows.Forms.Button();
            this.lbl_tipoProducto = new System.Windows.Forms.Label();
            this.btn_guardarModProducto = new System.Windows.Forms.Button();
            this.btn_busquedaAvanzadaProducto = new System.Windows.Forms.Button();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.txt_busquedaProducto = new System.Windows.Forms.TextBox();
            this.lbl_buscarProducto = new System.Windows.Forms.Label();
            this.btn_registrarProducto = new System.Windows.Forms.Button();
            this.btn_modificarProducto = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilitado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_mensajeError = new System.Windows.Forms.Label();
            this.grp_busquedaAvanzadaProducto = new System.Windows.Forms.GroupBox();
            this.lbl_msjErrorBusquedaAv = new System.Windows.Forms.Label();
            this.btn_BuscarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btn_cerrarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.rbtn_habilitado = new System.Windows.Forms.RadioButton();
            this.rbtn_deshabilitado = new System.Windows.Forms.RadioButton();
            this.rbtn_cualquiera = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_busquedaPrecioHasta = new System.Windows.Forms.Label();
            this.lbl_busquedaPrecioDesde = new System.Windows.Forms.Label();
            this.txt_busquedaPrecioHasta = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_busquedaPrecioDesde = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cbx_busquedaAvanzPrecio = new System.Windows.Forms.CheckBox();
            this.cmb_busquedaSeleccionTipo = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.lbl_busquedaAvSeleccionTipo = new System.Windows.Forms.Label();
            this.cbx_tipoProducto = new System.Windows.Forms.CheckBox();
            this.btn_activarDesactivar = new System.Windows.Forms.Button();
            this.cmb_estadoProducto = new TP_PAV.clases.ComboBoxHabilitado(this.components);
            this.txt_precioUnitario = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_tipoProducto = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.txt_descripcionProducto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_unidadMedida = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.txt_cantidadProducto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_NombreProducto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_IdProducto = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.titulo_estadisticas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.grp_busquedaAvanzadaProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_IdProducto
            // 
            this.lbl_IdProducto.AutoSize = true;
            this.lbl_IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdProducto.Location = new System.Drawing.Point(770, 121);
            this.lbl_IdProducto.Name = "lbl_IdProducto";
            this.lbl_IdProducto.Size = new System.Drawing.Size(78, 16);
            this.lbl_IdProducto.TabIndex = 2;
            this.lbl_IdProducto.Text = "ID Producto";
            // 
            // lbl_NomProducto
            // 
            this.lbl_NomProducto.AutoSize = true;
            this.lbl_NomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomProducto.Location = new System.Drawing.Point(770, 166);
            this.lbl_NomProducto.Name = "lbl_NomProducto";
            this.lbl_NomProducto.Size = new System.Drawing.Size(133, 16);
            this.lbl_NomProducto.TabIndex = 3;
            this.lbl_NomProducto.Text = "Nombre de Producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(770, 211);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(62, 16);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioUnitario.Location = new System.Drawing.Point(770, 391);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(96, 16);
            this.lbl_precioUnitario.TabIndex = 5;
            this.lbl_precioUnitario.Text = "Precio Unitario";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(770, 301);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(80, 16);
            this.lbl_descripcion.TabIndex = 6;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_unidadMedida
            // 
            this.lbl_unidadMedida.AutoSize = true;
            this.lbl_unidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidadMedida.Location = new System.Drawing.Point(770, 256);
            this.lbl_unidadMedida.Name = "lbl_unidadMedida";
            this.lbl_unidadMedida.Size = new System.Drawing.Size(120, 16);
            this.lbl_unidadMedida.TabIndex = 7;
            this.lbl_unidadMedida.Text = "Unidad de Medida";
            // 
            // lbl_estadoProducto
            // 
            this.lbl_estadoProducto.AutoSize = true;
            this.lbl_estadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoProducto.Location = new System.Drawing.Point(770, 436);
            this.lbl_estadoProducto.Name = "lbl_estadoProducto";
            this.lbl_estadoProducto.Size = new System.Drawing.Size(130, 16);
            this.lbl_estadoProducto.TabIndex = 8;
            this.lbl_estadoProducto.Text = "Estado del Producto";
            // 
            // btn_agregarUdeMedida
            // 
            this.btn_agregarUdeMedida.Enabled = false;
            this.btn_agregarUdeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarUdeMedida.Location = new System.Drawing.Point(1140, 251);
            this.btn_agregarUdeMedida.Name = "btn_agregarUdeMedida";
            this.btn_agregarUdeMedida.Size = new System.Drawing.Size(33, 26);
            this.btn_agregarUdeMedida.TabIndex = 16;
            this.btn_agregarUdeMedida.Text = "+";
            this.btn_agregarUdeMedida.UseVisualStyleBackColor = true;
            this.btn_agregarUdeMedida.Click += new System.EventHandler(this.btn_agregarUdeMedida_Click);
            // 
            // btn_agregarTipo
            // 
            this.btn_agregarTipo.Enabled = false;
            this.btn_agregarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarTipo.Location = new System.Drawing.Point(1140, 340);
            this.btn_agregarTipo.Name = "btn_agregarTipo";
            this.btn_agregarTipo.Size = new System.Drawing.Size(33, 26);
            this.btn_agregarTipo.TabIndex = 17;
            this.btn_agregarTipo.Text = "+";
            this.btn_agregarTipo.UseVisualStyleBackColor = true;
            this.btn_agregarTipo.Click += new System.EventHandler(this.btn_agregarTipo_Click);
            // 
            // btn_cancelarModProducto
            // 
            this.btn_cancelarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarModProducto.Location = new System.Drawing.Point(978, 489);
            this.btn_cancelarModProducto.Name = "btn_cancelarModProducto";
            this.btn_cancelarModProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_cancelarModProducto.TabIndex = 50;
            this.btn_cancelarModProducto.Text = "Cancelar Modificaciones";
            this.btn_cancelarModProducto.UseVisualStyleBackColor = true;
            this.btn_cancelarModProducto.Visible = false;
            this.btn_cancelarModProducto.Click += new System.EventHandler(this.btn_cancelarModProducto_Click);
            // 
            // lbl_tipoProducto
            // 
            this.lbl_tipoProducto.AutoSize = true;
            this.lbl_tipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoProducto.Location = new System.Drawing.Point(770, 346);
            this.lbl_tipoProducto.Name = "lbl_tipoProducto";
            this.lbl_tipoProducto.Size = new System.Drawing.Size(112, 16);
            this.lbl_tipoProducto.TabIndex = 58;
            this.lbl_tipoProducto.Text = "Tipo de Producto";
            // 
            // btn_guardarModProducto
            // 
            this.btn_guardarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarModProducto.Location = new System.Drawing.Point(773, 489);
            this.btn_guardarModProducto.Name = "btn_guardarModProducto";
            this.btn_guardarModProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_guardarModProducto.TabIndex = 49;
            this.btn_guardarModProducto.Text = "Guardar Modificaciones";
            this.btn_guardarModProducto.UseVisualStyleBackColor = true;
            this.btn_guardarModProducto.Visible = false;
            this.btn_guardarModProducto.Click += new System.EventHandler(this.btn_guardarModProducto_Click);
            // 
            // btn_busquedaAvanzadaProducto
            // 
            this.btn_busquedaAvanzadaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedaAvanzadaProducto.Location = new System.Drawing.Point(507, 56);
            this.btn_busquedaAvanzadaProducto.Name = "btn_busquedaAvanzadaProducto";
            this.btn_busquedaAvanzadaProducto.Size = new System.Drawing.Size(146, 30);
            this.btn_busquedaAvanzadaProducto.TabIndex = 65;
            this.btn_busquedaAvanzadaProducto.Text = "Busqueda avanzada";
            this.btn_busquedaAvanzadaProducto.UseVisualStyleBackColor = true;
            this.btn_busquedaAvanzadaProducto.Click += new System.EventHandler(this.btn_busquedaAvanzadaProducto_Click);
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarProducto.Location = new System.Drawing.Point(414, 56);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(67, 30);
            this.btn_buscarProducto.TabIndex = 64;
            this.btn_buscarProducto.Text = "Buscar";
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            this.btn_buscarProducto.Click += new System.EventHandler(this.btn_buscarProducto_Click);
            // 
            // txt_busquedaProducto
            // 
            this.txt_busquedaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaProducto.Location = new System.Drawing.Point(133, 60);
            this.txt_busquedaProducto.Name = "txt_busquedaProducto";
            this.txt_busquedaProducto.Size = new System.Drawing.Size(260, 22);
            this.txt_busquedaProducto.TabIndex = 63;
            this.txt_busquedaProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busquedaProducto_KeyUp);
            // 
            // lbl_buscarProducto
            // 
            this.lbl_buscarProducto.AutoSize = true;
            this.lbl_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscarProducto.Location = new System.Drawing.Point(10, 61);
            this.lbl_buscarProducto.Name = "lbl_buscarProducto";
            this.lbl_buscarProducto.Size = new System.Drawing.Size(116, 32);
            this.lbl_buscarProducto.TabIndex = 62;
            this.lbl_buscarProducto.Text = "                     Buscar:\r\n(Por ID o Nombre)";
            // 
            // btn_registrarProducto
            // 
            this.btn_registrarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarProducto.Location = new System.Drawing.Point(149, 121);
            this.btn_registrarProducto.Name = "btn_registrarProducto";
            this.btn_registrarProducto.Size = new System.Drawing.Size(109, 49);
            this.btn_registrarProducto.TabIndex = 61;
            this.btn_registrarProducto.Text = "Nuevo Producto\r\n";
            this.btn_registrarProducto.UseVisualStyleBackColor = true;
            this.btn_registrarProducto.Click += new System.EventHandler(this.btn_registrarProducto_Click);
            // 
            // btn_modificarProducto
            // 
            this.btn_modificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarProducto.Location = new System.Drawing.Point(307, 121);
            this.btn_modificarProducto.Name = "btn_modificarProducto";
            this.btn_modificarProducto.Size = new System.Drawing.Size(109, 49);
            this.btn_modificarProducto.TabIndex = 60;
            this.btn_modificarProducto.Text = "Modificar";
            this.btn_modificarProducto.UseVisualStyleBackColor = true;
            this.btn_modificarProducto.Click += new System.EventHandler(this.btn_modificarProducto_Click);
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_producto,
            this.cantidad_u_medida,
            this.id_u_medida,
            this.nombre_u_medida,
            this.descripcion,
            this.id_tipo_producto,
            this.nombre_tipo_producto,
            this.precio_unitario,
            this.estado_producto,
            this.Habilitado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_productos.Location = new System.Drawing.Point(15, 200);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(700, 350);
            this.dgv_productos.TabIndex = 66;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.DataPropertyName = "nombre_producto";
            this.nombre_producto.HeaderText = "Nombre";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // cantidad_u_medida
            // 
            this.cantidad_u_medida.DataPropertyName = "cantidad_u_medida";
            this.cantidad_u_medida.HeaderText = "Cantidad";
            this.cantidad_u_medida.Name = "cantidad_u_medida";
            this.cantidad_u_medida.ReadOnly = true;
            // 
            // id_u_medida
            // 
            this.id_u_medida.DataPropertyName = "id_u_medida";
            this.id_u_medida.HeaderText = "Unidad de Medida";
            this.id_u_medida.Name = "id_u_medida";
            this.id_u_medida.ReadOnly = true;
            this.id_u_medida.Visible = false;
            // 
            // nombre_u_medida
            // 
            this.nombre_u_medida.DataPropertyName = "nombre_u_medida";
            this.nombre_u_medida.HeaderText = "Unidad de Medida";
            this.nombre_u_medida.Name = "nombre_u_medida";
            this.nombre_u_medida.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // id_tipo_producto
            // 
            this.id_tipo_producto.DataPropertyName = "id_tipo_producto";
            this.id_tipo_producto.HeaderText = "Tipo";
            this.id_tipo_producto.Name = "id_tipo_producto";
            this.id_tipo_producto.ReadOnly = true;
            this.id_tipo_producto.Visible = false;
            // 
            // nombre_tipo_producto
            // 
            this.nombre_tipo_producto.DataPropertyName = "nombre_tipo_producto";
            this.nombre_tipo_producto.HeaderText = "Tipo de Producto";
            this.nombre_tipo_producto.Name = "nombre_tipo_producto";
            this.nombre_tipo_producto.ReadOnly = true;
            // 
            // precio_unitario
            // 
            this.precio_unitario.DataPropertyName = "precio_unitario";
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            // 
            // estado_producto
            // 
            this.estado_producto.DataPropertyName = "estado_producto";
            this.estado_producto.HeaderText = "Estado ";
            this.estado_producto.Name = "estado_producto";
            this.estado_producto.ReadOnly = true;
            this.estado_producto.Visible = false;
            // 
            // Habilitado
            // 
            this.Habilitado.DataPropertyName = "estado_producto";
            this.Habilitado.HeaderText = "Habilitado";
            this.Habilitado.Name = "Habilitado";
            this.Habilitado.ReadOnly = true;
            this.Habilitado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Habilitado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbl_mensajeError
            // 
            this.lbl_mensajeError.AutoSize = true;
            this.lbl_mensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensajeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_mensajeError.Location = new System.Drawing.Point(770, 534);
            this.lbl_mensajeError.Name = "lbl_mensajeError";
            this.lbl_mensajeError.Size = new System.Drawing.Size(135, 16);
            this.lbl_mensajeError.TabIndex = 76;
            this.lbl_mensajeError.Text = "Mensajes de Error";
            this.lbl_mensajeError.Visible = false;
            // 
            // grp_busquedaAvanzadaProducto
            // 
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.lbl_msjErrorBusquedaAv);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.btn_BuscarBusquedaAvanzada);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.btn_cerrarBusquedaAvanzada);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.rbtn_habilitado);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.rbtn_deshabilitado);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.rbtn_cualquiera);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.label2);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.lbl_busquedaPrecioHasta);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.lbl_busquedaPrecioDesde);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.txt_busquedaPrecioHasta);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.txt_busquedaPrecioDesde);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.cbx_busquedaAvanzPrecio);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.cmb_busquedaSeleccionTipo);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.lbl_busquedaAvSeleccionTipo);
            this.grp_busquedaAvanzadaProducto.Controls.Add(this.cbx_tipoProducto);
            this.grp_busquedaAvanzadaProducto.Location = new System.Drawing.Point(773, 83);
            this.grp_busquedaAvanzadaProducto.Name = "grp_busquedaAvanzadaProducto";
            this.grp_busquedaAvanzadaProducto.Size = new System.Drawing.Size(400, 467);
            this.grp_busquedaAvanzadaProducto.TabIndex = 77;
            this.grp_busquedaAvanzadaProducto.TabStop = false;
            this.grp_busquedaAvanzadaProducto.Text = "Busqueda Avanzada | Productos";
            this.grp_busquedaAvanzadaProducto.Visible = false;
            // 
            // lbl_msjErrorBusquedaAv
            // 
            this.lbl_msjErrorBusquedaAv.AutoSize = true;
            this.lbl_msjErrorBusquedaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msjErrorBusquedaAv.ForeColor = System.Drawing.Color.Red;
            this.lbl_msjErrorBusquedaAv.Location = new System.Drawing.Point(35, 373);
            this.lbl_msjErrorBusquedaAv.Name = "lbl_msjErrorBusquedaAv";
            this.lbl_msjErrorBusquedaAv.Size = new System.Drawing.Size(135, 16);
            this.lbl_msjErrorBusquedaAv.TabIndex = 69;
            this.lbl_msjErrorBusquedaAv.Text = "Mensajes de Error";
            this.lbl_msjErrorBusquedaAv.Visible = false;
            // 
            // btn_BuscarBusquedaAvanzada
            // 
            this.btn_BuscarBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarBusquedaAvanzada.Location = new System.Drawing.Point(316, 421);
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
            this.btn_cerrarBusquedaAvanzada.Location = new System.Drawing.Point(227, 421);
            this.btn_cerrarBusquedaAvanzada.Name = "btn_cerrarBusquedaAvanzada";
            this.btn_cerrarBusquedaAvanzada.Size = new System.Drawing.Size(67, 30);
            this.btn_cerrarBusquedaAvanzada.TabIndex = 67;
            this.btn_cerrarBusquedaAvanzada.Text = "Cerrar";
            this.btn_cerrarBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btn_cerrarBusquedaAvanzada.Click += new System.EventHandler(this.btn_cerrarBusquedaAvanzada_Click);
            // 
            // rbtn_habilitado
            // 
            this.rbtn_habilitado.AutoSize = true;
            this.rbtn_habilitado.Location = new System.Drawing.Point(155, 306);
            this.rbtn_habilitado.Name = "rbtn_habilitado";
            this.rbtn_habilitado.Size = new System.Drawing.Size(72, 17);
            this.rbtn_habilitado.TabIndex = 12;
            this.rbtn_habilitado.TabStop = true;
            this.rbtn_habilitado.Text = "Habilitado";
            this.rbtn_habilitado.UseVisualStyleBackColor = true;
            // 
            // rbtn_deshabilitado
            // 
            this.rbtn_deshabilitado.AutoSize = true;
            this.rbtn_deshabilitado.Location = new System.Drawing.Point(274, 306);
            this.rbtn_deshabilitado.Name = "rbtn_deshabilitado";
            this.rbtn_deshabilitado.Size = new System.Drawing.Size(89, 17);
            this.rbtn_deshabilitado.TabIndex = 11;
            this.rbtn_deshabilitado.TabStop = true;
            this.rbtn_deshabilitado.Text = "No Habilitado";
            this.rbtn_deshabilitado.UseVisualStyleBackColor = true;
            // 
            // rbtn_cualquiera
            // 
            this.rbtn_cualquiera.AutoSize = true;
            this.rbtn_cualquiera.Location = new System.Drawing.Point(35, 306);
            this.rbtn_cualquiera.Name = "rbtn_cualquiera";
            this.rbtn_cualquiera.Size = new System.Drawing.Size(75, 17);
            this.rbtn_cualquiera.TabIndex = 10;
            this.rbtn_cualquiera.TabStop = true;
            this.rbtn_cualquiera.Text = "Cualquiera";
            this.rbtn_cualquiera.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estado:";
            // 
            // lbl_busquedaPrecioHasta
            // 
            this.lbl_busquedaPrecioHasta.AutoSize = true;
            this.lbl_busquedaPrecioHasta.Location = new System.Drawing.Point(107, 217);
            this.lbl_busquedaPrecioHasta.Name = "lbl_busquedaPrecioHasta";
            this.lbl_busquedaPrecioHasta.Size = new System.Drawing.Size(38, 13);
            this.lbl_busquedaPrecioHasta.TabIndex = 8;
            this.lbl_busquedaPrecioHasta.Text = "Hasta:";
            // 
            // lbl_busquedaPrecioDesde
            // 
            this.lbl_busquedaPrecioDesde.AutoSize = true;
            this.lbl_busquedaPrecioDesde.Location = new System.Drawing.Point(107, 172);
            this.lbl_busquedaPrecioDesde.Name = "lbl_busquedaPrecioDesde";
            this.lbl_busquedaPrecioDesde.Size = new System.Drawing.Size(41, 13);
            this.lbl_busquedaPrecioDesde.TabIndex = 7;
            this.lbl_busquedaPrecioDesde.Text = "Desde:";
            // 
            // txt_busquedaPrecioHasta
            // 
            this.txt_busquedaPrecioHasta._campo = "precio_unitario";
            this.txt_busquedaPrecioHasta._mensaje_error = null;
            this.txt_busquedaPrecioHasta._nombre_tabla = "producto";
            this.txt_busquedaPrecioHasta._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.texto;
            this.txt_busquedaPrecioHasta._validable = false;
            this.txt_busquedaPrecioHasta.Enabled = false;
            this.txt_busquedaPrecioHasta.Location = new System.Drawing.Point(170, 214);
            this.txt_busquedaPrecioHasta.Name = "txt_busquedaPrecioHasta";
            this.txt_busquedaPrecioHasta.Size = new System.Drawing.Size(167, 20);
            this.txt_busquedaPrecioHasta.TabIndex = 6;
            // 
            // txt_busquedaPrecioDesde
            // 
            this.txt_busquedaPrecioDesde._campo = "precio_unitario";
            this.txt_busquedaPrecioDesde._mensaje_error = null;
            this.txt_busquedaPrecioDesde._nombre_tabla = "producto";
            this.txt_busquedaPrecioDesde._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.texto;
            this.txt_busquedaPrecioDesde._validable = false;
            this.txt_busquedaPrecioDesde.Enabled = false;
            this.txt_busquedaPrecioDesde.Location = new System.Drawing.Point(170, 168);
            this.txt_busquedaPrecioDesde.Name = "txt_busquedaPrecioDesde";
            this.txt_busquedaPrecioDesde.Size = new System.Drawing.Size(167, 20);
            this.txt_busquedaPrecioDesde.TabIndex = 5;
            // 
            // cbx_busquedaAvanzPrecio
            // 
            this.cbx_busquedaAvanzPrecio.AutoSize = true;
            this.cbx_busquedaAvanzPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_busquedaAvanzPrecio.Location = new System.Drawing.Point(16, 129);
            this.cbx_busquedaAvanzPrecio.Name = "cbx_busquedaAvanzPrecio";
            this.cbx_busquedaAvanzPrecio.Size = new System.Drawing.Size(71, 19);
            this.cbx_busquedaAvanzPrecio.TabIndex = 4;
            this.cbx_busquedaAvanzPrecio.Text = "Precio:";
            this.cbx_busquedaAvanzPrecio.UseVisualStyleBackColor = true;
            this.cbx_busquedaAvanzPrecio.CheckedChanged += new System.EventHandler(this.cbx_busquedaAvanzPrecio_CheckedChanged);
            // 
            // cmb_busquedaSeleccionTipo
            // 
            this.cmb_busquedaSeleccionTipo._campo = "id_tipo_producto";
            this.cmb_busquedaSeleccionTipo._mensaje_error = "No se selecciono un tipo de producto";
            this.cmb_busquedaSeleccionTipo._nombre_tabla = "producto";
            this.cmb_busquedaSeleccionTipo._validable = false;
            this.cmb_busquedaSeleccionTipo.Enabled = false;
            this.cmb_busquedaSeleccionTipo.FormattingEnabled = true;
            this.cmb_busquedaSeleccionTipo.Location = new System.Drawing.Point(170, 79);
            this.cmb_busquedaSeleccionTipo.Name = "cmb_busquedaSeleccionTipo";
            this.cmb_busquedaSeleccionTipo.Size = new System.Drawing.Size(167, 21);
            this.cmb_busquedaSeleccionTipo.TabIndex = 3;
            // 
            // lbl_busquedaAvSeleccionTipo
            // 
            this.lbl_busquedaAvSeleccionTipo.AutoSize = true;
            this.lbl_busquedaAvSeleccionTipo.Location = new System.Drawing.Point(58, 82);
            this.lbl_busquedaAvSeleccionTipo.Name = "lbl_busquedaAvSeleccionTipo";
            this.lbl_busquedaAvSeleccionTipo.Size = new System.Drawing.Size(87, 13);
            this.lbl_busquedaAvSeleccionTipo.TabIndex = 2;
            this.lbl_busquedaAvSeleccionTipo.Text = "Seleccionar Tipo";
            // 
            // cbx_tipoProducto
            // 
            this.cbx_tipoProducto.AutoSize = true;
            this.cbx_tipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipoProducto.Location = new System.Drawing.Point(16, 39);
            this.cbx_tipoProducto.Name = "cbx_tipoProducto";
            this.cbx_tipoProducto.Size = new System.Drawing.Size(139, 19);
            this.cbx_tipoProducto.TabIndex = 0;
            this.cbx_tipoProducto.Text = "Tipo de Producto:";
            this.cbx_tipoProducto.UseVisualStyleBackColor = true;
            this.cbx_tipoProducto.CheckedChanged += new System.EventHandler(this.cbx_tipoProducto_CheckedChanged);
            // 
            // btn_activarDesactivar
            // 
            this.btn_activarDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activarDesactivar.Location = new System.Drawing.Point(465, 121);
            this.btn_activarDesactivar.Name = "btn_activarDesactivar";
            this.btn_activarDesactivar.Size = new System.Drawing.Size(109, 49);
            this.btn_activarDesactivar.TabIndex = 78;
            this.btn_activarDesactivar.Text = "Desactivar";
            this.btn_activarDesactivar.UseVisualStyleBackColor = true;
            this.btn_activarDesactivar.Click += new System.EventHandler(this.btn_activarDesactivar_Click);
            // 
            // cmb_estadoProducto
            // 
            this.cmb_estadoProducto._campo = "estado_producto";
            this.cmb_estadoProducto._mensaje_error = "No se selecciono un estado";
            this.cmb_estadoProducto._nombre_tabla = "producto";
            this.cmb_estadoProducto._validable = true;
            this.cmb_estadoProducto.Enabled = false;
            this.cmb_estadoProducto.FormattingEnabled = true;
            this.cmb_estadoProducto.Items.AddRange(new object[] {
            "No Habilitado",
            "Habilitado"});
            this.cmb_estadoProducto.Location = new System.Drawing.Point(978, 435);
            this.cmb_estadoProducto.Name = "cmb_estadoProducto";
            this.cmb_estadoProducto.Size = new System.Drawing.Size(143, 21);
            this.cmb_estadoProducto.TabIndex = 75;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario._campo = "precio_unitario";
            this.txt_precioUnitario._mensaje_error = "No se ingreso el Precio Unitario del Producto";
            this.txt_precioUnitario._nombre_tabla = "producto";
            this.txt_precioUnitario._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_precioUnitario._validable = true;
            this.txt_precioUnitario.Enabled = false;
            this.txt_precioUnitario.Location = new System.Drawing.Point(978, 391);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(143, 20);
            this.txt_precioUnitario.TabIndex = 73;
            // 
            // cmb_tipoProducto
            // 
            this.cmb_tipoProducto._campo = "id_tipo_producto";
            this.cmb_tipoProducto._mensaje_error = "No se selecciono un Tipo de Producto";
            this.cmb_tipoProducto._nombre_tabla = "producto";
            this.cmb_tipoProducto._validable = true;
            this.cmb_tipoProducto.Enabled = false;
            this.cmb_tipoProducto.FormattingEnabled = true;
            this.cmb_tipoProducto.Location = new System.Drawing.Point(978, 343);
            this.cmb_tipoProducto.Name = "cmb_tipoProducto";
            this.cmb_tipoProducto.Size = new System.Drawing.Size(143, 21);
            this.cmb_tipoProducto.TabIndex = 72;
            // 
            // txt_descripcionProducto
            // 
            this.txt_descripcionProducto._campo = "descripcion";
            this.txt_descripcionProducto._mensaje_error = "";
            this.txt_descripcionProducto._nombre_tabla = "producto";
            this.txt_descripcionProducto._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.texto;
            this.txt_descripcionProducto._validable = false;
            this.txt_descripcionProducto.Enabled = false;
            this.txt_descripcionProducto.Location = new System.Drawing.Point(978, 300);
            this.txt_descripcionProducto.Name = "txt_descripcionProducto";
            this.txt_descripcionProducto.Size = new System.Drawing.Size(143, 20);
            this.txt_descripcionProducto.TabIndex = 71;
            // 
            // cmb_unidadMedida
            // 
            this.cmb_unidadMedida._campo = "id_u_medida";
            this.cmb_unidadMedida._mensaje_error = "No se selecciono Unidad de Medida";
            this.cmb_unidadMedida._nombre_tabla = "producto";
            this.cmb_unidadMedida._validable = true;
            this.cmb_unidadMedida.Enabled = false;
            this.cmb_unidadMedida.FormattingEnabled = true;
            this.cmb_unidadMedida.Location = new System.Drawing.Point(978, 252);
            this.cmb_unidadMedida.Name = "cmb_unidadMedida";
            this.cmb_unidadMedida.Size = new System.Drawing.Size(143, 21);
            this.cmb_unidadMedida.TabIndex = 70;
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto._campo = "cantidad_u_medida";
            this.txt_cantidadProducto._mensaje_error = "No se ingreso la Cantidad del Producto";
            this.txt_cantidadProducto._nombre_tabla = "producto";
            this.txt_cantidadProducto._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_cantidadProducto._validable = true;
            this.txt_cantidadProducto.Enabled = false;
            this.txt_cantidadProducto.Location = new System.Drawing.Point(978, 207);
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(143, 20);
            this.txt_cantidadProducto.TabIndex = 69;
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto._campo = "nombre_producto";
            this.txt_NombreProducto._mensaje_error = "No se ingreso el Nombre del Producto";
            this.txt_NombreProducto._nombre_tabla = "producto";
            this.txt_NombreProducto._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.texto;
            this.txt_NombreProducto._validable = true;
            this.txt_NombreProducto.Enabled = false;
            this.txt_NombreProducto.Location = new System.Drawing.Point(978, 162);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(143, 20);
            this.txt_NombreProducto.TabIndex = 68;
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto._campo = null;
            this.txt_IdProducto._mensaje_error = null;
            this.txt_IdProducto._nombre_tabla = null;
            this.txt_IdProducto._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_IdProducto._validable = false;
            this.txt_IdProducto.Enabled = false;
            this.txt_IdProducto.Location = new System.Drawing.Point(978, 117);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(143, 20);
            this.txt_IdProducto.TabIndex = 67;
            // 
            // titulo_estadisticas
            // 
            this.titulo_estadisticas.AutoSize = true;
            this.titulo_estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.titulo_estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_estadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo_estadisticas.Location = new System.Drawing.Point(19, 9);
            this.titulo_estadisticas.Name = "titulo_estadisticas";
            this.titulo_estadisticas.Size = new System.Drawing.Size(702, 31);
            this.titulo_estadisticas.TabIndex = 85;
            this.titulo_estadisticas.Text = "                  ADMINISTRAR PRODUCTOS                   ";
            // 
            // uc_ABM_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titulo_estadisticas);
            this.Controls.Add(this.btn_activarDesactivar);
            this.Controls.Add(this.grp_busquedaAvanzadaProducto);
            this.Controls.Add(this.lbl_mensajeError);
            this.Controls.Add(this.cmb_estadoProducto);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.cmb_tipoProducto);
            this.Controls.Add(this.txt_descripcionProducto);
            this.Controls.Add(this.cmb_unidadMedida);
            this.Controls.Add(this.txt_cantidadProducto);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.btn_busquedaAvanzadaProducto);
            this.Controls.Add(this.btn_buscarProducto);
            this.Controls.Add(this.txt_busquedaProducto);
            this.Controls.Add(this.lbl_buscarProducto);
            this.Controls.Add(this.btn_registrarProducto);
            this.Controls.Add(this.btn_modificarProducto);
            this.Controls.Add(this.lbl_tipoProducto);
            this.Controls.Add(this.btn_cancelarModProducto);
            this.Controls.Add(this.btn_guardarModProducto);
            this.Controls.Add(this.btn_agregarTipo);
            this.Controls.Add(this.btn_agregarUdeMedida);
            this.Controls.Add(this.lbl_estadoProducto);
            this.Controls.Add(this.lbl_unidadMedida);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_precioUnitario);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_NomProducto);
            this.Controls.Add(this.lbl_IdProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_ABM_Producto";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.uc_ABM_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.grp_busquedaAvanzadaProducto.ResumeLayout(false);
            this.grp_busquedaAvanzadaProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IdProducto;
        private System.Windows.Forms.Label lbl_NomProducto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_unidadMedida;
        private System.Windows.Forms.Label lbl_estadoProducto;
        private System.Windows.Forms.Button btn_agregarUdeMedida;
        private System.Windows.Forms.Button btn_agregarTipo;
        private System.Windows.Forms.Button btn_cancelarModProducto;
        private System.Windows.Forms.Label lbl_tipoProducto;
        private System.Windows.Forms.Button btn_guardarModProducto;
        private System.Windows.Forms.Button btn_busquedaAvanzadaProducto;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.TextBox txt_busquedaProducto;
        private System.Windows.Forms.Label lbl_buscarProducto;
        private System.Windows.Forms.Button btn_registrarProducto;
        private System.Windows.Forms.Button btn_modificarProducto;
        private System.Windows.Forms.DataGridView dgv_productos;
        private clases.TextBoxPersonal txt_IdProducto;
        private clases.TextBoxPersonal txt_NombreProducto;
        private clases.TextBoxPersonal txt_cantidadProducto;
        private clases.ComboBoxPersonal cmb_unidadMedida;
        private clases.TextBoxPersonal txt_descripcionProducto;
        private clases.ComboBoxPersonal cmb_tipoProducto;
        private clases.TextBoxPersonal txt_precioUnitario;
        private clases.ComboBoxHabilitado cmb_estadoProducto;
        private System.Windows.Forms.Label lbl_mensajeError;
        private System.Windows.Forms.GroupBox grp_busquedaAvanzadaProducto;
        private System.Windows.Forms.CheckBox cbx_tipoProducto;
        private clases.ComboBoxPersonal cmb_busquedaSeleccionTipo;
        private System.Windows.Forms.Label lbl_busquedaAvSeleccionTipo;
        private System.Windows.Forms.CheckBox cbx_busquedaAvanzPrecio;
        private clases.TextBoxPersonal txt_busquedaPrecioHasta;
        private clases.TextBoxPersonal txt_busquedaPrecioDesde;
        private System.Windows.Forms.Label lbl_busquedaPrecioHasta;
        private System.Windows.Forms.Label lbl_busquedaPrecioDesde;
        private System.Windows.Forms.RadioButton rbtn_habilitado;
        private System.Windows.Forms.RadioButton rbtn_deshabilitado;
        private System.Windows.Forms.RadioButton rbtn_cualquiera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_msjErrorBusquedaAv;
        private System.Windows.Forms.Button btn_BuscarBusquedaAvanzada;
        private System.Windows.Forms.Button btn_cerrarBusquedaAvanzada;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_producto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Habilitado;
        private System.Windows.Forms.Button btn_activarDesactivar;
        private System.Windows.Forms.Label titulo_estadisticas;
    }
}
