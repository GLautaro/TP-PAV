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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_registrar = new System.Windows.Forms.Button();
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_vendedores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label_informacion = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_activarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_habilitado = new System.Windows.Forms.ComboBox();
            this.grp_busquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.txt_busqAvan_comisionHasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_busqAvan_comisionDesde = new System.Windows.Forms.MaskedTextBox();
            this.txt_busqAvan_legajoHasta = new System.Windows.Forms.MaskedTextBox();
            this.txt_busqAvan_legajoDesde = new System.Windows.Forms.MaskedTextBox();
            this.chb_comision = new System.Windows.Forms.CheckBox();
            this.chb_NomyApe = new System.Windows.Forms.CheckBox();
            this.chb_legajo = new System.Windows.Forms.CheckBox();
            this.busqAvan_informacion = new System.Windows.Forms.Label();
            this.btn_cerrarBusquedaAvanzada = new System.Windows.Forms.Button();
            this.label_legajoHasta = new System.Windows.Forms.Label();
            this.label_legajoDesde = new System.Windows.Forms.Label();
            this.btn_busquedaAvanzada = new System.Windows.Forms.Button();
            this.radio_busqAvan_deshabilitados = new System.Windows.Forms.RadioButton();
            this.radio_busqAvan_habilitados = new System.Windows.Forms.RadioButton();
            this.radio_busqAvan_todos = new System.Windows.Forms.RadioButton();
            this.label_disponibilidad = new System.Windows.Forms.Label();
            this.txt_busqAvan_apellido = new System.Windows.Forms.TextBox();
            this.label_comisionHasta = new System.Windows.Forms.Label();
            this.label_comisionDesde = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.txt_busqAvan_nombre = new System.Windows.Forms.TextBox();
            this.btn_disponibilidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).BeginInit();
            this.grp_busquedaAvanzada.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(149, 124);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(109, 49);
            this.btn_registrar.TabIndex = 45;
            this.btn_registrar.Text = "Nuevo Vendedor";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_nuevoVendedor_Click);
            // 
            // txt_comision
            // 
            this.txt_comision.Enabled = false;
            this.txt_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comision.Location = new System.Drawing.Point(865, 391);
            this.txt_comision.Name = "txt_comision";
            this.txt_comision.Size = new System.Drawing.Size(186, 22);
            this.txt_comision.TabIndex = 44;
            this.txt_comision.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ocultar_label_informacion);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(865, 336);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(186, 22);
            this.txt_apellido.TabIndex = 43;
            this.txt_apellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ocultar_label_informacion);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(865, 279);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(186, 22);
            this.txt_nombre.TabIndex = 42;
            this.txt_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ocultar_label_informacion);
            // 
            // txt_legajo
            // 
            this.txt_legajo.Enabled = false;
            this.txt_legajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_legajo.Location = new System.Drawing.Point(865, 225);
            this.txt_legajo.Name = "txt_legajo";
            this.txt_legajo.Size = new System.Drawing.Size(186, 22);
            this.txt_legajo.TabIndex = 41;
            this.txt_legajo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ocultar_label_informacion);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(795, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Legajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(795, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Comision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(795, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(316, 124);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(109, 49);
            this.btn_modificar.TabIndex = 36;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(414, 56);
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
            this.txt_busqueda.Location = new System.Drawing.Point(130, 60);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(260, 22);
            this.txt_busqueda.TabIndex = 48;
            this.txt_busqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busqueda_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Buscar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Administrar Vendedores";
            // 
            // dgv_vendedores
            // 
            this.dgv_vendedores.AllowUserToAddRows = false;
            this.dgv_vendedores.AllowUserToDeleteRows = false;
            this.dgv_vendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vendedores.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgv_vendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vendedores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendedores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_vendedores.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_vendedores.Location = new System.Drawing.Point(15, 200);
            this.dgv_vendedores.MultiSelect = false;
            this.dgv_vendedores.Name = "dgv_vendedores";
            this.dgv_vendedores.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_vendedores.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_vendedores.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendedores.Size = new System.Drawing.Size(700, 350);
            this.dgv_vendedores.TabIndex = 51;
            this.dgv_vendedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vendedores_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "legajo_vendedor";
            this.Column1.HeaderText = "Legajo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombre_vendedor";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "apellido_vendedor";
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "porcentaje_comision";
            this.Column4.HeaderText = "Comision";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "habilitado";
            this.Column5.HeaderText = "Habilitado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label_informacion
            // 
            this.label_informacion.AutoSize = true;
            this.label_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_informacion.ForeColor = System.Drawing.Color.Red;
            this.label_informacion.Location = new System.Drawing.Point(810, 494);
            this.label_informacion.Name = "label_informacion";
            this.label_informacion.Size = new System.Drawing.Size(51, 16);
            this.label_informacion.TabIndex = 52;
            this.label_informacion.Text = "label7";
            this.label_informacion.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(865, 527);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 53;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(976, 527);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 54;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_activarBusquedaAvanzada
            // 
            this.btn_activarBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_activarBusquedaAvanzada.Location = new System.Drawing.Point(507, 56);
            this.btn_activarBusquedaAvanzada.Name = "btn_activarBusquedaAvanzada";
            this.btn_activarBusquedaAvanzada.Size = new System.Drawing.Size(146, 30);
            this.btn_activarBusquedaAvanzada.TabIndex = 55;
            this.btn_activarBusquedaAvanzada.Text = "Busqueda avanzada";
            this.btn_activarBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btn_activarBusquedaAvanzada.Click += new System.EventHandler(this.btn_activarBusquedaAvanzada_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(797, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Habilitado";
            // 
            // cmb_habilitado
            // 
            this.cmb_habilitado.Enabled = false;
            this.cmb_habilitado.FormattingEnabled = true;
            this.cmb_habilitado.Items.AddRange(new object[] {
            "No habilitado",
            "Habilitado"});
            this.cmb_habilitado.Location = new System.Drawing.Point(865, 449);
            this.cmb_habilitado.Name = "cmb_habilitado";
            this.cmb_habilitado.Size = new System.Drawing.Size(186, 21);
            this.cmb_habilitado.TabIndex = 57;
            // 
            // grp_busquedaAvanzada
            // 
            this.grp_busquedaAvanzada.BackColor = System.Drawing.SystemColors.Control;
            this.grp_busquedaAvanzada.Controls.Add(this.txt_busqAvan_comisionHasta);
            this.grp_busquedaAvanzada.Controls.Add(this.txt_busqAvan_comisionDesde);
            this.grp_busquedaAvanzada.Controls.Add(this.txt_busqAvan_legajoHasta);
            this.grp_busquedaAvanzada.Controls.Add(this.txt_busqAvan_legajoDesde);
            this.grp_busquedaAvanzada.Controls.Add(this.chb_comision);
            this.grp_busquedaAvanzada.Controls.Add(this.chb_NomyApe);
            this.grp_busquedaAvanzada.Controls.Add(this.chb_legajo);
            this.grp_busquedaAvanzada.Controls.Add(this.busqAvan_informacion);
            this.grp_busquedaAvanzada.Controls.Add(this.btn_cerrarBusquedaAvanzada);
            this.grp_busquedaAvanzada.Controls.Add(this.label_legajoHasta);
            this.grp_busquedaAvanzada.Controls.Add(this.label_legajoDesde);
            this.grp_busquedaAvanzada.Controls.Add(this.btn_busquedaAvanzada);
            this.grp_busquedaAvanzada.Controls.Add(this.radio_busqAvan_deshabilitados);
            this.grp_busquedaAvanzada.Controls.Add(this.radio_busqAvan_habilitados);
            this.grp_busquedaAvanzada.Controls.Add(this.radio_busqAvan_todos);
            this.grp_busquedaAvanzada.Controls.Add(this.label_disponibilidad);
            this.grp_busquedaAvanzada.Controls.Add(this.txt_busqAvan_apellido);
            this.grp_busquedaAvanzada.Controls.Add(this.label_comisionHasta);
            this.grp_busquedaAvanzada.Controls.Add(this.label_comisionDesde);
            this.grp_busquedaAvanzada.Controls.Add(this.label_apellido);
            this.grp_busquedaAvanzada.Controls.Add(this.label_nombre);
            this.grp_busquedaAvanzada.Controls.Add(this.txt_busqAvan_nombre);
            this.grp_busquedaAvanzada.Location = new System.Drawing.Point(760, 83);
            this.grp_busquedaAvanzada.Name = "grp_busquedaAvanzada";
            this.grp_busquedaAvanzada.Size = new System.Drawing.Size(332, 467);
            this.grp_busquedaAvanzada.TabIndex = 58;
            this.grp_busquedaAvanzada.TabStop = false;
            this.grp_busquedaAvanzada.Text = "Busqueda Avanzada | Reportes";
            this.grp_busquedaAvanzada.Visible = false;
            // 
            // txt_busqAvan_comisionHasta
            // 
            this.txt_busqAvan_comisionHasta.Enabled = false;
            this.txt_busqAvan_comisionHasta.Location = new System.Drawing.Point(117, 285);
            this.txt_busqAvan_comisionHasta.Mask = "99999";
            this.txt_busqAvan_comisionHasta.Name = "txt_busqAvan_comisionHasta";
            this.txt_busqAvan_comisionHasta.Size = new System.Drawing.Size(100, 20);
            this.txt_busqAvan_comisionHasta.TabIndex = 71;
            this.txt_busqAvan_comisionHasta.ValidatingType = typeof(int);
            // 
            // txt_busqAvan_comisionDesde
            // 
            this.txt_busqAvan_comisionDesde.Enabled = false;
            this.txt_busqAvan_comisionDesde.Location = new System.Drawing.Point(117, 256);
            this.txt_busqAvan_comisionDesde.Mask = "99999";
            this.txt_busqAvan_comisionDesde.Name = "txt_busqAvan_comisionDesde";
            this.txt_busqAvan_comisionDesde.Size = new System.Drawing.Size(100, 20);
            this.txt_busqAvan_comisionDesde.TabIndex = 70;
            this.txt_busqAvan_comisionDesde.ValidatingType = typeof(int);
            // 
            // txt_busqAvan_legajoHasta
            // 
            this.txt_busqAvan_legajoHasta.Enabled = false;
            this.txt_busqAvan_legajoHasta.Location = new System.Drawing.Point(113, 69);
            this.txt_busqAvan_legajoHasta.Mask = "99999";
            this.txt_busqAvan_legajoHasta.Name = "txt_busqAvan_legajoHasta";
            this.txt_busqAvan_legajoHasta.Size = new System.Drawing.Size(100, 20);
            this.txt_busqAvan_legajoHasta.TabIndex = 69;
            this.txt_busqAvan_legajoHasta.ValidatingType = typeof(int);
            // 
            // txt_busqAvan_legajoDesde
            // 
            this.txt_busqAvan_legajoDesde.Enabled = false;
            this.txt_busqAvan_legajoDesde.Location = new System.Drawing.Point(113, 43);
            this.txt_busqAvan_legajoDesde.Mask = "99999";
            this.txt_busqAvan_legajoDesde.Name = "txt_busqAvan_legajoDesde";
            this.txt_busqAvan_legajoDesde.Size = new System.Drawing.Size(100, 20);
            this.txt_busqAvan_legajoDesde.TabIndex = 68;
            this.txt_busqAvan_legajoDesde.ValidatingType = typeof(int);
            // 
            // chb_comision
            // 
            this.chb_comision.AccessibleName = "busqAvan_comision";
            this.chb_comision.AutoSize = true;
            this.chb_comision.Location = new System.Drawing.Point(6, 236);
            this.chb_comision.Name = "chb_comision";
            this.chb_comision.Size = new System.Drawing.Size(71, 17);
            this.chb_comision.TabIndex = 61;
            this.chb_comision.Text = "Comision:";
            this.chb_comision.UseVisualStyleBackColor = true;
            this.chb_comision.CheckedChanged += new System.EventHandler(this.chb_comision_CheckedChanged);
            // 
            // chb_NomyApe
            // 
            this.chb_NomyApe.AccessibleName = "busqAvan_nomyape";
            this.chb_NomyApe.AutoSize = true;
            this.chb_NomyApe.Location = new System.Drawing.Point(7, 122);
            this.chb_NomyApe.Name = "chb_NomyApe";
            this.chb_NomyApe.Size = new System.Drawing.Size(113, 17);
            this.chb_NomyApe.TabIndex = 60;
            this.chb_NomyApe.Text = "Nombre y apellido:";
            this.chb_NomyApe.UseVisualStyleBackColor = true;
            this.chb_NomyApe.CheckedChanged += new System.EventHandler(this.chb_NomyApe_CheckedChanged);
            // 
            // chb_legajo
            // 
            this.chb_legajo.AccessibleName = "busqAvan_legajo";
            this.chb_legajo.AutoSize = true;
            this.chb_legajo.Location = new System.Drawing.Point(6, 19);
            this.chb_legajo.Name = "chb_legajo";
            this.chb_legajo.Size = new System.Drawing.Size(61, 17);
            this.chb_legajo.TabIndex = 59;
            this.chb_legajo.Text = "Legajo:";
            this.chb_legajo.UseVisualStyleBackColor = true;
            this.chb_legajo.CheckedChanged += new System.EventHandler(this.chb_legajo_CheckedChanged);
            // 
            // busqAvan_informacion
            // 
            this.busqAvan_informacion.AutoSize = true;
            this.busqAvan_informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqAvan_informacion.ForeColor = System.Drawing.Color.Red;
            this.busqAvan_informacion.Location = new System.Drawing.Point(34, 395);
            this.busqAvan_informacion.Name = "busqAvan_informacion";
            this.busqAvan_informacion.Size = new System.Drawing.Size(51, 16);
            this.busqAvan_informacion.TabIndex = 67;
            this.busqAvan_informacion.Text = "label7";
            this.busqAvan_informacion.Visible = false;
            // 
            // btn_cerrarBusquedaAvanzada
            // 
            this.btn_cerrarBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrarBusquedaAvanzada.Location = new System.Drawing.Point(186, 431);
            this.btn_cerrarBusquedaAvanzada.Name = "btn_cerrarBusquedaAvanzada";
            this.btn_cerrarBusquedaAvanzada.Size = new System.Drawing.Size(67, 30);
            this.btn_cerrarBusquedaAvanzada.TabIndex = 66;
            this.btn_cerrarBusquedaAvanzada.Text = "Cerrar";
            this.btn_cerrarBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btn_cerrarBusquedaAvanzada.Click += new System.EventHandler(this.btn_cerrarBusquedaAvanzada_Click);
            // 
            // label_legajoHasta
            // 
            this.label_legajoHasta.AutoSize = true;
            this.label_legajoHasta.Location = new System.Drawing.Point(54, 72);
            this.label_legajoHasta.Name = "label_legajoHasta";
            this.label_legajoHasta.Size = new System.Drawing.Size(35, 13);
            this.label_legajoHasta.TabIndex = 62;
            this.label_legajoHasta.Text = "Hasta";
            // 
            // label_legajoDesde
            // 
            this.label_legajoDesde.AutoSize = true;
            this.label_legajoDesde.Location = new System.Drawing.Point(54, 46);
            this.label_legajoDesde.Name = "label_legajoDesde";
            this.label_legajoDesde.Size = new System.Drawing.Size(44, 13);
            this.label_legajoDesde.TabIndex = 61;
            this.label_legajoDesde.Text = "Desde: ";
            // 
            // btn_busquedaAvanzada
            // 
            this.btn_busquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedaAvanzada.Location = new System.Drawing.Point(259, 431);
            this.btn_busquedaAvanzada.Name = "btn_busquedaAvanzada";
            this.btn_busquedaAvanzada.Size = new System.Drawing.Size(67, 30);
            this.btn_busquedaAvanzada.TabIndex = 59;
            this.btn_busquedaAvanzada.Text = "Buscar";
            this.btn_busquedaAvanzada.UseVisualStyleBackColor = true;
            this.btn_busquedaAvanzada.Click += new System.EventHandler(this.btn_busquedaAvanzada_Click);
            // 
            // radio_busqAvan_deshabilitados
            // 
            this.radio_busqAvan_deshabilitados.AccessibleName = "busqAvan_disponibilidad";
            this.radio_busqAvan_deshabilitados.AutoSize = true;
            this.radio_busqAvan_deshabilitados.Location = new System.Drawing.Point(208, 343);
            this.radio_busqAvan_deshabilitados.Name = "radio_busqAvan_deshabilitados";
            this.radio_busqAvan_deshabilitados.Size = new System.Drawing.Size(89, 17);
            this.radio_busqAvan_deshabilitados.TabIndex = 12;
            this.radio_busqAvan_deshabilitados.Text = "Deshabilitado";
            this.radio_busqAvan_deshabilitados.UseVisualStyleBackColor = true;
            // 
            // radio_busqAvan_habilitados
            // 
            this.radio_busqAvan_habilitados.AccessibleName = "busqAvan_disponibilidad";
            this.radio_busqAvan_habilitados.AutoSize = true;
            this.radio_busqAvan_habilitados.Location = new System.Drawing.Point(117, 343);
            this.radio_busqAvan_habilitados.Name = "radio_busqAvan_habilitados";
            this.radio_busqAvan_habilitados.Size = new System.Drawing.Size(72, 17);
            this.radio_busqAvan_habilitados.TabIndex = 11;
            this.radio_busqAvan_habilitados.Text = "Habilitado";
            this.radio_busqAvan_habilitados.UseVisualStyleBackColor = true;
            // 
            // radio_busqAvan_todos
            // 
            this.radio_busqAvan_todos.AccessibleName = "busqAvan_disponibilidad";
            this.radio_busqAvan_todos.AutoSize = true;
            this.radio_busqAvan_todos.Checked = true;
            this.radio_busqAvan_todos.Location = new System.Drawing.Point(53, 343);
            this.radio_busqAvan_todos.Name = "radio_busqAvan_todos";
            this.radio_busqAvan_todos.Size = new System.Drawing.Size(55, 17);
            this.radio_busqAvan_todos.TabIndex = 10;
            this.radio_busqAvan_todos.TabStop = true;
            this.radio_busqAvan_todos.Text = "Todos";
            this.radio_busqAvan_todos.UseVisualStyleBackColor = true;
            // 
            // label_disponibilidad
            // 
            this.label_disponibilidad.AccessibleName = "busqAvan_disponibilidad";
            this.label_disponibilidad.AutoSize = true;
            this.label_disponibilidad.Location = new System.Drawing.Point(10, 322);
            this.label_disponibilidad.Name = "label_disponibilidad";
            this.label_disponibilidad.Size = new System.Drawing.Size(75, 13);
            this.label_disponibilidad.TabIndex = 9;
            this.label_disponibilidad.Text = "Disponibilidad:";
            // 
            // txt_busqAvan_apellido
            // 
            this.txt_busqAvan_apellido.AccessibleName = "busqAvan_nomyape";
            this.txt_busqAvan_apellido.Enabled = false;
            this.txt_busqAvan_apellido.Location = new System.Drawing.Point(116, 170);
            this.txt_busqAvan_apellido.Name = "txt_busqAvan_apellido";
            this.txt_busqAvan_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_busqAvan_apellido.TabIndex = 6;
            // 
            // label_comisionHasta
            // 
            this.label_comisionHasta.AutoSize = true;
            this.label_comisionHasta.Location = new System.Drawing.Point(57, 288);
            this.label_comisionHasta.Name = "label_comisionHasta";
            this.label_comisionHasta.Size = new System.Drawing.Size(35, 13);
            this.label_comisionHasta.TabIndex = 5;
            this.label_comisionHasta.Text = "Hasta";
            // 
            // label_comisionDesde
            // 
            this.label_comisionDesde.AutoSize = true;
            this.label_comisionDesde.Location = new System.Drawing.Point(57, 262);
            this.label_comisionDesde.Name = "label_comisionDesde";
            this.label_comisionDesde.Size = new System.Drawing.Size(44, 13);
            this.label_comisionDesde.TabIndex = 4;
            this.label_comisionDesde.Text = "Desde: ";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(46, 173);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(44, 13);
            this.label_apellido.TabIndex = 2;
            this.label_apellido.Text = "Apellido";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(46, 147);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombre";
            // 
            // txt_busqAvan_nombre
            // 
            this.txt_busqAvan_nombre.AccessibleName = "busqAvan_nomyape";
            this.txt_busqAvan_nombre.Enabled = false;
            this.txt_busqAvan_nombre.Location = new System.Drawing.Point(116, 144);
            this.txt_busqAvan_nombre.Name = "txt_busqAvan_nombre";
            this.txt_busqAvan_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_busqAvan_nombre.TabIndex = 0;
            // 
            // btn_disponibilidad
            // 
            this.btn_disponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disponibilidad.Location = new System.Drawing.Point(498, 124);
            this.btn_disponibilidad.Name = "btn_disponibilidad";
            this.btn_disponibilidad.Size = new System.Drawing.Size(109, 49);
            this.btn_disponibilidad.TabIndex = 59;
            this.btn_disponibilidad.Text = "Desactivar";
            this.btn_disponibilidad.UseVisualStyleBackColor = true;
            this.btn_disponibilidad.Click += new System.EventHandler(this.btn_disponibilidad_Click);
            // 
            // uc_ABM_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_disponibilidad);
            this.Controls.Add(this.grp_busquedaAvanzada);
            this.Controls.Add(this.cmb_habilitado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_activarBusquedaAvanzada);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label_informacion);
            this.Controls.Add(this.dgv_vendedores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_comision);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_legajo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificar);
            this.Name = "uc_ABM_Vendedor";
            this.Size = new System.Drawing.Size(1200, 600);
            this.Load += new System.EventHandler(this.uc_ABM_vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendedores)).EndInit();
            this.grp_busquedaAvanzada.ResumeLayout(false);
            this.grp_busquedaAvanzada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_vendedores;
        private System.Windows.Forms.Label label_informacion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_activarBusquedaAvanzada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_habilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.GroupBox grp_busquedaAvanzada;
        private System.Windows.Forms.RadioButton radio_busqAvan_habilitados;
        private System.Windows.Forms.RadioButton radio_busqAvan_todos;
        private System.Windows.Forms.Label label_disponibilidad;
        private System.Windows.Forms.TextBox txt_busqAvan_apellido;
        private System.Windows.Forms.Label label_comisionHasta;
        private System.Windows.Forms.Label label_comisionDesde;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox txt_busqAvan_nombre;
        private System.Windows.Forms.Button btn_busquedaAvanzada;
        private System.Windows.Forms.RadioButton radio_busqAvan_deshabilitados;
        private System.Windows.Forms.Label label_legajoHasta;
        private System.Windows.Forms.Label label_legajoDesde;
        private System.Windows.Forms.CheckBox chb_comision;
        private System.Windows.Forms.CheckBox chb_NomyApe;
        private System.Windows.Forms.CheckBox chb_legajo;
        private System.Windows.Forms.Button btn_cerrarBusquedaAvanzada;
        private System.Windows.Forms.Label busqAvan_informacion;
        private System.Windows.Forms.MaskedTextBox txt_busqAvan_legajoDesde;
        private System.Windows.Forms.MaskedTextBox txt_busqAvan_comisionHasta;
        private System.Windows.Forms.MaskedTextBox txt_busqAvan_comisionDesde;
        private System.Windows.Forms.MaskedTextBox txt_busqAvan_legajoHasta;
        private System.Windows.Forms.Button btn_disponibilidad;
    }
}
