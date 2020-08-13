using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneseUmProgramador.Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("================================ Cadastro de CLientes ================================");

            while (true)
            {
                string mensagem = "Olá usuário, bem vido ao programa\n" +
                    "\n Utilizando programação funcional" +
                    "\n\n" +
                    "\n     Digite uma das opções abaixo:" +
                    "\n         0 - Sair do Cadastro" +
                    "\n         1 - Para Cadastrar Clientes" +
                    "\n         2 - Para Listar Clientes";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var cliente = new Cliente();

                    Console.WriteLine("Digite o Nome do Cliente:");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do Cliente:");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Cliente:");
                    cliente.CPF = Console.ReadLine();
                    cliente.Gravar();

                }
                else if (valor == 2)
                {
                    var clientes = new Cliente().Ler();
                    foreach (Fornecedor c in clientes)
                    {
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);
                        Console.WriteLine("============================");
                    }

                }
                else
                {
                    Console.WriteLine("Opção invalida digite novamente");
                }
            }
        }
    }
}
