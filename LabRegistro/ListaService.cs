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
    public partial class ListaService : Form
    {
        public ListaService()
        {
            InitializeComponent();
        }
        Bienvenidos bnv = new Bienvenidos();
        bool flag = false;
        DataTable dt = new DataTable(); //Crea un objeto para controlar columnas y celdas del dataview
        void Procedimiento()
        {
            dt.Clear();
            if (flag == false)
            {
                foreach (DataGridViewColumn col in dgService.Columns)
                {
                    dt.Columns.Add(col.HeaderText); //Asigna el nombre  de las variables como encabezado
                }
                flag = true;
            }

            foreach (DataGridViewRow row in dgService.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value; //Asigna las celdas a partir de la listas 
                }
                dt.Rows.Add(dRow);
            }
        }

        private void ListaService_Load(object sender, EventArgs e)
        {
            dgService.DataSource = null;
            dgService.DataSource = Base.esperaservice.ToList();
            Procedimiento();
        }
    }
}
