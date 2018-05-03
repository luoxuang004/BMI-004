using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Slider1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HighrSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(HeighrSlider.Value, 1);
            HeightNumber.Text = value.ToString();

            double v = ((value / 200) * 320);
            Canvas.SetLeft(Height, v);
        }

        private void WeighrSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(WeighrSlider.Value, 1);
            WeightNumber.Text = value.ToString();

            double v = ((value / 200) * 320);
            Canvas.SetLeft(Weight, v);

            double h = double.Parse(HeightNumber.Text);
            double w = double.Parse(WeightNumber.Text);
            double bmi = w / Math.Pow((h / 100), 2);

            string[] parts = Math.Round(bmi, 1).ToString().Split('.');
        }
    }
}
