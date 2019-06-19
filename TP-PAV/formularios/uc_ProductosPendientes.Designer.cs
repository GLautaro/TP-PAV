namespace TP_PAV.formularios
{
    partial class uc_ProductosPendientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_productosPendientes = new System.Windows.Forms.DataGridView();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.btn_recargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productosPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Productos pendientes";
            // 
            // dgv_productosPendientes
            // 
            this.dgv_productosPendientes.AllowUserToAddRows = false;
            this.dgv_productosPendientes.AllowUserToDeleteRows = false;
            this.dgv_productosPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_productosPendientes.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_productosPendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_productosPendientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productosPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_productosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productosPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_producto,
            this.nombre_u_medida,
            this.cantidad_pendiente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_productosPendientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_productosPendientes.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_productosPendientes.Location = new System.Drawing.Point(19, 141);
            this.dgv_productosPendientes.Name = "dgv_productosPendientes";
            this.dgv_productosPendientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_productosPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_productosPendientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_productosPendientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_productosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productosPendientes.Size = new System.Drawing.Size(388, 350);
            this.dgv_productosPendientes.TabIndex = 56;
            // 
            // nombre_producto
            // 
            this.nombre_producto.DataPropertyName = "nombre_producto";
            this.nombre_producto.HeaderText = "Nombre del producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            this.nombre_producto.Width = 135;
            // 
            // nombre_u_medida
            // 
            this.nombre_u_medida.DataPropertyName = "nombre_u_medida";
            this.nombre_u_medida.HeaderText = "Unidad de medida";
            this.nombre_u_medida.Name = "nombre_u_medida";
            this.nombre_u_medida.ReadOnly = true;
            this.nombre_u_medida.Width = 123;
            // 
            // cantidad_pendiente
            // 
            this.cantidad_pendiente.DataPropertyName = "cantidad_pendiente";
            this.cantidad_pendiente.HeaderText = "Cantidad Pendiente";
            this.cantidad_pendiente.Name = "cantidad_pendiente";
            this.cantidad_pendiente.ReadOnly = true;
            this.cantidad_pendiente.Width = 128;
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensaje.Location = new System.Drawing.Point(14, 507);
            this.lbl_mensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(0, 25);
            this.lbl_mensaje.TabIndex = 57;
            // 
            // btn_recargar
            // 
            this.btn_recargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recargar.Location = new System.Drawing.Point(19, 76);
            this.btn_recargar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(207, 48);
            this.btn_recargar.TabIndex = 62;
            this.btn_recargar.TabStop = false;
            this.btn_recargar.Text = "Recargar listado";
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // uc_ProductosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.lbl_mensaje);
            this.Controls.Add(this.dgv_productosPendientes);
            this.Controls.Add(this.label5);
            this.Name = "uc_ProductosPendientes";
            this.Size = new System.Drawing.Size(670, 627);
            this.Load += new System.EventHandler(this.uc_ProductosPendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productosPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_productosPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_pendiente;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.Button btn_recargar;
    }
}
