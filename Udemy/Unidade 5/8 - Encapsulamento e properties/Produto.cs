using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Encapsulamento_e_properties
{
    class Produto
    {
        private string nome;
        private double preco;
        private int quantidade;

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public double Preco
        {
            get {
                return this.preco;
            }
            set {
                this.preco = value;
            }
        }

        /*
        
        IMPLEMENTAÇÃO DE MÉTODOS GETTERS E SETTERS

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetNome()
        {
            return this.nome;
        }
        */
    }
}
