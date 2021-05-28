using System;

namespace retangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = "";
            do
            {
                Console.Clear();

                Console.WriteLine("-- Retângulos --");
                Console.WriteLine("1 - Preenchido | 2 - Contorno | 0 - Sair\n");

                Console.Write("Escolha sua opção...: ");
                opcaoUsuario = Console.ReadLine();

                if (opcaoUsuario == "1")
                {
                    ExibeRetanguloPreenchido();
                }

                if (opcaoUsuario == "2")
                {
                    ExibeRetanguloContorno();
                }
            }
            while (opcaoUsuario != "0");
            Console.WriteLine("\n\nObrigado por utilizar nosso programa.");
        }

        static void ExibeRetanguloPreenchido()
        {
            Console.WriteLine("\n-- Retângulo Preenchido --\n");

            int linhas = 0;
            int colunas = 0;

            Console.Write("Quantidade de linhas.....: ");
            linhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade de colunas....: ");
            colunas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int linhaAtual = 0;
            while (linhaAtual < linhas)
            {
                linhaAtual += 1;

                int colunaAtual = 0;
                while (colunaAtual < colunas)
                {
                    colunaAtual += 1;
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("\nPressione uma tecla para continuar...");
            Console.ReadKey();
        }

        static void ExibeRetanguloContorno()
        {
            Console.WriteLine("\n-- Retângulo Contorno --\n");

            int qtdLinhas = 0;
            int qtdColunas = 0;

            Console.Write("Quantidade de linhas.....: ");
            qtdLinhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade de colunas....: ");
            qtdColunas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int linhaAtual = 0;
            while (linhaAtual < qtdLinhas)
            {
                linhaAtual += 1;

                int colunaAtual = 0;
                while (colunaAtual < qtdColunas)
                {
                    colunaAtual += 1;

                    if (linhaAtual == 1 || linhaAtual == qtdLinhas)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (colunaAtual == 1 || colunaAtual == qtdColunas)
                        {
                            Console.Write("*");

                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }

                Console.WriteLine();
            }

            Console.Write("\nPressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
