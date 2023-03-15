using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasProvas
{
    //Faça um programa que calcula a média das notas de provas de uma turma.
    internal class Fluxo
    {
        public int QuantidadeNotas { get; set; }
       
        public void ExecutarMetodos()
        {
            PerguntarUsuarioQuantidadeNotas();
            var matriz = PerguntarUsuarioNotas();
            var calculo = CalculoMedia(matriz);
            ExibirResultado(calculo);

        }
        private void PerguntarUsuarioQuantidadeNotas()
        {
            Console.WriteLine("Informe a quantidade de notas: ");
            QuantidadeNotas = Convert.ToInt32(Console.ReadLine());


        }
        private int[] PerguntarUsuarioNotas()
        {
            var matrizNotas = new int[QuantidadeNotas];

            for (int i = 0; i < QuantidadeNotas; i++)
            {
                Console.WriteLine($"Informe a nota {i + 1}: ");
                int notaInformada = Convert.ToInt32(Console.ReadLine());
                matrizNotas[i] = notaInformada;


            }
            
            return matrizNotas;
        }
        private decimal CalculoMedia(int[] matrizNotas)
        {
            int somaNotas = 0;

            for (int i = 0; i < QuantidadeNotas; i++)
            {
                int notas = matrizNotas[i];
                somaNotas += notas;

            }
            decimal mediaNotas = somaNotas / (decimal)QuantidadeNotas;

            return mediaNotas;
        }
        private void ExibirResultado(decimal mediaNotas)
        {
            Console.WriteLine($"O resultado é igual a : {mediaNotas}");
        }


    }
}
