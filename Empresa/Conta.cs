﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    class Conta
    {
        // atributos da classe
        public int numero;
        public string titular;
        public double saldo;


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
    }
}
