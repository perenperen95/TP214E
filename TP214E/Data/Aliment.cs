using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP214E.Data
{
    public class Aliment
    {
        private string _id;
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

        public ObjectId Id { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public string Unite { get; set; }
        public DateTime ExpireLe { get; set; }

    }
}
