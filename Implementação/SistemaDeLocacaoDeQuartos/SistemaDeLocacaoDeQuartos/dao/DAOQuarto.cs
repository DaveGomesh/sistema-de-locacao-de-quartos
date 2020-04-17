using MySql.Data.MySqlClient;
using SistemaDeLocacaoDeQuartos.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLocacaoDeQuartos.dao
{
    class DAOQuarto
    {
        //ATRIBUTOS
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader cursor;

        private string sql;
        private int resultado;

        //CONTRUTOR
        public DAOQuarto()
        {
            this.conexao = new MySqlConnection("server=localhost;userid=root;password=;database=aluguel;");
            this.comando = new MySqlCommand();
            this.comando.Connection = conexao;
            this.resultado = 0;
        }

        //CRUD

        //CRUD: Cadastrar
        public int cadastrar(Quarto quarto)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "INSERT INTO `aluguel`.`quarto` (`numeroQuarto`, `tipo`, `quantBanheiros`, `quantSalas`, `quantCozinhas`, `precoMensalidade`, `andar`) VALUES(@numeroQuarto, @tipo, @quantBanheiros, @quantSalas, @quantCozinhas, @precoMensalidade, @andar)";

                this.comando.Parameters.AddWithValue("@numeroQuarto", quarto.getNumeroQuarto());
                this.comando.Parameters.AddWithValue("@tipo", quarto.getTipo());
                this.comando.Parameters.AddWithValue("@quantBanheiros", quarto.getQuantBanheiros());
                this.comando.Parameters.AddWithValue("@quantSalas", quarto.getQuantSalas());
                this.comando.Parameters.AddWithValue("@quantCozinhas", quarto.getQuantCozinhas());
                this.comando.Parameters.AddWithValue("@precoMensalidade", quarto.getPrecoMensalidade());
                this.comando.Parameters.AddWithValue("@andar", quarto.getAndar());

                this.comando.Prepare();
                try
                {
                    this.resultado = this.comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com sucesso!", "Cadastro feito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar fazer o cadastro!", "Cadastro não realizado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha no cadastro", MessageBoxButtons.OK);
                }
            }
            this.conexao.Close();
            return this.resultado;
        }//Funcionando

        //CRUD: Localizar
        public void localizar(List<Quarto> lista)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = this.sql;

                try
                {
                    this.cursor = this.comando.ExecuteReader();

                    Quarto quarto = new Quarto();

                    while (this.cursor.Read())
                    {
                        quarto = quarto.clonar(this.cursor.GetString("idQuarto"), this.cursor.GetString("numeroQuarto"), this.cursor.GetString("tipo"), this.cursor.GetString("quantBanheiros"), this.cursor.GetString("quantSalas"), this.cursor.GetString("quantCozinhas"), this.cursor.GetString("precoMensalidade"), this.cursor.GetString("andar"));

                        lista.Add(quarto);
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar fazer a busca!", "Busca não realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na pesquisa", MessageBoxButtons.OK);
                }

            this.conexao.Close();
            }
        }

        //CRUD: Alterar
        public int alterar(Quarto quarto)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "UPDATE `aluguel`.`quarto` SET `numeroQuarto` = @numeroQuarto, `tipo` = @tipo, `quantBanheiros` = @quantBanheiros, `quantSalas` = @quantSalas, `quantCozinhas` = @quantCozinhas, `precoMensalidade` = @precoMensalidade, `andar` = @andar WHERE(`idQuarto` = @id)";

                this.comando.Parameters.AddWithValue("@id", Convert.ToInt32(quarto.getId()));
                this.comando.Parameters.AddWithValue("@numeroQuarto", quarto.getNumeroQuarto());
                this.comando.Parameters.AddWithValue("@tipo", quarto.getTipo());
                this.comando.Parameters.AddWithValue("@quantBanheiros", quarto.getQuantBanheiros());
                this.comando.Parameters.AddWithValue("@quantSalas", quarto.getQuantSalas());
                this.comando.Parameters.AddWithValue("@quantCozinhas", quarto.getQuantCozinhas());
                this.comando.Parameters.AddWithValue("@precoMensalidade", quarto.getPrecoMensalidade());
                this.comando.Parameters.AddWithValue("@andar", quarto.getAndar());

                this.comando.Prepare();

                try
                {
                    this.resultado = this.comando.ExecuteNonQuery();
                    MessageBox.Show("Alterado com sucesso!", "Alteração feita", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar fazer a alteração!", "Alteração não realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na alteração", MessageBoxButtons.OK);
                }
            }

            this.conexao.Close();
            return this.resultado;
        }

        //CRUD: Excluir
        public int excluir(string idQuarto)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "DELETE FROM `aluguel`.`quarto` WHERE (`idQuarto` = @idQuarto)";

                this.comando.Parameters.AddWithValue("@idQuarto", idQuarto);

                this.comando.Prepare();

                try
                {
                    this.resultado = this.comando.ExecuteNonQuery();
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar excluir o quarto!", "Quarto não excluído", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na exclusão", MessageBoxButtons.OK);
                }
            }
            
            this.conexao.Close();
            return this.resultado;
        }

        //FUNÇÕES ADICONAIS

        //Função para abrir a Conexão com o Banco
        private bool abrirConexao()
        {
            try
            {
                conexao.Open();
                return true;
            }
            catch (MySqlException exception)
            {
                switch (exception.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível fazer a conexão ao Banco de Dados. Por favor entre em contato com o Administrador!", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Dados técnicos: \n\n" + exception, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case 1042:
                        MessageBox.Show("Serviço MySQL inativo", "MySQL inativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case 1045:
                        MessageBox.Show("Username ou password da conexão incorretos, impossível conectar ao Banco de Dados!", "Problemas na conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    default:
                        MessageBox.Show("Não foi possível fazer a conexão ao Banco de Dados. Por favor entre em contato com o Administrador!", "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Dados técnicos: \n\n" + exception, "Erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                return false;
            }
        }

        //Função que prepara o comando SQL SELECT para ser feito a busca no Banco
        public void prepararComandoParaBusca(Quarto quarto, string comando)
        {
            this.sql = "SELECT * FROM aluguel.quarto WHERE ";

            if(quarto.getNumeroQuarto() != "")
            {
                this.sql += "numeroQuarto LIKE '%" + quarto.getNumeroQuarto() + "%' ";
            }

            if(quarto.getTipo() != "")
            {
                if(quarto.getNumeroQuarto() != "")
                {
                    this.sql += comando + " tipo LIKE '%" + quarto.getTipo() + "%' ";
                }
                else
                {
                    this.sql += "tipo LIKE '%" + quarto.getTipo() + "%' ";
                }
            }

            if(quarto.getQuantBanheiros() != "")
            {
                if(quarto.getNumeroQuarto() != "" || quarto.getTipo() != "")
                {
                    this.sql += comando + " quantBanheiros LIKE '%" + quarto.getQuantBanheiros() + "%' ";
                }
                else
                {
                    this.sql += "quantBanheiros LIKE '%" + quarto.getQuantBanheiros() + "%' ";
                }
            }

            if (quarto.getQuantSalas() != "")
            {
                if (quarto.getNumeroQuarto() != "" || quarto.getTipo() != "" || quarto.getQuantBanheiros() != "")
                {
                    this.sql += comando + " quantSalas LIKE '%" + quarto.getQuantSalas() + "%' ";
                }
                else
                {
                    this.sql += "quantSalas LIKE '%" + quarto.getQuantSalas() + "%' ";
                }
            }

            if (quarto.getQuantCozinhas() != "")
            {
                if (quarto.getNumeroQuarto() != "" || quarto.getTipo() != "" || quarto.getQuantBanheiros() != "" || quarto.getQuantSalas() != "")
                {
                    this.sql += comando + " quantCozinhas LIKE '%" + quarto.getQuantCozinhas() + "%' ";
                }
                else
                {
                    this.sql += "quantCozinhas LIKE '%" + quarto.getQuantCozinhas() + "%' ";
                }
            }

            if (quarto.getPrecoMensalidade() != "")
            {
                if (quarto.getNumeroQuarto() != "" || quarto.getTipo() != "" || quarto.getQuantBanheiros() != "" || quarto.getQuantSalas() != "" || quarto.getQuantCozinhas() != "")
                {
                    this.sql += comando + " precoMensalidade LIKE '%" + quarto.getPrecoMensalidade() + "%' ";
                }
                else
                {
                    this.sql += "precoMensalidade LIKE '%" + quarto.getPrecoMensalidade() + "%' ";
                }
            }

            if (quarto.getAndar() != "")
            {
                if (quarto.getNumeroQuarto() != "" || quarto.getTipo() != "" || quarto.getQuantBanheiros() != "" || quarto.getQuantSalas() != "" || quarto.getQuantCozinhas() != "" || quarto.getPrecoMensalidade() != "")
                {
                    this.sql += comando + " andar LIKE '%" + quarto.getAndar() + "%' ";
                }
                else
                {
                    this.sql += "andar LIKE '%" + quarto.getAndar() + "%' ";
                }
            }
        }

        //Função que retorna todos os clientes cadastrados no Bancos de Dados
        public void carregaTodosOsDados(List<Quarto> lista)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "SELECT * FROM aluguel.quarto ORDER BY numeroQuarto ASC";

                try
                {
                    this.cursor = this.comando.ExecuteReader();

                    Quarto quarto = new Quarto();

                    while (this.cursor.Read())
                    {
                        quarto = quarto.clonar(this.cursor.GetString("idQuarto"), this.cursor.GetString("numeroQuarto"), this.cursor.GetString("tipo"), this.cursor.GetString("quantBanheiros"), this.cursor.GetString("quantSalas"), this.cursor.GetString("quantCozinhas"), this.cursor.GetString("precoMensalidade"), this.cursor.GetString("andar"));

                        lista.Add(quarto);
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar fazer a busca!", "Busca não realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na pesquisa", MessageBoxButtons.OK);
                }

                this.conexao.Close();
            }
        }

        //Função que clona o objeto
        public DAOQuarto clonar()
        {
            return new DAOQuarto();
        }
    }
}
