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
    /// Логика взаимодействия для GetStudNumber.xaml
    /// </summary>
    public partial class GetStudNumber : Page
    {
        public GetStudNumber()
        {
            InitializeComponent();
           // я не знаю откуда брать данные так что для примера сделал так
            CBox_Students.ItemsSource = new List<Students>() { new Students("2008", "a", "Сергеев Сергей Cергеевич"), new Students("2008", "a", "Иванов Иван Иванович"), new Students("2008", "a", "Дмитриев Дмитрий Дмитриевич"), new Students("2008", "a", "Алексеев Алексей Алексеевич"), new Students("2008", "a", "Колобков Александр Александрович"), new Students("2008", "a", "Олушин Владимир Владимирович"), };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 SP = new Class1();
            MessageBox.Show("Сгенерирован студентческий билет под номером: " + SP.GetStudNumber((CBox_Students.SelectedItem as Students).Year, (CBox_Students.SelectedItem as Students).Group, (CBox_Students.SelectedItem as Students).Fio));
        }
    }
}
