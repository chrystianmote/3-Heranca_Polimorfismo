using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro2
{
    class PessoaFisica : Pessoa
    {
        public string Nome;
        public DateTime DataNasc;
        public string CPF;
        public string RG;

        public override void Cadastrar(string pNome, DateTime pDataNascimento, string pCPF, string pRG)
        {
            this.Nome = pNome;
            this.DataNasc = pDataNascimento;
            this.CPF = pCPF;
            this.RG = pRG;
        }

    }
}
