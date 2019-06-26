namespace TP_PAV.formularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_habilitarAgregarTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_habilitarModificarTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_handleStateTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_modificarTipoFranquicia = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregarTipoFranquicia = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_montoMinimo = new System.Windows.Forms.TextBox();
            this.dgv_tipoFranquicia = new System.Windows.Forms.DataGridView();
            this.label_validation = new System.Windows.Forms.Label();
            this.titulo_estadisticas = new System.Windows.Forms.Label();
            this.id_tipo_franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_tipo_franquicia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_minimo_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado_tipo_franquicia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoFranquicia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 39);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto Minimo";
            // 
            // btn_habilitarAgregarTipoFranquicia
            // 
            this.btn_habilitarAgregarTipoFranquicia.Location = new System.Drawing.Point(19, 112);
            this.btn_habilitarAgregarTipoFranquicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_habilitarAgregarTipoFranquicia.Name = "btn_habilitarAgregarTipoFranquicia";
            this.btn_habilitarAgregarTipoFranquicia.Size = new System.Drawing.Size(145, 34);
            this.btn_habilitarAgregarTipoFranquicia.TabIndex = 9;
            this.btn_habilitarAgregarTipoFranquicia.Text = "Añadir Nuevo";
            this.btn_habilitarAgregarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_habilitarAgregarTipoFranquicia.Click += new System.EventHandler(this.btn_habilitarAgregarTipoFranquicia_Click);
            // 
            // btn_habilitarModificarTipoFranquicia
            // 
            this.btn_habilitarModificarTipoFranquicia.Location = new System.Drawing.Point(261, 112);
            this.btn_habilitarModificarTipoFranquicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_habilitarModificarTipoFranquicia.Name = "btn_habilitarModificarTipoFranquicia";
            this.btn_habilitarModificarTipoFranquicia.Size = new System.Drawing.Size(139, 34);
            this.btn_habilitarModificarTipoFranquicia.TabIndex = 10;
            this.btn_habilitarModificarTipoFranquicia.Text = "Modificar";
            this.btn_habilitarModificarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_habilitarModificarTipoFranquicia.Click += new System.EventHandler(this.btn_habilitarModificarTipoFranquicia_Click);
            // 
            // btn_handleStateTipoFranquicia
            // 
            this.btn_handleStateTipoFranquicia.Location = new System.Drawing.Point(507, 112);
            this.btn_handleStateTipoFranquicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_handleStateTipoFranquicia.Name = "btn_handleStateTipoFranquicia";
            this.btn_handleStateTipoFranquicia.Size = new System.Drawing.Size(165, 34);
            this.btn_handleStateTipoFranquicia.TabIndex = 11;
            this.btn_handleStateTipoFranquicia.Text = "Habilitar";
            this.btn_handleStateTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_handleStateTipoFranquicia.Click += new System.EventHandler(this.btn_hanldeStateTipoFranquicia_Click);
            // 
            // btn_modificarTipoFranquicia
            // 
            this.btn_modificarTipoFranquicia.Enabled = false;
            this.btn_modificarTipoFranquicia.Location = new System.Drawing.Point(340, 189);
            this.btn_modificarTipoFranquicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificarTipoFranquicia.Name = "btn_modificarTipoFranquicia";
            this.btn_modificarTipoFranquicia.Size = new System.Drawing.Size(75, 23);
            this.btn_modificarTipoFranquicia.TabIndex = 12;
            this.btn_modificarTipoFranquicia.Text = "Guardar";
            this.btn_modificarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_modificarTipoFranquicia.Click += new System.EventHandler(this.btn_modificarTipoFranquicia_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(420, 190);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(84, 23);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregarTipoFranquicia
            // 
            this.btn_agregarTipoFranquicia.Enabled = false;
            this.btn_agregarTipoFranquicia.Location = new System.Drawing.Point(340, 190);
            this.btn_agregarTipoFranquicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregarTipoFranquicia.Name = "btn_agregarTipoFranquicia";
            this.btn_agregarTipoFranquicia.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarTipoFranquicia.TabIndex = 14;
            this.btn_agregarTipoFranquicia.Text = "Añadir";
            this.btn_agregarTipoFranquicia.UseVisualStyleBackColor = true;
            this.btn_agregarTipoFranquicia.Visible = false;
            this.btn_agregarTipoFranquicia.Click += new System.EventHandler(this.btn_agregarTipoFranquicia_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(13, 188);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(145, 22);
            this.txt_nombre.TabIndex = 16;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_montoMinimo
            // 
            this.txt_montoMinimo.Location = new System.Drawing.Point(185, 190);
            this.txt_montoMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_montoMinimo.Name = "txt_montoMinimo";
            this.txt_montoMinimo.Size = new System.Drawing.Size(135, 22);
            this.txt_montoMinimo.TabIndex = 17;
            this.txt_montoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_montoMinimo_KeyPress);
            // 
            // dgv_tipoFranquicia
            // 
            this.dgv_tipoFranquicia.AllowUserToAddRows = false;
            this.dgv_tipoFranquicia.AllowUserToDeleteRows = false;
            this.dgv_tipoFranquicia.AllowUserToResizeColumns = false;
            this.dgv_tipoFranquicia.AllowUserToResizeRows = false;
            this.dgv_tipoFranquicia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tipoFranquicia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tipoFranquicia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tipoFranquicia.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_tipoFranquicia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tipoFranquicia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_tipoFranquicia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tipoFranquicia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tipoFranquicia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoFranquicia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tipo_franquicia,
            this.nombre_tipo_franquicia,
            this.monto_minimo_compra,
            this.habilitado_tipo_franquicia});
            this.dgv_tipoFranquicia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_tipoFranquicia.EnableHeadersVisualStyles = false;
            this.dgv_tipoFranquicia.GridColor = System.Drawing.Color.Black;
            this.dgv_tipoFranquicia.Location = new System.Drawing.Point(15, 249);
            this.dgv_tipoFranquicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tipoFranquicia.MultiSelect = false;
            this.dgv_tipoFranquicia.Name = "dgv_tipoFranquicia";
            this.dgv_tipoFranquicia.ReadOnly = true;
            this.dgv_tipoFranquicia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tipoFranquicia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tipoFranquicia.RowHeadersVisible = false;
            this.dgv_tipoFranquicia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_tipoFranquicia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tipoFranquicia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tipoFranquicia.Size = new System.Drawing.Size(653, 219);
            this.dgv_tipoFranquicia.TabIndex = 57;
            this.dgv_tipoFranquicia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tipoFranquicia_CellMouseClick);
            // 
            // label_validation
            // 
            this.label_validation.AutoSize = true;
            this.label_validation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_validation.ForeColor = System.Drawing.Color.Red;
            this.label_validation.Location = new System.Drawing.Point(225, 218);
            this.label_validation.Name = "label_validation";
            this.label_validation.Size = new System.Drawing.Size(52, 20);
            this.label_validation.TabIndex = 58;
            this.label_validation.Text = "Error";
            this.label_validation.Visible = false;
            // 
            // titulo_estadisticas
            // 
            this.titulo_estadisticas.AutoSize = true;
            this.titulo_estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.titulo_estadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.titulo_estadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titulo_estadisticas.Location = new System.Drawing.Point(12, 60);
            this.titulo_estadisticas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo_estadisticas.Name = "titulo_estadisticas";
            this.titulo_estadisticas.Size = new System.Drawing.Size(594, 30);
            this.titulo_estadisticas.TabIndex = 79;
            this.titulo_estadisticas.Text = "   ADMINISTRAR TIPOS DE FRANQUICIAS     ";
            // 
            // id_tipo_franquicia
            // 
            this.id_tipo_franquicia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_tipo_franquicia.DataPropertyName = "id_tipo_franquicia";
            this.id_tipo_franquicia.HeaderText = "ID Tipo Franquicia";
            this.id_tipo_franquicia.Name = "id_tipo_franquicia";
            this.id_tipo_franquicia.ReadOnly = true;
            this.id_tipo_franquicia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_tipo_franquicia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre_tipo_franquicia
            // 
            this.nombre_tipo_franquicia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_tipo_franquicia.DataPropertyName = "nombre_tipo_franquicia";
            this.nombre_tipo_franquicia.HeaderText = "Nombre";
            this.nombre_tipo_franquicia.Name = "nombre_tipo_franquicia";
            this.nombre_tipo_franquicia.ReadOnly = true;
            this.nombre_tipo_franquicia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre_tipo_franquicia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monto_minimo_compra
            // 
            this.monto_minimo_compra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monto_minimo_compra.DataPropertyName = "monto_minimo_compra";
            this.monto_minimo_compra.HeaderText = "Monto Minimo Compra";
            this.monto_minimo_compra.Name = "monto_minimo_compra";
            this.monto_minimo_compra.ReadOnly = true;
            this.monto_minimo_compra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.monto_minimo_compra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // habilitado_tipo_franquicia
            // 
            this.habilitado_tipo_franquicia.DataPropertyName = "habilitado";
            this.habilitado_tipo_franquicia.HeaderText = "Habilitado";
            this.habilitado_tipo_franquicia.Name = "habilitado_tipo_franquicia";
            this.habilitado_tipo_franquicia.ReadOnly = true;
            // 
            // frm_TipoFranquicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 479);
            this.Controls.Add(this.titulo_estadisticas);
            this.Controls.Add(this.label_validation);
            this.Controls.Add(this.btn_handleStateTipoFranquicia);
            this.Controls.Add(this.btn_habilitarAgregarTipoFranquicia);
            this.Controls.Add(this.dgv_tipoFranquicia);
            this.Controls.Add(this.btn_habilitarModificarTipoFranquicia);
            this.Controls.Add(this.txt_montoMinimo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btn_agregarTipoFranquicia);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificarTipoFranquicia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_habilitarAgregarTipoFranquicia;
        private System.Windows.Forms.Button btn_habilitarModificarTipoFranquicia;
        private System.Windows.Forms.Button btn_handleStateTipoFranquicia;
        private System.Windows.Forms.Button btn_modificarTipoFranquicia;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregarTipoFranquicia;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_montoMinimo;
        private System.Windows.Forms.DataGridView dgv_tipoFranquicia;
        private System.Windows.Forms.Label label_validation;
        private System.Windows.Forms.Label titulo_estadisticas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_tipo_franquicia;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_minimo_compra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitado_tipo_franquicia;

    }
}