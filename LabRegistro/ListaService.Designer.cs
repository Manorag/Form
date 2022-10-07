namespace LabRegistro
{
    partial class ListaService
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgService = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAtendidosService = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtendidosService)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(138, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuarios por atender:";
            // 
            // dgService
            // 
            this.dgService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgService.Location = new System.Drawing.Point(32, 143);
            this.dgService.Name = "dgService";
            this.dgService.RowHeadersWidth = 62;
            this.dgService.RowTemplate.Height = 33;
            this.dgService.Size = new System.Drawing.Size(432, 472);
            this.dgService.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(699, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuarios atendidos:";
            // 
            // dgAtendidosService
            // 
            this.dgAtendidosService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtendidosService.Location = new System.Drawing.Point(592, 143);
            this.dgAtendidosService.Name = "dgAtendidosService";
            this.dgAtendidosService.RowHeadersWidth = 62;
            this.dgAtendidosService.RowTemplate.Height = 33;
            this.dgAtendidosService.Size = new System.Drawing.Size(432, 472);
            this.dgAtendidosService.TabIndex = 5;
            // 
            // ListaService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1088, 798);
            this.Controls.Add(this.dgAtendidosService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaService";
            this.Text = "ListaService";
            this.Load += new System.EventHandler(this.ListaService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtendidosService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgService;
        private Label label2;
        private DataGridView dgAtendidosService;
    }
}