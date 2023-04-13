using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    public class Commande
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public int Montant { get; set; }
        public Commande(string id, DateTime dateCommande, int montant)
        {
            Id = id;
            Date = dateCommande;
            Montant = montant;
        }
    }
}
