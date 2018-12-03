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
        int a =50, b =180;
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }
        public void Genre()
        {
            Genre1.Height = a;
            Genre1.Width = b;
            /*
            Genre2.Height = a;
            Genre2.Width = b;
            Genre3.Height = a;
            Genre3.Width = b;
            Genre4.Height = a;
            Genre4.Width = b;
            Genre5.Height = a;
            Genre5.Width = b;
            Genre6.Height = a;
            Genre6.Width = b;
            Genre7.Height = a;
            Genre7.Width = b;*/
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

        private void Genre1_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre1.Height = 70;
            Genre1.Width = 200;
            Genre1.Background = new SolidColorBrush(Color.FromArgb(70, 191, 41, 41));

        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Rectangle1_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre11.Height = 70;
            Genre11.Width = 200;
            Genre12.Height = 70;
            Genre12.Width = 200;
        }

        private void Rectangle1_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre11.Height = a;
            Genre11.Width = b;
            Genre12.Height = a;
            Genre12.Width = b;
        }

        private void Rectangle2_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre21.Height = 70;
            Genre21.Width = 200;
            Genre22.Height = 70;
            Genre22.Width = 200;
        }

        private void Rectangle2_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre21.Height = a;
            Genre21.Width = b;
            Genre22.Height = a;
            Genre22.Width = b;
        }

        private void Rectangle3_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre31.Height = 70;
            Genre31.Width = 200;
            Genre32.Height = 70;
            Genre32.Width = 200;
        }

        private void Rectangle3_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre31.Height = a;
            Genre31.Width = b;
            Genre32.Height = a;
            Genre32.Width = b;
        }

        private void Rectangle3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Rectangle1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Basket1.Margin = new Thickness(0, -300, 0, 0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Basket2.Margin = new Thickness(0, -400, 0, 0);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Basket3.Margin = new Thickness(0, -500, 0, 0);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Basket4.Margin = new Thickness(0, -600, 0, 0);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Basket5.Margin = new Thickness(0, -700, 0, 0);
            
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MAIN.Visibility = Visibility.Hidden;
            LOG.Visibility = Visibility.Visible;
        }

        private void LogIn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LOG.Visibility = Visibility.Hidden;
            MAIN.Visibility = Visibility.Visible;
            LG.Text = "ЛОГІН";
            PW.Text = "ПАРОЛЬ";
            NICK.Visibility = Visibility.Hidden;
            RETURN.Visibility = Visibility.Hidden;
            NEW.Visibility = Visibility.Visible;
            NEW01.Visibility = Visibility.Visible;
            NEW02.Visibility = Visibility.Visible;
        }

        private void NEW_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NICK.Visibility = Visibility.Visible;
            RETURN.Visibility = Visibility.Visible;
            NEW.Visibility = Visibility.Hidden;
            NEW01.Visibility = Visibility.Hidden;
            NEW02.Visibility = Visibility.Hidden;
        }

        private void RETURN_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NICK.Visibility = Visibility.Hidden;
            RETURN.Visibility = Visibility.Hidden;
            NEW.Visibility = Visibility.Visible;
            NEW01.Visibility = Visibility.Visible;
            NEW02.Visibility = Visibility.Visible;

        }


        private void Genre1_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre1.Height = a;
            Genre1.Width = b;
        }
    }
}

