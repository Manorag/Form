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
            ((System.ComponentModel.ISupportInitialize)(this.dgCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCaja
            // 
            this.dgCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCaja.Location = new System.Drawing.Point(241, 122);
            this.dgCaja.Name = "dgCaja";
            this.dgCaja.RowHeadersWidth = 62;
            this.dgCaja.RowTemplate.Height = 33;
            this.dgCaja.Size = new System.Drawing.Size(566, 472);
            this.dgCaja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(101, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios por atender:";
            // 
            // ListaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(85)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1088, 798);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCaja";
            this.Text = "ListaCaja";
            this.Load += new System.EventHandler(this.ListaCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgCaja;
        private Label label1;
    }
}