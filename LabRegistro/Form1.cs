using System.Globalization;

namespace LabRegistro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        string[] user = new string[3] { "Guillermo", "Christopher", "Melissa" }; //Usuarios ya insertados
        string[] password = new string[3] { "gentoo", "zorin", "arch" }; //Password
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Funcion de comprobacion de usuarios
        void Ingresar()
        {
            int var = 0;
            for (int i = 0; i < user.Length; i++)
            {
                if (txtUser.Text == user[i] && txtPassword.Text == password[i])
                {

                    new Registro().Show();
                    this.Hide();
                    i = user.Length;
                    var = 1;
                }
            }
            if (var == 0)
            {
                MessageBox.Show("User or password incorrect");
                txtUser.Clear();
                txtPassword.Clear();
                txtUser.Focus();
            }
        }

        private void bntIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                Ingresar();

            }
        }

        private void btnExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Ingresar();
            }
        }
    }
}