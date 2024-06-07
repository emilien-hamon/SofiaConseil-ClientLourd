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
    /// Logique d'interaction pour ViewFreelances.xaml
    /// </summary>
    public partial class ViewFreelances : UserControl
    {
        public ViewFreelances()
        {
            this.DataContext = new ViewModelFreelances();
            InitializeComponent();
        }

        private void ButtonAddFreelance_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelFreelances)this.DataContext).AddFreelance();
        }
        
        private void ButtonDeleteFreelance_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelFreelances)this.DataContext).RemoveFreelance();
        }
        
        private void ButtonUpdateFreelance_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelFreelances)this.DataContext).UpdateFreelance();
        }
    }
}
