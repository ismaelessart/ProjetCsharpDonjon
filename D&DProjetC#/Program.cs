using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le jeu Donjons et Dragons !");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Dans un monde où la magie et les créatures fantastiques abondent, une \r\nancienne légende raconte l'existence d'un donjon oublié depuis des \r\nsiècles. On dit que ce donjon renferme d'innombrables trésors, des \r\nartefacts puissants et des secrets ancestraux. Cependant, personne n'a \r\njamais réussi à percer ses mystères, et ceux qui ont osé s'y aventurer \r\nn'en sont jamais revenus.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Vous devez maîtriser le pouvoir du cristal pour vaincre les ténèbres qui menacent votre royaume. En explorant les recoins les plus sombres de la forêt ancienne et en affrontant les gardiens maléfiques, vous devrez déverrouiller les secrets de l'artefact et devenir le héros légendaire qui sauvera son monde de l'obscurité.\r\n\r\n");
            Console.ReadLine();
        }
    }
    class Personnage
    {
        public int PDV { get; set; }
        public int PDM { get; set; }
        public int intelligence { get; set; }
        public int dexterite { get; set; }
        public int constitution { get; set; }
        public int sagesse { get; set; }
        public int force { get; set; }

        public Personnage(int PDV, int PDM, int intelligence, int dexterite, int constitution, int sagesse, int force) 
        {
            this.PDV = PDV;
            this.PDM = PDM;
            this.intelligence = intelligence;
            this.dexterite = dexterite;
            this.constitution = constitution;
            this.sagesse = sagesse;
            this.force = force;
        }

    }
    class Mage
    {
        int PDV = 40;
        int PDM = 80;
        int intelligence = 16;
        int dexterite = 12;
        int constitution = 10;
        int sagesse = 14;
        int force = 8;
    }
}
