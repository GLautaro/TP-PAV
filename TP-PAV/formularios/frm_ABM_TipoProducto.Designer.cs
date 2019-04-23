namespace TP_PAV.formularios
{
    partial class frm_ABM_TipoProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_tipoProducto = new System.Windows.Forms.DataGridView();
            this.btn_agregarTipoProducto = new System.Windows.Forms.Button();
            this.btn_habilitarAgregarTipoProducto = new System.Windows.Forms.Button();
            this.btn_eliminarTipoProducto = new System.Windows.Forms.Button();
            this.btn_habilitarModificarTipoProducto = new System.Windows.Forms.Button();
            this.btn_modificarTipoProducto = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.msj_error = new System.Windows.Forms.Label();
            this.msj_registro_ok = new System.Windows.Forms.Label();
            this.msj_modificado_ok = new System.Windows.Forms.Label();
            this.msj_eliminado_ok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tipoProducto
            // 
            this.dgv_tipoProducto.AllowUserToAddRows = false;
            this.dgv_tipoProducto.AllowUserToDeleteRows = false;
            this.dgv_tipoProducto.AllowUserToResizeColumns = false;
            this.dgv_tipoProducto.AllowUserToResizeRows = false;
            this.dgv_tipoProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tipoProducto.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgv_tipoProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_tipoProducto.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_tipoProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tipoProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tipoProducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_tipoProducto.EnableHeadersVisualStyles = false;
            this.dgv_tipoProducto.GridColor = System.Drawing.Color.Black;
            this.dgv_tipoProducto.Location = new System.Drawing.Point(38, 201);
            this.dgv_tipoProducto.MultiSelect = false;
            this.dgv_tipoProducto.Name = "dgv_tipoProducto";
            this.dgv_tipoProducto.ReadOnly = true;
            this.dgv_tipoProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tipoProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_tipoProducto.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_tipoProducto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_tipoProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_tipoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tipoProducto.Size = new System.Drawing.Size(477, 150);
            this.dgv_tipoProducto.TabIndex = 40;
            this.dgv_tipoProducto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tipoProducto_CellMouseClick);
            // 
            // btn_agregarTipoProducto
            // 
            this.btn_agregarTipoProducto.Location = new System.Drawing.Point(354, 138);
            this.btn_agregarTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarTipoProducto.Name = "btn_agregarTipoProducto";
            this.btn_agregarTipoProducto.Size = new System.Drawing.Size(63, 19);
            this.btn_agregarTipoProducto.TabIndex = 39;
            this.btn_agregarTipoProducto.Text = "Añadir";
            this.btn_agregarTipoProducto.UseVisualStyleBackColor = true;
            this.btn_agregarTipoProducto.Visible = false;
            this.btn_agregarTipoProducto.Click += new System.EventHandler(this.btn_agregarTipoProducto_Click);
            // 
            // btn_habilitarAgregarTipoProducto
            // 
            this.btn_habilitarAgregarTipoProducto.Location = new System.Drawing.Point(38, 85);
            this.btn_habilitarAgregarTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_habilitarAgregarTipoProducto.Name = "btn_habilitarAgregarTipoProducto";
            this.btn_habilitarAgregarTipoProducto.Size = new System.Drawing.Size(104, 28);
            this.btn_habilitarAgregarTipoProducto.TabIndex = 38;
            this.btn_habilitarAgregarTipoProducto.TabStop = false;
            this.btn_habilitarAgregarTipoProducto.Text = "Nuevo";
            this.btn_habilitarAgregarTipoProducto.UseVisualStyleBackColor = true;
            this.btn_habilitarAgregarTipoProducto.Click += new System.EventHandler(this.btn_habilitarAgregarTipoProducto_Click);
            // 
            // btn_eliminarTipoProducto
            // 
            this.btn_eliminarTipoProducto.Location = new System.Drawing.Point(413, 85);
            this.btn_eliminarTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminarTipoProducto.Name = "btn_eliminarTipoProducto";
            this.btn_eliminarTipoProducto.Size = new System.Drawing.Size(102, 28);
            this.btn_eliminarTipoProducto.TabIndex = 37;
            this.btn_eliminarTipoProducto.TabStop = false;
            this.btn_eliminarTipoProducto.Text = "Eliminar";
            this.btn_eliminarTipoProducto.UseVisualStyleBackColor = true;
            this.btn_eliminarTipoProducto.Click += new System.EventHandler(this.btn_eliminarTipoProducto_Click);
            // 
            // btn_habilitarModificarTipoProducto
            // 
            this.btn_habilitarModificarTipoProducto.Location = new System.Drawing.Point(228, 85);
            this.btn_habilitarModificarTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_habilitarModificarTipoProducto.Name = "btn_habilitarModificarTipoProducto";
            this.btn_habilitarModificarTipoProducto.Size = new System.Drawing.Size(104, 28);
            this.btn_habilitarModificarTipoProducto.TabIndex = 36;
            this.btn_habilitarModificarTipoProducto.TabStop = false;
            this.btn_habilitarModificarTipoProducto.Text = "Modificar";
            this.btn_habilitarModificarTipoProducto.UseVisualStyleBackColor = true;
            this.btn_habilitarModificarTipoProducto.Click += new System.EventHandler(this.btn_habilitarModificarTipoProducto_Click);
            // 
            // btn_modificarTipoProducto
            // 
            this.btn_modificarTipoProducto.Location = new System.Drawing.Point(354, 139);
            this.btn_modificarTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificarTipoProducto.Name = "btn_modificarTipoProducto";
            this.btn_modificarTipoProducto.Size = new System.Drawing.Size(63, 19);
            this.btn_modificarTipoProducto.TabIndex = 35;
            this.btn_modificarTipoProducto.Text = "Guardar";
            this.btn_modificarTipoProducto.UseVisualStyleBackColor = true;
            this.btn_modificarTipoProducto.Click += new System.EventHandler(this.btn_modificarTipoProducto_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(421, 138);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 19);
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(222, 139);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(110, 20);
            this.txt_descripcion.TabIndex = 31;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(74, 138);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(110, 20);
            this.txt_nombre.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 32);
            this.panel1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Administrar tipos de productos";
            // 
            // msj_error
            // 
            this.msj_error.AutoSize = true;
            this.msj_error.BackColor = System.Drawing.Color.Red;
            this.msj_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_error.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.msj_error.Location = new System.Drawing.Point(193, 172);
            this.msj_error.Name = "msj_error";
            this.msj_error.Size = new System.Drawing.Size(175, 15);
            this.msj_error.TabIndex = 43;
            this.msj_error.Text = "Debe ingresar un nombre.";
            this.msj_error.Visible = false;
            // 
            // msj_registro_ok
            // 
            this.msj_registro_ok.AutoSize = true;
            this.msj_registro_ok.BackColor = System.Drawing.Color.LawnGreen;
            this.msj_registro_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_registro_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msj_registro_ok.Location = new System.Drawing.Point(152, 172);
            this.msj_registro_ok.Name = "msj_registro_ok";
            this.msj_registro_ok.Size = new System.Drawing.Size(250, 15);
            this.msj_registro_ok.TabIndex = 44;
            this.msj_registro_ok.Text = "Tipo de producto registrado con éxito.";
            this.msj_registro_ok.Visible = false;
            // 
            // msj_modificado_ok
            // 
            this.msj_modificado_ok.AutoSize = true;
            this.msj_modificado_ok.BackColor = System.Drawing.Color.LawnGreen;
            this.msj_modificado_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_modificado_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msj_modificado_ok.Location = new System.Drawing.Point(152, 172);
            this.msj_modificado_ok.Name = "msj_modificado_ok";
            this.msj_modificado_ok.Size = new System.Drawing.Size(256, 15);
            this.msj_modificado_ok.TabIndex = 45;
            this.msj_modificado_ok.Text = "Tipo de producto modificado con éxito.";
            this.msj_modificado_ok.Visible = false;
            // 
            // msj_eliminado_ok
            // 
            this.msj_eliminado_ok.AutoSize = true;
            this.msj_eliminado_ok.BackColor = System.Drawing.Color.LawnGreen;
            this.msj_eliminado_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_eliminado_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msj_eliminado_ok.Location = new System.Drawing.Point(152, 172);
            this.msj_eliminado_ok.Name = "msj_eliminado_ok";
            this.msj_eliminado_ok.Size = new System.Drawing.Size(249, 15);
            this.msj_eliminado_ok.TabIndex = 46;
            this.msj_eliminado_ok.Text = "Tipo de producto eliminado con éxito.";
            this.msj_eliminado_ok.Visible = false;
            // 
            // frm_ABM_TipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 363);
            this.Controls.Add(this.msj_eliminado_ok);
            this.Controls.Add(this.msj_modificado_ok);
            this.Controls.Add(this.msj_registro_ok);
            this.Controls.Add(this.msj_error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_tipoProducto);
            this.Controls.Add(this.btn_agregarTipoProducto);
            this.Controls.Add(this.btn_habilitarAgregarTipoProducto);
            this.Controls.Add(this.btn_eliminarTipoProducto);
            this.Controls.Add(this.btn_habilitarModificarTipoProducto);
            this.Controls.Add(this.btn_modificarTipoProducto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Name = "frm_ABM_TipoProducto";
            this.Text = "frm_ABM_TipoProducto";
            this.Load += new System.EventHandler(this.frm_ABM_TipoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tipoProducto;
        private System.Windows.Forms.Button btn_agregarTipoProducto;
        private System.Windows.Forms.Button btn_habilitarAgregarTipoProducto;
        private System.Windows.Forms.Button btn_eliminarTipoProducto;
        private System.Windows.Forms.Button btn_habilitarModificarTipoProducto;
        private System.Windows.Forms.Button btn_modificarTipoProducto;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msj_error;
        private System.Windows.Forms.Label msj_registro_ok;
        private System.Windows.Forms.Label msj_modificado_ok;
        private System.Windows.Forms.Label msj_eliminado_ok;
    }
}