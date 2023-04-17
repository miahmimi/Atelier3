using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CmdRevues hérite de Commande : contient des propriétés spécifiques à la commande de revues
    /// </summary>
    public class CmdRevues :Commande
    {
        public DateTime Fin_abonnement { get; set; }
        public String Revue { get; set; }
        public int Num { get; set; }

        public CmdRevues(DateTime dateFinAbonnement, DateTime dateCommande, int montant, string id, string idRevue, int numero) : base(id, dateCommande, montant)
        {
            Fin_abonnement = dateFinAbonnement;
            Revue = idRevue;
            Num = numero;
        }
    }
}
