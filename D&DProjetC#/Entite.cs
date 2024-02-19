using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    public abstract class Entite
    {
        protected string nom;
        protected bool estMort=false;
        protected int pointsDeVie;
        protected int degatsMin;
        protected int degatsMax;
        protected Random random=new Random();

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite) 
        {
            int degats = random.Next(degatsMin, degatsMax);
            uneEntite.PerdrePointsDeVie(degats);
            Console.WriteLine(this.nom + "(" + this.pointsDeVie + ")" + " attaque : " + uneEntite.nom);
            Console.WriteLine(uneEntite.nom + " a perdu " + degats + "points de vie.");
        }

        protected void PerdrePointsDeVie(int pointsDeVie)
        {

        }

        public bool EstMort()
        {
            return this.estMort;
        }
    }
}
