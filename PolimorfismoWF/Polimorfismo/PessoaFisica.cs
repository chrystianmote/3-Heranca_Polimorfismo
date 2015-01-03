using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    class PessoaFisica : Pessoa
    {
        public string Nome;
        public DateTime DataNascimento;
        public string CPF;
        public string RG;

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.Write("Digite o nome da pessoa: ");
            this.Nome = Console.ReadLine();
            Console.Write("Digite a data de nascimento: ");
            while (DateTime.TryParse(Console.ReadLine(), out this.DataNascimento) == false)
            {
                Console.Write("Digite a data no formato dd/mm/aaaa: ");
            }
            Console.Write("Digite o CPF: ");
            this.CPF = Console.ReadLine();
            Console.Write("Digite o RG: ");
            this.RG = Console.ReadLine();
        }

        public override void ExibirLinhaTabela()
        {
            Console.WriteLine("{0:D6} {1, -25} {2, -16}", this.Codigo, this.Nome, this.CPF);
        }
    }
}
