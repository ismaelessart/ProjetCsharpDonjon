using System;

namespace D_DProjetC_
{
    public class Arme
    {
    public string Nom { get; set; }
    public string Description { get; set; }
    public string Rarete { get; set; }
    public int Degats { get; set; }
    public int SagesseBonus { get; set; }
    public int IntelligenceBonus { get; set; }
    public int DexteriteBonus { get; set; }
    public int ForceBonus { get; set; }
    public int ArmureBonus { get; set; }
    public int ResistanceMagiqueBonus { get; set; }
    public int ChanceBonus { get; set; }
    public int PointsDeVieBonus { get; set; }
    protected int NombreSorts { get; set; }

    public Arme(string nom, string description, string rarete, int degats, int pointsDeVieBonus,int sagesseBonus, int intelligenceBonus, int dexteriteBonus, int forceBonus, int armureBonus, int resistanceMagiqueBonus, int chanceBonus)
    {
        Nom = nom;
        Description = description;
        Degats = degats;
        SagesseBonus = sagesseBonus;
        IntelligenceBonus = intelligenceBonus;
        DexteriteBonus = dexteriteBonus;
        ForceBonus = forceBonus;
        ArmureBonus = armureBonus;
        ResistanceMagiqueBonus = resistanceMagiqueBonus;
        ChanceBonus = chanceBonus;
        PointsDeVieBonus = pointsDeVieBonus;

        Random rand = new Random();
            int rareteIndex = rand.Next(4); 
            switch (rareteIndex)
            {
                case 0:
                    Rarete = "Commun";
                    PointsDeVieBonus *= 1;
                    Degats *= 1;
                    SagesseBonus *= 1;
                    IntelligenceBonus *= 1;
                    DexteriteBonus *= 1;
                    ForceBonus *= 1;
                    ArmureBonus *= 1;
                    ResistanceMagiqueBonus *= 1;
                    ChanceBonus *= 1;
                    NombreSorts = 1; 
                    break;
                case 1:
                    Rarete = "Rare";
                    PointsDeVieBonus *= 2;
                    Degats *= 2;
                    SagesseBonus *= 2;
                    IntelligenceBonus *= 2;
                    DexteriteBonus *= 2;
                    ForceBonus *= 2;
                    ArmureBonus *= 2;
                    ResistanceMagiqueBonus *= 2;
                    ChanceBonus *= 2;
                    NombreSorts = 2; 
                    break;
                case 2:
                    Rarete = "Épique";
                    PointsDeVieBonus *= 3;
                    Degats *= 3;
                    SagesseBonus *= 3;
                    IntelligenceBonus *= 3;
                    DexteriteBonus *= 3;
                    ForceBonus *= 3;
                    ArmureBonus *= 3;
                    ResistanceMagiqueBonus *= 3;
                    ChanceBonus *= 3;
                    NombreSorts = 3; 
                    break;
                case 3:
                    Rarete = "Légendaire";
                    PointsDeVieBonus *= 4;
                    Degats *= 4;
                    SagesseBonus *= 4;
                    IntelligenceBonus *= 4;
                    DexteriteBonus *= 4;
                    ForceBonus *= 4;
                    ArmureBonus *= 4;
                    ResistanceMagiqueBonus *= 4;
                    ChanceBonus *= 4;
                    NombreSorts = 4; 
                    break;
                default:
                    Rarete = "Commun"; 
                    NombreSorts = 1;
                    break;
            }
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"Stats de l'arme : {Nom}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Rarete : {Rarete}");
        Console.WriteLine($"Degats : {Degats}");
        Console.WriteLine($"Points de vie Bonus : +{PointsDeVieBonus}");
        Console.WriteLine($"Sagesse Bonus : +{SagesseBonus}");
        Console.WriteLine($"Intelligence Bonus : +{IntelligenceBonus}");
        Console.WriteLine($"Dexterite Bonus : +{DexteriteBonus}");
        Console.WriteLine($"Force Bonus : +{ForceBonus}");
        Console.WriteLine($"Armure Bonus : +{ArmureBonus}");
        Console.WriteLine($"Resistance Magique Bonus : +{ResistanceMagiqueBonus}");
        Console.WriteLine($"Chance Bonus : +{ChanceBonus}");
    }
    }
}