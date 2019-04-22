﻿namespace TP_PAV.formularios
{
    partial class frm_TipoFranquicia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_tipoFranquicia = new System.Windows.Forms.DataGridView();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_montoMinimo = new System.Windows.Forms.TextBox();
            this.txt_porcentajeDescuento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_habilitarAgregarTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_habilitarModificarTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_eliminarFranquicia = new System.Windows.Forms.Button();
            this.btn_modificarTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregarTipoFranquicia = new System.Windows.Forms.Button();
            this.id_tipo_franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipo_franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_minimo_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoFranquicia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 32);
            this.panel1.TabIndex = 1;
            // 
            // dgv_tipoFranquicia
            // 
            this.dgv_tipoFranquicia.AllowUserToAddRows = false;
            this.dgv_tipoFranquicia.AllowUserToDeleteRows = false;
            this.dgv_tipoFranquicia.AllowUserToResizeRows = false;
            this.dgv_tipoFranquicia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoFranquicia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tipo_franquicia,
            this.nombre_tipo_franquicia,
            this.monto_minimo_compra,
            this.porcentaje_descuento});
            this.dgv_tipoFranquicia.Location = new System.Drawing.Point(9, 101);
            this.dgv_tipoFranquicia.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_tipoFranquicia.MultiSelect = false;
            this.dgv_tipoFranquicia.Name = "dgv_tipoFranquicia";
            this.dgv_tipoFranquicia.RowTemplate.Height = 24;
            this.dgv_tipoFranquicia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tipoFranquicia.Size = new System.Drawing.Size(491, 179);
            this.dgv_tipoFranquicia.TabIndex = 2;
            this.dgv_tipoFranquicia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tipoFranquicia_CellMouseClick);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(9, 65);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(110, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_montoMinimo
            // 
            this.txt_montoMinimo.Location = new System.Drawing.Point(135, 65);
            this.txt_montoMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_montoMinimo.Name = "txt_montoMinimo";
            this.txt_montoMinimo.Size = new System.Drawing.Size(110, 20);
            this.txt_montoMinimo.TabIndex = 4;
            // 
            // txt_porcentajeDescuento
            // 
            this.txt_porcentajeDescuento.Location = new System.Drawing.Point(271, 65);
            this.txt_porcentajeDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_porcentajeDescuento.Name = "txt_porcentajeDescuento";
            this.txt_porcentajeDescuento.Size = new System.Drawing.Size(110, 20);
            this.txt_porcentajeDescuento.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Porcentaje Descuento";
            // 
            // btn_habilitarAgregarTipoFranquicia
            // 
            this.btn_habilitarAgregarTipoFranquicia.Location = new System.Drawing.Point(9, 292);
            this.btn_habilitarAgregarTipoFranquicia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_habilitarAgregarTipoFranquicia.Name = "btn_habilitarAgregarTipoFranquicia";
            this.btn_habilitarAgregarTipoFranquicia.Size = new System.Drawing.Size(109, 28);
            this.btn_habilitarAgregarTipoFranquicia.TabIndex = 9;
            this.btn_habilitarAgregarTipoFranquicia.Text = "Añadir Nuevo";
            this.btn_habilitarAgregarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_habilitarAgregarTipoFranquicia.Click += new System.EventHandler(this.btn_habilitarAgregarTipoFranquicia_Click);
            // 
            // btn_habilitarModificarTipoFranquicia
            // 
            this.btn_habilitarModificarTipoFranquicia.Location = new System.Drawing.Point(192, 292);
            this.btn_habilitarModificarTipoFranquicia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_habilitarModificarTipoFranquicia.Name = "btn_habilitarModificarTipoFranquicia";
            this.btn_habilitarModificarTipoFranquicia.Size = new System.Drawing.Size(104, 28);
            this.btn_habilitarModificarTipoFranquicia.TabIndex = 10;
            this.btn_habilitarModificarTipoFranquicia.Text = "Modificar";
            this.btn_habilitarModificarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_habilitarModificarTipoFranquicia.Click += new System.EventHandler(this.btn_habilitarModificarTipoFranquicia_Click);
            // 
            // btn_eliminarFranquicia
            // 
            this.btn_eliminarFranquicia.Location = new System.Drawing.Point(376, 292);
            this.btn_eliminarFranquicia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminarFranquicia.Name = "btn_eliminarFranquicia";
            this.btn_eliminarFranquicia.Size = new System.Drawing.Size(124, 28);
            this.btn_eliminarFranquicia.TabIndex = 11;
            this.btn_eliminarFranquicia.Text = "Eliminar";
            this.btn_eliminarFranquicia.UseVisualStyleBackColor = true;
            this.btn_eliminarFranquicia.Click += new System.EventHandler(this.btn_eliminarFranquicia_Click);
            // 
            // btn_modificarTipoFranquicia
            // 
            this.btn_modificarTipoFranquicia.Enabled = false;
            this.btn_modificarTipoFranquicia.Location = new System.Drawing.Point(385, 65);
            this.btn_modificarTipoFranquicia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificarTipoFranquicia.Name = "btn_modificarTipoFranquicia";
            this.btn_modificarTipoFranquicia.Size = new System.Drawing.Size(56, 19);
            this.btn_modificarTipoFranquicia.TabIndex = 12;
            this.btn_modificarTipoFranquicia.Text = "Guardar";
            this.btn_modificarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_modificarTipoFranquicia.Visible = false;
            this.btn_modificarTipoFranquicia.Click += new System.EventHandler(this.btn_modificarTipoFranquicia_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(445, 66);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(56, 19);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregarTipoFranquicia
            // 
            this.btn_agregarTipoFranquicia.Enabled = false;
            this.btn_agregarTipoFranquicia.Location = new System.Drawing.Point(385, 66);
            this.btn_agregarTipoFranquicia.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarTipoFranquicia.Name = "btn_agregarTipoFranquicia";
            this.btn_agregarTipoFranquicia.Size = new System.Drawing.Size(56, 19);
            this.btn_agregarTipoFranquicia.TabIndex = 14;
            this.btn_agregarTipoFranquicia.Text = "Añadir";
            this.btn_agregarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_agregarTipoFranquicia.Visible = false;
            this.btn_agregarTipoFranquicia.Click += new System.EventHandler(this.btn_agregarTipoFranquicia_Click);
            // 
            // id_tipo_franquicia
            // 
            this.id_tipo_franquicia.DataPropertyName = "id_tipo_franquicia";
            this.id_tipo_franquicia.HeaderText = "ID Tipo Franquicia";
            this.id_tipo_franquicia.Name = "id_tipo_franquicia";
            this.id_tipo_franquicia.Width = 50;
            // 
            // nombre_tipo_franquicia
            // 
            this.nombre_tipo_franquicia.DataPropertyName = "nombre_tipo_franquicia";
            this.nombre_tipo_franquicia.HeaderText = "Nombre del Tipo de Franquicia";
            this.nombre_tipo_franquicia.Name = "nombre_tipo_franquicia";
            this.nombre_tipo_franquicia.Width = 200;
            // 
            // monto_minimo_compra
            // 
            this.monto_minimo_compra.DataPropertyName = "monto_minimo_compra";
            this.monto_minimo_compra.HeaderText = "Monto Minimo de Compra";
            this.monto_minimo_compra.Name = "monto_minimo_compra";
            // 
            // porcentaje_descuento
            // 
            this.porcentaje_descuento.DataPropertyName = "porcentaje_descuento";
            this.porcentaje_descuento.HeaderText = "Porcentaje de Descuento";
            this.porcentaje_descuento.Name = "porcentaje_descuento";
            // 
            // frm_TipoFranquicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 361);
            this.Controls.Add(this.btn_agregarTipoFranquicia);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificarTipoFranquicia);
            this.Controls.Add(this.btn_eliminarFranquicia);
            this.Controls.Add(this.btn_habilitarModificarTipoFranquicia);
            this.Controls.Add(this.btn_habilitarAgregarTipoFranquicia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_porcentajeDescuento);
            this.Controls.Add(this.txt_montoMinimo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dgv_tipoFranquicia);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_TipoFranquicia";
            this.Text = "frm_TipoFranquicia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TipoFranquicia_FormClosing);
            this.Load += new System.EventHandler(this.frm_TipoFranquicia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoFranquicia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_tipoFranquicia;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_montoMinimo;
        private System.Windows.Forms.TextBox txt_porcentajeDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_habilitarAgregarTipoFranquicia;
        private System.Windows.Forms.Button btn_habilitarModificarTipoFranquicia;
        private System.Windows.Forms.Button btn_eliminarFranquicia;
        private System.Windows.Forms.Button btn_modificarTipoFranquicia;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregarTipoFranquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipo_franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_minimo_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_descuento;

    }
}