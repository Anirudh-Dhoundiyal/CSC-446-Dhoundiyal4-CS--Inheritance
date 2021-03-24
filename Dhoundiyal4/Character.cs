using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterNS
{
   public class Character
    {
        public string Name
        {
            get;
            set;
        }
        public Global.RaceType Race
        {
            get;
            set;

        }


        public short Health
        {
            get;
            set;
        }
        /*  Method: constructor
        ***************************************************** 
        * Description: Overwrites the class instance for Character
        * Input: Void
        * Output: Void
        * IN/OUT AGGS:
        *   public string Name;
        *    public Global.RaceType RaceType;
        *    public short Health;
        *    
        * RETURN : void
        */
        public Character(string name = "Geralt", Global.RaceType raceType = Global.RaceType.WITCHER, short health = 200)
        {
            Name = name;
            Race = raceType;
            Health = health;
        }
        /*  Method: Copy constructor
        ***************************************************** 
        * Description: copys the class instance for Character
        * Input: Void
        * Output: Void
        * IN/OUT AGGS:
        * RETURN : void
        */
        public Character(Character copycharacter)
        {
            Name = copycharacter.Name;
            Race = copycharacter.Race;
            Health = copycharacter.Health;
            
        }
    }
}
