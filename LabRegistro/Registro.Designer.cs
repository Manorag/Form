namespace LabRegistro
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.BarSide = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCaja = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnService = new System.Windows.Forms.Button();
            this.SearchContainer = new System.Windows.Forms.Panel();
            this.btnListaSBK = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnListCaja = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BarTimer = new System.Windows.Forms.Timer(this.components);
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.BarSide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SearchContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarSide
            // 
            this.BarSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.BarSide.Controls.Add(this.panel1);
            this.BarSide.Controls.Add(this.panel2);
            this.BarSide.Controls.Add(this.panel3);
            this.BarSide.Controls.Add(this.panel4);
            this.BarSide.Controls.Add(this.SearchContainer);
            this.BarSide.Controls.Add(this.panel5);
            this.BarSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarSide.Location = new System.Drawing.Point(0, 0);
            this.BarSide.MaximumSize = new System.Drawing.Size(311, 798);
            this.BarSide.MinimumSize = new System.Drawing.Size(81, 798);
            this.BarSide.Name = "BarSide";
            this.BarSide.Size = new System.Drawing.Size(311, 798);
            this.BarSide.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 149);
            this.panel1.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::LabRegistro.Properties.Resources._588a64e0d06f6719692a2d10;
            this.btnMenu.Location = new System.Drawing.Point(9, 44);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(61, 56);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(103, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Location = new System.Drawing.Point(3, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 105);
            this.panel2.TabIndex = 1;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(9, 3);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(275, 99);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCaja);
            this.panel3.Location = new System.Drawing.Point(3, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 105);
            this.panel3.TabIndex = 2;
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCaja.Location = new System.Drawing.Point(9, 3);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(275, 99);
            this.btnCaja.TabIndex = 2;
            this.btnCaja.Text = "Caja";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnService);
            this.panel4.Location = new System.Drawing.Point(3, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(306, 109);
            this.panel4.TabIndex = 5;
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnService.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnService.Location = new System.Drawing.Point(12, 6);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(275, 99);
            this.btnService.TabIndex = 2;
            this.btnService.Text = "Servicios Bancarios";
            this.btnService.UseVisualStyleBackColor = false;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // SearchContainer
            // 
            this.SearchContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.SearchContainer.Controls.Add(this.btnListaSBK);
            this.SearchContainer.Controls.Add(this.btnBuscar);
            this.SearchContainer.Controls.Add(this.btnListCaja);
            this.SearchContainer.Location = new System.Drawing.Point(3, 495);
            this.SearchContainer.MaximumSize = new System.Drawing.Size(300, 264);
            this.SearchContainer.MinimumSize = new System.Drawing.Size(300, 108);
            this.SearchContainer.Name = "SearchContainer";
            this.SearchContainer.Size = new System.Drawing.Size(300, 108);
            this.SearchContainer.TabIndex = 4;
            // 
            // btnListaSBK
            // 
            this.btnListaSBK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.btnListaSBK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnListaSBK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaSBK.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListaSBK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaSBK.Location = new System.Drawing.Point(12, 192);
            this.btnListaSBK.Name = "btnListaSBK";
            this.btnListaSBK.Size = new System.Drawing.Size(275, 60);
            this.btnListaSBK.TabIndex = 4;
            this.btnListaSBK.Text = "Servicios Bancarios";
            this.btnListaSBK.UseVisualStyleBackColor = false;
            this.btnListaSBK.Click += new System.EventHandler(this.btnListaSBK_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(140)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(12, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(275, 99);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Lista de espera";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListCaja
            // 
            this.btnListCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(108)))), ((int)(((byte)(124)))));
            this.btnListCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnListCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListCaja.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListCaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListCaja.Location = new System.Drawing.Point(12, 126);
            this.btnListCaja.Name = "btnListCaja";
            this.btnListCaja.Size = new System.Drawing.Size(275, 60);
            this.btnListCaja.TabIndex = 3;
            this.btnListCaja.Text = "Caja";
            this.btnListCaja.UseVisualStyleBackColor = false;
            this.btnListCaja.Click += new System.EventHandler(this.btnListCaja_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSalir);
            this.panel5.Location = new System.Drawing.Point(3, 609);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(306, 105);
            this.panel5.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(103)))), ((int)(((byte)(137)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(12, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(275, 99);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BarTimer
            // 
            this.BarTimer.Interval = 8;
            this.BarTimer.Tick += new System.EventHandler(this.BarTimer_tick);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 10;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(311, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1088, 798);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 798);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.BarSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.BarSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.SearchContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel BarSide;
        private Panel panel1;
        private Panel panel2;
        private Button btnInicio;
        private PictureBox btnMenu;
        private Label label1;
        private Panel panel3;
        private Button btnCaja;
        private System.Windows.Forms.Timer BarTimer;
        private Panel panel5;
        private Button btnSalir;
        private Panel SearchContainer;
        private Button btnListaSBK;
        private Button btnListCaja;
        private Button btnBuscar;
        private System.Windows.Forms.Timer SearchTimer;
        private Panel PanelPrincipal;
        private Panel panel4;
        private Button btnService;
    }
}