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

namespace ColorPicker
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ColorCanvas.Background = new SolidColorBrush(Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
        }

        private void ColorValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox kuldo = sender as TextBox;
                try
                {
                    int szin = int.Parse(kuldo.Text);
                    kuldo.Text = (szin > 255 ? 255 : szin).ToString();
                }
                catch
                {
                    kuldo.Text = 0.ToString();
                }
            }

        }

    }
}