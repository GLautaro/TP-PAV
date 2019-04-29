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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_busquedaAvanzada = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendedores.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_vendedores.GridColor = System.Drawing.Color.YellowGreen;
            this.dgv_vendedores.Location = new System.Drawing.Point(15, 200);
            this.dgv_vendedores.MultiSelect = false;
            this.dgv_vendedores.Name = "dgv_vendedores";
            this.dgv_vendedores.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_vendedores.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_vendedores.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_vendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendedores.Size = new System.Drawing.Size(700, 350);
            this.dgv_vendedores.TabIndex = 51;
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
            this.grp_busquedaAvanzada.Controls.Add(this.textBox5);
            this.grp_busquedaAvanzada.Controls.Add(this.textBox6);
            this.grp_busquedaAvanzada.Controls.Add(this.label14);
            this.grp_busquedaAvanzada.Controls.Add(this.label15);
            this.grp_busquedaAvanzada.Controls.Add(this.label16);
            this.grp_busquedaAvanzada.Controls.Add(this.btn_busquedaAvanzada);
            this.grp_busquedaAvanzada.Controls.Add(this.radioButton3);
            this.grp_busquedaAvanzada.Controls.Add(this.radioButton2);
            this.grp_busquedaAvanzada.Controls.Add(this.radioButton1);
            this.grp_busquedaAvanzada.Controls.Add(this.label13);
            this.grp_busquedaAvanzada.Controls.Add(this.textBox4);
            this.grp_busquedaAvanzada.Controls.Add(this.textBox3);
            this.grp_busquedaAvanzada.Controls.Add(this.textBox2);
            this.grp_busquedaAvanzada.Controls.Add(this.label12);
            this.grp_busquedaAvanzada.Controls.Add(this.label11);
            this.grp_busquedaAvanzada.Controls.Add(this.label10);
            this.grp_busquedaAvanzada.Controls.Add(this.label9);
            this.grp_busquedaAvanzada.Controls.Add(this.label8);
            this.grp_busquedaAvanzada.Controls.Add(this.textBox1);
            this.grp_busquedaAvanzada.Location = new System.Drawing.Point(760, 200);
            this.grp_busquedaAvanzada.Name = "grp_busquedaAvanzada";
            this.grp_busquedaAvanzada.Size = new System.Drawing.Size(332, 350);
            this.grp_busquedaAvanzada.TabIndex = 58;
            this.grp_busquedaAvanzada.TabStop = false;
            this.grp_busquedaAvanzada.Text = "Busqueda Avanzada | Reportes";
            this.grp_busquedaAvanzada.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(113, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 64;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(113, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Hasta";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Desde: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Legajo";
            // 
            // btn_busquedaAvanzada
            // 
            this.btn_busquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busquedaAvanzada.Location = new System.Drawing.Point(238, 305);
            this.btn_busquedaAvanzada.Name = "btn_busquedaAvanzada";
            this.btn_busquedaAvanzada.Size = new System.Drawing.Size(67, 30);
            this.btn_busquedaAvanzada.TabIndex = 59;
            this.btn_busquedaAvanzada.Text = "Buscar";
            this.btn_busquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(204, 278);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Deshabilitado";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 278);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Habilitado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(49, 278);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Todos";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Disponibilidad";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(80, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hasta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Desde: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Comision";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // uc_ABM_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_busquedaAvanzada;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
