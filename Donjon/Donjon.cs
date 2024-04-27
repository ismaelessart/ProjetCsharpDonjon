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
                    return new Salle { Id = id, Nom = nom, Portes = portes };
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
            string cheminFichier = @"C:\Users\Isma\Documents\ProjetC#\Donjon\bin\Debug\net8.0\donjon.xml";
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
    }
}
