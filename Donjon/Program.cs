using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace D_DProjetC_
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Menu();
        }

        public static void Menu()
        {   
            Console.Title = "Donjon";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string[] asciiArt = new string[]
            {
                "▓█████▄  ▒█████   ███▄    █  ▄▄▄██▀▀▀ ▒ █████   ███▄    █",
                "▒██▀ ██▌▒██▒  ██▒ ██ ▀█   █    ▒██    ▒██▒  ██▒ ██ ▀█   █",
                "░██   █▌▒██░  ██▒ ▓██  ▀█ ██▒   ░██   ▒██░  ██▒▓██  ▀█ ██▒",
                "░▓█▄   ▌▒██   ██░ ▓██▒  ▐▌██▒▓██▄██▓  ▒██   ██░▓██▒  ▐▌██▒",
                "░▒████▓ ░ ████▓▒░ ▒██░   ▓██░ ▓███▒   ░ ████▓▒░▒██░   ▓██░",
                "▒▒▓  ▒ ░ ▒░▒░▒░ ░  ▒░   ▒ ▒  ▒▓▒▒░   ░ ▒░▒░▒░ ░ ▒░    ▒ ▒",
                "░ ▒  ▒   ░ ▒ ▒░ ░  ░░   ░ ▒░ ▒ ░▒░     ░ ▒ ▒░ ░ ░░    ░ ▒░",
                "░ ░  ░ ░ ░ ░ ▒     ░    ░ ░  ░ ░ ░   ░ ░ ░ ▒     ░    ░ ░",
                "░        ░ ░            ░  ░   ░       ░ ░            ░",
                ""
            };

            foreach (string line in asciiArt)
            {
                Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1. Créer un personnage");
            Console.WriteLine("2. Charger un personnage");
            Console.WriteLine("3. Quitter");
            Console.Write("Entrez votre choix : ");
            int choixMenu;
            if (!int.TryParse(Console.ReadLine(), out choixMenu))
            {
                Console.Clear();
                Console.WriteLine("Caractère invalide !");
                Menu();
                return;
            }

            switch (choixMenu)
            {
                case 1:
                    CreerEtCommencer();
                    break;
                case 2:
                    ChargerPersonnage();
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Choix invalide !");
                    Menu();
                    break;
            }
        }

        static void CreerEtCommencer()
        {
            Donjon donjon = Donjon.ChargerDonjon("donjon.xml");
            Personnage personnage = Personnage.CreerPersonnage(donjon);
            Console.WriteLine("Voulez vous entrer dans le donjon ?");
            Console.WriteLine("1. Oui");
            Console.WriteLine("2. Non");
            int reponseDebutDonjon;
            if (!int.TryParse(Console.ReadLine(), out reponseDebutDonjon))
            {
                Console.Clear();
                Console.WriteLine("Caractère invalide !");
                Menu();
                return;
            }

            if (reponseDebutDonjon == 1)
            {   
                CommencerJeu(personnage, donjon);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Choix invalide !");
                Menu();
            }
        }

        static void CommencerJeu(Personnage personnage, Donjon donjon)
        {
            Console.WriteLine("Bienvenue dans le donjon !");
            personnage.SalleActuelle = donjon.GetSalleById(1);

            while (true)
            {
                Console.WriteLine($"Vous êtes dans la salle : {personnage.SalleActuelle.Nom}");
                /*personnage.ChoisirTypeArme();
                Arme armeAleatoire = ArmeFactory.CreerArmeAleatoire(personnage.TypeArme);
                personnage.EquiperArme(armeAleatoire);*/

                Console.WriteLine("Choisissez une porte à prendre ou sortez du jeu :");

                foreach (int porteId in personnage.SalleActuelle.Portes)
                {
                    Console.WriteLine($"- Porte vers salle {porteId}");
                }
                Console.WriteLine("- Sortir du jeu");

                string choix = Console.ReadLine();
                if (choix.ToLower() == "sortir du jeu")
                {
                    Console.WriteLine("Vous avez quitté le jeu.");
                    break;
                }

                int choixPorte;
                if (int.TryParse(choix, out choixPorte) && personnage.SalleActuelle.Portes.Contains(choixPorte))
                {
                    Salle salleDestination = donjon.GetSalleById(choixPorte);
                    if (salleDestination != null)
                    {
                        personnage.SalleActuelle = salleDestination;
                        Console.WriteLine($"Vous entrez dans la salle : {personnage.SalleActuelle.Nom}");
                        VerifierMonstresDansSalle(personnage.SalleActuelle, personnage);
                    }
                    else
                    {
                        Console.WriteLine("Numéro de salle invalide !");
                    }
                }
            }
        }

        static void ChargerPersonnage()
        {
            Console.WriteLine("Chargement du personnage...");
        }
        public static void VerifierMonstresDansSalle(Salle salle, Personnage personnage)
        {
            if (salle.Ennemis.Any())
            {
                Console.WriteLine("Des monstres sont présents dans la salle !");
                personnage.EngagerCombat(salle.Ennemis);
            }
            else
            {
                Console.WriteLine("Il n'y a pas de monstres dans cette salle.");
            }
        }
        public static void RetourMenuPrincipal()
        {
            Console.WriteLine("Retour au menu principal...");
            Menu();
        }
    }
}
