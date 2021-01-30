using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Conta
    {
        // atributos da classe
        public int numero { get; set; }
        public Cliente titular;
        public double saldo = 100.0;


        // metodo sacar
        public bool Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        // metodo deposita
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        // metodo Transfere
        public void Transfere(double valor, Conta destino)
        {
            if(this.Sacar(valor))
            {
                destino.Deposita(valor);
            }
        }


        public override string ToString()
        {
            return this.saldo.ToString("@");
        }
    }
}
