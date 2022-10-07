using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRegistro
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtenderService_Click(object sender, EventArgs e)
        {
            Base.esperaservice.Dequeue();
            MessageBox.Show("Atencion exitosa, puede retirarse de la cola. SBK");

            Base.atendidosservice.Enqueue(new Base
            {
                Numero = int.Parse(txtTurnoService.Text),
                Name = txtNomsService.Text
            });
            txtTurnoService.Clear();
            txtNomsService.Clear();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
