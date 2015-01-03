using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro2
{
    class PessoaJuridica:Pessoa
    {
        public string RazaoSoc;
        public DateTime DataFundacao;
        public string CNPJ;
        public string InscEstadual;

        public override void Cadastrar(string pRazaoSoc, DateTime pDataFundacao, string pCNPJ, string pInscEstadual)
        {
            this.RazaoSoc = pRazaoSoc;
            this.DataFundacao = pDataFundacao;
            this.CNPJ = pCNPJ;
            this.InscEstadual = pInscEstadual;
        }

    }
}
