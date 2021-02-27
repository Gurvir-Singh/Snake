using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Snake
{
    class Game
    {
        public Game() { }
        public bool gameRunning = true;
        public void PlayGame(Form1 f)
        {
            Grid playGrid = new Grid();
            playGrid.setupGrid();
            int snakePosX = 5;
            int snakePosY = 5;
            int snakeLength = 1;
            Random randGen = new Random();
            int applePosX = 1;
            int applePosY = 1;

            do
            {
                applePosX = randGen.Next(12);
                applePosY = randGen.Next(12);
            } while (playGrid.grid[applePosY][applePosX] != 'E');
            playGrid.updateGrid(applePosX, applePosY, '0');

            List<List<int>> positionsDrawnOver = new List<List<int>>();


            char direction = 'u';
            char lastFramesDirection = 'u';
            
            //long framesToPlay = 0;

            while (gameRunning)
            {
                if (f.KeyBuffer.Count > 0)
                {
                    direction = f.KeyBuffer.Dequeue();
                }
                

                    if (lastFramesDirection == 'u' && direction == 'd')
                    {
                        direction = lastFramesDirection;
                    }
                    else if (lastFramesDirection == 'd' && direction == 'u')
                    {
                        direction = lastFramesDirection;
                    }
                    else if (lastFramesDirection == 'l' && direction == 'r')
                    {
                        direction = lastFramesDirection;
                    }
                    else if (lastFramesDirection == 'r' && direction == 'l')
                    {
                        direction = lastFramesDirection;
                    }

                    if (direction == 'u')
                    {
                        snakePosY--;
                    }
                    else if (direction == 'd')
                    {
                        snakePosY++;
                    }
                    else if (direction == 'r')
                    {
                        snakePosX++;
                    }
                    else if (direction == 'l')
                    {
                        snakePosX--;
                    }
                    lastFramesDirection = direction;
                    if (playGrid.grid[snakePosY][snakePosX] == 'X' || playGrid.grid[snakePosY][snakePosX] == '#')
                    {
                        gameRunning = false;
                    }
                    else
                    {
                        if (playGrid.grid[snakePosY][snakePosX] == '0')
                        {
                            do
                            {
                                applePosX = randGen.Next(11);
                                applePosY = randGen.Next(11);
                            } while (playGrid.grid[applePosY][applePosX] != '.');
                            playGrid.updateGrid(applePosX, applePosY, '0');
                            snakeLength++;
                            foreach (List<int> arr in positionsDrawnOver)
                            {
                                arr[2]++;
                            }
                        }
                        playGrid.updateGrid(snakePosX, snakePosY, 'O');
                        List<int> posWritingOver = new List<int>{ snakePosX, snakePosY, snakeLength };
                        positionsDrawnOver.Add(posWritingOver);
                    }
                    if (positionsDrawnOver.Count() != 0 && gameRunning)
                    {
                        foreach (List<int> arr in positionsDrawnOver)
                        {
                            if (arr != positionsDrawnOver[positionsDrawnOver.Count() - 1])
                            {
                                playGrid.updateGrid(arr[0], arr[1], '#');
                            }
                            arr[2]--;
                        }
                        if (positionsDrawnOver[0][2] < 0 && playGrid.grid[positionsDrawnOver[0][1]][positionsDrawnOver[0][0]] != 'O')
                        {
                            playGrid.updateGrid(positionsDrawnOver[0][0], positionsDrawnOver[0][1], '.');
                            positionsDrawnOver.RemoveAt(0);
                        }
                    }
                
                //system("CLS");
                //if (framesToPlay % 100000) {
                //playGrid.printGrid();
                //}
                //std::this_thread::sleep_for(std::chrono::milliseconds(100));
                playGrid.updateScreen(f.panels);
                Thread.Sleep(200);
            }
            gameRunning = false;
        }
    }
}
