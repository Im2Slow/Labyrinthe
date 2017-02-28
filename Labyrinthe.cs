using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_6_Bis_Labyrinthe
{
    class Labyrinthe
    {
        //déclaration des champs

        int[,] board;
        int lineNumber;
        int columnNumber;
        Position start;
        Position finish;
        const int SPACE = 0;
        const int WALL = 1;
        const int START = 2;
        const int FINISH = 3;
        const int OCCUPIED = 4;
            
        //déclaration du/des constructeurs

        public Labyrinthe(string[] schema1, int lineNumber, int columnNumber)
        {                     
            this.lineNumber = lineNumber;
            this.columnNumber = columnNumber;
            board = new int[lineNumber, columnNumber];
            
            for (int i = 0; i < lineNumber; i++) /**/
            {
                char[][] charArray = new char[lineNumber][];

                charArray[i] = schema1[i].ToCharArray();
                for (int j = 0; j < columnNumber; j++)
                {                    
                    if (charArray[i][j] == ' ') board[i, j] = SPACE;
                    if (charArray[i][j] == '*') board[i, j] = WALL;
                    if (charArray[i][j] == 'd')
                    {
                        board[i, j] = START;
                        start = new Position(i, j);
                    }
                    if (charArray[i][j] == 'a')
                    {
                        board[i, j] = FINISH;
                        finish = new Position(i, j);
                    }
                    if (charArray[i][j] == '.') board[i, j] = OCCUPIED;
                }
            }
        }

        //déclaration des propriétés

        public Position Start
        {
            get { return start; }
        }
        public Position Finish
        {
            get { return finish; }
        }
        public int[,] Board
        {
            get { return board; }
        }

        //déclaration des méthodes
                
        public bool IsAWall(Position pos)
        {
            if (board[pos.X, pos.Y] == WALL) return true;
            return false;
        }
        public bool Occupied(Position pos)
        {
            if(board[pos.X,pos.Y] == OCCUPIED)return true;
            return false;
        }
        public bool MarkPath (Position pos)
        {
            if (IsAWall(pos) == false && Occupied(pos) == false)
            {
                board[pos.X, pos.Y] = OCCUPIED;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string chain = "";
            for(int i=0; i < lineNumber;i++)
            {               
                for(int j=0;j < columnNumber;j++)
                {
                    if (board[i, j] == SPACE) chain += " ";
                    if (board[i, j] == WALL) chain += "*";
                    if (board[i, j] == START) chain += "d";
                    if (board[i, j] == FINISH) chain += "a";
                    if (board[i, j] == OCCUPIED) chain += ".";
                }

               chain += "\n";
            }
            return chain;          
        }
    }
}
