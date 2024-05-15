using System;

namespace D_DProjetC_
{
    public class Epee : Arme
{
    public Epee(string nom, string description, string rarete, int degats, int PointsDeVieBonus, int sagesseBonus, int intelligenceBonus, int dexteriteBonus, int forceBonus, int armureBonus, int resistanceMagiqueBonus, int chanceBonus)
        : base(nom, description, rarete, degats, sagesseBonus, intelligenceBonus, dexteriteBonus, forceBonus, armureBonus, resistanceMagiqueBonus, chanceBonus, PointsDeVieBonus)
    {
        sorts = new List<string>
            {
                "Coup Rapide",
                "Tourbillon Tranchant",
                "Frénésie Guerrière",
                "Frappe Défensive",
                "Coup Éclair",
                "Lame de Feu",
                "Parade Parfaite",
                "Épée de Lumière"
            };
    }
}
}