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
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addProductoPedido = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cantidad = new TP_PAV.clases.TextBoxPersonal(this.components);
            this.cmb_tipoProducto = new TP_PAV.clases.ComboBoxPersonal(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Producto = new TP_PAV.clases.ComboBoxPersonal(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1014, 39);
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
            this.dgv_detallePedido.Location = new System.Drawing.Point(13, 113);
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
            this.dgv_detallePedido.Size = new System.Drawing.Size(572, 272);
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID PRODUCTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Visible = false;
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
            this.groupBox1.Location = new System.Drawing.Point(606, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 272);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Productos al Pedido";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad:";
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
            // frm_DetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 420);
            this.Controls.Add(this.dgv_detallePedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DetallePedido";
            this.Text = "frm_DetallePedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detallePedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_detallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addProductoPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private clases.TextBoxPersonal txt_cantidad;
        private clases.ComboBoxPersonal cmb_tipoProducto;
        private System.Windows.Forms.Label label8;
        private clases.ComboBoxPersonal cmb_Producto;
    }
}