using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    class Program
    {
        static int UserSelection()
        {
            int num = 0;
            string response = Console.ReadLine();
            if (int.TryParse(response, out num) && num > 0 && num < 9)
            {
                return num;
            }
            else
            {
                num = 10;
                return num;
            }
        }
        static void ShowGrid(int num1, int num2)
        {
            string[,] grid = new string[9, 9];
            for (int i = 0; i < 9; i++)  //Populates and then shows user the grid of "0"s
            {
                Console.Write("\n\t\t");
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = "0 ";
                    grid[0, 0] = "  ";                 //Populates the first space in grid with nothing to allow for 
                    for (int num = 8; num > 0; num--)  //clean looking numbering of columns and rows
                    {
                        string label;
                        label = Convert.ToString(num);
                        grid[0, num] = label + " ";
                    }
                    for (int num = 8; num > 0; num--)
                    {
                        string label;
                        label = Convert.ToString(num);
                        grid[num, 0] = label + " ";
                        grid[num1, num2] = "M ";
                    }
                    Console.Write(grid[i, j]);
                }
            }
        }
        static bool PlayAgain()
        {
            bool keepLooping = true;
            string response = "";

            while (keepLooping == true)
            {
                Console.WriteLine("Would you like to keep playing?");
                response = Console.ReadLine();
                response = response.ToLower();
                if (response == "y" || response == "yes")
                {
                    keepLooping = false;
                    return true;
                }
                else if(response=="n" || response == "no")
                {
                    keepLooping = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("Your input was not readable.\nPlease try answering with a yes or no.\n");
                }
            }
            return true;
        }
        static string PrintGrid()
        {
            string water = "";
            for (int i = 0; i < 9; i++)  //Populates and then shows user the grid of "0"s
            {
                string[,] grid = new string[9, 9];
                water = water + "\n\t\t";
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = "0 ";
                    grid[0, 0] = "  ";                 //Populates the first space in grid with nothing to allow for 
                    for (int num = 8; num > 0; num--)  //clean looking numbering of columns and rows
                    {
                        string label;
                        label = Convert.ToString(num);
                        grid[0, num] = label + " ";
                    }
                    for (int num = 8; num > 0; num--)
                    {
                        string label;
                        label = Convert.ToString(num);
                        grid[num, 0] = label + " ";
                    }
                    water = water + grid[i, j];
                }
            }
            return water;
        }

        static void Main(string[] args)
        {
            //Create a grid(an array with two dimensions) that is 8 by 8.

            //This grid will hold whether there is a ship in a given square or not.You can use a bool or an int for this.You will need to be able to display this grid, with
            //00000000
            //0000*000
            //00**0000
            //00000000
            //000**000
            //*0*00000
            //00000**0
            //00****00


            //Let the user try to "shoot" a ship by selecting two coordinates (the column and the row)

            //When users shoot an enemy, clear the ship in that cell

            //When all enemies are gone, make the "game" end.

            // Bonus:

            // If user picks a cell next to a ship, say "close!"

            string[,] grid = new string[9, 9];
            bool keepLooping = true;
            int row = 0;
            int column = 0;
            

            Console.WriteLine("\n\t   --Welcome to Battleship!!--\n\n\tHere are your available coordinates");
            Console.WriteLine(PrintGrid());

            while (keepLooping == true)
            {
                Console.WriteLine("\n\n  Please select a row: (1-8)");
                row = UserSelection();
                if (row < 10)
                {
                    Console.WriteLine("Please select a column: (1-8)");
                    column = UserSelection();
                    if (column < 10)
                    {
                        if (grid[row, column] == "0 ")
                        {
                            ShowGrid(row, column);
                            Console.WriteLine("\n\tYou Missed!");
                        }
                    }
                }
                keepLooping=PlayAgain();

            }
            Console.ReadLine();
        }
    }
}
