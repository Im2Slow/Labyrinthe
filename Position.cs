using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_6_Bis_Labyrinthe
{
    class Position
    { 
        // déclaration des champs

        int x;
        int y;

        //déclaration du/des constructeurs

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //déclaration des propriétés

        public int X
        {
            get { return x; }
            set { x = value; }
        }
         public int Y
        {
            get { return y; }
            set { y = value; }
        }

        //déclaration des méthodes

        override public string ToString()
        {
            string annonce = " est situé aux coordonnées : (" + x + " ," + y + " ).";
            return annonce;
        }

        public bool Equality (Position pos)
        {
            if (pos.x == this.x && pos.y == this.y)
            {
                return true;
            }
            return false;
        }
        public void Set (Position pos)
        {
            this.x = pos.x;
            this.y = pos.y;
        }
    }
}
