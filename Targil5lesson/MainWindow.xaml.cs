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

namespace Targil5lesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //int i;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ButtonGreenLight_Click(object sender, RoutedEventArgs e)
        {
            // Car.Margin.GetHashCode();
            //i = i + 5;
            Car.Margin = new Thickness(589 , 263, 0 ,0);
        }

        private void ButtonOrangeLight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRedLight_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BRAKES!");

        }
    }
}