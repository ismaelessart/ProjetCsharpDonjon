using System;

namespace D_DProjetC_
{
    public class Marteau : Arme
{
    public Marteau(string nom, string description, string rarete, int degats, int PointsDeVieBonus, int sagesseBonus, int intelligenceBonus, int dexteriteBonus, int forceBonus, int armureBonus, int resistanceMagiqueBonus, int chanceBonus)
        : base(nom, description, rarete, degats, sagesseBonus, intelligenceBonus, dexteriteBonus, forceBonus, armureBonus, resistanceMagiqueBonus, chanceBonus, PointsDeVieBonus)
    {

    }
}
}