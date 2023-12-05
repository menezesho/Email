using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace email
{
    internal class Email
    {
        #region Atributos

        internal int Id { get; set; }
        internal string Assunto { get; set; }
        internal string Corpo { get; set; }
        internal Usuario Remetente { get; set; }
        internal Usuario Destinatario { get; set; }

        #endregion

        #region Funcionalidades

        #region Envio de e-mail

        internal void EnviarEmail(Email email)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.Conectar());
                string sql = "INSERT INTO email (assunto, corpo, id_remetente, id_destinatario) VALUES (@assunto, @corpo, @id_remetente, @id_destinatario);";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("assunto", email.Assunto);
                comando.Parameters.AddWithValue("corpo", email.Corpo);
                comando.Parameters.AddWithValue("id_remetente", email.Remetente.Id);
                comando.Parameters.AddWithValue("id_destinatario", email.Destinatario.Id);

                comando.CommandType = CommandType.Text;
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("E-mail enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao enviar e-mail!" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Caixa de entrada

        internal DataTable CarregarCaixaDeEntrada(int idUsuario, bool lidos)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.Conectar()))
                {
                    string sql;

                    if (lidos)
                        sql = @"SELECT e.id, e.assunto, e.corpo, u.id AS id_remetente, u.nome, u.email
                    FROM email e
                    LEFT JOIN usuario u ON u.id = e.id_remetente
                    WHERE e.id_destinatario = @id_destinatario
                    AND e.excluido IS NULL
                    AND e.lido IS NOT NULL;";
                    else
                        sql = @"SELECT e.id, e.assunto, e.corpo, u.id AS id_remetente, u.nome, u.email
                    FROM email e
                    LEFT JOIN usuario u ON u.id = e.id_remetente
                    WHERE e.id_destinatario = @id_destinatario
                    AND e.excluido IS NULL
                    AND e.lido IS NULL;";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("id_destinatario", idUsuario);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(comando))
                    {
                        DataTable tabelaEmails = new DataTable();
                        da.Fill(tabelaEmails);
                        return tabelaEmails;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao listar e-mails da caixa de entrada!" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        internal void MoverEmailParaLixeira(int idEmail)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.Conectar()))
                {
                    string sql = "UPDATE email SET excluido = 1 WHERE email.id = @id;";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("id", idEmail);

                    comando.CommandType = CommandType.Text;
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("E-mail movido para a lixeira com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao mover e-mail para lixeira!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void MarcarOuDesmarcarEmailComoLido(int idEmail, bool emailLido)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.Conectar()))
                {
                    string sql;
                    if (emailLido)
                        sql = "UPDATE email SET lido = 1 WHERE email.id = @id;";
                    else
                        sql = "UPDATE email SET lido = NULL WHERE email.id = @id;";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("id", idEmail);

                    comando.CommandType = CommandType.Text;
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao marcar e-mail como lido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Lixeira

        internal DataTable CarregarLixeira(int idUsuario)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.Conectar());
                string sql = @"SELECT e.id, e.assunto, e.corpo, u.id AS id_remetente, u.nome, u.email
                        FROM email e
                        LEFT JOIN usuario u ON u.id = e.id_remetente
                        WHERE e.id_destinatario = @id_destinatario
                        AND e.excluido IS NOT NULL;";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("id_destinatario", idUsuario);

                using (MySqlDataAdapter da = new MySqlDataAdapter(comando))
                {
                    DataTable tabelaEmails = new DataTable();
                    da.Fill(tabelaEmails);
                    return tabelaEmails;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao listar e-mails da lixeira!" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal void RestaurarEmail(int idEmail)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.Conectar()))
                {
                    string sql = "UPDATE email SET excluido = NULL WHERE email.id = @id;";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("id", idEmail);

                    comando.CommandType = CommandType.Text;
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("E-mail restaurado com sucesso!\nAgora este e-mail se encontra na sua caixa de entrada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao restaurar e-mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void ExcluirEmailPermanentemente(int idEmail)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(Conexao.Conectar()))
                {
                    string sql = "DELETE FROM email WHERE id = @id;";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("id", idEmail);

                    comando.CommandType = CommandType.Text;
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("E-mail excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao excluir e-mail permanentemente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion
    }
}
