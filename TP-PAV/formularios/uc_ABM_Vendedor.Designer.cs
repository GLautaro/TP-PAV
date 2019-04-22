namespace TP_PAV.formularios
{
    partial class uc_ABM_Vendedor
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_nuevoVendedor = new System.Windows.Forms.Button();
            this.txt_comision = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_legajo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_vendedores = new System.Windows.Forms.DataGridView();
            this.legajo_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nuevoVendedor
            // 
            this.btn_nuevoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoVendedor.Location = new System.Drawing.Point(32, 327);
            this.btn_nuevoVendedor.Name = "btn_nuevoVendedor";
            this.btn_nuevoVendedor.Size = new System.Drawing.Size(173, 39);
            this.btn_nuevoVendedor.TabIndex = 45;
            this.btn_nuevoVendedor.Text = "Nuevo Vendedor";
            this.btn_nuevoVendedor.UseVisualStyleBackColor = true;
            this.btn_nuevoVendedor.Click += new System.EventHandler(this.btn_nuevoVendedor_Click);
            // 
            // txt_comision
            // 
            this.txt_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comision.Location = new System.Drawing.Point(705, 276);
            this.txt_comision.Name = "txt_comision";
            this.txt_comision.Size = new System.Drawing.Size(186, 22);
            this.txt_comision.TabIndex = 44;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(705, 246);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(186, 22);
            this.txt_apellido.TabIndex = 43;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(705, 210);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(186, 22);
            this.txt_nombre.TabIndex = 42;
            // 
            // txt_legajo
            // 
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.Location = new System.Drawing.Point(705, 177);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(186, 22);
            this.txt_legajo.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Comision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(782, 327);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(109, 41);
            this.btn_modificar.TabIndex = 36;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Visible = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(846, 126);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(67, 30);
            this.btn_buscar.TabIndex = 49;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.Location = new System.Drawing.Point(674, 130);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(160, 22);
            this.txt_busqueda.TabIndex = 48;
            this.txt_busqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busqueda_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Buscar:";
            // 
            // dgv_vendedores
            // 
            this.dgv_vendedores.AllowUserToAddRows = false;
            this.dgv_vendedores.AllowUserToDeleteRows = false;
            this.dgv_vendedores.AllowUserToResizeColumns = false;
            this.dgv_vendedores.AllowUserToResizeRows = false;
            this.dgv_vendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vendedores.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_vendedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_vendedores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_vendedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo_vendedor,
            this.nombre_vendedor,
            this.apellido_vendedor,
            this.Comision});
            this.dgv_vendedores.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_vendedores.EnableHeadersVisualStyles = false;
            this.dgv_vendedores.GridColor = System.Drawing.Color.Black;
            this.dgv_vendedores.Location = new System.Drawing.Point(20, 96);
            this.dgv_vendedores.MultiSelect = false;
            this.dgv_vendedores.Name = "dgv_vendedores";
            this.dgv_vendedores.ReadOnly = true;
            this.dgv_vendedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vendedores.RowHeadersVisible = false;
            this.dgv_vendedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_vendedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_vendedores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendedores.Size = new System.Drawing.Size(565, 202);
            this.dgv_vendedores.TabIndex = 22;
            this.dgv_vendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vendedores_CellContentClick);
            // 
            // legajo_vendedor
            // 
            this.legajo_vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.legajo_vendedor.DataPropertyName = "legajo_vendedor";
            this.legajo_vendedor.Frozen = true;
            this.legajo_vendedor.HeaderText = "Legajo";
            this.legajo_vendedor.Name = "legajo_vendedor";
            this.legajo_vendedor.ReadOnly = true;
            this.legajo_vendedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.legajo_vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.legajo_vendedor.Width = 60;
            // 
            // nombre_vendedor
            // 
            this.nombre_vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre_vendedor.DataPropertyName = "nombre_vendedor";
            this.nombre_vendedor.Frozen = true;
            this.nombre_vendedor.HeaderText = "Nombre";
            this.nombre_vendedor.Name = "nombre_vendedor";
            this.nombre_vendedor.ReadOnly = true;
            this.nombre_vendedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre_vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre_vendedor.Width = 67;
            // 
            // apellido_vendedor
            // 
            this.apellido_vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.apellido_vendedor.DataPropertyName = "apellido_vendedor";
            this.apellido_vendedor.Frozen = true;
            this.apellido_vendedor.HeaderText = "Apellido";
            this.apellido_vendedor.Name = "apellido_vendedor";
            this.apellido_vendedor.ReadOnly = true;
            this.apellido_vendedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.apellido_vendedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.apellido_vendedor.Width = 70;
            // 
            // Comision
            // 
            this.Comision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Comision.DataPropertyName = "porcentaje_comision";
            this.Comision.Frozen = true;
            this.Comision.HeaderText = "Comision (%)";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            this.Comision.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Comision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Comision.Width = 93;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Vendedores";
            // 
            // uc_ABM_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_nuevoVendedor);
            this.Controls.Add(this.txt_comision);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_vendedores);
            this.Name = "uc_ABM_Vendedor";
            this.Size = new System.Drawing.Size(972, 430);
            this.Load += new System.EventHandler(this.uc_ABM_vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nuevoVendedor;
        private System.Windows.Forms.TextBox txt_comision;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_legajo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_vendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.Label label5;
    }
}
