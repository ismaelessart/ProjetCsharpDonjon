using System;

namespace D_DProjetC_
{
    public class Dagues : Arme
{
    public Dagues(string nom, string description, string rarete, int degats, int PointsDeVieBonus, int sagesseBonus, int intelligenceBonus, int dexteriteBonus, int forceBonus, int armureBonus, int resistanceMagiqueBonus, int chanceBonus)
        : base(nom, description, rarete, degats, sagesseBonus, intelligenceBonus, dexteriteBonus, forceBonus, armureBonus, resistanceMagiqueBonus, chanceBonus, PointsDeVieBonus)
    {
        sorts = new List<string>
            {
                "Assaut Furtif",
                "Ombres Traîtresses",
                "Danse Mortelle",
                "Évasion Éclair",
                "Poison Perçant",
                "Coup Critique",
                "Frénésie Sanguinaire",
                "Voile de l'Invisible"
            };
    }
}
}