using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Zooka
{
    public static class PuxarNomeUsuario
    {
        // Guarda o nome completo do usuário autenticado
        public static string NomeCompleto { get; private set; }

        /// <summary>
        /// Busca o nome completo do usuário no banco de dados e define na sessão.
        /// </summary>
        public static void DefinirUsuario(string login)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT nome_profissonal FROM profissional WHERE login_profisonal = @profissional";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            NomeCompleto = result.ToString();
                        }
                        else
                        {
                            NomeCompleto = "Usuário não encontrado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar nome do usuário: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NomeCompleto = "Erro ao carregar nome";
            }
        }

        /// <summary>
        /// Limpa os dados salvos (caso o usuário saia do sistema).
        /// </summary>
        public static void EncerrarSessao()
        {
            NomeCompleto = null;
        }
    }
}
