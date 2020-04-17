using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeLocacaoDeQuartos.modelo;
using SistemaDeLocacaoDeQuartos.dao;

namespace SistemaDeLocacaoDeQuartos
{
    public partial class TelaLocalizarAlterarExcluirCliente : Form
    {
        //Construtor
        public TelaLocalizarAlterarExcluirCliente()
        {
            InitializeComponent();
            DAOCliente daoCliente = new DAOCliente();
            List<Cliente> lista = new List<Cliente>();
            daoCliente.carregaTodosOsDados(lista);
            carregarDadosParaDataGridView(lista);
            txtNome.Focus();
        }

        //Evento de click no botão "BUSCAR"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DAOCliente daoCliente = new DAOCliente();
            List<Cliente> lista = new List<Cliente>();

            if (verificarSeTemCamposDigitados())
            {
                Cliente cliente = new Cliente();
                preencherObjetoComDadosInformados(cliente);

                daoCliente.prepararComandoParaBusca(cliente, ckPesquisasEspecificas.Checked ? "AND" : "OR");

                daoCliente.localizar(lista);

                carregarDadosParaDataGridView(lista);
            }
            else
            {
                dgvClientes.Rows.Clear();
                daoCliente.carregaTodosOsDados(lista);
                carregarDadosParaDataGridView(lista);
            }
        }//FUNCIONANDO

        //Evento de click no botão "SALVAR"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificarSeTodosOsCamposEstaoPreenchidos())
            {
                Cliente cliente = new Cliente(txtId.Text, txtNome.Text, txtSobrenome.Text, txtCpf.Text.Replace(".", "").Replace("-", ""), txtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""), cmbSexo.Text);
                DAOCliente daoCliente = new DAOCliente();
                if (daoCliente.alterar(cliente) > 0)
                {
                    limparCampos();
                    List<Cliente> lista = new List<Cliente>();
                    daoCliente.carregaTodosOsDados(lista);
                    carregarDadosParaDataGridView(lista);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode ficar vazio!", "Campos vazios detectados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Evento de click na picture com a imagem da lixeira ("EXCLUIR")
        private void picExcluir_Click(object sender, EventArgs e)
        {
            excluirCliente();
        }

        //Limpa todos os campos do formulário        
        private void picLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtNome.Focus();
            txtSobrenome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            cmbSexo.SelectedIndex = -1;
            btnBuscar.Enabled = true;
            btnSalvar.Enabled = false;
            ckPesquisasEspecificas.Checked = false;
            ckAdicionarPesquisa.Checked = false;
        }

