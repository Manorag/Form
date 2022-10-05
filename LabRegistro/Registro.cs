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
    public partial class Registro : Form
    {
        bool Barexp;
        bool Search;
        //Codigo robado que aun no entiendo muy bien, pero mansa paja, metimos un Panel dentro del form registro, para luego mandar a llamar dentro de este panel cada form
        public void loadform(object Form)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
             Form a = Form as Form;
              a.TopLevel = false;
              a.Dock = DockStyle.Fill;
              this.PanelPrincipal.Controls.Add(a);
              this.PanelPrincipal.Tag = a;
              a.Show();

            
        }
        public void loadform2(object Form)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
            Form b= Form as Form;
            b.TopLevel = false;
            b.Dock=DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(b);
            this.PanelPrincipal.Tag = b;
            b.Show();
        }
        public void loadform3(object Form)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
            Form b = Form as Form;
            b.TopLevel = false;
            b.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(b);
            this.PanelPrincipal.Tag = b;
            b.Show();
        }
        public Registro()
        {
            InitializeComponent();
            loadform(new Bienvenidos());
        }
        
           Caja fmrCaja = new Caja();
           Service fmrService = new Service();

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void BarTimer_tick(object sender, EventArgs e)
        {
            //Controla el tamano del bar desplegable
            
            if (Barexp)
            {
                BarSide.Width -= 10;
                if (BarSide.Width == BarSide.MinimumSize.Width)
                {
                    Barexp = false;
                    BarTimer.Stop();
                }
            }
            else
            {
                BarSide.Width += 10;
                if(BarSide.Width == BarSide.MaximumSize.Width)
                {
                    Barexp = true;
                    BarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            BarTimer.Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            if (Search)
            {
                SearchContainer.Height += 10;
                if (SearchContainer.Height == SearchContainer.MaximumSize.Height)
                {
                    Search = false;
                    SearchTimer.Stop();
                }
            }
            else
            {
                SearchContainer.Height -= 10;
            }
            if (SearchContainer.Height == SearchContainer.MinimumSize.Height)
            {
                Search = true;
                SearchTimer.Stop();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchTimer.Start();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            loadform(new Bienvenidos());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            fmrService.ShowDialog(); /*No me va a permitir clickear otro form, hasta que este se cierre*/
        }

        private void btnListCaja_Click(object sender, EventArgs e)
        {
            loadform2(new ListaCaja());
        }

        private void btnListaSBK_Click(object sender, EventArgs e)
        {
            loadform3(new ListaService());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            fmrCaja.ShowDialog(); /*No me va a permitir clickear otro form, hasta que este se cierre*/
        }
    }
}
