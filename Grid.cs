using System;

namespace Tic_Tac_Toc_C_Sharp_Console
{
    public class Grid
    {

        private char character;
        private char[] grid;

        // Creates the grid
        public Grid()
        {
            character = 'O';
            grid = new char[9];
            for(int i = 0; i < 9; i++)
            {
                grid[i] = 'X';
            }
        }

        public void SetCharacter(char character)
        {
            this.character = character;
        }

        // Displays the grid
        public void DisplayGrid()
        {
            Console.WriteLine("\n\n{0}|{1}|{2}\n-----\n{3}|{4}|{5}\n-----\n{6}|{7}|{8}\n\n", grid[0], grid[1], grid[2], grid[3], grid[4], grid[5], grid[6], grid[7], grid[8]);
        }

        // Inserts O or X in the grid
        public void InsertElementIntoGrid(int position)
        {
            grid[position] = this.character;
        }

        // Checking if winning condition arises
        public bool CheckWin()
        {
            return false;
        }
    }
}
