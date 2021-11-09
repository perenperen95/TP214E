using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP214E.Data
{
    public class Aliment
    {
        private ObjectId _id;
        private string _nom;
        private int _quantite;
        private string _unite;
        private DateTime  _expireLe;

        public Aliment(ObjectId id, string nom, int quantite, string unite, DateTime expireLe)
        {
            Id = id;
            Nom = nom;
            Quantite = quantite;
            Unite = unite;
            ExpireLe = expireLe;
        }

        public Aliment(string nom, int quantite, string unite, DateTime expireLe)
        {
            Nom = nom;
            Quantite = quantite;
            Unite = unite;
            ExpireLe = expireLe;
        }

        public ObjectId Id {
            get { return _id; }
            set { _id = value; }
        }
        public string Nom {
            get { return _nom; }
            set { _nom = value; }
        }
        public int Quantite {
            get { return _quantite; }
            set { _quantite = value; }
        }
        public string Unite {
            get { return _unite; }
            set { _unite = value; }
        }
        public DateTime ExpireLe {
            get { return _expireLe; }
            set { _expireLe = value; }
        }

    }
}
