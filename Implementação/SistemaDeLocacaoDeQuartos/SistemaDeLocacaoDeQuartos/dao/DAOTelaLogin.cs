using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SistemaDeLocacaoDeQuartos.dao
{
    class DAOTelaLogin
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader cursor;
        private string sql;
        private string sqlLog;

        public DAOTelaLogin()
        {
            string strConexao = "server=localhost;userid=root;password=;database=aluguel;";
            conexao = new MySqlConnection(strConexao);
        }

        private bool abrirConexao()
        {
            try
            {
                conexao.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível fazer a conexão ao Banco de Dados. Por favor entre em contato com o Administrador!");
                        break;

                    case 1045:
                        MessageBox.Show("Username/password incorretos, impossível conectar ao Banco de Dados!");
                        break;

                    case 1042:
                        MessageBox.Show("Xampp inativo!");
                        break;
                }
                return false;
            }
        }

        public bool efetuarLogin(string login, string senha)
        {
            if (this.abrirConexao())
            {
                this.sql = "SELECT * FROM administrador WHERE usuario = @usuario AND senha = @senha";
                this.comando = new MySqlCommand();
                this.comando.CommandText = sql;
                this.comando.Connection = conexao;

                this.comando.Parameters.AddWithValue("@usuario", login);
                this.comando.Parameters.AddWithValue("@senha", GerarHashMd5(senha));

                this.cursor = comando.ExecuteReader();

                if (this.cursor.Read())
                {
                    conexao.Close();
                    if (salvarLogin(login) > 0)
                    {
                        return true;
                    }
                }
            }

            conexao.Close();
            return false;
        }

        private static string GerarHashMd5(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private int salvarLogin(string user)
        {
            string data="", hora="";

            if (DateTime.Now.Day < 10)
                data = "0" + DateTime.Now.Day.ToString();
            else
                data = DateTime.Now.Day.ToString();

            if (DateTime.Now.Month < 10)
                data += "/0" + DateTime.Now.Month.ToString();
            else
                data += "/" + DateTime.Now.Month.ToString();

            data += "/" + DateTime.Now.Year.ToString();


            if (DateTime.Now.Hour < 10)
                hora = "0" + DateTime.Now.Hour.ToString();
            else
                hora = DateTime.Now.Hour.ToString();

            if (DateTime.Now.Minute < 10)
                hora += ":0" + DateTime.Now.Minute.ToString();
            else
                hora += ":" + DateTime.Now.Minute.ToString();

            if (DateTime.Now.Second < 10)
                hora += ":0" + DateTime.Now.Second.ToString();
            else
                hora += ":" + DateTime.Now.Second.ToString();

            if (DateTime.Now.Millisecond < 10)
                hora += ":00" + DateTime.Now.Millisecond.ToString();
            else if (DateTime.Now.Millisecond > 10 && DateTime.Now.Millisecond < 100)
                hora += ":0" + DateTime.Now.Millisecond.ToString();
            else
                hora += ":" + DateTime.Now.Millisecond.ToString();

            if (this.abrirConexao())
            {
                this.sqlLog = "INSERT INTO `aluguel`.`logs` (`log_data`, `log_hora`, `user`) VALUES(@data, @hora, @user)";
                this.comando = new MySqlCommand();
                this.comando.CommandText = sqlLog;
                this.comando.Connection = conexao;

                this.comando.Parameters.AddWithValue("@data", data);
                this.comando.Parameters.AddWithValue("@hora", hora);
                this.comando.Parameters.AddWithValue("@user", user);

                this.comando.Prepare();
                int resultado = this.comando.ExecuteNonQuery();
                return resultado;
            }
            return 0;
        }
    }
}
