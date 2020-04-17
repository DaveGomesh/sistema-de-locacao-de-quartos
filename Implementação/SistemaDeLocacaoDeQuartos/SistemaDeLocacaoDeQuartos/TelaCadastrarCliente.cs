using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeLocacaoDeQuartos.dao;
using SistemaDeLocacaoDeQuartos.modelo;

namespace SistemaDeLocacaoDeQuartos
{
    public partial class TelaCadastrarCliente : Form
    {
        //Construtor
        public TelaCadastrarCliente()
        {
            InitializeComponent();
            rbMasculino.Checked = true;
            txtNome.Focus();
        }

        //Evento de click no botão "CADASTRAR"
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (verificarCampos() && !verificarSeCPFJaEstaCadastrado())
            {
                Cliente cliente = new Cliente(txtNome.Text, txtSobrenome.Text, txtCpf.Text.Replace(".", "").Replace("-", ""), txtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""), rbMasculino.Checked ? "Masculino" : "Feminino");
                DAOCliente daoCliente = new DAOCliente();
                if (daoCliente.cadastrar(cliente) > 0)
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
        
        //Verifica se todos os campos do formulário foram preenchidos
        private bool verificarCampos()
        {
            if (txtNome.Text != "")
            {
                if (txtSobrenome.Text != "")
                {
                    if (txtCpf.Text != "")
                    {
                        if (txtTelefone.Text != "")
                        {
                            if (rbMasculino.Checked || rbFeminino.Checked)
                            {
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Informe o sexo!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Informe o telefone!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe o CPF!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Informe o sobrenome!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe o nome!", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }

        //Função que verifica se o CPF informado já está cadastrado
        private bool verificarSeCPFJaEstaCadastrado()
        {
            DAOCliente daoCliente = new DAOCliente();

            if (daoCliente.procurarCPF(txtCpf.Text.Replace(".", "").Replace("-", "")))
            {
                return true;
            }

            return false;
        }

        //Limpa todos os campos dos formulário
        private void limparCampos()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCpf.Text = "";
            txtTelefone.Text = "";
            rbMasculino.Checked = true;
            txtNome.Focus();
        }

        //Permite que apenas números sejam digitados nesse campo
        //Formata o número de CPF, dinamicamente, no padrão de CPF
        //Deleta os pontos e hífens automaticamente
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

        //Permite que apenas números sejam digitados nesse campo
        //Formata o número de Telefone, dinamicamente, no padrão de numeros de telefones celular
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

        //Evento bugado que não quer sair ;-;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
