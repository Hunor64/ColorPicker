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

        public void UpdateCanvas()
        {
            byte red = (byte)RedSlider.Value;
            byte green = (byte)GreenSlider.Value;
            byte blue = (byte)BlueSlider.Value;
            ColorCanvas.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateCanvas();
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateCanvas();
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateCanvas();
        }

        private void RedValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int red = int.Parse(RedValue.Text);
                if (red > 255)
                {
                    RedValue.Text = 255.ToString();
                }
                else
                {
                    RedValue.Text = red.ToString();
                }

            }
            catch
            {

                RedValue.Text = 0.ToString();
            }
        }

        private void GreenValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int green = int.Parse(GreenValue.Text);
                if (green > 255)
                {
                    GreenValue.Text = 255.ToString();
                }
                else
                {
                    GreenValue.Text = green.ToString();
                }

            }
            catch
            {

                GreenValue.Text = 0.ToString();
            }
        }

        private void BlueValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int blue = int.Parse(BlueValue.Text);
                if (blue > 255)
                {
                    BlueValue.Text = 255.ToString();
                }
                else
                {
                    BlueValue.Text = blue.ToString();
                }

            }
            catch
            {

                BlueValue.Text = 0.ToString();
            }
        }
    }
}