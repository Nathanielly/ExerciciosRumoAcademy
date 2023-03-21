using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalLucro
{
    internal class Fluxo
    {
        public string[] Produto { get; set; }
        public int[] Quantidade { get; set; }
        public decimal[] PrecoCompra { get; set; }
        public decimal[] PrecoVenda { get; set; }

        public void ExecutarFluxo()
        {
            PerguntarInformacoesUsuario();
        }
        private void PerguntarInformacoesUsuario()
        {

            Console.WriteLine("Informe a quantidade de produtos a serem calculados: ");
            int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

            string[] produto = new string[quantidadeProdutos];
            decimal[] lucro = new decimal[quantidadeProdutos]; 

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine("Informe o produto: ");
                produto[i] = Console.ReadLine();

                Console.WriteLine("Informe a quantiade: ");
                int quantidadeVendida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o preço de compra: ");
                decimal precoCompra = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Informe o preço de venda: ");
                decimal precoVenda = Convert.ToDecimal(Console.ReadLine());

                lucro[i] = (precoVenda - precoCompra) * quantidadeVendida;

            }

            Console.WriteLine("Lucro por produto: " + Environment.NewLine);
            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine("O produto: " + produto[i] + " obteve o lucro: " + lucro[i]);

            }



        }

    }
}
