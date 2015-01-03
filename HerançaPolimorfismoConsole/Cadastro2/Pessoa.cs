using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro2
{
    abstract class Pessoa
    {
        public int Codigo;
        public string Endereco;
        public string Telefone;
        public string Email;

        public virtual void Cadastrar(int pCodigo, string pEndereco, string pTelefone, string pEmail)
        {
            this.Codigo = pCodigo;
            this.Endereco = pEndereco;
            this.Telefone = pTelefone;
            this.Email = pEmail;
        }
    }
}
