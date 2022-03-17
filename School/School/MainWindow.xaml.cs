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
using Library;

namespace School
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //SP.GetCountDisease()
            InitializeComponent();
        }
        Class1 SP;
        private void Arrow_Click(object sender, RoutedEventArgs e)
        {
            if (Menu.Visibility == Visibility.Collapsed)
            {
                Menu.Visibility = Visibility.Visible;
                (sender as Button).Content = "^";
            }
            else
            {
                Menu.Visibility = Visibility.Collapsed;
                (sender as Button).Content = "v";
            }
        }
    }
}
