using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP214E.Data;

namespace TP214E.Pages
{
    /// <summary>
    /// Interaction logic for PageCommandes.xaml
    /// </summary>
    public partial class PageCommandes : Page
    {
        AlimentDAL _alimentDAL;
        RecetteDAL _recetteDAL;
        CommandeDAL _CommadeDAL;
        Commande _maCommande;
        List<Recette> _recettesPossibles;
        public PageCommandes(AlimentDAL dal)
        {
            InitializeComponent();
            _maCommande = new Commande();
            //RecuperationToutesRecettesPossibles();
            //RemplirAffichageRecette(_recettesPossibles);
            testBoutonsHandlers();
        }

        private void RecuperationToutesRecettesPossibles()
        {
            _recettesPossibles = new List<Recette>();
            List<Recette> recettesExistantes = _recetteDAL.RechercherToutesLesRecettes();
            Dictionary<string, int> alimentsDansInventaire = ListeAlimentsEnDictionnaire();


            foreach (Recette recette in recettesExistantes)
            {
                foreach (var aliment in recette.AlimentsQuantites)
                {
                    if (aliment.Value <= alimentsDansInventaire[aliment.Key])
                    {
                        _recettesPossibles.Add(recette);
                    }

                }
            }
        }

        private Dictionary<string, int> ListeAlimentsEnDictionnaire()
        {
            List<Aliment> listeAliments = _alimentDAL.RechercherTousLesAliments();
            Dictionary<string, int> dictAliments = new Dictionary<string, int>();

            foreach (var aliment in listeAliments)
            {
                dictAliments.Add(aliment.Nom, aliment.Quantite);
            }
            return dictAliments;
        }

        private void RemplirAffichageRecette(List<Recette> pListeRecettesPossibles)
        {
            for (int i = 0; i < pListeRecettesPossibles.Count; i++)
            {
                Button nouveauBouton = CreerNouveauBouton(pListeRecettesPossibles[i]);
                if(i < 4)
                {
                    sp1.Children.Add(nouveauBouton);
                }
                else if(i < 8)
                {
                    sp2.Children.Add(nouveauBouton);
                }
                else if(i < 12)
                {
                    sp3.Children.Add(nouveauBouton);
                }
                else if(i < 16)
                {
                    sp4.Children.Add(nouveauBouton);
                }
            }
        }

        private Button CreerNouveauBouton(Recette pRecette)
        {
            Button nouveauBouton = new Button();

            nouveauBouton.Content = pRecette.Nom;
            nouveauBouton.Name = "Bouton" + pRecette.Nom;
            nouveauBouton.Padding = new Thickness(4);
            nouveauBouton.Tag = pRecette;

            nouveauBouton.Click += (object sender, RoutedEventArgs e) =>
            {
                _maCommande.AjouterItemCommande(pRecette);
            };

            return nouveauBouton;
        }


        private void RafraichirListBoxCommande()
        {
            lbCommande.Items.Clear();
            foreach (var item in _maCommande.Items)
            {
                lbCommande.Items.Add(item.Nom);
            }
        }

        private void btnRetirer_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in _maCommande.Items)
            {
                if (item.Nom == lbCommande.SelectedItem.ToString())
                {
                    _maCommande.RetirerItemCommande(item);
                }
            }
            RafraichirListBoxCommande();
        }

        private void btnCommander_Click(object sender, RoutedEventArgs e)
        {
            _maCommande.DateHeure = DateTime.Now;
            _CommadeDAL.AjouterCommandeLog(_maCommande);
            _maCommande.Items.Clear();
            _maCommande.Total = 0;
            RafraichirListBoxCommande();
        }

        private void testBoutonsHandlers()
        {
            for (int i = 0; i < 14; i++)
            {
                Button nouveauBouton = new Button();
                nouveauBouton.Name = "Bouton" + i.ToString();
                nouveauBouton.Content = "test" + i.ToString();
                nouveauBouton.Click += (object sender, RoutedEventArgs e) =>
                {
                    lbCommande.Items.Add(nouveauBouton.Content);
                };
                if (i < 4)
                {
                    sp1.Children.Add(nouveauBouton);
                }
                else if (i < 8)
                {
                    sp2.Children.Add(nouveauBouton);
                }
                else if (i < 12)
                {
                    sp3.Children.Add(nouveauBouton);
                }
                else if (i < 16)
                {
                    sp4.Children.Add(nouveauBouton);
                }
            }
        }
        
    }
}
