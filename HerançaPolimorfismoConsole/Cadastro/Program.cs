using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro
{
    class Program
    {
        static byte Opcoes()
        {
            Console.Clear();
            Console.Title = "Controle de Pessoas";
            Console.WriteLine("\n---------------------------------- ");
            Console.WriteLine("\tCadastro de Pessoas  ");
            Console.WriteLine("----------------------------------\n\n");
            Console.WriteLine(" 1 - Cadastrar Pessoa Física ");
            Console.WriteLine(" 2 - Cadastrar Pessoa Jurídica ");
            Console.WriteLine(" 3 - Listar");
            Console.WriteLine(" 4 - Sair \n\n");
            Console.WriteLine("--------------------------");
            Console.Write(" Informe a Opção Desejada: ");
            byte op;
            while (!byte.TryParse(Console.ReadLine(), out op))
            {
                Console.Write("\n\n\t Opção Inválida! Digite novamente: ");
            }
            if (op != 4)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\n\n Obrigado por utilizar este programa...");
                Console.ReadKey();
            }
            return op;
        }
        static List<Pessoa> Pessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            bool sair = false;
            do
            {
                switch (Opcoes())
                {
                    case 1:
                        PessoaFisica pf = new PessoaFisica();
                        pf.Cadastrar();
                        Pessoas.Add(pf);
                        break;
                    case 2:
                        PessoaJuridica pj = new PessoaJuridica();
                        pj.Cadastrar();
                        Pessoas.Add(pj);
                        break;
                    case 3:
                        Console.WriteLine("Código   Nome                     Documento");
                        foreach (Pessoa p in Pessoas)
                        {
                            p.ExibirLinhaTabela();
                        }
                        break;
                    case 4:
                        sair = true;
                        break;
                    default:
                        break;
                }
            } while (!sair);
        }
    }
}
