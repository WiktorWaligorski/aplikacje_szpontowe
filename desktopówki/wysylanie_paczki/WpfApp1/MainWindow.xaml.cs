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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public void Check_Radio(object sender, RoutedEventArgs e)
        {
            if (Pocztowka.IsChecked == true)
            {
                Obrazek.Source = new BitmapImage(new Uri("/src/pocztowka.png", UriKind.Relative));
                CenaLabel.Content = "Cena: 1 zł";
            }
            else if (List.IsChecked == true)
            {
                Obrazek.Source = new BitmapImage(new Uri("/src/list.png", UriKind.Relative));
                CenaLabel.Content = "Cena: 1,5 zł";
                
            }
            else if (Paczka.IsChecked == true)
            {
                Obrazek.Source = new BitmapImage(new Uri("/src/paczka.png", UriKind.Relative));
                CenaLabel.Content = "Cena: 10 zł";
            }
        }

        public void Check_Kod(object sender, RoutedEventArgs e)
        {
            string postal = kod.Text;
            string cyfry = "0123456789";
            if  (postal.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }
            for (int i = 0; i < postal.Length; i++)
            {
                if (!cyfry.Contains(postal[i]))
                {
                    MessageBox.Show("od pocztowy powinien się składać z samych cyfr");
                    return;
                }
            }
            MessageBox.Show("Dane przesyłki zostały wprowadzone");
            return;

        }
        public MainWindow()
        {
            InitializeComponent();

        }
    }
}