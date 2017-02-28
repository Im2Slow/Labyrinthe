using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_6_Bis_Labyrinthe
{
    class Personnage
    {
        //déclaration des champs

        Labyrinthe laby;
        Position characterPosition;
        

        //déclaration du/des constructeurs

        public Personnage(Labyrinthe laby)
        {
            characterPosition = laby.Start;
            this.laby = laby;           
        }

        //déclaration des propriétés

            public Position CharacterPosition
        {
            get { return characterPosition; }
        }
        
        //déclaration des méthodes

        public bool IsArrived()
        {
            if (characterPosition.Equality(laby.Finish)) return true;
            return false;
        }

        public void NextMove(string Button)
        {
            if(Button.Length==1)
            {
                Position LastPosition = new Position(characterPosition.X, characterPosition.Y);
                if (Button == "z")
                {
                    characterPosition.X--;

                    if(laby.IsAWall(CharacterPosition) != true && laby.Occupied(CharacterPosition) != true) /**/
                    {
                        laby.MarkPath(characterPosition);

                    }
                    else
                    {
                        characterPosition.Set(LastPosition);
                    }

                }
                if (Button == "q")
                {
                    characterPosition.Y--;

                    if (laby.IsAWall(CharacterPosition) != true && laby.Occupied(CharacterPosition) != true) /**/
                    {
                        laby.MarkPath(characterPosition);
                    }
                    else
                    {
                        characterPosition.Set(LastPosition);
                    }
                }
                if (Button == "d")
                {
                    characterPosition.Y++;

                    if (laby.IsAWall(CharacterPosition) != true && laby.Occupied(CharacterPosition) != true) 
                    {                        
                        laby.MarkPath(characterPosition);

                    }
                    else
                    {
                        characterPosition.Set(LastPosition);
                           
                    }
                                       
                }
                if (Button == "s")
                {
                    characterPosition.X++;
                    if (laby.IsAWall(CharacterPosition) != true && laby.Occupied(CharacterPosition) != true) /**/
                    {
                        laby.MarkPath(characterPosition);
                    }
                    else
                    {
                        characterPosition.Set(LastPosition);
                    }
                }
            }
        }
    }
}
