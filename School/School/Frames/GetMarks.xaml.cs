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
    /// Логика взаимодействия для GetMarks.xaml
    /// </summary>
    public partial class GetMarks : Page
    {
        public GetMarks()
        {
            InitializeComponent();
        }
        Class1 SP;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SP = new Class1();
            LView_Marks.ItemsSource = SP.GetMarks(DateTime.Now, new List<Students>() { new Students("2008", "a", "Сергеев Сергей Cергеевич"), new Students("2008", "a", "Иванов Иван Иванович"), new Students("2008", "a", "Дмитриев Дмитрий Дмитриевич"), new Students("2008", "a", "Алексеев Алексей Алексеевич"), new Students("2008", "a", "Колобков Александр Александрович"), new Students("2008", "a", "Олушин Владимир Владимирович"), });

        }
    }
}
