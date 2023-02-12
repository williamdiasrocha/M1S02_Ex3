using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            MensagemCelular mensagem = new MensagemCelular();
            mensagem.Telefone = 123456789;
            mensagem.Mensagem = "Olá, como você está?";
            mensagem.Executar();

            Console.ReadLine();
        }
    }
}