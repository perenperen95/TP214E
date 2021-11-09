using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace TP214E.Pages.Interfaces
{
    interface IPageAliment
    {
        public void AfficherErreurChamp(TextBlock labelErreur, string erreur);

        public void EnleverErreurChamp(TextBlock labelErreur);
    }
}
