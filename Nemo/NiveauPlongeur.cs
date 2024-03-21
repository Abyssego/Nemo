using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class NiveauPlongeur
    {
        private int _numPlongeur;
        private string _nomPlongeur;


        public NiveauPlongeur(int numPlongeur, string nomPlongeur)
        {
            _numPlongeur = numPlongeur;
            _nomPlongeur = nomPlongeur;

        }

        public int NumPlongeur
        {
            get { return _numPlongeur; }
            set { _numPlongeur = value; }
        }

        public string NomPlongeur
        {
            get { return _nomPlongeur; }
            set { _nomPlongeur = value; }
        }

        public string PrenomPlongeur
        {
            get { return _prenomPlongeur; }
            set { _prenomPlongeur = value; }
        }

        public NiveauPlongeur LeNiveauPlongeur
        {
            get { return _leNiveauPlongeur; }
            set { _leNiveauPlongeur = value; }
        }


        public override string ToString()
        {
            return NumPlongeur.ToString();
        }
    }
}
