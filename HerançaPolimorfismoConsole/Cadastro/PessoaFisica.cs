using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro
{
    class PessoaFisica : Pessoa
    {
        public string Nome;
        public DateTime DatasNasc;
        public string CPF;
        public string RG;

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.Write("Digite o nome: ");
            this.Nome = Console.ReadLine();
            Console.Write("Digite Data de nascimento: ");
            while (!DateTime.TryParse(Console.ReadLine(), out this.DatasNasc))
            {
                Console.WriteLine("Valor Inválido: ");
            }
            Console.Write("Digite o CPF: ");
            this.CPF = Console.ReadLine();
            Console.Write("Digite o RG: ");
            this.RG = Console.ReadLine();
        }
        public override void ExibirLinhaTabela()                
        {
            Console.WriteLine("{0:D6} {1,-25} {2,-16}",this.Codigo,this.Nome, this.CPF);
        }
    }
}
