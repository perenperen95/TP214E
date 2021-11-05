using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using System.Windows;

namespace TP214E.Data
{
    public class AlimentDAL: DAL
    {
        const string NOM_DE_LA_COLLECTION_ALIMENT = "Aliments";

        IMongoCollection<Aliment> _collectionAliment;

        public AlimentDAL() : base()
        {
            IMongoDatabase db = mongoDBClient.GetDatabase(NOM_DE_LA_BD);
            _collectionAliment = db.GetCollection<Aliment>(NOM_DE_LA_COLLECTION_ALIMENT);

        }

        public List<Aliment> RechercherTousLesAliments()
        {
            var aliments = new List<Aliment>();
            try
            {
                IMongoDatabase db = mongoDBClient.GetDatabase(NOM_DE_LA_BD);
                aliments = db.GetCollection<Aliment>(NOM_DE_LA_COLLECTION_ALIMENT).Aggregate().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter à la base de données " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            return aliments;
        }

        public bool CreerAliment(Aliment aliment)
        {
            try
            {
                _collectionAliment.InsertOne(aliment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter à la base de données " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        public bool ChercherUnAliment(string nomAliment)
        {
            try
            {
                IMongoDatabase db = mongoDBClient.GetDatabase(NOM_DE_LA_BD);
                var constructeur = Builders<Aliment>.Filter;
                var filtre = constructeur.Eq("Nom", nomAliment);

                Aliment aliment = _collectionAliment.Find(filtre).First();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter à la base de données " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return false;
        }

        public bool ModifierAliment(Aliment aliment)
        {
            try
            {
                var filtre = Builders<Aliment>.Filter.Eq(s => s.Id, aliment.Id);
                _collectionAliment.ReplaceOne(filtre, aliment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter à la base de données " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
    }
}
