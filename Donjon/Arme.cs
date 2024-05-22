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
        protected List<string> sorts = new List<string>();

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

            CreerArme(this);

        }

        static void CreerArme(Arme @this)
        {
            Random rand = new Random();
            int rareteIndex = rand.Next(4);
            switch (rareteIndex)
            {
                case 0:
                    @this.Rarete = "Commun";
                    @this.PointsDeVieBonus *= 1;
                    @this.Degats *= 1;
                    @this.SagesseBonus *= 1;
                    @this.IntelligenceBonus *= 1;
                    @this.DexteriteBonus *= 1;
                    @this.ForceBonus *= 1;
                    @this.ArmureBonus *= 1;
                    @this.ResistanceMagiqueBonus *= 1;
                    @this.ChanceBonus *= 1;
                    @this.NombreSorts = 1;
                    break;
                case 1:
                    @this.Rarete = "Rare";
                    @this.PointsDeVieBonus *= 2;
                    @this.Degats *= 2;
                    @this.SagesseBonus *= 2;
                    @this.IntelligenceBonus *= 2;
                    @this.DexteriteBonus *= 2;
                    @this.ForceBonus *= 2;
                    @this.ArmureBonus *= 2;
                    @this.ResistanceMagiqueBonus *= 2;
                    @this.ChanceBonus *= 2;
                    @this.NombreSorts = 2;
                    break;
                case 2:
                    @this.Rarete = "Épique";
                    @this.PointsDeVieBonus *= 3;
                    @this.Degats *= 3;
                    @this.SagesseBonus *= 3;
                    @this.IntelligenceBonus *= 3;
                    @this.DexteriteBonus *= 3;
                    @this.ForceBonus *= 3;
                    @this.ArmureBonus *= 3;
                    @this.ResistanceMagiqueBonus *= 3;
                    @this.ChanceBonus *= 3;
                    @this.NombreSorts = 3;
                    break;
                case 3:
                    @this.Rarete = "Légendaire";
                    @this.PointsDeVieBonus *= 4;
                    @this.Degats *= 4;
                    @this.SagesseBonus *= 4;
                    @this.IntelligenceBonus *= 4;
                    @this.DexteriteBonus *= 4;
                    @this.ForceBonus *= 4;
                    @this.ArmureBonus *= 4;
                    @this.ResistanceMagiqueBonus *= 4;
                    @this.ChanceBonus *= 4;
                    @this.NombreSorts = 4;
                    break;
                default:
                    @this.Rarete = "Commun";
                    @this.NombreSorts = 1;
                    break;
            }

            var sortsDisponibles = new List<string>(@this.sorts);
            List<string> sortsChoisis = new List<string>();
            for (int i = 0; i < @this.NombreSorts; i++)
            {
                int indexSort = rand.Next(sortsDisponibles.Count);
                sortsChoisis.Add(sortsDisponibles[indexSort]);
                sortsDisponibles.RemoveAt(indexSort);
            }

            @this.sorts = sortsChoisis;
        }
        static void AfficherDetails(Arme @this)
        {
            Console.WriteLine($"Stats de l'arme : {@this.Nom}");
            Console.WriteLine($"Description : {@this.Description}");
            Console.WriteLine($"Rarete : {@this.Rarete}");
            Console.WriteLine($"Degats : {@this.Degats}");
            Console.WriteLine($"Points de vie Bonus : +{@this.PointsDeVieBonus}");
            Console.WriteLine($"Sagesse Bonus : +{@this.SagesseBonus}");
            Console.WriteLine($"Intelligence Bonus : +{@this.IntelligenceBonus}");
            Console.WriteLine($"Dexterite Bonus : +{@this.DexteriteBonus}");
            Console.WriteLine($"Force Bonus : +{@this.ForceBonus}");
            Console.WriteLine($"Armure Bonus : +{@this.ArmureBonus}");
            Console.WriteLine($"Resistance Magique Bonus : +{@this.ResistanceMagiqueBonus}");
            Console.WriteLine($"Chance Bonus : +{@this.ChanceBonus}");
        }
    }
}