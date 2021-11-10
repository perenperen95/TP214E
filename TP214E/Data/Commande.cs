using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace TP214E.Data
{
    public class Commande
    {
        private ObjectId _id;
        private List<Recette>_items;
        private int _total;
        private DateTime _dateHeure;

        public Commande(ObjectId pId, Recette pRecette)
        {
            Total = 0;
            Items = new List<Recette>();
            AjouterItemCommande(pRecette);
        }

        public Commande(Recette pRecette)
        {
            Total = 0;
            Items = new List<Recette>();
            AjouterItemCommande(pRecette);
        }

        public void AjouterItemCommande(Recette pRecette)
        {
            Items.Add(pRecette);
            Total += pRecette.Prix;
        }

        public void RetirerItemCommande(Recette pRecette)
        {
            Items.Remove(pRecette);
            Total -= pRecette.Prix;
        }

        public ObjectId Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public List<Recette> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public DateTime DateHeure
        {
            get { return _dateHeure; }
            set { _dateHeure = value; }
        }
    }
}
