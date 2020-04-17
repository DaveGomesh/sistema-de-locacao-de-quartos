using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeLocacaoDeQuartos.modelo
{
    class Quarto
    {
        private string id;
        private string numeroQuarto;
        private string tipo;
        private string quantBanheiros;
        private string quantSalas;
        private string quantCozinhas;
        private string precoMensalidade;
        private string andar;

        //CONSTRUTOR VAZIO E DEFININDO TODOS OS VALORES
        //DOS ATRIBUTOS COMO VAZIO
        public Quarto()
        {
            this.setId("");
            this.setNumeroQuarto("");
            this.setTipo("");
            this.setQuantBanheiros("");
            this.setQuantSalas("");
            this.setQuantCozinhas("");
            this.setPrecoMensalidade("");
            this.setAndar("");
        }

        //CONSTRUTOR SEM O ID
        public Quarto(string numeroQuarto, string tipo, string quantBanheiros, string quantSalas, string quantCozinhas, string precoMensalidade, string andar)
        {
            //this.setId(id);
            this.setNumeroQuarto(numeroQuarto);
            this.setTipo(tipo);
            this.setQuantBanheiros(quantBanheiros);
            this.setQuantSalas(quantSalas);
            this.setQuantCozinhas(quantCozinhas);
            this.setPrecoMensalidade(precoMensalidade);
            this.setAndar(andar);
        }

        //CONSTRUTOR COM O ID
        public Quarto(string id, string numeroQuarto, string tipo, string quantBanheiros, string quantSalas, string quantCozinhas, string precoMensalidade, string andar)
        {
            this.setId(id);
            this.setNumeroQuarto(numeroQuarto);
            this.setTipo(tipo);
            this.setQuantBanheiros(quantBanheiros);
            this.setQuantSalas(quantSalas);
            this.setQuantCozinhas(quantCozinhas);
            this.setPrecoMensalidade(precoMensalidade);
            this.setAndar(andar);
        }

        //METODOS GETTERS
        public string getId()
        {
            return this.id;
        }

        public string getNumeroQuarto()
        {
            return this.numeroQuarto;
        }

        public string getTipo()
        {
            return this.tipo;
        }

        public string getQuantBanheiros()
        {
            return this.quantBanheiros;
        }

        public string getQuantSalas()
        {
            return this.quantSalas;
        }

        public string getQuantCozinhas()
        {
            return this.quantCozinhas;
        }

        public string getPrecoMensalidade()
        {
            return this.precoMensalidade;
        }

        public string getAndar()
        {
            return this.andar;
        }

        //METDOS SETTERS
        public void setId(string id)
        {
            this.id = id;
        }

        public void setNumeroQuarto(string numeroQuarto)
        {
            this.numeroQuarto = numeroQuarto;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void setQuantBanheiros(string quantBanheiros)
        {
            this.quantBanheiros = quantBanheiros;
        }

        public void setQuantSalas(string quantSalas)
        {
            this.quantSalas = quantSalas;
        }

        public void setQuantCozinhas(string quantCozinhas)
        {
            this.quantCozinhas = quantCozinhas;
        }

        public void setPrecoMensalidade(string precoMensalidade)
        {
            this.precoMensalidade = precoMensalidade;
        }

        public void setAndar(string andar)
        {
            this.andar = andar;
        }

        //Método que clona o objeto (Padrão de Projeto Prototype)
        public Quarto clonar(string id, string numeroQuarto, string tipo, string quantBanheiros, string quantSalas, string quantCozinhas, string precoMensalidade, string andar)
        {
            return new Quarto(id, numeroQuarto, tipo, quantBanheiros, quantSalas, quantCozinhas, precoMensalidade, andar);
        }
    }
}
