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
    public partial class ListaCaja : Form
    {
        public ListaCaja()
        {
            InitializeComponent();
            
        }
        bool flag = false;
        DataTable dt = new DataTable();

        void Procedimiento()
        {
            dt.Clear();
            if (flag == false)
            {
                foreach (DataGridViewColumn col in dgCaja.Columns)
                {
                    dt.Columns.Add(col.HeaderText); //Asigna el nombre  de las variables como encabezado
                }
                flag = true;
            }

            foreach (DataGridViewRow row in dgCaja.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value; //Asigna las celdas a partir de la listas 
                }
                dt.Rows.Add(dRow);
            }
        }


        private void ListaCaja_Load(object sender, EventArgs e)
        {
            dgCaja.DataSource = null;
            dgCaja.DataSource = Base.esperacaja.ToList();
            Procedimiento();
        }
    }
}
