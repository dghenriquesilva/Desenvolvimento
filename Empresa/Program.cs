using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente diogo = new Cliente();
            diogo.nome = "diogo";

            Conta umaConta = new Conta();
            umaConta.titular = diogo;
            umaConta.titular.rg = "3565";

            Console.WriteLine(umaConta.titular.nome);
            Cliente c2 = new Cliente(;

        }
    }
}
