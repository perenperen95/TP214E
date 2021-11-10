using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace TP214E.Data
{
    public class Recette
    {
        private ObjectId _id;
        private Dictionary<Aliment, int> _aliments;
        private decimal _prix;

        public ObjectId Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public decimal Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public Dictionary<Aliment, int> Aliments
        {
            get { return _aliments; }
            set { _aliments = value; }
        }

        public Recette(Dictionary<Aliment, int> pAliments, decimal pPrix)
        {
            _aliments = pAliments;
            Prix = pPrix;
        }

        public void AjouterAlimentDansRecette(Aliment pAliment, int pNombre)
        {
            _aliments.Add(pAliment, pNombre);
        }

        public void ChangerComptePourAliment(Aliment pAliment, int pNouveauNombre)
        {
            if (pNouveauNombre == 0)
            {
                RetirerAlimentDeRecette(pAliment);
            }
            else
            {
                _aliments[pAliment] = pNouveauNombre;
            }
        }

        public void RetirerAlimentDeRecette(Aliment pAliment)
        {
            _aliments.Remove(pAliment);
        }

    }
}
