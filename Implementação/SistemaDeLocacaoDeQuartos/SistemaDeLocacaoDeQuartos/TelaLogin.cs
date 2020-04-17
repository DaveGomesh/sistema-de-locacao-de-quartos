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

namespace SistemaDeLocacaoDeQuartos
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text, senha = txtSenha.Text;

            if(login == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Campos vazios");
                txtLogin.Focus();
            }
            else
            {
                DAOTelaLogin daologin = new DAOTelaLogin();
                if(daologin.efetuarLogin(login, senha) == true)
                {
                    //MessageBox.Show("Parabéns");
                    this.Hide();
                    TelaMenuPrincipal telaMenuPrincipal = new TelaMenuPrincipal();
                    telaMenuPrincipal.Show();                    
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorreta!", "Erro");
                    //txtLogin.Text = "";
                    txtSenha.Text = "";
                    txtSenha.Focus();
                }
            }
        }
    }
}
