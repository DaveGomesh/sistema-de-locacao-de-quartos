using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLocacaoDeQuartos.modelo
{
    class Cliente
    {
        private string id;
        private string nome;
        private string sobrenome;
        private string cpf;
        private string telefone;
        private string sexo;

        //CONSTRUTOR VAZIO E DEFININDO TODOS OS VALORES
        //DOS ATRIBUTOS COMO VAZIO
        public Cliente()
        {
            this.setId("");
            this.setNome("");
            this.setSobrenome("");
            this.setCpf("");
            this.setTelefone("");
            this.setSexo("");
        }

        //CONSTRUTOR SEM O ID
        public Cliente(string nome, string sobrenome, string cpf, string telefone, string sexo)
        {
            this.setNome(nome);
            this.setSobrenome(sobrenome);
            this.setCpf(cpf);
            this.setTelefone(telefone);
            this.setSexo(sexo);
        }

        //CONSTRUTOR COM O ID
        public Cliente(string id, string nome, string sobrenome, string cpf, string telefone, string sexo)
        {
            this.setId(id);
            this.setNome(nome);
            this.setSobrenome(sobrenome);
            this.setCpf(cpf);
            this.setTelefone(telefone);
            this.setSexo(sexo);
        }

        //METODOS GETTES
        public string getId()
        {
            return this.id;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        //METODOS SETTRES
        public void setId(string id)
        {
            this.id = id;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        //Método que clona o objeto (Padrão de Projeto Prototype)
        public Cliente clonar(string id, string nome, string sobrenome, string cpf, string telefone, string sexo)
        {
            return new Cliente(id, nome, sobrenome, cpf, telefone, sexo);
        }
    }
}
