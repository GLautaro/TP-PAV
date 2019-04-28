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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_IdProducto = new System.Windows.Forms.Label();
            this.lbl_NomProducto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precioUnitario = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_unidadMedida = new System.Windows.Forms.Label();
            this.lbl_estadoProducto = new System.Windows.Forms.Label();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.cmb_unidadMedida = new System.Windows.Forms.ComboBox();
            this.txt_descripcionProducto = new System.Windows.Forms.TextBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.cmb_estadoProducto = new System.Windows.Forms.ComboBox();
            this.btn_agregarUdeMedida = new System.Windows.Forms.Button();
            this.btn_agregarEstado = new System.Windows.Forms.Button();
            this.btn_habilitarAñadirProducto = new System.Windows.Forms.Button();
            this.btn_modificarProducto = new System.Windows.Forms.Button();
            this.btn_eliminarProducto = new System.Windows.Forms.Button();
            this.btn_cancelarModProducto = new System.Windows.Forms.Button();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_tipoProducto = new System.Windows.Forms.ComboBox();
            this.lbl_tipoProducto = new System.Windows.Forms.Label();
            this.btn_guardarModProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // lbl_IdProducto
            // 
            this.lbl_IdProducto.AutoSize = true;
            this.lbl_IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdProducto.Location = new System.Drawing.Point(721, 39);
            this.lbl_IdProducto.Name = "lbl_IdProducto";
            this.lbl_IdProducto.Size = new System.Drawing.Size(78, 16);
            this.lbl_IdProducto.TabIndex = 2;
            this.lbl_IdProducto.Text = "ID Producto";
            // 
            // lbl_NomProducto
            // 
            this.lbl_NomProducto.AutoSize = true;
            this.lbl_NomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomProducto.Location = new System.Drawing.Point(721, 84);
            this.lbl_NomProducto.Name = "lbl_NomProducto";
            this.lbl_NomProducto.Size = new System.Drawing.Size(133, 16);
            this.lbl_NomProducto.TabIndex = 3;
            this.lbl_NomProducto.Text = "Nombre de Producto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(721, 129);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(62, 16);
            this.lbl_cantidad.TabIndex = 4;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_precioUnitario
            // 
            this.lbl_precioUnitario.AutoSize = true;
            this.lbl_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precioUnitario.Location = new System.Drawing.Point(721, 304);
            this.lbl_precioUnitario.Name = "lbl_precioUnitario";
            this.lbl_precioUnitario.Size = new System.Drawing.Size(96, 16);
            this.lbl_precioUnitario.TabIndex = 5;
            this.lbl_precioUnitario.Text = "Precio Unitario";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(721, 219);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(80, 16);
            this.lbl_descripcion.TabIndex = 6;
            this.lbl_descripcion.Text = "Descripción";
            // 
            // lbl_unidadMedida
            // 
            this.lbl_unidadMedida.AutoSize = true;
            this.lbl_unidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidadMedida.Location = new System.Drawing.Point(721, 174);
            this.lbl_unidadMedida.Name = "lbl_unidadMedida";
            this.lbl_unidadMedida.Size = new System.Drawing.Size(120, 16);
            this.lbl_unidadMedida.TabIndex = 7;
            this.lbl_unidadMedida.Text = "Unidad de Medida";
            // 
            // lbl_estadoProducto
            // 
            this.lbl_estadoProducto.AutoSize = true;
            this.lbl_estadoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoProducto.Location = new System.Drawing.Point(721, 358);
            this.lbl_estadoProducto.Name = "lbl_estadoProducto";
            this.lbl_estadoProducto.Size = new System.Drawing.Size(130, 16);
            this.lbl_estadoProducto.TabIndex = 8;
            this.lbl_estadoProducto.Text = "Estado del Producto";
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProducto.Location = new System.Drawing.Point(929, 39);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(89, 21);
            this.txt_IdProducto.TabIndex = 9;
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProducto.Location = new System.Drawing.Point(929, 81);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(143, 21);
            this.txt_NombreProducto.TabIndex = 10;
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadProducto.Location = new System.Drawing.Point(929, 126);
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(143, 21);
            this.txt_cantidadProducto.TabIndex = 11;
            // 
            // cmb_unidadMedida
            // 
            this.cmb_unidadMedida.FormattingEnabled = true;
            this.cmb_unidadMedida.Location = new System.Drawing.Point(929, 174);
            this.cmb_unidadMedida.Name = "cmb_unidadMedida";
            this.cmb_unidadMedida.Size = new System.Drawing.Size(143, 21);
            this.cmb_unidadMedida.TabIndex = 12;
            // 
            // txt_descripcionProducto
            // 
            this.txt_descripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcionProducto.Location = new System.Drawing.Point(929, 219);
            this.txt_descripcionProducto.Name = "txt_descripcionProducto";
            this.txt_descripcionProducto.Size = new System.Drawing.Size(143, 21);
            this.txt_descripcionProducto.TabIndex = 13;
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioUnitario.Location = new System.Drawing.Point(929, 315);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(143, 21);
            this.txt_precioUnitario.TabIndex = 14;
            // 
            // cmb_estadoProducto
            // 
            this.cmb_estadoProducto.FormattingEnabled = true;
            this.cmb_estadoProducto.Location = new System.Drawing.Point(929, 358);
            this.cmb_estadoProducto.Name = "cmb_estadoProducto";
            this.cmb_estadoProducto.Size = new System.Drawing.Size(143, 21);
            this.cmb_estadoProducto.TabIndex = 15;
            // 
            // btn_agregarUdeMedida
            // 
            this.btn_agregarUdeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarUdeMedida.Location = new System.Drawing.Point(1096, 172);
            this.btn_agregarUdeMedida.Name = "btn_agregarUdeMedida";
            this.btn_agregarUdeMedida.Size = new System.Drawing.Size(33, 26);
            this.btn_agregarUdeMedida.TabIndex = 16;
            this.btn_agregarUdeMedida.Text = "+";
            this.btn_agregarUdeMedida.UseVisualStyleBackColor = true;
            this.btn_agregarUdeMedida.Click += new System.EventHandler(this.btn_agregarUdeMedida_Click);
            // 
            // btn_agregarEstado
            // 
            this.btn_agregarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarEstado.Location = new System.Drawing.Point(1096, 260);
            this.btn_agregarEstado.Name = "btn_agregarEstado";
            this.btn_agregarEstado.Size = new System.Drawing.Size(33, 26);
            this.btn_agregarEstado.TabIndex = 17;
            this.btn_agregarEstado.Text = "+";
            this.btn_agregarEstado.UseVisualStyleBackColor = true;
            this.btn_agregarEstado.Click += new System.EventHandler(this.btn_agregarEstado_Click);
            // 
            // btn_habilitarAñadirProducto
            // 
            this.btn_habilitarAñadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_habilitarAñadirProducto.Location = new System.Drawing.Point(14, 404);
            this.btn_habilitarAñadirProducto.Name = "btn_habilitarAñadirProducto";
            this.btn_habilitarAñadirProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_habilitarAñadirProducto.TabIndex = 46;
            this.btn_habilitarAñadirProducto.Text = "Añadir Nuevo Producto";
            this.btn_habilitarAñadirProducto.UseVisualStyleBackColor = true;
            // 
            // btn_modificarProducto
            // 
            this.btn_modificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarProducto.Location = new System.Drawing.Point(254, 404);
            this.btn_modificarProducto.Name = "btn_modificarProducto";
            this.btn_modificarProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_modificarProducto.TabIndex = 47;
            this.btn_modificarProducto.Text = "Modificar Producto";
            this.btn_modificarProducto.UseVisualStyleBackColor = true;
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarProducto.Location = new System.Drawing.Point(494, 404);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_eliminarProducto.TabIndex = 48;
            this.btn_eliminarProducto.Text = "Eliminar Producto";
            this.btn_eliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarModProducto
            // 
            this.btn_cancelarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarModProducto.Location = new System.Drawing.Point(951, 417);
            this.btn_cancelarModProducto.Name = "btn_cancelarModProducto";
            this.btn_cancelarModProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_cancelarModProducto.TabIndex = 50;
            this.btn_cancelarModProducto.Text = "Cancelar Modificaciones";
            this.btn_cancelarModProducto.UseVisualStyleBackColor = true;
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarProducto.Location = new System.Drawing.Point(1043, 35);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(65, 26);
            this.btn_buscarProducto.TabIndex = 51;
            this.btn_buscarProducto.Text = "Buscar";
            this.btn_buscarProducto.UseVisualStyleBackColor = true;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_productos.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_productos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.descripcion,
            this.id_tipo_producto,
            this.precio_unitario,
            this.estado_producto});
            this.dgv_productos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_productos.EnableHeadersVisualStyles = false;
            this.dgv_productos.GridColor = System.Drawing.Color.Black;
            this.dgv_productos.Location = new System.Drawing.Point(8, 41);
            this.dgv_productos.MultiSelect = false;
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_productos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(690, 337);
            this.dgv_productos.TabIndex = 57;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Id Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 85;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            this.nombre_producto.Width = 116;
            // 
            // cantidad_u_medida
            // 
            this.cantidad_u_medida.HeaderText = "Cantidad";
            this.cantidad_u_medida.Name = "cantidad_u_medida";
            this.cantidad_u_medida.ReadOnly = true;
            this.cantidad_u_medida.Width = 79;
            // 
            // id_u_medida
            // 
            this.id_u_medida.HeaderText = "Unidad de Medida";
            this.id_u_medida.Name = "id_u_medida";
            this.id_u_medida.ReadOnly = true;
            this.id_u_medida.Width = 121;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 95;
            // 
            // id_tipo_producto
            // 
            this.id_tipo_producto.HeaderText = "Tipo Producto";
            this.id_tipo_producto.Name = "id_tipo_producto";
            this.id_tipo_producto.ReadOnly = true;
            this.id_tipo_producto.Width = 97;
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.Name = "precio_unitario";
            this.precio_unitario.ReadOnly = true;
            this.precio_unitario.Width = 102;
            // 
            // estado_producto
            // 
            this.estado_producto.HeaderText = "Estado del Producto";
            this.estado_producto.Name = "estado_producto";
            this.estado_producto.ReadOnly = true;
            this.estado_producto.Width = 128;
            // 
            // cmb_tipoProducto
            // 
            this.cmb_tipoProducto.FormattingEnabled = true;
            this.cmb_tipoProducto.Location = new System.Drawing.Point(929, 263);
            this.cmb_tipoProducto.Name = "cmb_tipoProducto";
            this.cmb_tipoProducto.Size = new System.Drawing.Size(143, 21);
            this.cmb_tipoProducto.TabIndex = 59;
            this.cmb_tipoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_tipoProducto
            // 
            this.lbl_tipoProducto.AutoSize = true;
            this.lbl_tipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoProducto.Location = new System.Drawing.Point(721, 264);
            this.lbl_tipoProducto.Name = "lbl_tipoProducto";
            this.lbl_tipoProducto.Size = new System.Drawing.Size(112, 16);
            this.lbl_tipoProducto.TabIndex = 58;
            this.lbl_tipoProducto.Text = "Tipo de Producto";
            // 
            // btn_guardarModProducto
            // 
            this.btn_guardarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarModProducto.Location = new System.Drawing.Point(724, 417);
            this.btn_guardarModProducto.Name = "btn_guardarModProducto";
            this.btn_guardarModProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_guardarModProducto.TabIndex = 49;
            this.btn_guardarModProducto.Text = "Guardar Modificaciones";
            this.btn_guardarModProducto.UseVisualStyleBackColor = true;
            this.btn_guardarModProducto.Click += new System.EventHandler(this.btn_guardarModProducto_Click);
            // 
            // uc_ABM_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_tipoProducto);
            this.Controls.Add(this.lbl_tipoProducto);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.btn_buscarProducto);
            this.Controls.Add(this.btn_cancelarModProducto);
            this.Controls.Add(this.btn_guardarModProducto);
            this.Controls.Add(this.btn_eliminarProducto);
            this.Controls.Add(this.btn_modificarProducto);
            this.Controls.Add(this.btn_habilitarAñadirProducto);
            this.Controls.Add(this.btn_agregarEstado);
            this.Controls.Add(this.btn_agregarUdeMedida);
            this.Controls.Add(this.cmb_estadoProducto);
            this.Controls.Add(this.txt_precioUnitario);
            this.Controls.Add(this.txt_descripcionProducto);
            this.Controls.Add(this.cmb_unidadMedida);
            this.Controls.Add(this.txt_cantidadProducto);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.lbl_estadoProducto);
            this.Controls.Add(this.lbl_unidadMedida);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_precioUnitario);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_NomProducto);
            this.Controls.Add(this.lbl_IdProducto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_ABM_Producto";
            this.Size = new System.Drawing.Size(1145, 477);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_IdProducto;
        private System.Windows.Forms.Label lbl_NomProducto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precioUnitario;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_unidadMedida;
        private System.Windows.Forms.Label lbl_estadoProducto;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.TextBox txt_cantidadProducto;
        private System.Windows.Forms.ComboBox cmb_unidadMedida;
        private System.Windows.Forms.TextBox txt_descripcionProducto;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.ComboBox cmb_estadoProducto;
        private System.Windows.Forms.Button btn_agregarUdeMedida;
        private System.Windows.Forms.Button btn_agregarEstado;
        private System.Windows.Forms.Button btn_habilitarAñadirProducto;
        private System.Windows.Forms.Button btn_modificarProducto;
        private System.Windows.Forms.Button btn_eliminarProducto;
        private System.Windows.Forms.Button btn_cancelarModProducto;
        private System.Windows.Forms.Button btn_buscarProducto;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_producto;
        private System.Windows.Forms.ComboBox cmb_tipoProducto;
        private System.Windows.Forms.Label lbl_tipoProducto;
        private System.Windows.Forms.Button btn_guardarModProducto;
    }
}
