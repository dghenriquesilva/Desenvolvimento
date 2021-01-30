using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Cliente
    {
        // atributos
        public string cpf;
        public int idade;
        public string endereco;
        internal object titular;

        // Auto properties
        public string Nome { get; set; };
        public string Rg { get; set; };


        //Construtor

        public void Cliente(string nome, string rg)
        {
            this.Nome = nome;
            this.Rg = rg;
            return "uva";
        }

        // metodo
        public bool EhMaiorDeidade()
        {
            if (this.idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
