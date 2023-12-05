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
    internal class Usuario
    {
        #region Atributos

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        #endregion

        #region Funcionalidades

        internal DataTable ListarUsuarios()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.Conectar());
                string sql = "SELECT id, nome, email, senha FROM usuario;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                DataTable tabelaUsuarios = new DataTable();
                da.Fill(tabelaUsuarios);
                return tabelaUsuarios;
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao listar usuários!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal DataTable ListarDestinatarios(int idUsuario)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.Conectar());
                string sql = @" SELECT id, nome, email FROM usuario
                                WHERE id != @id;";
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", idUsuario);

                using (MySqlDataAdapter da = new MySqlDataAdapter(comando))
                {
                    DataTable tabelaDestinatarios = new DataTable();
                    da.Fill(tabelaDestinatarios);
                    return tabelaDestinatarios;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao listar destinatários!" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        internal int AutenticarUsuario(Usuario usuario)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(Conexao.Conectar());
                string sql = "SELECT id FROM usuario WHERE email=@email AND BINARY senha=@senha;";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@email", usuario.Email);
                comando.Parameters.AddWithValue("@senha", usuario.Senha);

                conexao.Open();
                MySqlDataReader dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    MessageBox.Show("Usuário autenticado com sucesso!", "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return Convert.ToInt32(dados["id"]);
                }
                else
                {
                    MessageBox.Show("E-mail ou senha inválidos!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
                MessageBox.Show("Erro ao autenticar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        #endregion
    }
}
