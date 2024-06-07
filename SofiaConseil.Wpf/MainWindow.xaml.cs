using SofiaConseil.DbLib.Class;
using SofiaConseil.Wpf.ViewModel;
using SofiaConseil.Wpf.Views;
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

namespace SofiaConseil.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new ViewModelMainWindow();
            this.DataContext = new ViewModelFreelances();
            this.DataContext = new ViewModelDemandes();
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            DockPanelMain.Children.Clear();
            DockPanelMain.Children.Add(new ViewHome());
        }

        private void ButtonCompetences_Click(object sender, RoutedEventArgs e)
        {
            DockPanelMain.Children.Clear();
            DockPanelMain.Children.Add(new ViewCompetences());
        }
        private void ButtonFreelances_Click(object sender, RoutedEventArgs e)
        {
            DockPanelMain.Children.Clear();
            DockPanelMain.Children.Add(new ViewFreelances());
        }
        
        
        private void ButtonDemandes_Click(object sender, RoutedEventArgs e)
        {
            DockPanelMain.Children.Clear();
            DockPanelMain.Children.Add(new ViewDemandes());
        }
    }
}