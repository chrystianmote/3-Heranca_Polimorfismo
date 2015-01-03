using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro
{
    abstract class Pessoa
    {
        public int Codigo;
        public string Endereco;
        public string Telefone;
        public string Email;

        public virtual void Cadastrar()
        {
            Console.Write("Digite o Código: ");
            while (!int.TryParse(Console.ReadLine(),out this.Codigo))
            {
                Console.WriteLine("Valor Inválido!: ");
            }
            Console.Write("Digite o Endereço: ");
            this.Endereco = Console.ReadLine();
            Console.Write("Digite o Telefone: ");
            this.Telefone = Console.ReadLine();
            Console.Write("Digite o E-mail: ");
            this.Telefone = Console.ReadLine();

 
        }
        public abstract void ExibirLinhaTabela();

    }
}
