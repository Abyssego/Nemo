using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class Plongeur
    {
        private int id;
        private string nom;
        private string prenom;
        private int niveau;
        private NiveauPlonger niveauPlonger;

        public NiveauPlonger NiveauPlonger
        {
            get { return niveauPlonger; }
            set { niveauPlonger = value; }
        }

        public int Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }


        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }


        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public Plongeur(int id, string nm, string pn, int lv, NiveauPlonger np)
        {
            this.id = id;
            this.nom = nm;
            this.prenom = pn;
            this.niveau = lv;
            this.niveauPlonger = np;
        }
    }
}
