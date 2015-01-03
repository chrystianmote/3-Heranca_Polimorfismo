using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    class PessoaJuridica : Pessoa
    {
        public string RazaoSocial;
        public DateTime DataFundacao;
        public string CNPJ;
        public string InscEst;

        public override void Cadastrar()
        {
            base.Cadastrar();
            Console.Write("Digite a razão social: ");
            this.RazaoSocial = Console.ReadLine();
            while (DateTime.TryParse(Console.ReadLine(), out this.DataFundacao) == false)
            {
                Console.Write("Digite a data de fundação no formato dd/mm/aaaa: ");
            }
            Console.Write("Digite o CNPJ: ");
            this.CNPJ = Console.ReadLine();
            Console.Write("Digite a inscrição estadual: ");
            this.InscEst = Console.ReadLine();
        }

        public override void ExibirLinhaTabela()
        {
            Console.WriteLine("{0:D6} {1, -25} {2, -16}", this.Codigo, this.RazaoSocial, this.CNPJ);
        }
    }
}
