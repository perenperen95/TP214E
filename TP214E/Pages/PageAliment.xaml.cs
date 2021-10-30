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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class PageAliment : Page
    {
        DAL _dal;
        Aliment _aliment;

        public PageAliment(DAL dal, Aliment aliment)
        {
            _dal = dal;
            _aliment = aliment;
            InitializeComponent();
            RemplissageFormulaire();
        }

        public void FermerPage(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        public void EnvoyerInformationsAliment(object sender, RoutedEventArgs e)
        {
            if (VerificationCasEnvoie())
            {
                CreerAliment();
            }
            else
            {
                ModifierAliment();
            }
        }

        public bool VerificationCasEnvoie()
        {
            return true;
        }

        public void CreerAliment()
        {

        }

        public void ModifierAliment()
        {

        }

        private void btnEnvoyerInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        public void RemplissageFormulaire()
        {
            if (_aliment != null)
            {
                lblId.Text = _aliment.Id.ToString();
                txtNom.Text = _aliment.Nom;
                txtQuatite.Text = _aliment.Quantite.ToString();
                txtUnite.Text = _aliment.Unite;
            }
        }
    }
}
