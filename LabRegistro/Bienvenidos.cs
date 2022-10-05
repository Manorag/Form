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
    public partial class Bienvenidos : Form
    {
        public Bienvenidos()
        {
            InitializeComponent();
        }
        //int i = 1, k=1;
        void Agregar()
        {
            if (cbAccion.SelectedIndex == 0)
            {
                Base.esperaservice.Enqueue(new Base
                {
                    Numero = Base.k++,
                    Name = txtNombre.Text
                });
            }
            if (cbAccion.SelectedIndex == 1)
            {

                Base.esperacaja.Enqueue(new Base
                {
                    Numero = Base.i++,
                    Name = txtNombre.Text
                });

            }

        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            Agregar();
            txtNombre.Clear();
            txtNombre.Focus();
            
            
        }
    }
}
