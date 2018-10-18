using System;

namespace wizard
{
    public class Ship
{

    //The { get; set; } format creates accessor methods for the field specified
    //This is done to allow flexibility
    public int row { get; set; }
    public string col { get; set; }
    public string dir { get; set; }
    public char mapChar { get; set; }
    public int bb = 5;
    public int dd = 2;
    public int ca = 3;
    public int ap = 4;
    public char[,] _playerShips = new char[10,10];
    public char[,] _opponentShips = new char[10,10];
    public char[,] _opponentSearch = new char[10,10];
    public char[,] _playerSearch = new char[10,10];

    // public void Ships(string col, int rows, string direction, string map)
    // {
    //     mapChar = map;
    //     row = rows;
    //     dir = direction;
    //     mapChar = map;
    // }
    public void Addship(int row, string column, string direction, string type)
    {

        row = Convert.ToInt32(Console.ReadLine());
        column = Console.ReadLine();
        direction = Console.ReadLine();
        type = Console.ReadLine();
        int col = Int32.Parse(column);
        // int dir = Int32.Parse(direction);
        _playerShips[row,col] = mapChar;

            if(type == "AA" || type == "aa"){
            for(int i = 0; i < 5; i++){
                if(dir == "h"){
                    _playerShips[row,i] = mapChar;
                }
                else{
                    _playerShips[i,col] = mapChar;
                }
            }
        }

            if(type == "BB" || type == "bb"){
            for(int i = 1; i < 5; i++){
                if(dir == "h"){
                    _playerShips[row,i] = mapChar;
                }
                else{
                    _playerShips[i,col] = mapChar;
                }
            }
        }

            if(type == "SS" || type == "ss"){
            for(int i = 1; i < 5; i++){
                if(dir == "h"){
                    _playerShips[row,i] = mapChar;
                }
                else{
                    _playerShips[i,col] = mapChar;
                }
            }
        }
            if(type == "CA" || type == "ca"){
            for(int i = 1; i < 5; i++){
                if(dir == "h"){
                    _playerShips[row,i] = mapChar;
                }
                else{
                    _playerShips[i,col] = mapChar;
                }
            }
        }
            if(type == "DD" || type == "dd"){
            for(int i = 1; i < 5; i++){
                if(dir == "h"){
                    _playerShips[row,i] = mapChar;
                }
                else{
                    _playerShips[i,col] = mapChar;
                }
                
            }
        } 
        }
        public void AddOpponentship(int row, int column, string direction, string type){
            Random rand = new Random();
            row = rand.Next(1,11);
            column = rand.Next(1,11);
            direction = Console.ReadLine();
            type = Console.ReadLine();
            // int col = Int32.Parse(column);
            // int dir = Int32.Parse(direction);
            // _opponentShips[row,column] = mapChar;
            
            string[] ships = new string[5] {"CV", "BB", "SS", "CA", "DD"};
            for(int i = 0; i < 5; i++)
            {
                if(type == "CV")
                {
                row = rand.Next(1,11);
                column = rand.Next(1,11);
                dir = rand.Next(1) == 0 ? "h" : "v";
                if(dir == "h")
                {
                    for(int j = 0; j < 5; i++)
                    {
                    _opponentShips[row,i] = mapChar;
                    }
                }
                }
                else
                {
                    _opponentShips[i,column] = mapChar;
                }
                

                

                if(type == "BB")
                {
                row = rand.Next(1,11);
                column = rand.Next(1,11);
                dir = rand.Next(1) == 0 ? "h" : "v";
                if(dir == "h")
                {
                    for(int j = 0; j < 5; i++)
                    {
                    _opponentShips[row,i] = mapChar;
                    }
                }
                else
                {
                    _opponentShips[i,column] = mapChar;
                }
                }



               if(type == "SS")
                {
                row = rand.Next(1,11);
                column = rand.Next(1,11);
                dir = rand.Next(1) == 0 ? "h" : "v";
                    if(dir == "h")
                    {
                        for(int j = 0; j < 5; i++)
                        {
                        _opponentShips[row,i] = mapChar;
                        }
                    }
                    else
                    {
                        _opponentShips[i,column] = mapChar;
                    }
                }
                


                if(type == "CA")
                {
                row = rand.Next(1,11);
                column = rand.Next(1,11);
                dir = rand.Next(1) == 0 ? "h" : "v";
                    if(dir == "h")
                    {
                        for(int j = 0; j < 5; i++)
                        {
                        _opponentShips[row,i] = mapChar;
                        }
                    }
                    else
                    {
                        _opponentShips[i,column] = mapChar;
                    }
                }




                if(type == "DD")
                {
                row = rand.Next(1,11);
                column = rand.Next(1,11);
                dir = rand.Next(1) == 0 ? "h" : "v";
                    if(dir == "h")
                    {
                        for(int j = 0; j < 5; i++)
                        {
                        _opponentShips[row,i] = mapChar;
                        }
                    }
                    else
                    {
                        _opponentShips[i,column] = mapChar;
                    }
                }
            }
        }
        public void attack(int row, int column){
            for(int i = 0; i < 11; i++)
            {
                row = Convert.ToInt32(Console.ReadLine());
                column = Convert.ToInt32(Console.ReadLine());
                _playerSearch[row,col] = mapChar;
                if(_playerSearch[row,col] == _OpponentShips[row, column]){
                    Console.WriteLine("You hit!");
                    _playerSearch[i,column] = "X";
                }
                else{
                    Console.WriteLine("You missed!");
                    _playerSearch[i,column] = "O";
                }
            }
        }
    }
}