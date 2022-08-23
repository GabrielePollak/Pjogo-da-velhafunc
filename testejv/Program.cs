using System;
using System.Collections.Generic;

namespace Pjogodavelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3];
            string turnos = "X";
            
            List<string> indexNumeros = new List<string>{};
            int index = 1; 

            int tentativas = 0;

            Console.WriteLine("-----------------------");
            Console.WriteLine("     Jogo da Velha     ");
            Console.WriteLine("_______________________");



            //alimentando a matriz

            for (int i = 0; i < 3; i++) //linha
            {
                for (int j = 0; j < 3; j++) //coluna
                {
                    matriz[i, j] = index.ToString();
                    indexNumeros.Add(index.ToString()); //exclui já usado/lista dos válidos
                    index++;
                }

            }

            //imprimindo a matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" [{matriz[i, j]}] ");
                }
                Console.WriteLine();

            }
            Console.Write($"Onde você quer marcar {turnos} ?");
            


            string jogada = Console.ReadLine();

            // Inicio do jogo



            while (tentativas < 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matriz[i, j] == jogada && indexNumeros.Contains(jogada))
                        {
                            matriz[i, j] = turnos;
                            indexNumeros.Remove(jogada);
                        }
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($" [{matriz[i, j]}] ");
                    }
                    Console.WriteLine();
                }

                jogada = Console.ReadLine();

               //verificando vitoria

                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                    matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    Console.WriteLine($"O ganhador é: {turnos}");
                    break;
                }

                if (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0] ||
                    matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1] ||
                    matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2])
                {
                    Console.WriteLine($"O ganhador é: {turnos}");
                    break;
                }

                if (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] ||
                    matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] ||
                    matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2])
                {
                    Console.WriteLine($"O ganhador é: {turnos}");
                    break;
                }
                else
                {
                    if (turnos == "X")
                    {
                        turnos = "O";
                    }
                    else
                    {
                        turnos = "X";
                    }

                }


               


                tentativas++;





                Console.Clear();

            }
             



        }
    }
}
