using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo_WindowsForms
{
    class PessoaFisica : Pessoa
    {
        public string Nome;
        public DateTime DataNascimento;
        public string CPF;
        public string RG;

        public override void Cadastrar(string fNome, DateTime fDataNascimento, string fCPF, string fRG)
        {
            this.Nome = fNome;
            this.DataNascimento = fDataNascimento;
            this.CPF = fCPF;
            this.RG = fRG;
        }
    }
}
