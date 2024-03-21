using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemo
{
    public class Pret
    {
        public int ID_Pret { get; set; }
        public int ID_Client { get; set; }
        public DateTime Date_Pret { get; set; }
        public DateTime? Date_Retour { get; set; }
        public string Materiel_Pret { get; set; }
        public bool Est_Approuve { get; set; }

        // Propriété de navigation pour le client
        public Client Client { get; set; }
    }
}
