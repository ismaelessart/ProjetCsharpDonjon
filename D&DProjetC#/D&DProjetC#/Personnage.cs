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

        public double ExperienceRequise()
        {
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }
        public string Caracteristiques()
        {
            return this.nom+ "\n" + "Points de vie : " + pointsDeVie + "\n" + "Niveau :" + niveau + "\n" + "Points d'expérience : (" + experience+ "/" + ExperienceRequise() + ")\n" + "Dégats : [" + degatsMin + ";" + degatsMax + "]";
        }
    }

}
