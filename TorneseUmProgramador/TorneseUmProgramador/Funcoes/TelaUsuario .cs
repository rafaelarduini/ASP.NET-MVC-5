using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneseUmProgramador.Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("================================ Cadastro de Usuarios ================================");

            while (true)
            {
                string mensagem = "Olá usuário, bem vido ao programa\n" +
                    "\n Utilizando programação funcional" +
                    "\n\n" +
                    "\n     Digite uma das opções abaixo:" +
                    "\n         0 - Sair do Cadastro" +
                    "\n         1 - Para Cadastrar Usuarios" +
                    "\n         2 - Para Listar Usuarios";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.WriteLine("Digite o Nome do Usuario:");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do Usuario:");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Usuario:");
                    usuario.CPF = Console.ReadLine();
                    usuario.Gravar();

                }
                else if (valor == 2)
                {
                    var usuarios = new Usuario().Ler();
                    foreach (Usuario c in usuarios)
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
