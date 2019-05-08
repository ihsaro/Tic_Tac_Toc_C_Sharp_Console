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
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            do
            {
                newGame = ' ';
                Grid grid = new Grid();
                grid.DisplayGrid();

                while(true) {
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
                    grid.InsertElementIntoGrid(positionInput);
                    grid.DisplayGrid();
                    if(grid.CheckWin())
                    {
                        Console.WriteLine("Player {0} has won!\n", grid.GetWinningPlayer());    
                        break;
                    }
                    else if(grid.CheckDraw())
                    {
                        Console.WriteLine("Draw\n");
                        break;
                    }
                    if(oTurn)
                    {
                        oTurn = false;
                    }
                    else
                    {
                        oTurn = true;
                    }
                }
                
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
