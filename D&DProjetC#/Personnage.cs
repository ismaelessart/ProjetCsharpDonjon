using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    public abstract class Personnage : Entite
    {
        private int niveau;
        private int experience;

        public Personnage(string nom) : base(nom)
        {
            this.nom = nom;
            niveau = 1;
            experience = 0;
        }

        public void GagnerExperience(int experience)
        {
            this.experience = experience;
            while (this.experience >= ExperienceRequise())
            {
                niveau += 1;
                AttribuerPointsStats();
            }
        }

        private void AttribuerPointsStats()
        {
            int pointsStats = 5;
            while (pointsStats > 0)
            {
                Console.WriteLine($"Points disponibles : {pointsStats}");
                Console.WriteLine("1. Augmenter les points de vie");
                Console.WriteLine("2. Augmenter les dégats minimum");
                Console.WriteLine("3. Augmenter les dégats maximum");
                Console.WriteLine("4. Confirmer le choix");
                Console.WriteLine("5. Recommencer");
                Console.WriteLine("Choisissez une option :");
                string choix = Console.ReadLine();
                Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        pointsDeVie++;
                        Console.WriteLine("Points de vie augmentés !");
                        pointsStats--;
                        break;
                    case "2":
                        degatsMin++;
                        Console.WriteLine("Dégats minimum augmentés !");
                        pointsStats--;
                        break;
                    case "3":
                        degatsMax++;
                        Console.WriteLine("Dégats maximum augmentés !");
                        pointsStats--;
                        break;
                    case "4":
                        if (pointsStats == 0)
                        {
                            Console.WriteLine("Choix confirmé !");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Vous devez utiliser tous vos points avant de confirmer !");
                            break;
                        }
                    case "5":
                        Console.WriteLine("Recommençons !");
                        pointsStats = 5;
                        pointsDeVie = 0;
                        degatsMin = 0;
                        degatsMax = 0;
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez choisir à nouveau.");
                        break;
                }
            }
            Console.WriteLine($"Nouvelles statistiques: Points de vie: {pointsDeVie}, Dégats minimum: {degatsMin}, Dégats maximum: {degatsMax}.");
        }


        public double ExperienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }
        public string Caracteristiques()
        {
            return this.nom + "\n" +
                "Points de vie : " + pointsDeVie + "\n" +
                "Niveau :" + niveau + "\n" +
                "Points d'expérience : (" + experience + "/" + ExperienceRequise() + ")\n" +
                "Dégats : [" + degatsMin + ";" + degatsMax + "]";
        }
    }

}
