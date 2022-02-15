using System;

namespace Diamantes.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante de x");


            bool continuar = true;

            while (continuar)
            {


                int n, x, y;
                Console.Write("Insira um valor inteiro impar e maior que 1: ");
                n = int.Parse(Console.ReadLine());
                x = 1;
                y = (n - 1) / 2; //espacos
                int meio = (n - 1) / 2;

                //verifica se é impar
                if (n % 2 == 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, insira um valor impar e maior que 1");
                    Console.ResetColor();

                }

                // diamante - parte superior

                for (int i = 0; y > 0; i++) //faz isso até a quantidade de espacos for maior q 0
                {

                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(" ");//espacos
                    }

                    for (int k = 1; k <= x; k++)
                    {
                        Console.Write("x");
                    }


                    x = x + 2;
                    y = y - 1; //espaco
                    Console.WriteLine(" ");
                }

                //inferior

                for (int i = 0; y <= meio; i++)
                {

                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(" ");//espaco
                    }

                    for (int k = 1; k <= x; k++)
                    {
                        Console.Write("x");
                    }


                    x = x - 2;
                    y = y + 1; //espaco
                    Console.WriteLine(" ");
                }


                Console.WriteLine("\nDigite 1 para desenhar outro diamante ou 2 para sair");
                string strContinuar = Console.ReadLine();

                if (strContinuar != "1" && strContinuar != "2")
                {
                    Console.WriteLine("Por favor, digite uma opção válida");
                    Console.WriteLine("Digite 1 para desenhar outro diamante ou 2 para sair");
                    strContinuar = Console.ReadLine();
                }

                if (strContinuar == "1")
                {
                    Console.Clear();
                    continuar = true;
                }
                else if (strContinuar == "2")
                {
                    continuar = false;
                }

            }

        }
    }
}


