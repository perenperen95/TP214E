using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP214E.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP214E.Data.Tests
{
    [TestClass()]
    public class CommandeTests
    {
        [TestMethod()]
        public void VerifierPrixAjouterALaCommandeTest()
        {
            Recette recetteTest = new Recette("tomates en dés", new Dictionary<string, int> { { "tomate", 1 } }, 2);
            Commande maCommande = new Commande();
            Commande copieCommande = maCommande;

            maCommande.AjouterItemCommande(recetteTest);

            Assert.IsTrue(maCommande.Total > copieCommande.Total);
        }

        [TestMethod()]
        public void VerifierCountAjouterALaCommandeTest()
        {
            Recette recetteTest = new Recette("tomates en dés", new Dictionary<string, int> { { "tomate", 1 } }, 2);
            Commande maCommande = new Commande();
            Commande copieCommande = maCommande;

            maCommande.AjouterItemCommande(recetteTest);

            Assert.IsTrue(maCommande.Items.Count > copieCommande.Items.Count);
        }

        [TestMethod()]
        public void VerifierPrixRetirerDeLaCommandeTest()
        {
            Recette recetteTest = new Recette("tomates en dés", new Dictionary<string, int> { { "tomate", 1 } }, 2);
            Commande maCommande = new Commande();
            maCommande.AjouterItemCommande(recetteTest);
            Commande copieCommande = maCommande;

            maCommande.RetirerItemCommande(recetteTest);

            Assert.IsTrue(maCommande.Total < copieCommande.Total);
        }

        [TestMethod()]
        public void VerifierCountRetirerDeLaCommandeTest()
        {
            Recette recetteTest = new Recette("tomates en dés", new Dictionary<string, int> { { "tomate", 1 } }, 2);
            Commande maCommande = new Commande();
            maCommande.AjouterItemCommande(recetteTest);
            Commande copieCommande = maCommande;

            maCommande.RetirerItemCommande(recetteTest);

            Assert.IsTrue(maCommande.Items.Count < copieCommande.Items.Count);
        }

    }
}