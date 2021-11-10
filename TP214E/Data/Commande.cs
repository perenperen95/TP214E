using System;
using System.Collections.Generic;
using System.Text;

namespace TP214E.Data
{
    public class Commande
    {
        private List<Recette> _recettes;
        private decimal _prixTotal;

        public List<Recette> Recettes
        {
            get { return _recettes; }
        }

        public decimal PrixTotal
        {
            get { return _prixTotal; }
        }

        public Commande(Recette pRecette)
        {
            _prixTotal = 0;
            _recettes = new List<Recette>();
            AjouterRecetteDansCommande(pRecette);
        }

        public void AjouterRecetteDansCommande(Recette pRecette)
        {
            _recettes.Add(pRecette);
            _prixTotal += pRecette.Prix;
        }

        public void RetirerRecetteDeCommande(Recette pRecette)
        {
            _recettes.Remove(pRecette);
            _prixTotal -= pRecette.Prix;
        }
    }
}
