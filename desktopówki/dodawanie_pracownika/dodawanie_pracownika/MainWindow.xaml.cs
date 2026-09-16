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

namespace dodawanie_pracownika
{
    public partial class MainWindow : Window
    {
        string OutputPassword = "";
        private void GeneratePassword(object sender, RoutedEventArgs e)
        {
            OutputPassword = "";
            string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
            string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Numbers = "0123456789";
            string SpecialCharacters = "!@#$%^&*()_+-=";
            bool IncludeLetters = (bool)chkSmallAndCapitalLetters.IsChecked;
            bool IncludeNumbers = (bool)chkNumbers.IsChecked;
            bool IncludeSpecialCharacters = (bool)chkSpecialCharacters.IsChecked;
            Random rand = new Random();

            int PasswordLength = int.Parse(txtPasswordLength.Text);

            if (IncludeLetters)
            {
                OutputPassword += CapitalLetters[rand.Next(0, CapitalLetters.Length)];
                PasswordLength--;
            }
            if (IncludeNumbers)
            {
                OutputPassword += Numbers[rand.Next(0, Numbers.Length)];
                PasswordLength--;
            }
            if (IncludeSpecialCharacters)
            {
                OutputPassword += SpecialCharacters[rand.Next(0, SpecialCharacters.Length)];
                PasswordLength--;
            }
            for (int i = 0; i < PasswordLength; i++)
            {
                rand.Next(0, SmallLetters.Length);
                OutputPassword += SmallLetters[rand.Next(0, SmallLetters.Length)];
            }

            MessageBox.Show(OutputPassword, "Wygenerowane hasło", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DataDisplay(object sender, RoutedEventArgs e)
        {
            string Name = txtName.Text;
            string Surname = txtLastName.Text;
            string Position = cmbPosition.Text;
            MessageBox.Show($"Imię: {Name}\nNazwisko: {Surname}\nStanowisko: {Position}\nHasło: {OutputPassword}", "Dane pracownika", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}