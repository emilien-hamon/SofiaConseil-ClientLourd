using SofiaConseil.Wpf.ViewModel;
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

namespace SofiaConseil.Wpf.Views
{
    public partial class ViewDemandes : UserControl
    {
        public ViewDemandes()
        {
            InitializeComponent();
            this.DataContext = new ViewModelDemandes();
        }

        private void UpdateDemandeButton_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelDemandes)this.DataContext).UpdateDemande();
        }
    }
}
