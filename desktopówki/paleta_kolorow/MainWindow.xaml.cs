using System.Linq.Expressions;
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

namespace paleta_kolorow
{
    public partial class MainWindow : Window
    {
        private void GetValue(object sender, RoutedEventArgs e)
        {
            Slider slider = (Slider)sender;
            double value = slider.Value;
            string label_name = "value" + slider.Name[^1].ToString();
            switch (label_name)
            {
                case "valueR":
                    ValueR.Content = value;
                    break;
                case "valueG":
                    ValueG.Content = value;
                    break;
                case "valueB":
                    ValueB.Content = value;
                    break;
            }
            Color color = Color.FromArgb(255, (byte)SliderR.Value, (byte)SliderG.Value, (byte)SliderB.Value);
            Brush brush = new SolidColorBrush(color);
            CurrentColor.Fill = brush;

        }
        public void GetColor(object sender, RoutedEventArgs e)
        {
            byte R = (byte)SliderR.Value;
            byte G = (byte)SliderG.Value;
            byte B = (byte)SliderB.Value;

            ColorValues.Content = $"{R}, {G}, {B}";
            Color color = Color.FromArgb(255, R, G, B);
            Brush brush = new SolidColorBrush(color);
            ColorValues.Background = brush;

        }
        public MainWindow()
        {
            InitializeComponent();
        }

    }
}