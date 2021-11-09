using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModaleAliment
{
  
    public class Modale : ContentControl
    {
        public static readonly DependencyProperty ProprieteEstOuverte =
            DependencyProperty.Register("EstOuverte", typeof(bool), typeof(Modale), new PropertyMetadata(false));

        static Modale()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Modale), new FrameworkPropertyMetadata(typeof(Modale)));
        }

        public bool EstOuverte
        {
            get { return (bool)GetValue(ProprieteEstOuverte); }
            set { SetValue(ProprieteEstOuverte, value); }
        }

        public void fermerModale(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
