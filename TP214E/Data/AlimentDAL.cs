using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using System.Windows;

namespace TP214E.Data
{
    public class AlimentDAL: DAL
    {
        public AlimentDAL() : base()
        {

        }

        public List<Aliment> ALiments()
        {
            var aliments = new List<Aliment>();
            try
            {
                IMongoDatabase db = mongoDBClient.GetDatabase("TP2DB");
                aliments = db.GetCollection<Aliment>("Aliments").Aggregate().ToList();

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
                // Creer l'aliment
                IMongoDatabase db = mongoDBClient.GetDatabase("TP2DB");
                //aliments = db.GetCollection<Aliment>("Aliments").Aggregate().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible de se connecter à la base de données " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        public bool ModifierAliment(Aliment aliment)
        {
            try
            {
                // Modifier l'aliment
                IMongoDatabase db = mongoDBClient.GetDatabase("TP2DB");
                //aliments = db.GetCollection<Aliment>("Aliments").Aggregate().ToList();

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
