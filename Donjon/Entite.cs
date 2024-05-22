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
        public bool EstMort { get; protected set; }
        protected int chance;
        protected int pointsDeVie;
        protected int sagesse;
        protected int intelligence;
        protected int dexterite;
        protected int force;
        protected int armure;
        protected int resistanceMagique;
                public bool IsAlive{ get { return !EstMort; }}
        public Entite(string nom)
        {
            this.nom = nom;
            EstMort = false;
        }
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
                    EstMort = true;
                }
            }
        }

        public virtual int Attaquer()
        {
            return force;
        }
        

        public virtual void RecevoirDegats(int degats)
        {
            PointsDeVie -= degats;
            if (PointsDeVie <= 0)
            {
                EstMort = true;
            }
        }

    }
}