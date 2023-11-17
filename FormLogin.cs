using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            User user = User.LoginUser(txtuser.Text, txtpass.Text);
            if (user != null)
            {
                FormHome formHome = new FormHome();
                UserManager.CurrentUser = user;
                BookManager.CurrentBooks = new Arbol();
                ReserveManager.CurrentReserves = new Cola();
                RegistroManager.CurrentRegister = new Lista();
                Hide();
                formHome.Show();
            }
            else
            {
                lblError.Text = "Los datos son incorrectos";
                lblError.ForeColor = Color.Red;
                lblError.Visible = true;
                txtuser.Clear();
                txtpass.Clear();

            }
        }
        
    }
}