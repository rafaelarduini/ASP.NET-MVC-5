using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneseUmProgramador.Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("================================ Cadastro de Fornecedor ================================");

            while (true)
            {
                string mensagem = "Olá usuário, bem vido ao programa\n" +
                    "\n Utilizando programação funcional" +
                    "\n\n" +
                    "\n     Digite uma das opções abaixo:" +
                    "\n         0 - Sair do Cadastro" +
                    "\n         1 - Para Cadastrar Fornecedores" +
                    "\n         2 - Para Listar Fornecedores";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedores = new Fornecedor();

                    Console.WriteLine("Digite o CNPJ:");
                    fornecedores.CNPJ = Console.ReadLine();

                    Console.WriteLine("Digite o Nome do Fornecedor:");
                    fornecedores.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do Fornecedor:");
                    fornecedores.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do gerente:");
                    fornecedores.CPF = Console.ReadLine();
                    fornecedores.Gravar();

                }
                else if (valor == 2)
                {
                    var fornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor c in fornecedores)
                    {
                        Console.WriteLine("CNPJ: " + c.CNPJ);
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
