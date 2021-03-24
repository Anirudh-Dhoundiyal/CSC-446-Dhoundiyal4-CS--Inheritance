using System;

namespace CharacterNS
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero ani = new Hero( 60, Global.WeaponType.SPELL );
            View.ViewV(ani);
            View.ViewH(ani);

            ani.Name = "Anirudh";
            Hero newani = new Hero(ani);
            newani.Name = "NewAnirudh";
            View.ViewV(newani);
            View.ViewH(newani);
        }
    }
}
