using SofiaConseil.DbLib.Class;
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
        public string Email { get; set; }

        public MainWindow()
        {
            using (SofiaConseilContext context = new())
            {
                Email = context.Users.First().Email;
            }
            this.DataContext = this;
            InitializeComponent();
        }
    }
}