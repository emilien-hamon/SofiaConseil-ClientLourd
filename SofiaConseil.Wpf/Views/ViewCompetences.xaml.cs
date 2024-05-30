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
    /// <summary>
    /// Logique d'interaction pour ViewCompetences.xaml
    /// </summary>
    public partial class ViewCompetences : UserControl
    {
        public ViewCompetences()
        {
            this.DataContext = new ViewModelCompetences();
            InitializeComponent();
        }

        private void ButtonAddCompetence_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelCompetences)this.DataContext).AddCompetence();
        }
    }
}
