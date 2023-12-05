using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace email
{
    public partial class FormLixeira : Form
    {
        Email email = new Email();
        int idEmail, idUsuario;

        public FormLixeira(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void FormLixeira_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void lbxEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView emailSelecionado = (DataRowView)lbxEmails.SelectedItem;

            if (emailSelecionado != null)
            {
                idEmail = Convert.ToInt32(lbxEmails.SelectedValue);
                tbRemetente.Text = $"{emailSelecionado["nome"]} [{emailSelecionado["email"]}]";
                tbAssunto.Text = emailSelecionado["assunto"].ToString();
                tbCorpo.Text = emailSelecionado["corpo"].ToString();
            }
        }

        #region Botões

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            if (idEmail == 0) // Verifica se algum e-mail foi selecionado
            {
                MessageBox.Show("Nenhum e-mail foi selecionado!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja mesmo restaurar este e-mail?", "Restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                email.RestaurarEmail(idEmail);
                LimparCampos();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (idEmail == 0) // Verifica se algum e-mail foi selecionado
            {
                MessageBox.Show("Nenhum e-mail foi selecionado!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja mesmo excluir este e-mail?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                email.ExcluirEmailPermanentemente(idEmail);
                LimparCampos();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        #endregion

        #region Funções 

        private void LimparCampos()
        {
            lbxEmails.DataSource = email.CarregarLixeira(idUsuario);

            idEmail = 0;
            lbxEmails.ClearSelected();
            tbRemetente.Clear();
            tbAssunto.Clear();
            tbCorpo.Clear();
        }

        #endregion
    }
}
