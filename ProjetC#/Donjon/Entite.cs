using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DProjetC_
{
    public abstract class Entite
    {
        protected int niveau;
        protected string nom;
        protected bool estMort=false;
        protected int chance;
        protected int pointsDeVie;
        protected int sagesse;
        protected int intelligence;
        protected int dexterite;
        protected int force;
        protected int armure;
        protected int resistanceMagique;

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite) 
        {
            
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