        //Função que exclui cliente
        private void excluirCliente()
        {
            picExcluir.Focus();

            if (verificarSeTemSeleconados())
            {
                DAOCliente daoCliente = new DAOCliente();
                DAOCliente _daoCliente;
                bool sucesso = true;

                if (MessageBox.Show("Você realmente deseja excluir esse(s) cliente(s)?\nOs dados serão apagados permanentemente!", "Excluir clientes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow linha in dgvClientes.Rows)
                    {
                        if (linha.Cells["colExcluir"].Value != null)
                        {
                            _daoCliente = daoCliente.clonar();
                            if (_daoCliente.excluir(linha.Cells["colId"].Value.ToString()) <= 0)
                            {
                                MessageBox.Show("Não foi possível exluir o cliente: " + linha.Cells["colNome"].Value, "Cliente não excluído", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sucesso = false;
                            }
                        }
                    }

                    if (sucesso == true)
                    {
                        MessageBox.Show("Operação concluída com sucesso!\nTodos os clientes selecionados foram excluídos!", "Exclusão feita", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("A Operação não foi concluída com sucesso!\nHouve falha na exclusão de um ou mais clientes!", "Operação concluída com falhas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    List<Cliente> lista = new List<Cliente>();
                    daoCliente.carregaTodosOsDados(lista);
                    carregarDadosParaDataGridView(lista);
                }
            }
            else
            {
                MessageBox.Show("Selecione um ou mais clientes para excluir!", "Nenhum cliente selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Se algum campo estiver digitado retorna "True", se não retorna "False"
        private bool verificarSeTemCamposDigitados()
        {
            if(txtNome.Text != "" || txtSobrenome.Text != "" || txtCpf.Text != "" || txtTelefone.Text != "" || cmbSexo.SelectedIndex == 0 || cmbSexo.SelectedIndex == 1)
            {
                return true;
            }
            return false;
        }

        //Verifica se todos os campos estão preenchidos
        private bool verificarSeTodosOsCamposEstaoPreenchidos()
        {
            if(txtNome.Text != "" && txtNome.Text != "" && txtSobrenome.Text != "" && txtCpf.Text != "" && txtTelefone.Text != "" && (cmbSexo.SelectedIndex == 0 || cmbSexo.SelectedIndex == 1))
            {
                return true;
            }           
            return false;
        }

        //Preenche o objeto do tipo "Cliente" com todos os dados informados na tela
        private void preencherObjetoComDadosInformados(Cliente cliente)
        {
            if (txtNome.Text != "")
            {
                cliente.setNome(txtNome.Text);
            }

            if (txtSobrenome.Text != "")
            {
                cliente.setSobrenome(txtSobrenome.Text);
            }

            if (txtCpf.Text != "")
            {
                cliente.setCpf(txtCpf.Text.Replace(".", "").Replace("-", ""));
            }

            if (txtTelefone.Text != "")
            {
                cliente.setTelefone(txtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
            }

            if (cmbSexo.SelectedItem != null)
            {
                cliente.setSexo(cmbSexo.Text);
            }
        }

        //Carrega todos os dados para o DataGridView
        private void carregarDadosParaDataGridView(List<Cliente> lista)
        {
            if (!ckAdicionarPesquisa.Checked)
            {
                dgvClientes.Rows.Clear();
            }

            string[] dados = new string[6];

            foreach (Cliente cliente in lista)
            {
                bool podeAdicionar = true;
                //Inclusão dos dados do cliente no vetor
                dados[0] = Convert.ToString(cliente.getId());

                if (ckAdicionarPesquisa.Checked && verificarSeTemCamposDigitados())
                {
                    foreach (DataGridViewRow linha in dgvClientes.Rows)
                    {
                        if ((linha.Cells["colId"].Value.ToString() == dados[0]))
                        {
                            podeAdicionar = false;
                        }
                    }
                }

                dados[1] = cliente.getNome();
                dados[2] = cliente.getSobrenome();
                dados[3] = cliente.getCpf().Insert(3, ".").Insert(7, ".").Insert(11, "-");
                dados[4] = cliente.getTelefone().Insert(0, "(").Insert(3, ") ").Insert(6, " ").Insert(11, "-");
                dados[5] = cliente.getSexo();

                //Adição dos dados na linha do DataGridView
                if(podeAdicionar == true)
                {
                    dgvClientes.Rows.Add(dados);
                }
            }

        }

        //Evento de duplo click na primeira célula de qualquer linha do DataGridView (a vazia, antes do id)
        private void dgvClientes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            colocarDadosNosCampos();
        }

        //Evento de duplo click em qualquer célula do DataGridView, menos nas células do "Excluir"
        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvClientes.CurrentCell.ColumnIndex != 6 && dgvClientes.CurrentCell.ColumnIndex != 7)
            {
                colocarDadosNosCampos();
            }

            if(dgvClientes.CurrentCell.ColumnIndex == 7)
            {
                dgvClientes.Rows.RemoveAt(dgvClientes.CurrentRow.Index);
            }
        }
        
        //Coloca os dados da linha selecionada nos campos do formulário
        private void colocarDadosNosCampos()
        {
            if (dgvClientes.CurrentRow.Cells["colId"].Value != null)
            {
                btnBuscar.Enabled = false;
                btnSalvar.Enabled = true;

                txtId.Text = dgvClientes.CurrentRow.Cells["colId"].Value.ToString();
                txtNome.Text = dgvClientes.CurrentRow.Cells["colNome"].Value.ToString();
                txtSobrenome.Text = dgvClientes.CurrentRow.Cells["colSobrenome"].Value.ToString();
                txtCpf.Text = dgvClientes.CurrentRow.Cells["colCpf"].Value.ToString();
                txtTelefone.Text = dgvClientes.CurrentRow.Cells["colTelefone"].Value.ToString();

                if (dgvClientes.CurrentRow.Cells["colSexo"].Value.ToString() == "Masculino")
                {
                    cmbSexo.SelectedIndex = 0;
                }
                else
                {
                    cmbSexo.SelectedIndex = 1;
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        //Verifica se tem algum Check Box do DataGridView selecionado
        private bool verificarSeTemSeleconados()
        {
            foreach (DataGridViewRow linha in dgvClientes.Rows)
            {
                if (linha.Cells["colExcluir"].Value != null)
                {
                    return true;
                }
            }
            return false;
        }

        //Limpa todos os campos do formulário
        private void limparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            cmbSexo.SelectedIndex = -1;
            btnBuscar.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Focus();
        }

        //Botão que serve de ponte para ativação de outros ou de funções
        private void btnAcionar_Click(object sender, EventArgs e)
        {
            if (verificarSeTemSeleconados())
            {
                excluirCliente();
            }
            else if (btnBuscar.Enabled == true)
            {
                btnBuscar.PerformClick();
            }
            else if (btnSalvar.Enabled == true)
            {
                btnSalvar.PerformClick();
            }
        }

        //Se a tecla enter for pressionada dentro do DataGridView o botão "ACIONAR" é disparado
        private void dgvClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && verificarSeTemSeleconados())
            {
                btnAcionar.PerformClick();
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                txtCpf.SelectionStart = txtCpf.Text.Length + 1;

                if (txtCpf.Text.Length == 3 || txtCpf.Text.Length == 7)
                    txtCpf.Text += ".";
                else if (txtCpf.Text.Length == 11)
                    txtCpf.Text += "-";
                txtCpf.SelectionStart = txtCpf.Text.Length + 1;
            }

            if (e.KeyChar == 8)
            {
                if (txtCpf.Text.Length == 5 || txtCpf.Text.Length == 9 || txtCpf.Text.Length == 13)
                {
                    txtCpf.Text = txtCpf.Text.Remove(txtCpf.Text.Length - 1);
                    txtCpf.SelectionStart = txtCpf.Text.Length + 1;
                }
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                txtTelefone.SelectionStart = txtTelefone.Text.Length + 1;

                if (txtTelefone.Text.Length == 0)
                    txtTelefone.Text += "(";
                else if (txtTelefone.Text.Length == 3)
                    txtTelefone.Text += ") ";
                else if (txtTelefone.Text.Length == 6)
                    txtTelefone.Text += " ";
                else if (txtTelefone.Text.Length == 11)
                    txtTelefone.Text += "-";

                txtTelefone.SelectionStart = txtTelefone.Text.Length + 1;
            }
        }
    }
}
