namespace LabRegistro
{
    partial class ListaCaja
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
            this.dgCaja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAtendidosCaja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtendidosCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCaja
            // 
            this.dgCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCaja.Location = new System.Drawing.Point(42, 136);
            this.dgCaja.Name = "dgCaja";
            this.dgCaja.RowHeadersWidth = 62;
            this.dgCaja.RowTemplate.Height = 33;
            this.dgCaja.Size = new System.Drawing.Size(432, 472);
            this.dgCaja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(143, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios por atender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(700, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuarios atendidos:";
            // 
            // dgAtendidosCaja
            // 
            this.dgAtendidosCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtendidosCaja.Location = new System.Drawing.Point(615, 136);
            this.dgAtendidosCaja.Name = "dgAtendidosCaja";
            this.dgAtendidosCaja.RowHeadersWidth = 62;
            this.dgAtendidosCaja.RowTemplate.Height = 33;
            this.dgAtendidosCaja.Size = new System.Drawing.Size(432, 472);
            this.dgAtendidosCaja.TabIndex = 3;
            // 
            // ListaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1088, 798);
            this.Controls.Add(this.dgAtendidosCaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCaja";
            this.Text = "ListaCaja";
            this.Load += new System.EventHandler(this.ListaCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtendidosCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgCaja;
        private Label label1;
        private Label label2;
        private DataGridView dgAtendidosCaja;
    }
}