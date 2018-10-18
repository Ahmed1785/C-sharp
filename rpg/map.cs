using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace wizard
{
    public class Map
{
    public int gridSize = 10;
    public int gridWidth = 10;
    public int gridHeight = 10;
    public int Battleship = 5;
    public int Destroyer = 2; 
    public int cruiser = 3;
    public int aircraft = 4;
    public int row;
    public int col;
    public int[,] grid = new int[10, 10];

    for(int i = 1; i <= 255; i++){
                if(i%2 == 1){
                    Console.WriteLine(i);
                }
            }


}
}