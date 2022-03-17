using Library;
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

namespace School.Frames
{
    /// <summary>
    /// Логика взаимодействия для GetCountDisease.xaml
    /// </summary>
    public partial class GetCountDisease : Page
    {
        public GetCountDisease()
        {
            InitializeComponent();
        }
        List<Mark> marks = new List<Mark>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                marks.Add(new Mark(Date.DisplayDate, CBox_Estimation.Text));
                LView_Marks.ItemsSource = null;
                LView_Marks.ItemsSource = marks;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(new Class1().GetCountDisease(marks).ToString());
        }
    }
}
