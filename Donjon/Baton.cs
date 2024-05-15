using System;

namespace D_DProjetC_
{
    public class Baton : Arme
{
    public Baton(string nom, string description, string rarete, int degats, int PointsDeVieBonus, int sagesseBonus, int intelligenceBonus, int dexteriteBonus, int forceBonus, int armureBonus, int resistanceMagiqueBonus, int chanceBonus)
        : base(nom, description, rarete, degats, sagesseBonus, intelligenceBonus, dexteriteBonus, forceBonus, armureBonus, resistanceMagiqueBonus, chanceBonus, PointsDeVieBonus)
    {
        sorts = new List<string>
            {
                "Boule de Feu",
                "Rayon de Guérison",
                "Gel Glacial",
                "Bénédiction de Sagesse",
                "Protection Élémentaire",
                "Invocation de Vent",
                "Renforcement d'Armure",
                "Éclat Divin"
            };
    }
}
}