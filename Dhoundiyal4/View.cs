using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterNS
{
    public static class View
    {
        /*  Method: Override Cunstructor
        ***************************************************** 
        * Description: Displays the class instance for HERO Horizontally 
        * Input: HERO hero
        * Output: Void
        * IN/OUT AGGS:
        *   public string Name;
        *    public Global.RaceType RaceType;
        *    public short Health;
        *    public short Protection;
        *    public Global.WeaponType Weapon;
        * RETURN : void
        */
        public static void ViewH(Hero heroH)
        {
            Console.WriteLine("HERO  |  RACE  |  HEALTH  |  PROTECTION  |  WEAPON ");
            Console.Write(heroH.Name);
            Console.Write("  ");
            Console.Write(heroH.Race);
            Console.Write("     ");
            Console.Write(heroH.Health);
            Console.Write("         ");
            Console.Write(heroH.Protection);
            Console.Write("          ");
            Console.Write(heroH.Weapon);
            Console.WriteLine(" ");
        }
        /*  Method: Override Cunstructor
        ***************************************************** 
        * Description: Displays the class instance for HERO Vertically 
        * Input: HERO hero
        * Output: Void
        * IN/OUT AGGS:
        *   public string Name;
        *    public Global.RaceType RaceType;
        *    public short Health;
        *    public short Protection;
        *    public Global.WeaponType Weapon;
        * RETURN : void
        */
        public static void ViewV(Hero heroV)
        {
            Console.WriteLine("  ");
            Console.WriteLine("Hero:       " + heroV.Name);
            Console.WriteLine("Race:       " + heroV.Race);
            Console.WriteLine("Health:     " + heroV.Health);
            Console.WriteLine("Protection: " + heroV.Protection);
            Console.WriteLine("Weapon:     " + heroV.Weapon);
            Console.WriteLine("");
        }
    }
}
