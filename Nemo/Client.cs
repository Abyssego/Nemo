using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class Client
    {
        public int ID_Client { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Code_Postal { get; set; }
        public string Pays { get; set; }
        public DateTime? Date_Inscription { get; set; }
        public int Niveau_Pl_SousMarine { get; set; }

        // Propriété de navigation pour les prêts
        public ICollection<Pret> Prets { get; set; }
    }
}
