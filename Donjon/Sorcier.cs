using System;

namespace D_DProjetC_
{
    public class Sorcier : Ennemi
    {
        public Sorcier() : base("Sorcier")
        {
            niveau = 4;
            pointsDeVie = 40;
            sagesse = 25;
            intelligence = 30;
            dexterite = 10;
            force = 5;
            armure = 5;
            resistanceMagique = 20;
        }
    }
}