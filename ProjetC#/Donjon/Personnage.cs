using System;

namespace D_DProjetC_
{
    public class Personnage : Entite
    {
        public string Nom { get; set; }
        private new int niveau;
        private new int chance;
        public int Position { get; set; } 
        public Donjon Donjon { get; set; } 
        public Salle SalleActuelle { get; set; }


        private double experience;
        private readonly int experienceGagnee;

        public Personnage(string nom) : base(nom)
        {
            Nom = nom;
            Position = 0;
            niveau = 1;
            experience = 0;
            chance = 5;
            intelligence = 5;
            dexterite = 5;
            force = 5;
            pointsDeVie = 100;
            armure = 10;
            resistanceMagique = 5;
            sagesse = 5;
        }

        public int PointsRestants { get; private set; } = 5;

        public void AttribuerPointsStatistiques(int choixStatistique, int pointsStatistique)
        {
            switch (choixStatistique)
            {
                case 1:
                    chance += pointsStatistique;
                    break;
                case 2:
                    intelligence += pointsStatistique;
                    break;
                case 3:
                    dexterite += pointsStatistique;
                    break;
                case 4:
                    force += pointsStatistique;
                    break;
                case 5:
                    sagesse += pointsStatistique;
                    break;
                case 6:
                    pointsDeVie += pointsStatistique * 5; 
                    break;
                case 7:
                    armure += pointsStatistique;
                    break;
                case 8:
                    resistanceMagique += pointsStatistique;
                    break;
                default:
                    Console.WriteLine("Choix de statistique invalide. Réessayez.");
                    break;
            }

            PointsRestants -= pointsStatistique;
        }

        public double ExperienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }

        public void GagnerExperience(int experienceGagnee)
        {
            double ratioSagesse = sagesse / 100.0;
            double experienceFinale = experienceGagnee * (1 + ratioSagesse);
            int experienceFinaleArrondie = (int)Math.Round(experienceFinale);
            this.experience += experienceFinaleArrondie;
            Console.WriteLine($"Vous avez gagné {experienceFinaleArrondie} points d'expérience !");
            if (this.experience >= Math.Round(ExperienceRequise()))
            {
                this.experience -= (int)Math.Round(ExperienceRequise());
                this.niveau++;
                Console.WriteLine("Félicitations, vous êtes monté d'un niveau !");
                
            }
        }

        public static Personnage CreerPersonnage()
        {
            Console.Clear();
            Console.WriteLine("Entrez le nom de votre personnage :");
            Console.WriteLine();
            string? nom = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nBienvenue {nom} !");
            Console.WriteLine();

            if (string.IsNullOrEmpty(nom))
                throw new ArgumentNullException(nameof(nom));

            Personnage nouveauPersonnage = new Personnage(nom);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Attribuez 5 points à vos caractéristiques :");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Points restants : 5\n");

            while (nouveauPersonnage.PointsRestants > 0)
            {
                Console.WriteLine("Caractéristique actuelles :\n" + nouveauPersonnage.Caracteristiques() + "\n");
                Console.WriteLine("Choisissez la caractéristique à augmenter :\n");
                Console.WriteLine("1. Chance\n2. Intelligence\n3. Dextérité\n4. Force\n5. Sagesse\n6. Points de Vie\n7. Armure\n8. Résistance magique");

                if (int.TryParse(Console.ReadLine(), out int choixStatistique) && choixStatistique >= 1 && choixStatistique <= 8)
                {
                    Console.WriteLine($"\nEntrez le nombre de points à attribuer à {nouveauPersonnage.ChoixStatistique(choixStatistique)} :\n");
                    if (int.TryParse(Console.ReadLine(), out int pointsStatistique))
                    {
                        if (pointsStatistique <= nouveauPersonnage.PointsRestants)
                        {
                            nouveauPersonnage.AttribuerPointsStatistiques(choixStatistique, pointsStatistique);
                            Console.WriteLine("\nPoints attribués avec succès !");
                        }
                        else
                        {
                            Console.WriteLine("\nVous n'avez pas suffisamment de points restants. Réessayez.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nValeur invalide pour les points. Réessayez.");
                    }
                }
                else
                {
                    Console.WriteLine("\nChoix de caractéristique invalide. Réessayez.");
                }
            }

            Console.WriteLine(nouveauPersonnage.Caracteristiques());
            return nouveauPersonnage;
        }

        public string Caracteristiques()
        {
            return "\n" +
                   "Caractéristiques de votre personnage :\n" +
                   "Points de vie : " + pointsDeVie + "\n" +
                   "Niveau : " + niveau + "\n" +
                   "Points d'expérience : (" + experience + "/" + ExperienceRequise() + ")\n" +
                   "Sagesse : " + sagesse + "\n" +
                   "Intelligence : " + intelligence + "\n" +
                   "Dextérité : " + dexterite + "\n" +
                   "Force : " + force + "\n" +
                   "Chance : " + chance + "\n" +
                   "Armure : " + armure + "\n" +
                   "Résistance magique : " + resistanceMagique + "\n";
        }

        public static void Utiliser()
        {
            Console.WriteLine("Le personnage utilise l'objet.");
        }

        public string ChoixStatistique(int choixStatistique)
        {
            switch (choixStatistique)
            {
                case 1:
                    return "Chance";
                case 2:
                    return "Intelligence";
                case 3:
                    return "Dextérité";
                case 4:
                    return "Force";
                case 5:
                    return "Sagesse";
                case 6:
                    return "Points de Vie";
                case 7:
                    return "Armure";
                case 8:
                    return "Résistance magique";
                default:
                    return "";
            }
        }

        static void DeplacerPersonnage(Donjon donjon, Personnage personnage)
        {
            while (true)
            {
                AfficherOptionsPortes(personnage, donjon);

                int choixPorte;
                if (int.TryParse(Console.ReadLine(), out choixPorte))
                {
                    if (choixPorte >= 1 && choixPorte <= personnage.SalleActuelle.Portes.Count)
                    {
                        int idSalleDestination = personnage.SalleActuelle.Portes[choixPorte - 1];
                        Salle salleDestination = donjon.Salles.FirstOrDefault(s => s.Id == idSalleDestination);

                        if (salleDestination != null)
                        {
                            Console.WriteLine($"Vous entrez dans la salle : {salleDestination.Nom}");
                            personnage.SalleActuelle = salleDestination;
                        }
                        else
                        {
                            Console.WriteLine("Salle non trouvée.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choix de porte invalide.");
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un numéro de porte valide.");
                }
            }
        }

static void AfficherSalleActuelle(Personnage personnage)
{
    Console.WriteLine($"Vous êtes dans la salle : {personnage.SalleActuelle.Nom}");
}

static void AfficherOptionsPortes(Personnage personnage, Donjon donjon)
{
    Console.WriteLine("Choisissez une porte pour vous déplacer :");
    for (int i = 0; i < personnage.SalleActuelle.Portes.Count; i++)
    {
        int idSalleDestination = personnage.SalleActuelle.Portes[i];
        Salle salleDestination = donjon.Salles.FirstOrDefault(s => s.Id == idSalleDestination);
        if (salleDestination != null)
        {
            Console.WriteLine($"{i + 1}. {salleDestination.Nom}");
        }
    }
}
}
}