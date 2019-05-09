using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumulacja
{
    class Grid
    {
        public Cell[,] Map;
        int Map_height, Map_width;

        public Grid()
        {

        }

        public Grid(int Map_width, int Map_height)
        {
            this.Map_width = Map_width;
            this.Map_height = Map_height;

            this.Map = new Cell[Map_height, Map_width];

            for(int i=0; i< Map_height; i++)
            {
                for(int j=0; j< Map_width; j++)
                {
                    
                    this.Map[i, j] = new Cell();
                }
            }
        }

        public Cell[,] getMap()
        {
            return Map;
        }

        public void changeMapState(int i, int j, bool state)
        {
            this.Map[i, j].setCellState(state);
        }

        public void UpdateVector()
        {
            bool[] neighbourhood = new bool[8];
            int counter = 0;
            bool[,] previousIteration = new bool[Map_height, Map_width];
            for (int i = 0; i < Map_height; i++)
            {
                for (int j = 0; j < Map_width; j++)
                {
                    previousIteration[i, j] = this.Map[i, j].getCellState();
                }
            }


            for (int i = 0; i < Map_height; i++)
            {
                for (int j = 0; j < Map_width; j++)
                {
                    
                    //winkle
                    if (j == 0 && i == 0)
                    {
                        neighbourhood[0] = previousIteration[Map_height - 1, Map_width - 1];
                        neighbourhood[1] = previousIteration[Map_height - 1, 0];
                        neighbourhood[2] = previousIteration[Map_height - 1, 1];

                        neighbourhood[3] = previousIteration[0, Map_width - 1];
                        neighbourhood[4] = previousIteration[0, 1];

                        neighbourhood[5] = previousIteration[1, Map_width - 1];
                        neighbourhood[6] = previousIteration[1, 0];
                        neighbourhood[7] = previousIteration[1, 1];
                    }
                    else if (j == Map_width - 1 && i == 0)
                    {
                        neighbourhood[0] = previousIteration[Map_height - 1, Map_width - 2];
                        neighbourhood[1] = previousIteration[Map_height - 1, Map_width - 1];
                        neighbourhood[2] = previousIteration[Map_height - 1, 0];

                        neighbourhood[3] = previousIteration[0, Map_width - 2];
                        neighbourhood[4] = previousIteration[0, 0];

                        neighbourhood[5] = previousIteration[1, Map_width - 2];
                        neighbourhood[6] = previousIteration[1, Map_width - 1];
                        neighbourhood[7] = previousIteration[1, 0];
                    }
                    else if (j == 0 && i == Map_height - 1)
                    {
                        neighbourhood[0] = previousIteration[Map_height - 2, Map_width - 1];
                        neighbourhood[1] = previousIteration[Map_height - 2, 0];
                        neighbourhood[2] = previousIteration[Map_height - 2, 1];

                        neighbourhood[3] = previousIteration[Map_height - 1, Map_width - 1];
                        neighbourhood[4] = previousIteration[Map_height - 1, 1];

                        neighbourhood[5] = previousIteration[0, Map_width - 1];
                        neighbourhood[6] = previousIteration[0, 0];
                        neighbourhood[7] = previousIteration[0, 1];
                    }
                    else if (j == Map_width - 1 && i == Map_height - 1)
                    {
                        neighbourhood[0] = previousIteration[Map_height - 2, Map_width - 2];
                        neighbourhood[1] = previousIteration[Map_height - 2, Map_width - 1];
                        neighbourhood[2] = previousIteration[Map_height - 2, 0];

                        neighbourhood[3] = previousIteration[Map_height - 1, Map_width - 2];
                        neighbourhood[4] = previousIteration[Map_height - 1, 0];

                        neighbourhood[5] = previousIteration[0, Map_width - 2];
                        neighbourhood[6] = previousIteration[0, Map_width - 1];
                        neighbourhood[7] = previousIteration[0, 0];
                    }
                    //krawedzie lewa
                    else if (j == 0 && i != 0 && i != (Map_height - 1))
                    {
                        neighbourhood[0] = previousIteration[i - 1, Map_width - 1];
                        neighbourhood[1] = previousIteration[i - 1, j];
                        neighbourhood[2] = previousIteration[i - 1, j + 1]; 

                        neighbourhood[3] = previousIteration[i, Map_width - 1];
                        neighbourhood[4] = previousIteration[i, j + 1]; 

                        neighbourhood[5] = previousIteration[i + 1, Map_width - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, j + 1];
                    }
                    // góna krawędź
                    else if (j != 0 && i == 0 && j != (Map_width - 1))
                    {
                        neighbourhood[0] = previousIteration[Map_height - 1 , j - 1];
                        neighbourhood[1] = previousIteration[Map_height - 1 , j];
                        neighbourhood[2] = previousIteration[Map_height - 1 , j + 1];

                        neighbourhood[3] = previousIteration[i, j - 1];
                        neighbourhood[4] = previousIteration[i, j + 1];

                        neighbourhood[5] = previousIteration[i + 1, j - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, j + 1];
                    }
                    // prawa krawędź
                    else if (j == Map_width - 1 && i != 0 && i != (Map_height - 1))
                    {
                        neighbourhood[0] = previousIteration[i - 1, j - 1];
                        neighbourhood[1] = previousIteration[i - 1, j];
                        neighbourhood[2] = previousIteration[i - 1, 0];

                        neighbourhood[3] = previousIteration[i, j - 1];
                        neighbourhood[4] = previousIteration[i, 0];

                        neighbourhood[5] = previousIteration[i + 1, j - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, 0];
                    }
                    // dolna krawędź
                    else if (j != 0 && i == (Map_height - 1) && j != (Map_width - 1))
                    {
                        neighbourhood[0] = previousIteration[i - 1, j - 1];
                        neighbourhood[1] = previousIteration[i - 1, j];
                        neighbourhood[2] = previousIteration[i - 1, j + 1];

                        neighbourhood[3] = previousIteration[i, j - 1];
                        neighbourhood[4] = previousIteration[i, j + 1];

                        neighbourhood[5] = previousIteration[0 , j - 1];
                        neighbourhood[6] = previousIteration[0 , j];
                        neighbourhood[7] = previousIteration[0 , j + 1];
                    }

                    //reszta
                    else
                    {
                        neighbourhood[0] = previousIteration[i - 1, j - 1];
                        neighbourhood[1] = previousIteration[i - 1, j];
                        neighbourhood[2] = previousIteration[i - 1, j + 1];

                        neighbourhood[3] = previousIteration[i, j - 1];
                        neighbourhood[4] = previousIteration[i, j + 1];

                        neighbourhood[5] = previousIteration[i + 1, j - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, j + 1];
                    }
                    
                    //////////////////////////////////////////////////////

                    
                    for (int k = 0; k < 8; k++)
                    {
                        if (neighbourhood[k] == true)
                            counter++;
                    }

                    if (!Map[i, j].getCellState())
                    {
                        if (counter == 3)
                        { 
                            Map[i, j].setCellState(true);
                        }
                    }
                    else
                    {
                        if (counter == 2 || counter == 3)
                        {
                            counter = 0;
                            /* do nothing */
                        }
                        else if (counter > 3)
                        {
                            Map[i, j].setCellState(false);
                        }

                        else if (counter < 2)
                        {
                            Map[i, j].setCellState(false);
                        }
                       
                    }
                    counter = 0;
                }
            }
        }

        public void UpdateVectorGunGame()
        {
            bool[] neighbourhood = new bool[8];
            int counter = 0;
            bool[,] previousIteration = new bool[Map_height, Map_width];
            for (int i = 0; i < Map_height; i++)
            {
                for (int j = 0; j < Map_width; j++)
                {
                    previousIteration[i, j] = this.Map[i, j].getCellState();
                }
            }


            for (int i = 0; i < Map_height; i++)
            {
                for (int j = 0; j < Map_width; j++)
                {

                    //winkle
                    if (j == 0 && i == 0)
                    {
                        neighbourhood[0] = false;
                        neighbourhood[1] = false;
                        neighbourhood[2] = false;
                                           
                        neighbourhood[3] = false;
                        neighbourhood[4] = false;
                                           
                        neighbourhood[5] = false;
                        neighbourhood[6] = false;
                        neighbourhood[7] = false;
                    }
                    else if (j == Map_width - 1 && i == 0)
                    {
                        neighbourhood[0] = false;
                        neighbourhood[1] = false;
                        neighbourhood[2] = false;

                        neighbourhood[3] = false;
                        neighbourhood[4] = false;

                        neighbourhood[5] = false;
                        neighbourhood[6] = false;
                        neighbourhood[7] = false;
                    }
                    else if (j == 0 && i == Map_height - 1)
                    {
                        neighbourhood[0] = false;
                        neighbourhood[1] = false;
                        neighbourhood[2] = false;

                        neighbourhood[3] = false;
                        neighbourhood[4] = false;

                        neighbourhood[5] = false;
                        neighbourhood[6] = false;
                        neighbourhood[7] = false;
                    }
                    else if (j == Map_width - 1 && i == Map_height - 1)
                    {
                        neighbourhood[0] = false;
                        neighbourhood[1] = false;
                        neighbourhood[2] = false;

                        neighbourhood[3] = false;
                        neighbourhood[4] = false;

                        neighbourhood[5] = false;
                        neighbourhood[6] = false;
                        neighbourhood[7] = false;
                    }
                    //krawedzie lewa
                    else if (j == 0 && i != 0 && i != (Map_height - 1))
                    {
                        neighbourhood[0] = previousIteration[i - 1, Map_width - 1];
                        neighbourhood[1] = previousIteration[i - 1, j];
                        neighbourhood[2] = previousIteration[i - 1, j + 1];

                        neighbourhood[3] = previousIteration[i, Map_width - 1];
                        neighbourhood[4] = previousIteration[i, j + 1];

                        neighbourhood[5] = previousIteration[i + 1, Map_width - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, j + 1];
                    }
                    // góna krawędź
                    else if (j != 0 && i == 0 && j != (Map_width - 1))
                    {
                        neighbourhood[0] = previousIteration[Map_height - 1, j - 1];
                        neighbourhood[1] = previousIteration[Map_height - 1, j];
                        neighbourhood[2] = previousIteration[Map_height - 1, j + 1];

                        neighbourhood[3] = previousIteration[i, j - 1];
                        neighbourhood[4] = previousIteration[i, j + 1];

                        neighbourhood[5] = previousIteration[i + 1, j - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, j + 1];
                    }
                    // prawa krawędź
                    else if (j == Map_width - 1 && i != 0 && i != (Map_height - 1))
                    {
                        neighbourhood[0] = previousIteration[i - 1, j - 1];
                        neighbourhood[1] = previousIteration[i - 1, j];
                        neighbourhood[2] = previousIteration[i - 1, 0];

                        neighbourhood[3] = previousIteration[i, j - 1];
                        neighbourhood[4] = previousIteration[i, 0];

                        neighbourhood[5] = previousIteration[i + 1, j - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, 0];
                    }
                    // dolna krawędź
                    else if (j != 0 && i == (Map_height - 1) && j != (Map_width - 1))
                    {
                        neighbourhood[0] = false;
                        neighbourhood[1] = false;
                        neighbourhood[2] = false;

                        neighbourhood[3] = false;
                        neighbourhood[4] = false;

                        neighbourhood[5] = false;
                        neighbourhood[6] = false;
                        neighbourhood[7] = false;
                    }

                    //reszta
                    else
                    {
                        neighbourhood[0] = previousIteration[i - 1, j - 1];
                        neighbourhood[1] = previousIteration[i - 1, j];
                        neighbourhood[2] = previousIteration[i - 1, j + 1];

                        neighbourhood[3] = previousIteration[i, j - 1];
                        neighbourhood[4] = previousIteration[i, j + 1];

                        neighbourhood[5] = previousIteration[i + 1, j - 1];
                        neighbourhood[6] = previousIteration[i + 1, j];
                        neighbourhood[7] = previousIteration[i + 1, j + 1];
                    }

                    //////////////////////////////////////////////////////


                    for (int k = 0; k < 8; k++)
                    {
                        if (neighbourhood[k] == true)
                            counter++;
                    }

                    if (!Map[i, j].getCellState())
                    {
                        if (counter == 3)
                        {
                            Map[i, j].setCellState(true);
                        }
                    }
                    else
                    {
                        if (counter == 2 || counter == 3)
                        {
                            counter = 0;
                            /* do nothing */
                        }
                        else if (counter > 3)
                        {
                            Map[i, j].setCellState(false);
                        }

                        else if (counter < 2)
                        {
                            Map[i, j].setCellState(false);
                        }

                    }
                    counter = 0;
                }
            }
        }
    }
}
