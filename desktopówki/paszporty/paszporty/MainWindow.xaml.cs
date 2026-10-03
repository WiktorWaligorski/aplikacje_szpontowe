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

namespace paszporty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NumberLostFocus(object sender,  RoutedEventArgs e)
        {
            string number = NumberInput.Text;
            try
            {
                face.Source = new BitmapImage(new Uri($"/src/{number}-zdjecie.jpg", UriKind.Relative));
                fingerprint.Source = new BitmapImage(new Uri($"/src/{number}-odcisk.jpg", UriKind.Relative));
            }
            catch
            {
                face.Source = null;
                fingerprint.Source = null;

            }
        }
        public void DisplayInfo(object sender, RoutedEventArgs e)
        {
            if (first_nameInput.Text.ToString() != string.Empty && surnameInput.Text.ToString() != string.Empty)
            {
                string eye_color =
                    (blue_eyes.IsChecked == true) ? "niebieskie" :
                    (green_eyes.IsChecked == true) ? "zielone" : "piwne";
                MessageBox.Show($"{first_nameInput.Text} {surnameInput.Text} kolor oczu: {eye_color}");
            }
            else
            {
                MessageBox.Show("Wprowadź dane");
            }
            
        }
    }
}