using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace email
{
    public partial class FormEnviarEmail : Form
    {
        int idUsuario;
        int? idDestinatario;

        public FormEnviarEmail(int idUsuario, string resposta = null, int? idDestinatario = null)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            if (idDestinatario != null)
            {
                tbCorpo.Text = $"RESPOSTA À: [{resposta}].\n\n";
                this.idDestinatario = idDestinatario;
            }
        }

        private void FormEnviarEmail_Load(object sender, EventArgs e)
        {
            cbDestinatario.DataSource = ListarDestinatarios();
            if (idDestinatario != null)
                cbDestinatario.SelectedValue = idDestinatario;
        }

        private void cbDestinatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView itemSelecionado = (DataRowView)cbDestinatario.SelectedItem;

            tbNome.Text = itemSelecionado["nome"].ToString();
        }

        #region Botões

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (cbDestinatario.SelectedIndex == 0 &&
                string.IsNullOrEmpty(tbAssunto.Text) &&
                string.IsNullOrEmpty(tbCorpo.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Email email = new Email();
            email.Remetente = new Usuario();
            email.Destinatario = new Usuario();

            email.Assunto = tbAssunto.Text.Trim();
            email.Corpo = tbCorpo.Text.Trim();
            email.Remetente.Id = idUsuario;
            email.Destinatario.Id = Convert.ToInt32(cbDestinatario.SelectedValue);

            email.EnviarEmail(email);

            LimparCampos();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        #endregion

        #region Funções

        private void LimparCampos()
        {
            cbDestinatario.SelectedIndex = 0;
            tbAssunto.Clear();
            tbCorpo.Clear();
        }

        private DataTable ListarDestinatarios()
        {
            Usuario destinatario = new Usuario();
            DataTable tabelaDestinatarios = destinatario.ListarDestinatarios(idUsuario);
            DataRow linha = tabelaDestinatarios.NewRow();
            linha["id"] = 0;
            linha["nome"] = string.Empty;
            linha["email"] = "Selecione";
            tabelaDestinatarios.Rows.InsertAt(linha, 0);
            return tabelaDestinatarios;
        }

        #endregion
    }
}