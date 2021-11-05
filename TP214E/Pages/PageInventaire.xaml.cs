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
using TP214E.Pages;

namespace TP214E
{
    /// <summary>
    /// Logique d'interaction pour Inventaire.xaml
    /// </summary>
    public partial class PageInventaire : Page
    {
        private List<Aliment> aliments;
        AlimentDAL _dal;
        public PageInventaire()
        {
            _dal = new AlimentDAL();
            InitializeComponent();
        }

        private void ChargerLesAliments()
        {
            aliments = _dal.RechercherTousLesAliments();
            lvAliments.ItemsSource = aliments;
            DataContext = this;
        }

        public void AuChargement(object sender, RoutedEventArgs e)
        {
            ChargerLesAliments();
        }

        private void OnFermerModaleClick(object sender, RoutedEventArgs e)
        {
            //modale.EstOuverte = false;
            //ne fonctionne pas pour l'instant: test d'une autre solution
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            ListViewItem elemetDeLaliste = sender as ListViewItem;
            if (elemetDeLaliste != null && elemetDeLaliste.IsSelected)
            {
                Aliment alimentSelectionne = (Aliment)elemetDeLaliste.DataContext;
                PageAliment frmAliment = new PageAliment(_dal, alimentSelectionne);

                this.NavigationService.Navigate(frmAliment);
            }
        }

        private void btnAcheterAliment_Click(object sender, RoutedEventArgs e)
        {
            PageAliment frmAliment = new PageAliment(_dal, null);
            this.NavigationService.Navigate(frmAliment);
        }
    }
}
