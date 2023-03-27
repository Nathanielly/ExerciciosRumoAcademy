using LerGravarArquivoTexto.Entidade;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerGravarArquivoTexto
{
    public class Fluxo
    {
        private readonly string caminhoArquivo = "C:\\Projetos\\Exemplo.csv";
        public void Executar()
        {
            var parametro = CadastrarClientesLista();
            GravarArquivo(parametro);
            BuscarClientePorCpf(parametro);

        }
        public static List<Cliente> CadastrarClientesLista()
        {
            var clientes = new List<Cliente>();

            for (   int i = 0; i < 0; i++)
            {
                Console.WriteLine("Nome do cliente: ");
                string nomeCliente = Console.ReadLine();

                Console.WriteLine("CPF do cliente: ");
                long cpfCliente = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Data de nascimento do cliente: ");
                DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

                var cliente = new Cliente();
                cliente.Nome = nomeCliente;
                cliente.Cpf = cpfCliente;
                cliente.DataNascimento = dataNascimento;

                clientes.Add(cliente);

            }

            return clientes;
        }

        public void GravarArquivo(List<Cliente> clientes)
        {
            using (StreamWriter escreverArquivo = File.AppendText(caminhoArquivo)) 
            {
                foreach (var cliente in clientes)
                {
                    escreverArquivo.WriteLine($"{cliente.Cpf};{cliente.Nome};{cliente.DataNascimento}");

                }

            }


        }

        public string? BuscarClientePorCpf(List<Cliente> clientes)
        {
           var lerArquivo = new StreamReader(caminhoArquivo);

            Console.WriteLine("Informe o CPF: ");
            long cpf = Convert.ToInt64(Console.ReadLine());  

            while(true)
            {
                var linha = lerArquivo.ReadLine();
                    
                if (linha == null)
                {
                    Console.WriteLine("CPF não encontrado.");
                    break;
                }
                    

                string[] colunas = linha.Split(";");

                var cliente = new Entidade.Cliente();
                cliente.Cpf = Convert.ToInt64(colunas[0]);
                cliente.Nome = colunas[1];
                cliente.DataNascimento = Convert.ToDateTime(colunas[2]);

                if (cliente.Cpf == cpf)
                {
                    Console.WriteLine("CPF encontrado! \nCliente: " + cliente.Nome);
                    break;
                }

            }
            return null;

            
        }

    }
}
