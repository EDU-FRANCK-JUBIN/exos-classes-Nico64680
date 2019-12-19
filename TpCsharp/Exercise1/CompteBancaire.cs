using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCsharp.Exercise1
{
    class CompteBancaire
    {
        private string titulaire;
        private int solde;
        private string devise;

        public static int nbrCOmpte;

        public string Titulaire { get => titulaire; }
        public int Solde { get => solde; }
        public string Devise { get => devise; }

        public CompteBancaire(string titulaire, int solde, string devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
        }

        public void Crediter(int montant)
        {
            solde = solde + montant;
        }

        public void Debiter(int montant)
        {
            solde = solde - montant;
        }

        public override string ToString()
        {
            return String.Format("Compte de {0} avec un solde de {1} en {2}", titulaire, solde, devise);
        }
    }
}
