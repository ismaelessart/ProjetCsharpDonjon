using System;

namespace D_DProjetC_
{   
    public class Gobelin : Ennemi
    {
        public Gobelin() : base("Gobelin")
        {
            niveau = 2;
            pointsDeVie = 30;
            sagesse = 3;
            intelligence = 3;
            dexterite = 10;
            force = 15;
            armure = 5;
            resistanceMagique = 3;
        }
    }
}