using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email
{
    public partial class FormMenu : Form
    {
        int idUsuario;

        public FormMenu(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btEnviarEmail_Click(object sender, EventArgs e)
        {
            FormEnviarEmail formEnviarEmail = new FormEnviarEmail(idUsuario);
            formEnviarEmail.ShowDialog();
        }

        private void btEnviados_Click(object sender, EventArgs e)
        {
            FormEnviados formEnviados = new FormEnviados();
            formEnviados.ShowDialog();
        }

        private void btCaixaDeEntrada_Click(object sender, EventArgs e)
        {
            FormCaixaDeEntrada formCaixaDeEntrada = new FormCaixaDeEntrada(idUsuario);
            formCaixaDeEntrada.ShowDialog();
        }

        private void btLixeira_Click(object sender, EventArgs e)
        {
            FormLixeira formLixeira = new FormLixeira(idUsuario);
            formLixeira.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
