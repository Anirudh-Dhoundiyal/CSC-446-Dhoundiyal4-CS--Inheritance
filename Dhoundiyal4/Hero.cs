using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterNS
{
    public class Hero : Character
    {
        public short Protection
        {
            get;
            set;
        }

        public Global.WeaponType Weapon
        {
            get;
            set;
        }
        /*  Method: default constructor
        ***************************************************** 
        * Description: Overwrites the class instance for HERO
        * Input: Void
        * Output: Void
        * IN/OUT AGGS:
        *  
        *   
        *    public short Protection;
        *    public Global.WeaponType Weapon;
        * RETURN : void
        */
        public Hero()
        {
           
            Protection = 50;
            Weapon = Global.WeaponType.AXE;
        }
        /*  Method: parameterized constructor
        ***************************************************** 
        * Description: Overwrites the class instance for HERO
        * Input: Void
        * Output: Void
        * IN/OUT AGGS:
        *  
        *   
        *    public short Protection;
        *    public Global.WeaponType Weapon;
        * RETURN : void
        */
        public Hero(short protection , Global.WeaponType weapon)
        {

            Protection = protection;
            Weapon = weapon;
        }
        /*  Method: Copy constructor
        ***************************************************** 
        * Description: copys the class instance for HERO
        * Input: Void
        * Output: Void
        * IN/OUT AGGS:
        *   Hero :hero
        * RETURN : void
        */
        public Hero(Hero copyhero)
        {
            
            Protection = copyhero.Protection;
            Weapon = copyhero.Weapon;
        }
    }
}
