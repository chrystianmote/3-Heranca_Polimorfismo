using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    class Program
    {

        static List<Pessoa> pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            int Op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------");
                Console.WriteLine("    CADASTRO DE CLIENTES");
                Console.WriteLine("-----------------------------\n");
                Console.WriteLine("1 - Cadastrar P essoa Física");
                Console.WriteLine("2 - Cadastrar Pessoa Jurídica");
                Console.WriteLine("3 - Listar Pessoas Cadastradas");
                Console.WriteLine("4 - Sair");
                while (Int32.TryParse(Console.ReadLine(), out Op) == false)
                {
                    Console.Write("Digite uma opção numérica: ");
                }
                Console.Clear();
                switch (Op)
                {
                    case 1:
                        PessoaFisica pf = new PessoaFisica();
                        pf.Cadastrar();
                        pessoas.Add(pf);
                        break;
                    case 2:
                        PessoaJuridica pj = new PessoaJuridica();
                        pj.Cadastrar();
                        pessoas.Add(pj);
                        break;
                    case 3:
                        Console.WriteLine("Código Nome                     Documento");
                        foreach (Pessoa p in pessoas)
                        {
                            p.ExibirLinhaTabela();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tchau!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Ops, erro!");
                        Console.ReadKey();
                        break;
                }
            } while (Op != 3);
        }
    }
}
