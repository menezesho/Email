using System;
using System.Windows.Forms;

namespace email
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbEmail.Text = "teste";
            tbSenha.Text = "teste";
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbSenha.Text)) // Verifica se o e-mail e a senha não tenham sido preenchidos
            {
                MessageBox.Show("Preencha o e-mail e a senha para autenticar!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.Email = tbEmail.Text;
            usuario.Senha = tbSenha.Text;

            int idUsuario = usuario.AutenticarUsuario(usuario); // Faz a autenticação do usuário

            if (idUsuario != 0) // Verifica se o usuário foi autenticado
            {
                FormMenu formMenu = new FormMenu(idUsuario);
                formMenu.ShowDialog();
            }
        }
    }
}
