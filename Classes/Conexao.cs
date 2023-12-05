namespace email
{
    internal class Conexao
    {
        internal static string Conectar()
        {
            string server = "localhost";
            string user = "root";
            string password = "";
            string database = "email";
            string port = "3306";
            return $"server={server};user={user};database={database};password={password};port={port}";
        }
    }
}
