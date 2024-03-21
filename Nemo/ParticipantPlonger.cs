using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class ParticipantPlonger
    {
        private string _datePlonger;
        private int _numPlongeur;
        private Plongeur _lePlongeur;
        private Plonger _lePlonger;
        private Personnel _lePersonnel;
        private string _nomPlongeur;
        private string _prenomPlongeur;
        private NiveauPlonger _leNiveauPlongeur;

        public ParticipantPlonger(int numPlongeur, string nomPlongeur, string prenomPlongeur, NiveauPlonger leNiveauPlongeur)
        {
            _numPlongeur = numPlongeur;
            _nomPlongeur = nomPlongeur;
            _prenomPlongeur = prenomPlongeur;
            _leNiveauPlongeur = leNiveauPlongeur;
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

        public NiveauPlonger LeNiveauPlongeur
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
