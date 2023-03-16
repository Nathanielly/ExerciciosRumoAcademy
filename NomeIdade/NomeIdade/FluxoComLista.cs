using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeIdade
{
    internal class FluxoComLista
    {
        public void ExecutarLista()
        {
            var pessoas = new List<Pessoa>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Informe o nome da pessoa: ");
                string nomePessoa = Console.ReadLine();

                Console.WriteLine("Informe a idade da pessoa: ");
                short idadePessoa = Convert.ToInt16(Console.ReadLine());

                var pessoa = new Pessoa();
                pessoa.Nome = nomePessoa;
                pessoa.Idade = idadePessoa;

                pessoas.Add(pessoa);

            }

            var nomeMaisVelho = "";
            var idadeMaisVelho = 0;

            foreach (var pessoa in pessoas)
            {
                

                if (idadeMaisVelho < pessoa.Idade)
                {
                    idadeMaisVelho = pessoa.Idade;
                    nomeMaisVelho = pessoa.Nome;
                }

            }
            Console.WriteLine($"A pessoa mais velha da lista é {nomeMaisVelho} com {idadeMaisVelho} anos");
        }
    }
}
