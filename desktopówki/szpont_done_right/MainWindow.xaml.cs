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

namespace szpont_done_right
{
    public partial class MainWindow : Window
    {
        public double total;

        public string name;
        public string surname;
        public string phone;

        public int days;
        string destination;
        public void EstimateCost()
        {
            total = 0;
            days = int.Parse(DaysInput.Text);
            int dailyPrice = 0;
            destination = ((ComboBoxItem)ComboList.SelectedItem).Content.ToString();
            switch (destination)
            {
                case "Góry":
                    dailyPrice = 120;
                    break;
                case "Morze":
                    dailyPrice = 150;
                    break;
                case "Jeziora":
                    dailyPrice = 100;
                    break;
            }

            total = dailyPrice * days;
            if (Food.IsChecked == true)
            {
                total += days * 50;
            }
            if (Guide.IsChecked == true)
            {
                total += 300;
            }
            if (days > 7)
            {
                total *= 0.9;
            }

        }

       

        public void DisplayTotal(object sender, RoutedEventArgs e)
        {
            EstimateCost();
            MessageBox.Show("kwota: " + total);
        }

        public void DisplayAll(object sender, RoutedEventArgs e)
        {
            EstimateCost();
            name = NameInput.Text;
            surname = SurnameInput.Text;
            phone = NumberInput.Text;
            MessageBox.Show($"imię i nazwisko: {name} {surname} \n" +
                $"telefon {phone} \n" +
                $"kierunek: {destination}\n" +
                $"kwota: {total}");
        }



        public MainWindow()
        {
            InitializeComponent();
        }
    }
}