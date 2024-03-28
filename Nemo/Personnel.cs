using System;

namespace Nemo
{
    public class Personnel
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _role;
        private string _dateEmbauche;
        private string _statut;


        public Personnel(int id, string nom, string prenom, string role, string dateEmbauche, string statut)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _role = role;
            _dateEmbauche = dateEmbauche;
            _statut = statut;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public string DateEmbauche
        {
            get { return _dateEmbauche; }
            set { _dateEmbauche = value; }
        }

        public string Statut
        {
            get { return _statut; }
            set { _statut = value; }
        }

        public override string ToString()
        {
            return Nom.ToString() + " " + Prenom.ToString();
        }
    }
}
