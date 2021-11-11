using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace TP214E.Data
{
    public class Recette
    {
        private ObjectId _id;
        private Dictionary<Aliment, int> _alimentsQuantites;
        private int _prix;

        public ObjectId Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Dictionary<Aliment, int> AlimentsQuantites
        {
            get { return _alimentsQuantites; }
            set { _alimentsQuantites = value; }
        }
        public int Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }
    }
}
