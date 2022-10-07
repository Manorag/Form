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
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void Caja_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtenderCaja_Click(object sender, EventArgs e)
        {
            Base.esperacaja.Dequeue();
            MessageBox.Show("Atencion exitosa, puede retirarse de la cola. CAJA");
            Base.atendidoscaja.Enqueue(new Base
            {
                Numero = int.Parse(txtTurnoCaja.Text),
                Name = txtNomsCaja.Text
            });
            txtTurnoCaja.Clear();
            txtNomsCaja.Clear();
        }
    }
}
