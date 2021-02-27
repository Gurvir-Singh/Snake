using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Grid
    {
        public List<List<char>> grid = new List<List<char>>();
        public void setupGrid()
        {
            char charachterForGrid = 'E';
            List<char> gridBoundry = new List<char>();
            for (int i = 0; i < 12; i++)
            {
                gridBoundry.Add('X');
            }
            grid.Add(gridBoundry);
            
            for (int i = 0; i < 10; i++)
            {
                List<char> gridLine = new List<char> { 'X', charachterForGrid, charachterForGrid, charachterForGrid, charachterForGrid, charachterForGrid, charachterForGrid, charachterForGrid, charachterForGrid, charachterForGrid, charachterForGrid, 'X' };
                grid.Add(gridLine);
            }
            grid.Add(gridBoundry);
        }
        public void updateGrid(int x, int y, char newChar)
        {
            grid[y][x] = newChar;
        }
        public void updateScreen(List<List<System.Windows.Forms.Panel>> screen)
        {
            for (int i = 1; i < grid.Count()-1; i++)
            {

                for (int j = 1; j < grid[i].Count()-1; j++)
                {
                    if (grid[i][j] == '0')
                    {
                        screen[i-1][j-1].BackColor = System.Drawing.Color.Red;
                    }
                    else if (grid[i][j] == 'O')
                    {
                        screen[i-1][j-1].BackColor = System.Drawing.Color.Green;
                    }
                    else if (grid[i][j] == '#')
                    {
                        screen[i - 1][j - 1].BackColor = System.Drawing.Color.LimeGreen;
                    }
                    else
                    {
                        screen[i-1][j-1].BackColor = System.Drawing.Color.Black;
                    }
                }
            }
        }
    }
}
