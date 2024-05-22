using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace D_DProjetC_
{
    [XmlRoot("donjon")]
    public class Donjon
    {
        [XmlArray("salles")]
        [XmlArrayItem("salle")]
        public List<Salle> Salles { get; set; }

        public Donjon()
        {
            Salles = new List<Salle>();
        }
        public List<Ennemi> GetEnnemisDansSalle(int idSalle)
        {
        Salle salle = Salles.FirstOrDefault(s => s.Id == idSalle);
        return salle != null ? salle.Ennemis : new List<Ennemi>();
        }
        public static Donjon ChargerDonjon(string cheminFichier)
        {
            Donjon donjon = new Donjon();

            try
            {
                XDocument doc = XDocument.Load(cheminFichier);

                donjon.Salles = doc.Root.Elements("salle").Select((salleElement, index) =>
                {
                    string nom = salleElement.Attribute("nom").Value;
                    int id = index + 1; 
                    List<int> portes = salleElement.Element("portes").Elements("porte")
                                                    .Select(porteElement => int.Parse(porteElement.Attribute("vers").Value))
                                                    .ToList();
                    List<Ennemi> ennemis = new List<Ennemi>();
                    XElement ennemisElement = salleElement.Element("ennemis");
                    if (ennemisElement != null)
                    {
                        ennemis = ennemisElement.Elements("ennemi")
                                                .Select(ennemiElement => Ennemi.ChargerEnnemi(ennemiElement))
                                                .ToList();
                    }

                    return new Salle { Id = id, Nom = nom, Portes = portes, Ennemis = ennemis };
                }).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement du donjon : {ex.Message}");
            }

            return donjon;
        }

    

        public void SauvegarderDonjon()
        {
            string cheminFichier = @"C:\Users\alkaa\Desktop\Donjon\donjon.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Donjon));
            using (FileStream fichier = new FileStream(cheminFichier, FileMode.Create))
            {
                serializer.Serialize(fichier, this);
            }
        }

        public Salle GetSalleById(int id)
        {
            return Salles.FirstOrDefault(s => s.Id == id);
        }

        public void AfficherEnnemisDansSalles()
        {
            foreach (var salle in Salles)
            {
                if (salle.Ennemis.Any())
                {
                    Console.WriteLine($"Dans la salle \"{salle.Nom}\", il y a les ennemis suivants :");
                    foreach (var ennemi in salle.Ennemis)
                    {
                        Console.WriteLine($"- {ennemi.Nom}");
                    }
                }
                else
                {
                    Console.WriteLine($"La salle \"{salle.Nom}\" est vide.");
                }
            }
        }
    }
}
