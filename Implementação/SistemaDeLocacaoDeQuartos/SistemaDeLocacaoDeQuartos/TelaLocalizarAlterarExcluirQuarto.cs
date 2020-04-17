using SistemaDeLocacaoDeQuartos.dao;
using SistemaDeLocacaoDeQuartos.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLocacaoDeQuartos
{
    public partial class TelaLocalizarAlterarExcluirQuarto : Form
    {
        //Construtor
        public TelaLocalizarAlterarExcluirQuarto()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            DAOQuarto daoQuarto = new DAOQuarto();
            List<Quarto> lista = new List<Quarto>();
            daoQuarto.carregaTodosOsDados(lista);
            carregarDadosParaDataGridView(lista);
            cmbNumeroDoQuarto.Focus();
        }

        //Evento de click no botão "BUSCAR"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DAOQuarto daoQuarto = new DAOQuarto();
            List<Quarto> lista = new List<Quarto>();

            if (verificaSeTemCamposDigitados())
            {
                Quarto quarto = new Quarto();
                preencherObjetoComDadosInformados(quarto);

                daoQuarto.prepararComandoParaBusca(quarto, ckPesquisasEspecificas.Checked ? "AND" : "OR");

                daoQuarto.localizar(lista);

                carregarDadosParaDataGridView(lista);
            }
            else
            {
                daoQuarto.carregaTodosOsDados(lista);
                carregarDadosParaDataGridView(lista);
            }
        }

        //Evento de click no botão "SALVAR"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (verificarSeTodosOsCamposEstaoPreenchidos())
            {
                Quarto quarto = new Quarto(txtId.Text, cmbNumeroDoQuarto.Text, cmbTipo.Text, cmbBanheiros.Text, cmbSalas.Text, cmbCozinhas.Text, cmbPrecoDaMensalidade.Text, cmbAndar.Text);
                DAOQuarto daoQuarto = new DAOQuarto();
                if(daoQuarto.alterar(quarto) > 0)
                {
                    limparCampos();
                    List<Quarto> lista = new List<Quarto>();
                    daoQuarto.carregaTodosOsDados(lista);
                    carregarDadosParaDataGridView(lista);
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode ficar vazio!", "Campos vazios detectados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Evento de click no botão "LIMPAR"
        private void picLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //Evento de click no botão "EXCLUIR"
        private void picExcluir_Click(object sender, EventArgs e)
        {
            excluirQuarto();
        }

        //Função para excluir quartos
        private void excluirQuarto()
        {
            picExcluir.Focus();

            if (verificarSeTemSeleconados())
            {
                DAOQuarto daoQuarto = new DAOQuarto();
                DAOQuarto _daoQuarto;
                bool sucesso = true;

                if (MessageBox.Show("Você realmente deseja excluir esse(s) quartos(s)?\nOs dados serão apagados permanentemente!", "Excluir quartos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow linha in dgvQuarto.Rows)
                    {
                        if (linha.Cells["colExcluir"].Value != null)
                        {
                            _daoQuarto = daoQuarto.clonar();
                            if (_daoQuarto.excluir(linha.Cells["colId"].Value.ToString()) <= 0)
                            {
                                MessageBox.Show("Não foi possível exluir o Quarto: " + linha.Cells["colNumeroQuarto"].Value, "Quarto não excluído", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sucesso = false;
                            }
                        }
                    }

                    if (sucesso == true)
                    {
                        MessageBox.Show("Operação concluída com sucesso!\nTodos os quartos selecionados foram excluídos!", "Exclusão feita", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("A Operação não foi concluída com sucesso!\nHouve falha na exclusão de um ou mais quartos!", "Operação concluída com falhas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    List<Quarto> lista = new List<Quarto>();
                    daoQuarto.carregaTodosOsDados(lista);
                    carregarDadosParaDataGridView(lista);
                }
            }
            else
            {
                MessageBox.Show("Selecione um ou mais quartos para excluir!", "Nenhum quarto selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Verifica se tem algum Check Box do DataGridView selecionado
        private bool verificarSeTemSeleconados()
        {
            foreach (DataGridViewRow linha in dgvQuarto.Rows)
            {
                if (linha.Cells["colExcluir"].Value != null)
                {
                    return true;
                }
            }
            return false;
        }

        //Verifica se todos os campos estão preenchidos
        private bool verificarSeTodosOsCamposEstaoPreenchidos()
        {
            if((cmbNumeroDoQuarto.SelectedIndex != -1 || cmbNumeroDoQuarto.Text != "") && cmbTipo.SelectedIndex != -1 && cmbBanheiros.SelectedIndex != -1 && cmbSalas.SelectedIndex != -1 && cmbCozinhas.SelectedIndex != -1 && (cmbPrecoDaMensalidade.SelectedIndex != -1 || cmbPrecoDaMensalidade.Text != "") && cmbAndar.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        //Limpa todos os campos do formulário
        private void limparCampos()
        {
            btnBuscar.Enabled = true;
            btnSalvar.Enabled = false;

            txtId.Text = "";
            cmbNumeroDoQuarto.Text = "";
            cmbTipo.SelectedIndex = -1;
            cmbBanheiros.SelectedIndex = -1;
            cmbSalas.SelectedIndex = -1;
            cmbCozinhas.SelectedIndex = -1;
            cmbPrecoDaMensalidade.Text = "";
            cmbAndar.SelectedIndex = -1;
        }

        //Se algum campo estiver digitado retorna "True", se não retorna "False"
        private bool verificaSeTemCamposDigitados()
        {
            if (cmbNumeroDoQuarto.Text != "" || cmbNumeroDoQuarto.SelectedIndex == 0 || cmbNumeroDoQuarto.SelectedIndex == 1 || cmbTipo.SelectedIndex == 0 || cmbTipo.SelectedIndex == 1 || cmbBanheiros.SelectedIndex == 0 || cmbBanheiros.SelectedIndex == 1 || cmbSalas.SelectedIndex == 0 || cmbSalas.SelectedIndex == 1 || cmbCozinhas.SelectedIndex == 0 || cmbCozinhas.SelectedIndex == 1 || cmbPrecoDaMensalidade.Text != "" || cmbPrecoDaMensalidade.SelectedIndex == 0 || cmbPrecoDaMensalidade.SelectedIndex == 1 || cmbAndar.SelectedIndex == 0 || cmbAndar.SelectedIndex == 1)
            {
                return true;
            }
            return false;
        }

        //Preenche o objeto do tipo "Cliente" com todos os dados informados na tela
        private void preencherObjetoComDadosInformados(Quarto quarto)
        {
            if (cmbNumeroDoQuarto.Text != "" || cmbNumeroDoQuarto.SelectedIndex == 0 || cmbNumeroDoQuarto.SelectedIndex == 1)
            {
                quarto.setNumeroQuarto(cmbNumeroDoQuarto.Text);
            }

            if (cmbTipo.SelectedIndex == 0 || cmbTipo.SelectedIndex == 1)
            {
                quarto.setTipo(cmbTipo.Text);
            }

            if (cmbBanheiros.SelectedIndex == 0 || cmbBanheiros.SelectedIndex == 1)
            {
                quarto.setQuantBanheiros(cmbBanheiros.Text);
            }

            if (cmbSalas.SelectedIndex == 0 || cmbSalas.SelectedIndex == 1)
            {
                quarto.setQuantSalas(cmbSalas.Text);
            }

            if (cmbCozinhas.SelectedIndex == 0 || cmbCozinhas.SelectedIndex == 1)
            {
                quarto.setQuantCozinhas(cmbCozinhas.Text);
            }

            if (cmbPrecoDaMensalidade.Text != "" || cmbPrecoDaMensalidade.SelectedIndex == 0 || cmbPrecoDaMensalidade.SelectedIndex == 1)
            {
                quarto.setPrecoMensalidade(cmbPrecoDaMensalidade.Text);
            }

            if (cmbAndar.SelectedIndex == 0 || cmbAndar.SelectedIndex == 1)
            {
                quarto.setAndar(cmbAndar.SelectedIndex == 0 ? "1" : "2");
            }
        }

        //Carrega todos os dados para o DataGridView
        private void carregarDadosParaDataGridView(List<Quarto> lista)
        {
            if (!ckAdicionarPesquisa.Checked)
            {
                dgvQuarto.Rows.Clear();
            }

            string[] dados = new string[8];

            foreach(Quarto quarto in lista)
            {
                bool podeAdicionar = true;

                dados[0] = Convert.ToString(quarto.getId());

                if(ckAdicionarPesquisa.Checked && verificaSeTemCamposDigitados())
                {
                    foreach (DataGridViewRow linha in dgvQuarto.Rows)
                    {
                        if ((linha.Cells["colId"].Value.ToString() == dados[0]))
                        {
                            podeAdicionar = false;
                        }
                    }
                }

                dados[1] = quarto.getNumeroQuarto();
                dados[2] = quarto.getTipo();
                dados[3] = quarto.getQuantBanheiros();
                dados[4] = quarto.getQuantSalas();
                dados[5] = quarto.getQuantCozinhas();
                dados[6] = quarto.getPrecoMensalidade();
                dados[7] = quarto.getAndar();

                if(podeAdicionar == true)
                {
                    dgvQuarto.Rows.Add(dados);
                }
            }
        }

        //Coloca os dados da linha selecionada nos campos do formulário
        private void colocarDadosNosCampos()
        {
            btnBuscar.Enabled = false;
            btnSalvar.Enabled = true;

            txtId.Text = dgvQuarto.CurrentRow.Cells["colId"].Value.ToString();

            cmbNumeroDoQuarto.Text = dgvQuarto.CurrentRow.Cells["colNumeroQuarto"].Value.ToString();

            if(dgvQuarto.CurrentRow.Cells["colTipo"].Value.ToString() == "Simples")
            {
                cmbTipo.SelectedIndex = 0;
            }
            else
            {
                cmbTipo.SelectedIndex = 1;
            }

            if(dgvQuarto.CurrentRow.Cells["colBanheiros"].Value.ToString() == "1")
            {
                cmbBanheiros.SelectedIndex = 0;
            }
            else
            {
                cmbBanheiros.SelectedIndex = 1;
            }

            if (dgvQuarto.CurrentRow.Cells["colSalas"].Value.ToString() == "1")
            {
                cmbSalas.SelectedIndex = 0;
            }
            else
            {
                cmbSalas.SelectedIndex = 1;
            }

            if (dgvQuarto.CurrentRow.Cells["colCozinhas"].Value.ToString() == "1")
            {
                cmbCozinhas.SelectedIndex = 0;
            }
            else
            {
                cmbCozinhas.SelectedIndex = 1;
            }

            cmbPrecoDaMensalidade.Text = dgvQuarto.CurrentRow.Cells["colPrecoMensalidade"].Value.ToString();

            if(dgvQuarto.CurrentRow.Cells["colAndar"].Value.ToString() == "1")
            {
                cmbAndar.SelectedIndex = 0;
            }
            else
            {
                cmbAndar.SelectedIndex = 1;
            }
        }

        //Função que corrige os dados, segundo as regras de negócio do sistema,
        //no momento que é alterado a opção do tipo do quarto
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.SelectedIndex == 0)
            {
                if(cmbBanheiros.SelectedIndex == 1)
                {
                    cmbBanheiros.SelectedIndex = 0;
                }

                if(cmbSalas.SelectedIndex == 1)
                {
                    cmbSalas.SelectedIndex = 0;
                }

                if(cmbCozinhas.SelectedIndex == 1)
                {
                    cmbCozinhas.SelectedIndex = 0;
                }
            }
        }

        //Função que não permite colocar valor 2 caso a opção de Simples esteja selecionada
        private void cmbBanheiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipo.SelectedIndex == 0)
            {
                cmbBanheiros.SelectedIndex = 0;
            }
        }

        //Função que não permite colocar valor 2 caso a opção de Simples esteja selecionada
        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                cmbSalas.SelectedIndex = 0;
            }
        }

        //Função que não permite colocar valor 2 caso a opção de Simples esteja selecionada
        private void cmbCozinhas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex == 0)
            {
                cmbCozinhas.SelectedIndex = 0;
            }
        }

        //Evento de duplo click em qualquer célula do DataGridView, menos nas células do "Excluir"
        private void dgvQuarto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvQuarto.CurrentCell.ColumnIndex != 8)
            {
                colocarDadosNosCampos();
            }
        }

        //Evento de duplo click na primeira célula de qualquer linha do DataGridView (a vazia, antes do id)
        private void dgvQuarto_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            colocarDadosNosCampos();
        }
    }
}
