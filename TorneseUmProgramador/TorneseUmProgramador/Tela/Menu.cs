using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorneseUmProgramador.Funcoes;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDORES = 6;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vido ao programa\n" +
                    "\n Aplicação Console Final" +
                    "\n\n" +
                    "\n     Digite uma das opções abaixo:" +
                    "\n         0 - Sair do programa" +
                    "\n         1 - Para Ler arquivos" +
                    "\n         2 - Para executar a tabuada" +
                    "\n         3 - Calcular média de alunos" +
                    "\n         4 - Cadastrar Clientes" +
                    "\n         5 - Cadastrar Usuarios" +
                    "\n         6 - Cadastrar Fornecedores";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("========================= Opção Ler Arquivos ======================");
                    Arquivo.Ler(1);
                    Console.WriteLine("\n==================================================================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("========================= Opção Tabuada ======================");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("\n==================================================================\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n==================================================================\n");
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("==================================================================");
                }
                else if (valor == CADASTRAR_USUARIOS)
                {
                    TelaUsuario.Chamar();
                    Console.WriteLine("==================================================================");
                }
                else if (valor == CADASTRAR_FORNECEDORES)
                {
                    TelaFornecedor.Chamar();
                    Console.WriteLine("==================================================================");
                }
                else
                {
                    Console.WriteLine("Opção invalida digite novamente");
                }
            }
        }

    }
}
