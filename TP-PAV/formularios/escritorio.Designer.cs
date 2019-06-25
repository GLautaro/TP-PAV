namespace TP_PAV
{
    partial class Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escritorio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_menuHistorialPedidos = new System.Windows.Forms.Button();
            this.btn_menuEstadisticas = new System.Windows.Forms.Button();
            this.btn_menuFranquicias = new System.Windows.Forms.Button();
            this.btn_menuProductos = new System.Windows.Forms.Button();
            this.btn_menuVendedores = new System.Windows.Forms.Button();
            this.btn_menuPedidos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_menuHistorialPedidos);
            this.panel1.Controls.Add(this.btn_menuEstadisticas);
            this.panel1.Controls.Add(this.btn_menuFranquicias);
            this.panel1.Controls.Add(this.btn_menuProductos);
            this.panel1.Controls.Add(this.btn_menuVendedores);
            this.panel1.Controls.Add(this.btn_menuPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 736);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.YellowGreen;
            this.SidePanel.Location = new System.Drawing.Point(3, 56);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 3;
            // 
            // btn_menuHistorialPedidos
            // 
            this.btn_menuHistorialPedidos.FlatAppearance.BorderSize = 0;
            this.btn_menuHistorialPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuHistorialPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuHistorialPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menuHistorialPedidos.Location = new System.Drawing.Point(6, 116);
            this.btn_menuHistorialPedidos.Name = "btn_menuHistorialPedidos";
            this.btn_menuHistorialPedidos.Size = new System.Drawing.Size(184, 54);
            this.btn_menuHistorialPedidos.TabIndex = 8;
            this.btn_menuHistorialPedidos.Text = "Historial de pedidos";
            this.btn_menuHistorialPedidos.UseVisualStyleBackColor = true;
            this.btn_menuHistorialPedidos.Click += new System.EventHandler(this.btn_menuHistorialPedidos_Click);
            // 
            // btn_menuEstadisticas
            // 
            this.btn_menuEstadisticas.FlatAppearance.BorderSize = 0;
            this.btn_menuEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menuEstadisticas.Location = new System.Drawing.Point(6, 355);
            this.btn_menuEstadisticas.Name = "btn_menuEstadisticas";
            this.btn_menuEstadisticas.Size = new System.Drawing.Size(184, 54);
            this.btn_menuEstadisticas.TabIndex = 7;
            this.btn_menuEstadisticas.Text = "Estadisticas";
            this.btn_menuEstadisticas.UseVisualStyleBackColor = true;
            this.btn_menuEstadisticas.Click += new System.EventHandler(this.btn_menuEstadisticas_Click);
            // 
            // btn_menuFranquicias
            // 
            this.btn_menuFranquicias.FlatAppearance.BorderSize = 0;
            this.btn_menuFranquicias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuFranquicias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuFranquicias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menuFranquicias.Location = new System.Drawing.Point(6, 295);
            this.btn_menuFranquicias.Name = "btn_menuFranquicias";
            this.btn_menuFranquicias.Size = new System.Drawing.Size(184, 54);
            this.btn_menuFranquicias.TabIndex = 6;
            this.btn_menuFranquicias.Text = "Franquicias";
            this.btn_menuFranquicias.UseVisualStyleBackColor = true;
            this.btn_menuFranquicias.Click += new System.EventHandler(this.btn_menuFranquicias_Click);
            // 
            // btn_menuProductos
            // 
            this.btn_menuProductos.FlatAppearance.BorderSize = 0;
            this.btn_menuProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menuProductos.Location = new System.Drawing.Point(4, 175);
            this.btn_menuProductos.Name = "btn_menuProductos";
            this.btn_menuProductos.Size = new System.Drawing.Size(184, 54);
            this.btn_menuProductos.TabIndex = 5;
            this.btn_menuProductos.Text = "Productos";
            this.btn_menuProductos.UseVisualStyleBackColor = true;
            this.btn_menuProductos.Click += new System.EventHandler(this.btn_menuProductos_Click);
            // 
            // btn_menuVendedores
            // 
            this.btn_menuVendedores.FlatAppearance.BorderSize = 0;
            this.btn_menuVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuVendedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menuVendedores.Location = new System.Drawing.Point(6, 235);
            this.btn_menuVendedores.Name = "btn_menuVendedores";
            this.btn_menuVendedores.Size = new System.Drawing.Size(184, 54);
            this.btn_menuVendedores.TabIndex = 4;
            this.btn_menuVendedores.Text = "Vendedores";
            this.btn_menuVendedores.UseVisualStyleBackColor = true;
            this.btn_menuVendedores.Click += new System.EventHandler(this.btn_menuVendedores_Click);
            // 
            // btn_menuPedidos
            // 
            this.btn_menuPedidos.FlatAppearance.BorderSize = 0;
            this.btn_menuPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menuPedidos.Location = new System.Drawing.Point(3, 56);
            this.btn_menuPedidos.Name = "btn_menuPedidos";
            this.btn_menuPedidos.Size = new System.Drawing.Size(184, 54);
            this.btn_menuPedidos.TabIndex = 3;
            this.btn_menuPedidos.Text = "Pedidos";
            this.btn_menuPedidos.UseVisualStyleBackColor = true;
            this.btn_menuPedidos.Click += new System.EventHandler(this.btn_menuPedidos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 24);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1226, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 106);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(851, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de Administracion de pedidos, clientes y vendedores de Don Cayetano Pasta" +
    "s.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.Location = new System.Drawing.Point(190, 124);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1217, 601);
            this.main_panel.TabIndex = 5;
            // 
            // Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 736);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sistema de Administracion de pedidos, clientes y vendedores - Don Cayetano Pastas" +
    "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_menuHistorialPedidos;
        private System.Windows.Forms.Button btn_menuEstadisticas;
        private System.Windows.Forms.Button btn_menuFranquicias;
        private System.Windows.Forms.Button btn_menuProductos;
        private System.Windows.Forms.Button btn_menuVendedores;
        private System.Windows.Forms.Button btn_menuPedidos;
        private System.Windows.Forms.Panel SidePanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel main_panel;
    }
}

