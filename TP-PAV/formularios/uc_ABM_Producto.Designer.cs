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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_guardarModProducto = new System.Windows.Forms.Button();
            this.btn_cancelarModProducto = new System.Windows.Forms.Button();
            this.btn_buscarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_producto,
            this.cantidad_u_medida,
            this.id_u_medida,
            this.descripcion,
            this.precio_unitario,
            this.estado_producto});
            this.dataGridView1.Location = new System.Drawing.Point(14, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre de Producto";
            this.nombre_producto.Name = "nombre_producto";
            // 
            // cantidad_u_medida
            // 
            this.cantidad_u_medida.HeaderText = "Cantidad";
            this.cantidad_u_medida.Name = "cantidad_u_medida";
            // 
            // id_u_medida
            // 
            this.id_u_medida.HeaderText = "Unidad de Medida";
            this.id_u_medida.Name = "id_u_medida";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio Unitario";
            this.precio_unitario.Name = "precio_unitario";
            // 
            // estado_producto
            // 
            this.estado_producto.HeaderText = "Estado de Producto";
            this.estado_producto.Name = "estado_producto";
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
            this.lbl_precioUnitario.Location = new System.Drawing.Point(721, 264);
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
            this.lbl_estadoProducto.Location = new System.Drawing.Point(721, 309);
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
            this.txt_precioUnitario.Location = new System.Drawing.Point(929, 264);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(143, 21);
            this.txt_precioUnitario.TabIndex = 14;
            // 
            // cmb_estadoProducto
            // 
            this.cmb_estadoProducto.FormattingEnabled = true;
            this.cmb_estadoProducto.Location = new System.Drawing.Point(929, 309);
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
            // 
            // btn_agregarEstado
            // 
            this.btn_agregarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarEstado.Location = new System.Drawing.Point(1096, 304);
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
            // btn_guardarModProducto
            // 
            this.btn_guardarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardarModProducto.Location = new System.Drawing.Point(724, 368);
            this.btn_guardarModProducto.Name = "btn_guardarModProducto";
            this.btn_guardarModProducto.Size = new System.Drawing.Size(162, 30);
            this.btn_guardarModProducto.TabIndex = 49;
            this.btn_guardarModProducto.Text = "Guardar Modificaciones";
            this.btn_guardarModProducto.UseVisualStyleBackColor = true;
            // 
            // btn_cancelarModProducto
            // 
            this.btn_cancelarModProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarModProducto.Location = new System.Drawing.Point(951, 368);
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
            // uc_ABM_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uc_ABM_Producto";
            this.Size = new System.Drawing.Size(1145, 477);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_producto;
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
        private System.Windows.Forms.Button btn_guardarModProducto;
        private System.Windows.Forms.Button btn_cancelarModProducto;
        private System.Windows.Forms.Button btn_buscarProducto;
    }
}
