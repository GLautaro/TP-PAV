namespace TP_PAV.formularios
{
    partial class frm_ABM_UnidadMedida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_unidadMedida = new System.Windows.Forms.DataGridView();
            this.id_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_u_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregarUnidadMedida = new System.Windows.Forms.Button();
            this.btn_habilitarAgregarUnidadMedida = new System.Windows.Forms.Button();
            this.btn_eliminarUnidadMedida = new System.Windows.Forms.Button();
            this.btn_habilitarModificarUnidadMedida = new System.Windows.Forms.Button();
            this.btn_modificarUnidadMedida = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.msj_eliminado_ok = new System.Windows.Forms.Label();
            this.msj_modificado_ok = new System.Windows.Forms.Label();
            this.msj_registro_ok = new System.Windows.Forms.Label();
            this.msj_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unidadMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_unidadMedida
            // 
            this.dgv_unidadMedida.AllowUserToAddRows = false;
            this.dgv_unidadMedida.AllowUserToDeleteRows = false;
            this.dgv_unidadMedida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_unidadMedida.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_unidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_unidadMedida.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_unidadMedida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_unidadMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_unidadMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_u_medida,
            this.nombre_u_medida});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_unidadMedida.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_unidadMedida.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_unidadMedida.Location = new System.Drawing.Point(38, 229);
            this.dgv_unidadMedida.Name = "dgv_unidadMedida";
            this.dgv_unidadMedida.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_unidadMedida.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_unidadMedida.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_unidadMedida.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_unidadMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_unidadMedida.Size = new System.Drawing.Size(477, 167);
            this.dgv_unidadMedida.TabIndex = 69;
            this.dgv_unidadMedida.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tipoProducto_CellMouseClick);
            // 
            // id_u_medida
            // 
            this.id_u_medida.DataPropertyName = "id_u_medida";
            this.id_u_medida.HeaderText = "Código";
            this.id_u_medida.Name = "id_u_medida";
            this.id_u_medida.ReadOnly = true;
            // 
            // nombre_u_medida
            // 
            this.nombre_u_medida.DataPropertyName = "nombre_u_medida";
            this.nombre_u_medida.HeaderText = "Nombre";
            this.nombre_u_medida.Name = "nombre_u_medida";
            this.nombre_u_medida.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Administrar unidad de medida";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 32);
            this.panel1.TabIndex = 63;
            // 
            // btn_agregarUnidadMedida
            // 
            this.btn_agregarUnidadMedida.Location = new System.Drawing.Point(316, 155);
            this.btn_agregarUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregarUnidadMedida.Name = "btn_agregarUnidadMedida";
            this.btn_agregarUnidadMedida.Size = new System.Drawing.Size(63, 19);
            this.btn_agregarUnidadMedida.TabIndex = 62;
            this.btn_agregarUnidadMedida.Text = "Añadir";
            this.btn_agregarUnidadMedida.UseVisualStyleBackColor = true;
            this.btn_agregarUnidadMedida.Visible = false;
            this.btn_agregarUnidadMedida.Click += new System.EventHandler(this.btn_agregarUnidadMedida_Click);
            // 
            // btn_habilitarAgregarUnidadMedida
            // 
            this.btn_habilitarAgregarUnidadMedida.Location = new System.Drawing.Point(38, 102);
            this.btn_habilitarAgregarUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.btn_habilitarAgregarUnidadMedida.Name = "btn_habilitarAgregarUnidadMedida";
            this.btn_habilitarAgregarUnidadMedida.Size = new System.Drawing.Size(104, 28);
            this.btn_habilitarAgregarUnidadMedida.TabIndex = 61;
            this.btn_habilitarAgregarUnidadMedida.TabStop = false;
            this.btn_habilitarAgregarUnidadMedida.Text = "Nuevo";
            this.btn_habilitarAgregarUnidadMedida.UseVisualStyleBackColor = true;
            this.btn_habilitarAgregarUnidadMedida.Click += new System.EventHandler(this.btn_habilitarAgregarUnidadMedida_Click);
            // 
            // btn_eliminarUnidadMedida
            // 
            this.btn_eliminarUnidadMedida.Location = new System.Drawing.Point(413, 102);
            this.btn_eliminarUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminarUnidadMedida.Name = "btn_eliminarUnidadMedida";
            this.btn_eliminarUnidadMedida.Size = new System.Drawing.Size(102, 28);
            this.btn_eliminarUnidadMedida.TabIndex = 60;
            this.btn_eliminarUnidadMedida.TabStop = false;
            this.btn_eliminarUnidadMedida.Text = "Eliminar";
            this.btn_eliminarUnidadMedida.UseVisualStyleBackColor = true;
            this.btn_eliminarUnidadMedida.Click += new System.EventHandler(this.btn_eliminarUnidadMedida_Click);
            // 
            // btn_habilitarModificarUnidadMedida
            // 
            this.btn_habilitarModificarUnidadMedida.Location = new System.Drawing.Point(228, 102);
            this.btn_habilitarModificarUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.btn_habilitarModificarUnidadMedida.Name = "btn_habilitarModificarUnidadMedida";
            this.btn_habilitarModificarUnidadMedida.Size = new System.Drawing.Size(104, 28);
            this.btn_habilitarModificarUnidadMedida.TabIndex = 59;
            this.btn_habilitarModificarUnidadMedida.TabStop = false;
            this.btn_habilitarModificarUnidadMedida.Text = "Modificar";
            this.btn_habilitarModificarUnidadMedida.UseVisualStyleBackColor = true;
            this.btn_habilitarModificarUnidadMedida.Click += new System.EventHandler(this.btn_habilitarModificarUnidadMedida_Click);
            // 
            // btn_modificarUnidadMedida
            // 
            this.btn_modificarUnidadMedida.Location = new System.Drawing.Point(316, 155);
            this.btn_modificarUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificarUnidadMedida.Name = "btn_modificarUnidadMedida";
            this.btn_modificarUnidadMedida.Size = new System.Drawing.Size(63, 19);
            this.btn_modificarUnidadMedida.TabIndex = 58;
            this.btn_modificarUnidadMedida.Text = "Guardar";
            this.btn_modificarUnidadMedida.UseVisualStyleBackColor = true;
            this.btn_modificarUnidadMedida.Click += new System.EventHandler(this.btn_modificarUnidadMedida_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(383, 155);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(64, 19);
            this.btn_cancelar.TabIndex = 57;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(192, 153);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(110, 20);
            this.txt_nombre.TabIndex = 53;
            // 
            // msj_eliminado_ok
            // 
            this.msj_eliminado_ok.AutoSize = true;
            this.msj_eliminado_ok.BackColor = System.Drawing.Color.Transparent;
            this.msj_eliminado_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_eliminado_ok.ForeColor = System.Drawing.Color.LawnGreen;
            this.msj_eliminado_ok.Location = new System.Drawing.Point(167, 188);
            this.msj_eliminado_ok.Name = "msj_eliminado_ok";
            this.msj_eliminado_ok.Size = new System.Drawing.Size(259, 15);
            this.msj_eliminado_ok.TabIndex = 73;
            this.msj_eliminado_ok.Text = "Unidad de medida eliminado con éxito.";
            this.msj_eliminado_ok.Visible = false;
            // 
            // msj_modificado_ok
            // 
            this.msj_modificado_ok.AutoSize = true;
            this.msj_modificado_ok.BackColor = System.Drawing.Color.Transparent;
            this.msj_modificado_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_modificado_ok.ForeColor = System.Drawing.Color.LawnGreen;
            this.msj_modificado_ok.Location = new System.Drawing.Point(167, 188);
            this.msj_modificado_ok.Name = "msj_modificado_ok";
            this.msj_modificado_ok.Size = new System.Drawing.Size(266, 15);
            this.msj_modificado_ok.TabIndex = 72;
            this.msj_modificado_ok.Text = "Unidad de medida modificado con éxito.";
            this.msj_modificado_ok.Visible = false;
            // 
            // msj_registro_ok
            // 
            this.msj_registro_ok.AutoSize = true;
            this.msj_registro_ok.BackColor = System.Drawing.Color.Transparent;
            this.msj_registro_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_registro_ok.ForeColor = System.Drawing.Color.LawnGreen;
            this.msj_registro_ok.Location = new System.Drawing.Point(175, 188);
            this.msj_registro_ok.Name = "msj_registro_ok";
            this.msj_registro_ok.Size = new System.Drawing.Size(260, 15);
            this.msj_registro_ok.TabIndex = 71;
            this.msj_registro_ok.Text = "Unidad de medida registrado con éxito.";
            this.msj_registro_ok.Visible = false;
            // 
            // msj_error
            // 
            this.msj_error.AutoSize = true;
            this.msj_error.BackColor = System.Drawing.Color.Transparent;
            this.msj_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msj_error.ForeColor = System.Drawing.Color.Red;
            this.msj_error.Location = new System.Drawing.Point(219, 188);
            this.msj_error.Name = "msj_error";
            this.msj_error.Size = new System.Drawing.Size(175, 15);
            this.msj_error.TabIndex = 70;
            this.msj_error.Text = "Debe ingresar un nombre.";
            this.msj_error.Visible = false;
            // 
            // frm_ABM_UnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 413);
            this.Controls.Add(this.msj_eliminado_ok);
            this.Controls.Add(this.msj_modificado_ok);
            this.Controls.Add(this.msj_registro_ok);
            this.Controls.Add(this.msj_error);
            this.Controls.Add(this.dgv_unidadMedida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_agregarUnidadMedida);
            this.Controls.Add(this.btn_habilitarAgregarUnidadMedida);
            this.Controls.Add(this.btn_eliminarUnidadMedida);
            this.Controls.Add(this.btn_habilitarModificarUnidadMedida);
            this.Controls.Add(this.btn_modificarUnidadMedida);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Name = "frm_ABM_UnidadMedida";
            this.Text = "frm_ABM_UnidadMedida";
            this.Load += new System.EventHandler(this.frm_ABM_UnidadMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unidadMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_unidadMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agregarUnidadMedida;
        private System.Windows.Forms.Button btn_habilitarAgregarUnidadMedida;
        private System.Windows.Forms.Button btn_eliminarUnidadMedida;
        private System.Windows.Forms.Button btn_habilitarModificarUnidadMedida;
        private System.Windows.Forms.Button btn_modificarUnidadMedida;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_u_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_u_medida;
        private System.Windows.Forms.Label msj_eliminado_ok;
        private System.Windows.Forms.Label msj_modificado_ok;
        private System.Windows.Forms.Label msj_registro_ok;
        private System.Windows.Forms.Label msj_error;
    }
}