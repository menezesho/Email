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
    public partial class FormCaixaDeEntrada : Form
    {
        Email email = new Email();
        int idEmail, idUsuario, idRemetente;
        bool emailLido = false;

        public FormCaixaDeEntrada(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void FormCaixaDeEntrada_Load(object sender, EventArgs e)
        {
            LimparCampos();
            rbNaoLidos.Checked = true;
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
                idRemetente = Convert.ToInt32(emailSelecionado["id_remetente"]);

                #region Lido ou não lido?

                if (rbLidos.Checked)
                    ckLido.Checked = true;
                else
                    ckLido.Checked = false;

                ckLido.Enabled = true;

                #endregion
            }
        }

        private void rbLidosENaoLidos_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        #region Botões

        private void btResponder_Click(object sender, EventArgs e)
        {
            if (idEmail == 0) // Verifica se algum e-mail foi selecionado
            {
                MessageBox.Show("Nenhum e-mail foi selecionado!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormEnviarEmail formEnviarEmail = new FormEnviarEmail(idUsuario, tbAssunto.Text, idRemetente);
            formEnviarEmail.ShowDialog();
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
                email.MoverEmailParaLixeira(idEmail);
                LimparCampos();
            }
        }

        private void ckLido_Click(object sender, EventArgs e)
        {
            email.MarcarOuDesmarcarEmailComoLido(idEmail, ckLido.Checked);

            if (rbLidos.Checked)
                lbxEmails.DataSource = email.CarregarCaixaDeEntrada(idUsuario, true);
            else
                lbxEmails.DataSource = email.CarregarCaixaDeEntrada(idUsuario, false);
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        #endregion

        #region Funções 

        private void LimparCampos()
        {
            if (rbLidos.Checked)
            {
                lbxEmails.DataSource = email.CarregarCaixaDeEntrada(idUsuario, true);
                ckLido.Checked = true;
            }
            else
            {
                lbxEmails.DataSource = email.CarregarCaixaDeEntrada(idUsuario, false);
                ckLido.Checked = false;
            }

            idEmail = 0;
            lbxEmails.ClearSelected();
            tbRemetente.Clear();
            tbAssunto.Clear();
            tbCorpo.Clear();
            ckLido.Enabled = false;
        }

        #endregion
    }
}
