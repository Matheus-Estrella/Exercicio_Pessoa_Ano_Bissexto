using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pessoa_Ano_Bissexto
{
    internal class Pessoa
    {
        string nome;
        string profissao;
        DateTime nascimento;
        public Pessoa()
        {
            Console.Write("\nInsira o nome: ");
            this.nome = Console.ReadLine();
            Console.Write("\nInsira a profissão: ");
            this.profissao = Console.ReadLine();
            Console.Write("\nInsira a data de nascimento: ");
            this.nascimento = DateTime.Parse(Console.ReadLine());
        }
        public DateTime Get_Nascimento()
        {
            return nascimento;
        }
        public string Get_Nome()
        {
            return nome;
        }
    }
}
