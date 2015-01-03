using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro
{
    class PessoaJuridica:Pessoa
    {
        public string RazaoSoc;
        public DateTime DataFundacao;
        public string CNPJ;
        public string InscEstadual;

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.Write("Digite o Razão Social: ");
            this.RazaoSoc = Console.ReadLine();
            Console.Write("Digite o CNPJ: ");
            this.CNPJ = Console.ReadLine();
            Console.Write("Digite o Inscrição Estadual: ");
            this.InscEstadual = Console.ReadLine();
            Console.Write("Digite o Data de Fundação: ");
            while (!DateTime.TryParse(Console.ReadLine(), out this.DataFundacao))
            {
                Console.Write("Inválido: ");
            }
        }
        public override void ExibirLinhaTabela()
        {
            Console.WriteLine("{0:D6} {1,-25} {2,-16}", this.Codigo, this.RazaoSoc, this.CNPJ);
        }

    }
}
