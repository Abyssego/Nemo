﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    class Plongeur
    {
        private int id;
        private string nom;
        private string prenom;
        private int niveau;

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
    }
}
