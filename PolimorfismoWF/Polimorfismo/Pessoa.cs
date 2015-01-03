using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    abstract class Pessoa
    {
        public int Codigo;
        public string Endereco;
        public string Teleofne;
        public string Email;

        public abstract void ExibirLinhaTabela();

        public virtual void Cadastrar()
        {
            Console.Write("Digite o seu código: ");
            while (Int32.TryParse(Console.ReadLine(), out this.Codigo) == false)
            {
                Console.Write("Digite um código numérico: ");
            }
            Console.Write("Digite o endereço: ");
            this.Endereco = Console.ReadLine();
            Console.Write("Digite o telefone: ");
            this.Teleofne = Console.ReadLine();
            Console.Write("Digite o e-mail: ");
            this.Email = Console.ReadLine();
        }
    }
}
