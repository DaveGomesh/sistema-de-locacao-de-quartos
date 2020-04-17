using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaDeLocacaoDeQuartos.modelo;
using System.Windows.Forms;

namespace SistemaDeLocacaoDeQuartos.dao
{
    class DAOCliente
    {
        //ATRIBUTOS
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlDataReader cursor;

        private string sql;
        private int resultado;

        //CONTRUTOR
        public DAOCliente()
        {
            this.conexao = new MySqlConnection("server=localhost;userid=root;password=;database=aluguel;");
            this.comando = new MySqlCommand();
            this.comando.Connection = conexao;
            this.resultado = 0;
        }

        //CRUD

        //CRUD: Cadastrar
        public int cadastrar(Cliente cliente)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "INSERT INTO cliente (nome, sobrenome, cpf, telefone, sexo) VALUES (@nome, @sobrenome, @cpf, @telefone, @sexo);";

                this.comando.Parameters.AddWithValue("@nome", cliente.getNome());
                this.comando.Parameters.AddWithValue("@sobrenome", cliente.getSobrenome());
                this.comando.Parameters.AddWithValue("@cpf", cliente.getCpf());
                this.comando.Parameters.AddWithValue("@telefone", cliente.getTelefone());
                this.comando.Parameters.AddWithValue("@sexo", cliente.getSexo());

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
        } //FUNCIONANDO

        //CRUD: Localizar
        public void localizar(List<Cliente> lista)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = this.sql;

                try
                {
                    this.cursor = comando.ExecuteReader();

                    Cliente cliente = new Cliente();

                    while (this.cursor.Read())
                    {
                        //Setando cada atributo do objeto Cliente criado com o nome da tabela correspondente e o tipo de dado(int,GetInt,varchar,GetString, etc) 
                        cliente = cliente.clonar(this.cursor.GetString("idCliente"), this.cursor.GetString("nome"), this.cursor.GetString("sobrenome"), this.cursor.GetString("cpf"), this.cursor.GetString("telefone"), this.cursor.GetString("sexo"));

                        lista.Add(cliente);
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar realizar a busca!", "Busca não realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na pesquisa", MessageBoxButtons.OK);
                }

                this.conexao.Close();
            }
        }//FUNCIONANDO

        //CRUD: Alterar
        public int alterar(Cliente cliente)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "UPDATE `aluguel`.`cliente` SET `nome` = @nome, `sobrenome` = @sobrenome, `cpf` = @cpf, `telefone` = @telefone, `sexo` = @sexo WHERE(`idCliente` = @id)";

                this.comando.Parameters.AddWithValue("@id", Convert.ToInt32(cliente.getId()));
                this.comando.Parameters.AddWithValue("@nome", cliente.getNome());
                this.comando.Parameters.AddWithValue("@sobrenome", cliente.getSobrenome());
                this.comando.Parameters.AddWithValue("@cpf", cliente.getCpf());
                this.comando.Parameters.AddWithValue("@telefone", cliente.getTelefone());
                this.comando.Parameters.AddWithValue("@sexo", cliente.getSexo());

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
            return resultado;
        }//FUNCIONANDO

        //CRUD: Excluir
        public int excluir(string idCliente)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "DELETE FROM `aluguel`.`cliente` WHERE (`idCliente` = @idCliente)";

                this.comando.Parameters.AddWithValue("@idCliente", idCliente);

                this.comando.Prepare();

                try
                {
                    this.resultado = this.comando.ExecuteNonQuery();
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar excluir o cliente!", "Cliente não excluído", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na exclusão", MessageBoxButtons.OK);
                }
            }
            this.conexao.Close();
            return resultado;
        }//FUNCIONANDO

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
        public void prepararComandoParaBusca(Cliente cliente, string comando)
        {
            this.sql = "SELECT * FROM aluguel.cliente WHERE ";

            if (cliente.getNome() != "")
            {
                this.sql += "nome LIKE '%" + cliente.getNome() + "%' ";
            }

            if (cliente.getSobrenome() != "")
            {
                if (cliente.getNome() != "")
                {
                    this.sql += comando + " sobrenome LIKE '%" + cliente.getSobrenome() + "%' ";
                }
                else
                {
                    this.sql += "sobrenome LIKE '%" + cliente.getSobrenome() + "%' ";
                }
            }

            if (cliente.getCpf() != "")
            {
                if (cliente.getNome() != "" || cliente.getSobrenome() != "")
                {
                    this.sql += comando + " cpf LIKE '%" + cliente.getCpf() + "%' ";
                }
                else
                {
                    this.sql += "cpf LIKE '%" + cliente.getCpf() + "%' ";
                }
            }

            if (cliente.getTelefone() != "")
            {
                if (cliente.getNome() != "" || cliente.getSobrenome() != "" || cliente.getCpf() != "")
                {
                    this.sql += comando + " telefone LIKE '%" + cliente.getTelefone() + "%' ";
                }
                else
                {
                    this.sql += "telefone LIKE '%" + cliente.getTelefone() + "%' ";
                }
            }

            if (cliente.getSexo() != "")
            {
                if (cliente.getNome() != "" || cliente.getSobrenome() != "" || cliente.getCpf() != "" || cliente.getTelefone() != "")
                {
                    this.sql += comando + " sexo LIKE '%" + cliente.getSexo() + "%' ";
                }
                else
                {
                    this.sql += "sexo LIKE '%" + cliente.getSexo() + "%' ";
                }
            }
        }

        //Função que retorna todos os clientes cadastrados no Bancos de Dados
        public void carregaTodosOsDados(List<Cliente> lista)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "SELECT * FROM aluguel.cliente ORDER BY nome ASC";

                try
                {
                    this.cursor = comando.ExecuteReader();

                    Cliente cliente = new Cliente();

                    while (this.cursor.Read())
                    {
                        //Setando cada atributo do objeto Cliente criado com o nome da tabela correspondente e o tipo de dado(int,GetInt,varchar,GetString, etc) 
                        cliente = cliente.clonar(this.cursor.GetString("idCliente"), this.cursor.GetString("nome"), this.cursor.GetString("sobrenome"), this.cursor.GetString("cpf"), this.cursor.GetString("telefone"), this.cursor.GetString("sexo"));

                        lista.Add(cliente);
                    }
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar buscar todos os clientes!", "Busca não realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na pesquisa", MessageBoxButtons.OK);
                }

                this.conexao.Close();
            }
        }

        //Se o CPF já esta cadastrado retorna "TRUE", se não retorna "FALSE"
        public bool procurarCPF(string cpf)
        {
            if (this.abrirConexao())
            {
                this.comando.CommandText = "SELECT cliente.nome, cliente.sobrenome, cliente.cpf FROM aluguel.cliente WHERE cliente.cpf = @cpf;";

                this.comando.Parameters.AddWithValue("@cpf", cpf);

                this.comando.Prepare();

                try
                {
                    this.cursor = this.comando.ExecuteReader();
                }
                catch(MySqlException exception)
                {
                    MessageBox.Show("Houve um problema ao tentar verificar o CPF informado!", "CPF não verificado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Dados técnicos: " + exception, "Falha na verificação", MessageBoxButtons.OK);
                }
            }

            if (this.cursor.Read())
            {
                MessageBox.Show("O CPF informado já esta cadastrado!\nCliente cadastrado: " + cursor.GetString("nome") + " " + cursor.GetString("sobrenome"), "CPF já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método que clona o objeto (Padrão de Projeto Prototype)
        public DAOCliente clonar()
        {
            return new DAOCliente();
        }
    }
}
