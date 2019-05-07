using System;

namespace Tic_Tac_Toc_C_Sharp_Console
{
    public class TicTacToe
    {
        public static void Main(string[] args)
        {
            bool stopPlay = false;
            char newGame;
            bool oTurn = true;
            int positionInput;
            do
            {
                newGame = ' ';
                Grid grid = new Grid();
                grid.DisplayGrid();
                if(oTurn)
                {
                    grid.SetCharacter('O');
                    Console.Write("Player 1 (O): ");
                }
                else
                {
                    grid.SetCharacter('X');
                    Console.Write("Player 2 (X): ");
                }
                positionInput = Convert.ToInt32(Console.ReadLine());

                while(true)
                {
                    Console.Write("New Game (Y/N): ");
                    newGame = Console.ReadKey().KeyChar;
                    if(newGame == 'Y' || newGame == 'y' || newGame == 'N' || newGame == 'n')
                    {
                        if(newGame == 'n' || newGame == 'N')
                        {
                            stopPlay = true;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice, enter again!");
                    }
                }
            } while(stopPlay != true);
            Console.WriteLine("\nGOODBYE\n\n");
        }
    }
}
