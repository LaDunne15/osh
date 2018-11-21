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

namespace Проекта
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(Text2.Content);
            a++;
            Text2.Content = Convert.ToString(a);
        }

        private void RIGHT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int a = Convert.ToInt32(Text2.Content);
            a++;
            Text2.Content = Convert.ToString(a);
        }

        private void LEFT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int a = Convert.ToInt32(Text2.Content);
            
            if (a > 1)
                a--;
            else a=1;
            Text2.Content = Convert.ToString(a);
        }
    }
}
