using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo_WindowsForms
{
    class PessoaJuridica : Pessoa
    {
        public string RazaoSocial;
        public DateTime DataFundacao;
        public string CNPJ;
        public string InscEst;

        public override void Cadastrar(string jRazaoSocial, DateTime jDataFundacao, string jCnpj, string jInscEst)
        {
            this.RazaoSocial = jRazaoSocial;
            this.DataFundacao = jDataFundacao;
            this.CNPJ = jCnpj;
            this.InscEst = jInscEst;
        }
    }
}
