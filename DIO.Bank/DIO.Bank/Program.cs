using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoFisica, 0, 0, "Renato Vieira");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
