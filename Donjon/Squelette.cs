using System;

namespace D_DProjetC_
{   
    public class Squelette : Ennemi
    {
        public Squelette() : base("Squelette")
        {
            niveau = 1;
            pointsDeVie = 50;
            sagesse = 5;
            intelligence = 5;
            dexterite = 15;
            force = 20;
            armure = 10;
            resistanceMagique = 5;
        }
    }
}