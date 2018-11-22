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
            LEFT.Opacity = 0.5;
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
            if(a>9)
            {
                Text2.Content =Convert.ToString(a);
            }else
                Text2.Content = "0"+ Convert.ToString(a);

        }

        private void RIGHT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int a = Convert.ToInt32(Text2.Content);
            a++;
            if (a > 9)
            {
                Text2.Content = Convert.ToString(a);
            }
            else
                Text2.Content = "0" + Convert.ToString(a);
            LEFT.Opacity = 0.9;
        }

        private void LEFT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int a = Convert.ToInt32(Text2.Content);

            if (a > 1)
                a--;
            else { a = 1; }
            if (a == 1)
            { LEFT.Opacity = 0.5;}
            if (a > 9)
            {
                Text2.Content = Convert.ToString(a);
            }
            else
                Text2.Content = "0" + Convert.ToString(a);
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Genre1.Height = 70;
            Genre2.Height = 50;
            Genre3.Height = 50;
            Genre4.Height = 50;
            Genre5.Height = 50;
            Genre6.Height = 50;
            Genre7.Height = 50;
            Genre1.Width = 200;
            Genre2.Width = 180;
            Genre3.Width = 180;
            Genre4.Width = 180;
            Genre5.Width = 180;
            Genre6.Width = 180;
            Genre7.Width = 180;
        }

        private void Genre2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Genre1.Height = 50;
            Genre2.Height = 70;
            Genre3.Height = 50;
            Genre4.Height = 50;
            Genre5.Height = 50;
            Genre6.Height = 50;
            Genre7.Height = 50;
            Genre1.Width = 180;
            Genre2.Width = 200;
            Genre3.Width = 180;
            Genre4.Width = 180;
            Genre5.Width = 180;
            Genre6.Width = 180;
            Genre7.Width = 180;
        }

        private void Genre3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Genre1.Height = 50;
            Genre2.Height = 50;
            Genre3.Height = 70;
            Genre4.Height = 50;
            Genre5.Height = 50;
            Genre6.Height = 50;
            Genre7.Height = 50;
            Genre1.Width = 180;
            Genre2.Width = 180;
            Genre3.Width = 200;
            Genre4.Width = 180;
            Genre5.Width = 180;
            Genre6.Width = 180;
            Genre7.Width = 180;
        }

        private void Genre4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Genre1.Height = 50;
            Genre2.Height = 50;
            Genre3.Height = 50;
            Genre4.Height = 70;
            Genre5.Height = 50;
            Genre6.Height = 50;
            Genre7.Height = 50;
            Genre1.Width = 180;
            Genre2.Width = 180;
            Genre3.Width = 180;
            Genre4.Width = 200;
            Genre5.Width = 180;
            Genre6.Width = 180;
            Genre7.Width = 180;
        }

        private void Genre5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Genre1.Height = 50;
            Genre2.Height = 50;
            Genre3.Height = 50;
            Genre4.Height = 50;
            Genre5.Height = 70;
            Genre6.Height = 50;
            Genre7.Height = 50;
            Genre1.Width = 180;
            Genre2.Width = 180;
            Genre3.Width = 180;
            Genre4.Width = 180;
            Genre5.Width = 200;
            Genre6.Width = 180;
            Genre7.Width = 180;
        }

        private void Genre6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Genre1.Height = 50;
            Genre2.Height = 50;
            Genre3.Height = 50;
            Genre4.Height = 50;
            Genre5.Height = 50;
            Genre6.Height = 70;
            Genre7.Height = 50;
            Genre1.Width = 180;
            Genre2.Width = 180;
            Genre3.Width = 180;
            Genre4.Width = 180;
            Genre5.Width = 180;
            Genre6.Width = 200;
            Genre7.Width = 180;
        }

        private void Genre7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Genre1.Height = 50;
            Genre2.Height = 50;
            Genre3.Height = 50;
            Genre4.Height = 50;
            Genre5.Height = 50;
            Genre6.Height = 50;
            Genre7.Height = 70;
            Genre1.Width = 180;
            Genre2.Width = 180;
            Genre3.Width = 180;
            Genre4.Width = 180;
            Genre5.Width = 180;
            Genre6.Width = 180;
            Genre7.Width = 200;
        }
    }
}
