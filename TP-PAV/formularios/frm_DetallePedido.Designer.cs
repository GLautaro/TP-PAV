namespace TP_PAV.formularios
{
    partial class frm_DetallePedido
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

        #region Windows Form Designer generated code

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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_detallePedido = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addProductoPedido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardarPedido = new System.Windows.Forms.Button();
            this.btn_descartarPedido = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_montoTotal = new System.Windows.Forms.Label();
            this.cmb_tipoProducto = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.cmb_Producto = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.txt_precio_unitario = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_cantidad = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_montoMinimo = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.txt_id_pedido = new TP_PAV.clases.TextBoxPersonal(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Detalle Pedido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 39);
            this.panel1.TabIndex = 16;
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
            this.id_producto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detallePedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_detallePedido.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_detallePedido.Location = new System.Drawing.Point(13, 135);
            this.dgv_detallePedido.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgv_detallePedido.Size = new System.Drawing.Size(572, 250);
            this.dgv_detallePedido.TabIndex = 55;
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
            // id_producto
            // 
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "ID PRODUCTO";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_producto.Visible = false;
            // 
            // btn_addProductoPedido
            // 
            this.btn_addProductoPedido.Location = new System.Drawing.Point(816, 315);
            this.btn_addProductoPedido.Name = "btn_addProductoPedido";
            this.btn_addProductoPedido.Size = new System.Drawing.Size(150, 35);
            this.btn_addProductoPedido.TabIndex = 19;
            this.btn_addProductoPedido.Text = "Agregar Producto";
            this.btn_addProductoPedido.UseVisualStyleBackColor = true;
            this.btn_addProductoPedido.Click += new System.EventHandler(this.btn_addProductoPedido_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "ID PEDIDO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Precio Unitario:";
            // 
            // btn_guardarPedido
            // 
            this.btn_guardarPedido.Location = new System.Drawing.Point(649, 382);
            this.btn_guardarPedido.Name = "btn_guardarPedido";
            this.btn_guardarPedido.Size = new System.Drawing.Size(150, 35);
            this.btn_guardarPedido.TabIndex = 60;
            this.btn_guardarPedido.Text = "Guardar Pedido";
            this.btn_guardarPedido.UseVisualStyleBackColor = true;
            this.btn_guardarPedido.Click += new System.EventHandler(this.btn_guardarPedido_Click);
            // 
            // btn_descartarPedido
            // 
            this.btn_descartarPedido.Location = new System.Drawing.Point(816, 382);
            this.btn_descartarPedido.Name = "btn_descartarPedido";
            this.btn_descartarPedido.Size = new System.Drawing.Size(150, 35);
            this.btn_descartarPedido.TabIndex = 61;
            this.btn_descartarPedido.Text = "Descartar Pedido";
            this.btn_descartarPedido.UseVisualStyleBackColor = true;
            this.btn_descartarPedido.Click += new System.EventHandler(this.btn_descartarPedido_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(572, 95);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_error.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "MONTO MINIMO DE COMPRA:";
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Location = new System.Drawing.Point(649, 315);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(150, 35);
            this.btn_deleteItem.TabIndex = 65;
            this.btn_deleteItem.Text = "Eliminar Producto";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 66;
            this.label5.Text = "Total: $";
            // 
            // lbl_montoTotal
            // 
            this.lbl_montoTotal.AutoSize = true;
            this.lbl_montoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montoTotal.Location = new System.Drawing.Point(419, 395);
            this.lbl_montoTotal.Name = "lbl_montoTotal";
            this.lbl_montoTotal.Size = new System.Drawing.Size(24, 25);
            this.lbl_montoTotal.TabIndex = 67;
            this.lbl_montoTotal.Text = "0";
            // 
            // cmb_tipoProducto
            // 
            this.cmb_tipoProducto._campo = null;
            this.cmb_tipoProducto._mensaje_error = "Necesita agregar un Tipo de Producto";
            this.cmb_tipoProducto._nombre_tabla = null;
            this.cmb_tipoProducto._validable = true;
            this.cmb_tipoProducto.FormattingEnabled = true;
            this.cmb_tipoProducto.Location = new System.Drawing.Point(743, 158);
            this.cmb_tipoProducto.Name = "cmb_tipoProducto";
            this.cmb_tipoProducto.Size = new System.Drawing.Size(223, 24);
            this.cmb_tipoProducto.TabIndex = 71;
            this.cmb_tipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmb_tipoProducto_SelectedIndexChanged);
            // 
            // cmb_Producto
            // 
            this.cmb_Producto._campo = null;
            this.cmb_Producto._mensaje_error = "Necesita seleccionar un Producto";
            this.cmb_Producto._nombre_tabla = null;
            this.cmb_Producto._validable = true;
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(742, 201);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Size = new System.Drawing.Size(224, 24);
            this.cmb_Producto.TabIndex = 70;
            this.cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.cmb_Producto_SelectedIndexChanged);
            // 
            // txt_precio_unitario
            // 
            this.txt_precio_unitario._campo = null;
            this.txt_precio_unitario._mensaje_error = null;
            this.txt_precio_unitario._nombre_tabla = null;
            this.txt_precio_unitario._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.texto;
            this.txt_precio_unitario._validable = false;
            this.txt_precio_unitario.Enabled = false;
            this.txt_precio_unitario.Location = new System.Drawing.Point(742, 239);
            this.txt_precio_unitario.Name = "txt_precio_unitario";
            this.txt_precio_unitario.Size = new System.Drawing.Size(224, 22);
            this.txt_precio_unitario.TabIndex = 69;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad._campo = null;
            this.txt_cantidad._mensaje_error = "Necesita agregar una Cantidad";
            this.txt_cantidad._nombre_tabla = null;
            this.txt_cantidad._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_cantidad._validable = true;
            this.txt_cantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cantidad.Location = new System.Drawing.Point(742, 278);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(224, 22);
            this.txt_cantidad.TabIndex = 68;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // txt_montoMinimo
            // 
            this.txt_montoMinimo._campo = "";
            this.txt_montoMinimo._mensaje_error = null;
            this.txt_montoMinimo._nombre_tabla = "";
            this.txt_montoMinimo._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_montoMinimo._validable = false;
            this.txt_montoMinimo.Enabled = false;
            this.txt_montoMinimo.Location = new System.Drawing.Point(429, 95);
            this.txt_montoMinimo.Name = "txt_montoMinimo";
            this.txt_montoMinimo.Size = new System.Drawing.Size(116, 22);
            this.txt_montoMinimo.TabIndex = 64;
            // 
            // txt_id_pedido
            // 
            this.txt_id_pedido._campo = "id_pedido";
            this.txt_id_pedido._mensaje_error = null;
            this.txt_id_pedido._nombre_tabla = "pedido_x_producto";
            this.txt_id_pedido._tipo = TP_PAV.clases.TextBoxPersonal.tipo_dato.numero;
            this.txt_id_pedido._validable = false;
            this.txt_id_pedido.Enabled = false;
            this.txt_id_pedido.Location = new System.Drawing.Point(98, 98);
            this.txt_id_pedido.Name = "txt_id_pedido";
            this.txt_id_pedido.Size = new System.Drawing.Size(116, 22);
            this.txt_id_pedido.TabIndex = 57;
            // 
            // frm_DetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 429);
            this.Controls.Add(this.cmb_tipoProducto);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.txt_precio_unitario);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_montoTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_deleteItem);
            this.Controls.Add(this.txt_montoMinimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_descartarPedido);
            this.Controls.Add(this.btn_guardarPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addProductoPedido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_id_pedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_detallePedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DetallePedido";
            this.Text = "frm_DetallePedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DetallePedido_FormClosing);
            this.Load += new System.EventHandler(this.frm_DetallePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_detallePedido;
        private System.Windows.Forms.Button btn_addProductoPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private clases.TextBoxPersonal txt_id_pedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_guardarPedido;
        private System.Windows.Forms.Button btn_descartarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label3;
        private clases.TextBoxPersonal txt_montoMinimo;
        private System.Windows.Forms.Button btn_deleteItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_montoTotal;
        private clases.TextBoxPersonal txt_cantidad;
        private clases.TextBoxPersonal txt_precio_unitario;
        private clases.ComboBoxPersonal cmb_Producto;
        private clases.ComboBoxPersonal cmb_tipoProducto;
    }
}