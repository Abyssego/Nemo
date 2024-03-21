using System;

namespace Nemo
{
    public class Personnel
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _role;
        private string _diplome;
        private string _email;
        private string _telephone;

        public Personnel(int id, string nom, string prenom, string role, string diplome, string email, string telephone)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _role = role;
            _diplome = diplome;
            _email = email;
            _telephone = telephone;
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

        public string Diplome
        {
            get { return _diplome; }
            set { _diplome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
