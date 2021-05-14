using System;

namespace Exercicio_Cadastro_de_Produtos
{
    class Program
    {

        static string[] nome = new string[10];
        static float[] preco = new float[10];
        static bool[] promocao = new bool[10];
        static int i = 0;
        static string descontar = "";
        static string resposta;
        static string opcoes = "";
        static string recadastrar = "";
        static bool repetir = false;


        static void Main(string[] args)
        {
            do
            {
                funcao_menu();
                opcoes = Console.ReadLine();
                switch (opcoes)
                {
                    case "1":
                        do
                        {
                            funcao_cadastrar();
                            Console.WriteLine("Deseja Cadastrar um novo produto? (S - Sim / N - Não)");
                            resposta = Console.ReadLine().ToLower();
                        } while (resposta == "s");
                        funcao_voltar_menu();
                        break;
                    case "2":
                        funcao_mostrar_produtos();
                        funcao_voltar_menu();
                        break;
                    case "0":
                        Console.WriteLine("Obrigado por usar nosso sistema, até a proxima");
                        repetir = true;
                        break;
                    default:
                        Console.WriteLine("Você digitou uma opção invalida, por favor comece novamente e digite uma opção valida!!");
                        repetir = false;
                        break;
                }
            } while (repetir == false);
        }
        static void funcao_menu()
        {
            Console.WriteLine($@"
=======================================
|   Qual das opções você quer seguir? |
|======================================
|       1 - Cadastrar Produtos        | 
|       2 - Mostrar Produtos          |
|       0 - Sair                      |
=======================================          
");
        }

        static void funcao_cadastrar()
        {
            Console.Write("Qual o nome do produto: ");
            nome[i] = Console.ReadLine();
            Console.Write("Qual o Preço do Produto: R$");
            preco[i] = float.Parse(Console.ReadLine());
            Console.Write("O produto esta em promoção? (S - Sim / N - Não) ");
            descontar = Console.ReadLine().ToLower();
            if (descontar == "s")
            {
                promocao[i] = true;
            }
            else if (descontar == "n")
            {
                promocao[i] = false;
            }
            i++;

        }

        static void funcao_voltar_menu()
        {
            Console.WriteLine($@"
===========================================
|     Gostaria de voltar ao menu?         |
|=========================================|    
|    S - Sim                              |
|    N - Não                              |
===========================================
");
            recadastrar = Console.ReadLine().ToLower();
            if (recadastrar == "s")
            {
                repetir = false;
            }
            else
            {
                Console.WriteLine("Obrigado por usar nosso sistema, até a proxima");
                repetir = true;
            }
        }

        static void funcao_mostrar_produtos()
        {
            Console.WriteLine("Esses são os produtos que temos no sistema: \n");
            for (var j = 0; j < i; j++)
            {
                Console.WriteLine($"Produto: {nome[j]}");
                Console.WriteLine($"Preço: R${preco[j]}");
                if (promocao[j] == true)
                {
                    Console.WriteLine($"Este produto tem promoção \n");
                }
                else if (promocao[j] == false)
                {
                    Console.WriteLine($"Este produto não tem promoção\n");
                }
            }

            if (i == 0)
            {
                Console.WriteLine("Ainda não temos produtos no sistema");
            }
        }
    }
}
