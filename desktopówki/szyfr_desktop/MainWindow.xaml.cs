using Microsoft.Win32;
using System.IO;
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

namespace szyfr_desktop
{

    public partial class MainWindow : Window
    {
        static string Encode(int k, string input)
        {
            string output = "";
            int input_ascii = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case ' ':
                        output += ' ';
                        break;

                    case '\n':
                    case '\r':
                        output += input[i];
                        break;
                    default:
                        input_ascii = (int)input[i];
                        if (input_ascii + k > 122)
                        {
                            output += (char)(input_ascii - 26 + k);
                        }
                        else if (input_ascii + k < 97)
                        {
                            output += (char)(input_ascii + 26 + k);
                        }
                        else
                        {
                            output += (char)(input_ascii + k);
                        }
                        break;
                }
            }

            return output;
        }
        void EncodeAndDisplay(object sender, RoutedEventArgs e)
        {
            int key;

            if (!int.TryParse(KeyInput.Text, out key))
            {
                key = 0;
            }
            string Input = TextInput.Text;
            string output = Encode(key, Input);

            TextOutput.Text = output;

        }

        void SaveText(object sender, RoutedEventArgs e)
        {
            string text = TextOutput.Text;

            var Dialog = new SaveFileDialog
            {
                Title = "Zapisywanie jako",
                DefaultExt = ".txt"
            };
            if (Dialog.ShowDialog() == true)
            {
                File.WriteAllText(Dialog.FileName, text, Encoding.UTF8);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}