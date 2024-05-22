using System;

namespace D_DProjetC_
{   
    public class Orc : Ennemi
    {
        public Orc() : base("Orc")
        {
            niveau = 3;
            pointsDeVie = 80;
            sagesse = 7;
            intelligence = 7;
            dexterite = 10;
            force = 25;
            armure = 15;
            resistanceMagique = 7;
        }
    }
}