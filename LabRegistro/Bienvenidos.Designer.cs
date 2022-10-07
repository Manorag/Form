namespace LabRegistro
{
    partial class Bienvenidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenidos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbAccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(343, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAN-K-NET";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(333, 343);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(370, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // cbAccion
            // 
            this.cbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccion.FormattingEnabled = true;
            this.cbAccion.Items.AddRange(new object[] {
            "Servicios Bancarios",
            "Caja"});
            this.cbAccion.Location = new System.Drawing.Point(333, 443);
            this.cbAccion.Name = "cbAccion";
            this.cbAccion.Size = new System.Drawing.Size(370, 33);
            this.cbAccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(333, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(333, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione la accion que va a realizar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(470, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bienvenido!";
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSig.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSig.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSig.Location = new System.Drawing.Point(713, 520);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(185, 50);
            this.btnSig.TabIndex = 7;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(680, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 98);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(229, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 98);
            this.panel2.TabIndex = 9;
            // 
            // Bienvenidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1088, 798);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenidos";
            this.Text = "Bienvenidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private ComboBox cbAccion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSig;
        private Panel panel1;
        private Panel panel2;
    }
}