namespace TP_PAV.formularios
{
    partial class frm_ABM_Barrio
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
            this.label33 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_barrio = new System.Windows.Forms.TextBox();
            this.btn_habilitarAgregarBarrio = new System.Windows.Forms.Button();
            this.btn_habilitarModificarBarrio = new System.Windows.Forms.Button();
            this.btn_eliminarBarrio = new System.Windows.Forms.Button();
            this.btn_modificarBarrio = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregarBarrio = new System.Windows.Forms.Button();
            this.dgv_barrio = new System.Windows.Forms.DataGridView();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barrio)).BeginInit();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(12, 56);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(252, 32);
            this.label33.TabIndex = 44;
            this.label33.Text = "Administrar Barrios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 39);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre del Barrio:";
            // 
            // txt_nombre_barrio
            // 
            this.txt_nombre_barrio.Enabled = false;
            this.txt_nombre_barrio.Location = new System.Drawing.Point(145, 127);
            this.txt_nombre_barrio.Name = "txt_nombre_barrio";
            this.txt_nombre_barrio.Size = new System.Drawing.Size(119, 22);
            this.txt_nombre_barrio.TabIndex = 46;
            // 
            // btn_habilitarAgregarBarrio
            // 
            this.btn_habilitarAgregarBarrio.Location = new System.Drawing.Point(12, 419);
            this.btn_habilitarAgregarBarrio.Name = "btn_habilitarAgregarBarrio";
            this.btn_habilitarAgregarBarrio.Size = new System.Drawing.Size(197, 44);
            this.btn_habilitarAgregarBarrio.TabIndex = 48;
            this.btn_habilitarAgregarBarrio.Text = "Agregar Barrio Nuevo";
            this.btn_habilitarAgregarBarrio.UseVisualStyleBackColor = true;
            this.btn_habilitarAgregarBarrio.Click += new System.EventHandler(this.btn_habilitarAgregarBarrio_Click);
            // 
            // btn_habilitarModificarBarrio
            // 
            this.btn_habilitarModificarBarrio.Location = new System.Drawing.Point(290, 419);
            this.btn_habilitarModificarBarrio.Name = "btn_habilitarModificarBarrio";
            this.btn_habilitarModificarBarrio.Size = new System.Drawing.Size(197, 44);
            this.btn_habilitarModificarBarrio.TabIndex = 49;
            this.btn_habilitarModificarBarrio.Text = "Modificar Barrio";
            this.btn_habilitarModificarBarrio.UseVisualStyleBackColor = true;
            this.btn_habilitarModificarBarrio.Click += new System.EventHandler(this.btn_habilitarModificarBarrio_Click);
            // 
            // btn_eliminarBarrio
            // 
            this.btn_eliminarBarrio.Location = new System.Drawing.Point(572, 419);
            this.btn_eliminarBarrio.Name = "btn_eliminarBarrio";
            this.btn_eliminarBarrio.Size = new System.Drawing.Size(197, 44);
            this.btn_eliminarBarrio.TabIndex = 50;
            this.btn_eliminarBarrio.Text = "Eliminar Barrio";
            this.btn_eliminarBarrio.UseVisualStyleBackColor = true;
            this.btn_eliminarBarrio.Click += new System.EventHandler(this.btn_eliminarBarrio_Click);
            // 
            // btn_modificarBarrio
            // 
            this.btn_modificarBarrio.Enabled = false;
            this.btn_modificarBarrio.Location = new System.Drawing.Point(270, 128);
            this.btn_modificarBarrio.Name = "btn_modificarBarrio";
            this.btn_modificarBarrio.Size = new System.Drawing.Size(75, 23);
            this.btn_modificarBarrio.TabIndex = 51;
            this.btn_modificarBarrio.Text = "Guardar";
            this.btn_modificarBarrio.UseVisualStyleBackColor = true;
            this.btn_modificarBarrio.Click += new System.EventHandler(this.btn_modificarBarrio_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(351, 127);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 52;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregarBarrio
            // 
            this.btn_agregarBarrio.Location = new System.Drawing.Point(270, 126);
            this.btn_agregarBarrio.Name = "btn_agregarBarrio";
            this.btn_agregarBarrio.Size = new System.Drawing.Size(75, 25);
            this.btn_agregarBarrio.TabIndex = 53;
            this.btn_agregarBarrio.Text = "Añadir";
            this.btn_agregarBarrio.UseVisualStyleBackColor = true;
            this.btn_agregarBarrio.Visible = false;
            this.btn_agregarBarrio.Click += new System.EventHandler(this.btn_agregarBarrio_Click);
            // 
            // dgv_barrio
            // 
            this.dgv_barrio.AllowUserToAddRows = false;
            this.dgv_barrio.AllowUserToDeleteRows = false;
            this.dgv_barrio.AllowUserToResizeColumns = false;
            this.dgv_barrio.AllowUserToResizeRows = false;
            this.dgv_barrio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_barrio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_barrio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_barrio.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_barrio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_barrio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_barrio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_barrio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_barrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_barrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barrio,
            this.nombre_barrio});
            this.dgv_barrio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_barrio.EnableHeadersVisualStyles = false;
            this.dgv_barrio.GridColor = System.Drawing.Color.Black;
            this.dgv_barrio.Location = new System.Drawing.Point(12, 166);
            this.dgv_barrio.MultiSelect = false;
            this.dgv_barrio.Name = "dgv_barrio";
            this.dgv_barrio.ReadOnly = true;
            this.dgv_barrio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_barrio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_barrio.RowHeadersVisible = false;
            this.dgv_barrio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_barrio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_barrio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_barrio.Size = new System.Drawing.Size(757, 235);
            this.dgv_barrio.TabIndex = 58;
            this.dgv_barrio.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_barrio_CellMouseClick);
            // 
            // id_barrio
            // 
            this.id_barrio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_barrio.DataPropertyName = "id_barrio";
            this.id_barrio.HeaderText = "ID Barrio";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_barrio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre_barrio
            // 
            this.nombre_barrio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre_barrio.DataPropertyName = "nombre_barrio";
            this.nombre_barrio.HeaderText = "Nombre";
            this.nombre_barrio.Name = "nombre_barrio";
            this.nombre_barrio.ReadOnly = true;
            this.nombre_barrio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre_barrio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frm_ABM_Barrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 481);
            this.Controls.Add(this.dgv_barrio);
            this.Controls.Add(this.btn_agregarBarrio);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificarBarrio);
            this.Controls.Add(this.btn_eliminarBarrio);
            this.Controls.Add(this.btn_habilitarModificarBarrio);
            this.Controls.Add(this.btn_habilitarAgregarBarrio);
            this.Controls.Add(this.txt_nombre_barrio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ABM_Barrio";
            this.Text = "Administrar Barrios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ABM_Barrio_FormClosing);
            this.Load += new System.EventHandler(this.frm_ABM_Barrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_barrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_barrio;
        private System.Windows.Forms.Button btn_habilitarAgregarBarrio;
        private System.Windows.Forms.Button btn_habilitarModificarBarrio;
        private System.Windows.Forms.Button btn_eliminarBarrio;
        private System.Windows.Forms.Button btn_modificarBarrio;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregarBarrio;
        private System.Windows.Forms.DataGridView dgv_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_barrio;
    }
}