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
    public partial class TelaMenuPrincipal : Form
    {
        private Form instanciapai { get; set; }

        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }

        private bool verificarFormAberto()
        {
            if((Application.OpenForms.OfType<TelaAlugar>().Count() > 0) || (Application.OpenForms.OfType<TelaCadastrarCliente>().Count() > 0) || (Application.OpenForms.OfType<TelaCadastrarQuarto>().Count() > 0) || (Application.OpenForms.OfType<TelaDesalugar>().Count() > 0) || (Application.OpenForms.OfType<TelaLocalizarAlterarExcluirCliente>().Count() > 0) || (Application.OpenForms.OfType<TelaLocalizarAlterarExcluirQuarto>().Count() > 0))
            {
                return false;
            }
            return true;
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificarFormAberto())
            {
                TelaCadastrarCliente telaCadastrarCliente = new TelaCadastrarCliente();
                this.instanciapai = this;
                telaCadastrarCliente.MdiParent = instanciapai;
                telaCadastrarCliente.Show();
            }
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificarFormAberto())
            {
                TelaLocalizarAlterarExcluirCliente telaLocalizarAlterarExcluirCliente = new TelaLocalizarAlterarExcluirCliente();
                this.instanciapai = this;
                telaLocalizarAlterarExcluirCliente.MdiParent = instanciapai;
                telaLocalizarAlterarExcluirCliente.Show();
            }
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (verificarFormAberto())
            {

                TelaCadastrarQuarto telaCadastrarQuarto = new TelaCadastrarQuarto();
                this.instanciapai = this;
                telaCadastrarQuarto.MdiParent = instanciapai;
                telaCadastrarQuarto.Show();
            }
        }

        private void localizarAlterarExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificarFormAberto())
            {
                TelaLocalizarAlterarExcluirQuarto telaLocalizarAlterarExcluirQuarto = new TelaLocalizarAlterarExcluirQuarto();
                this.instanciapai = this;
                telaLocalizarAlterarExcluirQuarto.MdiParent = instanciapai;
                telaLocalizarAlterarExcluirQuarto.Show();
            }
        }

        private void alugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificarFormAberto())
            {
                TelaAlugar telaAlugar = new TelaAlugar();
                this.instanciapai = this;
                telaAlugar.MdiParent = instanciapai;
                telaAlugar.Show();
            }
        }

        private void desalugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verificarFormAberto())
            {
                TelaDesalugar telaDesalugar = new TelaDesalugar();
                this.instanciapai = this;
                telaDesalugar.MdiParent = instanciapai;
                telaDesalugar.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair da aplicação?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void TelaMenuPrincipal_Deactivate(object sender, EventArgs e)
        {
            //Application.Exit();  
            //Environment.Exit(Environment.ExitCode);
        }
    }
}
