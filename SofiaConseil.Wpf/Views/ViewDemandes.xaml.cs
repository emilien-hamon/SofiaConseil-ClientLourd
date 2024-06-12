<<<<<<< Updated upstream
﻿using SofiaConseil.Wpf.ViewModel;
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
=======
﻿using SofiaConseil.DbLib.Class;
using SofiaConseil.Wpf.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
>>>>>>> Stashed changes

namespace SofiaConseil.Wpf.Views
{
    public partial class ViewDemandes : UserControl
    {
        public ViewDemandes()
        {
            InitializeComponent();
<<<<<<< Updated upstream
            this.DataContext = new ViewModelDemandes();
=======
        }

        private void ListBoxMateriels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var viewModel = DataContext as ViewModelDemandes;
            if (viewModel == null)
                return;

            viewModel.SelectedMateriels.Clear();

            foreach (Materiel materiel in ListBoxMateriels.SelectedItems)
            {
                viewModel.SelectedMateriels.Add(materiel);
            }
>>>>>>> Stashed changes
        }

        private void UpdateDemandeButton_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< Updated upstream
            ((ViewModelDemandes)this.DataContext).UpdateDemande();
=======
            var viewModel = DataContext as ViewModelDemandes;
            viewModel?.UpdateDemande();
>>>>>>> Stashed changes
        }
    }
}
