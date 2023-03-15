using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeIdade
{
    //Faça um programa armazena o nome e idade (inteiro) de 10 pessoas, e mostra o mais velho para o usuário.
    internal class Fluxo
    {
        public string[]? Nome { get; set; }
        public int[]? Idade { get; set; }

        public void Executar()
        {
            PerguntarUsuario();
            MostrarMaisVelho();

        }
        public void PerguntarUsuario()
        {
            Nome = new string[5];
            Idade = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Informe o nome {i + 1}:");
                string nome = Console.ReadLine();
                Nome[i] = nome;

                Console.WriteLine($"Informe a idade {i + 1}:");
                int idade = Convert.ToInt32(Console.ReadLine());
                Idade[i] = idade;


            }

        }

        public void MostrarMaisVelho()
        {
            int maiorIdade = Idade[0];
            for (int i = 0; i < Idade.Length; i++)
            {
                if (Idade[i] > maiorIdade)
                {
                    maiorIdade = Idade[i];
                }
            }

            Console.WriteLine($"A idade do mais velho é: {maiorIdade}");
        }
    }
}
