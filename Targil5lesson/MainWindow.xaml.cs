using System.Reflection;
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
        public int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ButtonGreenLight_Click(object sender, RoutedEventArgs e)
        {

            i = i + 30;
            Car.Margin = new Thickness(578 - i, 283, 0, 0);
        }

        private void ButtonRedLight_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BRAKES!");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ramzor.Visibility = new VisualTransition("Visible");
            //Ramzor.Visibility = Visibility.Visible;
            i = i + 5;
            Car.Margin = new Thickness(578 - i, 283, 0, 0);
        }
    }
}