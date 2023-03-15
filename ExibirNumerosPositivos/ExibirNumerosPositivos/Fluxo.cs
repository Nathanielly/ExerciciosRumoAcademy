using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExibirNumerosPositivos
{
    //Faça um algoritmo que receba 15 números e exiba somente os positivos para o usuário
    internal class Fluxo
    {
        public void Executar()
        {
            var array = PerguntarUsuarioNumeros();
            ArmazenarNumerosPositivos(array);
            

        }
        private int[] PerguntarUsuarioNumeros()
        {
            Console.WriteLine("Por favor, informe 15 números inteiros!");

            int[] tamanhoArray = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Informe o nº {i + 1}: ");
                int numeroInformado = Convert.ToInt32(Console.ReadLine());
                tamanhoArray[i] = numeroInformado;
            }

            return tamanhoArray;

        }
        private void ArmazenarNumerosPositivos(int[] tamanhoArray)
        {
            Console.WriteLine("Os números positivos desta matriz são : ");

            foreach (int numero in tamanhoArray)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }
            }

        }
        
    }
}
