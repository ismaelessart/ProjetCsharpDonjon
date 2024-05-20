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

        public string Nom => nom;
        public int PointsDeVie
        {
            get => pointsDeVie;
            set
            {
                pointsDeVie = value;
                if (pointsDeVie <= 0)
                {
                    pointsDeVie = 0;
                    estMort = true;
                }
            }
        }

        public void Attaquer(Entite uneEntite) 
        {
            return force;
        }

        protected void PerdrePointsDeVie(int pointsDeVie)
        {
            int degatsReels = degats - armure;
            if (degatsReels > 0)
            {
                PointsDeVie -= degatsReels;
            }
        }

        public bool EstMort()
        {
            return this.estMort;
        }
    }
}