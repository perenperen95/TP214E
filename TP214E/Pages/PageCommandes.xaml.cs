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
        public PageCommandes()
        {
            InitializeComponent();
        }

        public List<Recette> RecuperationToutesRecettesPossibles()
        {
            List<Recette> recettesPossibles = new List<Recette>();
            List<Recette> recettesExistantes = _recetteDAL.RechercherToutesLesRecettes();
            List<Aliment> alimentsDansInventaire = _alimentDAL.RechercherTousLesAliments();


            foreach (Recette recette in recettesExistantes)
            {
                foreach (var aliment in recette.AlimentsQuantites)
                {
                    if (aliment.Value <= aliment.Key.Quantite)
                    {

                    }

                }
            }

            return recettesPossibles;
        }

        //private static bool InventaireDisponiblePourAliment(Aliment pAliment1, Aliment pAliment2)
        //{
        //    return pAliment1.Quantite >= pAliment2.Quantite;
        //}
    }
}
