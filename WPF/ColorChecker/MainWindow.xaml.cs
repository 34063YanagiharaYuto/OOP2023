using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }
        

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            byte r = (byte)rSlider.Value;
            byte g = (byte)gSlider.Value;
            byte b = (byte)bSlider.Value;
            colorArea.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            Color color = Color.FromRgb((byte)rSlider.Value,(byte)gSlider.Value,(byte)bSlider.Value);
            MyColor colors = new MyColor {
                Name = Name,
                Color = color
            };
            
        }

        private void cbColorList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = (MyColor)((ListBox)sender).SelectedItem;
            var colors = item.Color;
            rSlider.Value = colors.R;
            gSlider.Value = colors.G;
            bSlider.Value = colors.B;
        }
    }


    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }

        public override string ToString() {
            return " R: " + Color.R + " G: " + Color.G +  " B: " + Color.B;
        }
    }
    

    
}
