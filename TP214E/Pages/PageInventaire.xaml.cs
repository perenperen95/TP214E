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
        DAL _dal;
        public PageInventaire(DAL dal)
        {
            InitializeComponent();
            aliments = dal.ALiments();

            DataContext = this;
        }

        private void OnFermerModaleClick(object sender, RoutedEventArgs e)
        {
            //modale.EstOuverte = false;
            //ne fonctionne pas pour l'instant: test d'une autre solution
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            var aliment = sender as ListViewItem;
            if (aliment != null && aliment.IsSelected)
            {
                Aliment al = new Aliment();
                PageAliment frmAliment = new PageAliment(_dal, al);

                this.NavigationService.Navigate(frmAliment);
            }
        }

        private void btnAcheterAliment_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
