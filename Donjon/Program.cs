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

        static void Menu()
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
            Console.WriteLine();
            Console.WriteLine("2. Charger un personnage");
            Console.WriteLine();
            Console.WriteLine("3. Quitter");
            Console.Write("Entrez votre choix : ");
            Console.WriteLine();
            int choixMenu;
            bool isValidInput = int.TryParse(Console.ReadLine(), out choixMenu);

            if (!isValidInput)
            {
                Console.Clear();
                string errorMessage = "Caractère invalide !";
                Console.WriteLine(errorMessage);
                Menu();
                return;
            }

            switch (choixMenu)
            {
                case 1:
                    // Créer un personnage
                    Personnage personnage = Personnage.CreerPersonnage();
                    Donjon donjon = Donjon.ChargerDonjon("donjon.xml");
                    Console.WriteLine("Voulez vous entrer dans le donjon ?");
                    Console.WriteLine("1. Oui");
                    Console.WriteLine("2. Non");
                    int reponseDebutDonjon;
                    bool isValidResponse = int.TryParse(Console.ReadLine(), out reponseDebutDonjon);

                    if (!isValidResponse)
                    {
                        Console.Clear();
                        string errorMessageDebutDonjon = "Caractère invalide !";
                        Console.WriteLine(errorMessageDebutDonjon);
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
                        string errorMessageDebutDonjon = "Choix invalide !";
                        Console.WriteLine(errorMessageDebutDonjon);
                        Menu();
                        return;
                    }
                    break;
                case 2:
                    // Charger un personnage
                    ChargerPersonnage();
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    string errorMessage = "Choix invalide !";
                    Console.Clear();
                    Console.WriteLine(errorMessage);
                    Menu();
                    return;
            }
        }

        static void CommencerJeu(Personnage personnage, Donjon donjon)
        {
            Console.WriteLine("Bienvenue dans le donjon !");
            personnage.SalleActuelle = donjon.GetSalleById(1);

            while (true)
            {
                Console.WriteLine($"Vous êtes dans la salle : {personnage.SalleActuelle.Nom}");
                Console.WriteLine("Choisissez une porte à prendre :");

                foreach (int porteId in personnage.SalleActuelle.Portes)
                {
                    Console.WriteLine($"- Porte vers salle {porteId}");
                }

                Console.WriteLine("Entrez le numéro de la porte :");
                int choixPorte;
                if (int.TryParse(Console.ReadLine(), out choixPorte))
                {
                    if (personnage.SalleActuelle.Portes.Contains(choixPorte))
                    {
                        Salle salleDestination = donjon.GetSalleById(choixPorte);
                        if (salleDestination != null)
                        {
                            personnage.SalleActuelle = salleDestination;
                            Console.WriteLine($"Vous entrez dans la salle : {personnage.SalleActuelle.Nom}");

                            // Gérer les ennemis dans la salle
                            List<Ennemi> ennemis = salleDestination.GenererEnnemis();
                            if (ennemis.Count > 0)
                            {
                                Console.WriteLine($"Vous rencontrez {ennemis.Count} ennemi(s) !");
                                foreach (var ennemi in ennemis)
                                {
                                    Console.WriteLine($"{ennemi.Nom} apparaît !");
                                }

                                personnage.EngagerCombat(ennemis);
                                if (!personnage.IsAlive)
                                {
                                    Console.WriteLine("Game Over!");
                                    return;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Numéro de salle invalide !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Numéro de porte invalide !");
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide !");
                }
            }
        }
    

        static void EngagerCombat(Personnage personnage, List<Ennemi> ennemis)
        {
            personnage.EngagerCombat(ennemis);
        }

        static void ChargerPersonnage()
        {
            Console.WriteLine("Chargement du personnage...");
        }

        static void Combat()
        {
            Console.WriteLine("C'est à votre tour de jouer !");
            Console.WriteLine("Choisissez une action :");
            Console.WriteLine("1. Attaque de base");
            Console.WriteLine("2. Sorts ");
            Console.WriteLine("3. Objets");
            Console.WriteLine("4. Fuir");
            int choixAction = Convert.ToInt32(Console.ReadLine());

            switch (choixAction)
            {
                case 1:
                    Attaque();
                    break;
                case 2:
                    Sorts();
                    break;
                case 3:
                    Personnage.Utiliser();
                    break;
                case 4:
                    Fuir();
                    break;
                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }
        }

        static void Attaque()
        {
            Console.WriteLine("Vous attaquez !");
            AttaqueBase();
        }

        static void Sorts()
        {
            // Implémenter la logique des sorts
        }

        static void Fuir()
        {
            if (new De().Lancer() > 10)
            {
                Console.WriteLine("Vous avez réussi à fuir !");
            }
            else if (new De().Lancer() < 5)
            {
                Console.WriteLine("Echec critique ! Vous n'avez pas réussi à fuir, l'ennemi vous attaque !");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas réussi à fuir !");
            }
        }
    }
}