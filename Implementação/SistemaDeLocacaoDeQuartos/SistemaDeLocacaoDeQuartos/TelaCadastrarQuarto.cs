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
    public partial class TelaCadastrarQuarto : Form
    {
        //CONSTRUTOR
        public TelaCadastrarQuarto()
        {
            InitializeComponent();
            cmbBanheiros.SelectedIndex = 0;
            cmbSalas.SelectedIndex = 0;
            cmbCozinhas.SelectedIndex = 0;
            txtNumeroQuarto.Focus();
        }

        //Evento de click no botão "CADASTRAR"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                Quarto quarto = new Quarto(txtNumeroQuarto.Text, rbSimples.Checked ? "Simples" : "Luxo", cmbBanheiros.Text, cmbSalas.Text, cmbCozinhas.Text, cmbPrecoDaMensalidade.Text, rbPrimeiroAndar.Checked ? "1" : "2");
                DAOQuarto daoQuarto = new DAOQuarto();
                if(daoQuarto.cadastrar(quarto) > 0)
                {
                    limparCampos();
                }
            }

        }

        //Evento de click no botão "LIMPAR"
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        //FUNÇÕES ADICONAIS

        //Função que limpa todos os campos do formulário
        private void limparCampos()
        {
            txtNumeroQuarto.Text = "";
            rbSimples.Checked = true;
            cmbPrecoDaMensalidade.Text = "";
            cmbPrecoDaMensalidade.SelectedIndex = -1;
            rbPrimeiroAndar.Checked = true;
        }

        //Função que verifica se todos os campos do formulário foram preenchidos
        private bool verificarCampos()
        {
            if(txtNumeroQuarto.Text != "")
            {
                if (rbSimples.Checked != false || rbLuxo.Checked != false)
                {
                    if(cmbBanheiros.Text != "" || cmbBanheiros.SelectedText != "")
                    {
                        if(cmbSalas.Text != "" || cmbSalas.SelectedText != "")
                        {
                            if(cmbCozinhas.Text != "" || cmbCozinhas.SelectedText != "")
                            {
                                if(cmbPrecoDaMensalidade.Text != "" || cmbPrecoDaMensalidade.SelectedText != "")
                                {
                                    if(rbPrimeiroAndar.Checked != false || rbSegundoAndar.Checked != false)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Informe o andar!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Informe o preço da mensalidade!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Informe a quantidade de cozinhas!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Informe a quantidade de salas!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe a quantidade de banheiros!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Informe o tipo do quarto!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe o número do quarto!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }

        //Função que corrige os dados, segundo as regras de negócio do sistema,
        //no momento que é alterado a opção do tipo do quarto
        private void rbSimples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSimples.Checked)
            {
                cmbBanheiros.SelectedIndex = 0;
                cmbSalas.SelectedIndex = 0;
                cmbCozinhas.SelectedIndex = 0;

                cmbBanheiros.Enabled = false;
                cmbSalas.Enabled = false;
                cmbCozinhas.Enabled = false;
            }
            else if (rbLuxo.Checked)
            {
                cmbBanheiros.Enabled = true;
                cmbSalas.Enabled = true;
                cmbCozinhas.Enabled = true;
            }
        }

        //Permite que apenas números sejam digitados nesse campo
        private void txtNumeroQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //Permite que apenas números sejam digitados nesse campo
        private void cmbPrecoDaMensalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //Permite que apenas números sejam digitados nesse campo
        private void cmbBanheiros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //Permite que apenas números sejam digitados nesse campo
        private void cmbSalas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //Permite que apenas números sejam digitados nesse campo
        private void cmbCozinhas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
