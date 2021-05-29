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

namespace Z7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Label label;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label = new Label() { Content = "TEST" };
            MyWrapPanel.Children.Add(label);
            MyWrapPanel.Children.OfType<Button>().Where(x => x.Content.ToString() == "Button");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyWrapPanel.Children.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            label.Content = "XAML";
        }
    }
}
