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

namespace School.Frames
{
    /// <summary>
    /// Логика взаимодействия для MinAVG.xaml
    /// </summary>
    public partial class MinAVG : Page
    {
        public MinAVG()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 SP = new Class1();
            MessageBox.Show(SP.MinAVG(TBox_Marks.Text.Split(new char[2] { ',', ' ' })).ToString());

        }
    }
}
