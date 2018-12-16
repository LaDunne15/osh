﻿using System;
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
using System.Data.SqlClient;

namespace Проекта
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Proekta;Integrated Security=True";
        ListBook list = new ListBook();
        int onlineGenre = 1;
        public void Write(int write)
        {
            if(write == 0)
            {
                Book1.Visibility = Visibility.Hidden;
                Book2.Visibility = Visibility.Hidden;
                Book3.Visibility = Visibility.Hidden;
                Book4.Visibility = Visibility.Hidden;
                Book5.Visibility = Visibility.Hidden;
            }
            if (write == 1)
            {
                Book1.Visibility = Visibility.Visible;
                Book2.Visibility = Visibility.Hidden;
                Book3.Visibility = Visibility.Hidden;
                Book4.Visibility = Visibility.Hidden;
                Book5.Visibility = Visibility.Hidden;
            }
            if (write == 2)
            {
                Book1.Visibility = Visibility.Visible;
                Book2.Visibility = Visibility.Visible;
                Book3.Visibility = Visibility.Hidden;
                Book4.Visibility = Visibility.Hidden;
                Book5.Visibility = Visibility.Hidden;
            }
            if (write == 3)
            {
                Book1.Visibility = Visibility.Visible;
                Book2.Visibility = Visibility.Visible;
                Book3.Visibility = Visibility.Visible;
                Book4.Visibility = Visibility.Hidden;
                Book5.Visibility = Visibility.Hidden;
            }
            if (write == 4)
            {
                Book1.Visibility = Visibility.Visible;
                Book2.Visibility = Visibility.Visible;
                Book3.Visibility = Visibility.Visible;
                Book4.Visibility = Visibility.Visible;
                Book5.Visibility = Visibility.Hidden;
            }
            if (write == 5)
            {
                Book1.Visibility = Visibility.Visible;
                Book2.Visibility = Visibility.Visible;
                Book3.Visibility = Visibility.Visible;
                Book4.Visibility = Visibility.Visible;
                Book5.Visibility = Visibility.Visible;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            LEFT.Opacity = 0.5;
            gr.Content = "Видалити\nкнигу\nіз бази";
        }
        int a =40, b =180;
        int LOGlever = 1;
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
            if(list.cou(onlineGenre)/5+1==a)
            { RIGHT.Opacity = 0.9; }
               else
            a++;
            if (a > 9)
            {
                Text2.Content = Convert.ToString(a);
            }
            else
                Text2.Content = "0" + Convert.ToString(a);
            LEFT.Opacity = 0.9;
            Releaze();
        }

        private void LEFT_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int a = Convert.ToInt32(Text2.Content);
            if (list.cou(onlineGenre)/5+1!= a)
                RIGHT.Opacity = 0.9;
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
            Releaze();
        }


        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

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
            
            if(LOGlever == 2)
            {
                if (PW.Text == PW_2.Text)
                {
                    string script = "INSERT INTO LOGIN (Nickname,Login,Password) VALUES ('" + NICK.Text + "','" + LG.Text + "','" + PW.Text + "')"; 
            LOG.Visibility = Visibility.Hidden;
            MAIN.Visibility = Visibility.Visible;
            NICK.Visibility = Visibility.Hidden;
            RETURN.Visibility = Visibility.Hidden;
            NEW.Visibility = Visibility.Visible;
            NEW01.Visibility = Visibility.Visible;
            NEW02.Visibility = Visibility.Visible;
            LOGIN02.Content = "Вхід";
            PW_2.Visibility = Visibility.Hidden;
            LOGlever = 1;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(script, connection);
                        command.ExecuteNonQuery();
                    }
                }
                else
                    MessageBox.Show("Паролі не cпівпадають!");
                    
            }
        }

        private void NEW_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NICK.Visibility = Visibility.Visible;
            RETURN.Visibility = Visibility.Visible;
            NEW.Visibility = Visibility.Hidden;
            NEW01.Visibility = Visibility.Hidden;
            NEW02.Visibility = Visibility.Hidden;
            PW_2.Visibility = Visibility.Visible;
            PW_1.Visibility = Visibility.Visible;
            NICK1.Visibility = Visibility.Visible;
            LOGIN02.Content = "NEW";
            LOGlever = 2;
        }

        private void RETURN_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NICK.Visibility = Visibility.Hidden;
            RETURN.Visibility = Visibility.Hidden;
            NEW.Visibility = Visibility.Visible;
            NEW01.Visibility = Visibility.Visible;
            NEW02.Visibility = Visibility.Visible;
            PW_2.Visibility = Visibility.Hidden;

            PW_1.Visibility = Visibility.Hidden;
            NICK1.Visibility = Visibility.Hidden;
            LOGIN02.Content = "Вхід";
            LOGlever = 1;
        }

        private void NICK_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NICK.Clear();
        }

        private void PW_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PW_2.Text = "";
        }

        private void LG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LG.Text = "";
        }

        private void PW_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PW.Text = "";
        }

        private void LG_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void NICK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            NICK.Text = string.Empty;
        }

        private void LG_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        public void Releaze()
        {
            list.Lista.Clear();
            string b = "SELECT * FROM Books";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(b, connection);
                SqlDataReader CC = command.ExecuteReader();

                if (CC.HasRows)
                {
                    while (CC.Read())
                    {
                        object x1 = CC.GetValue(0);
                        object x2 = CC.GetValue(1);
                        object x3 = CC.GetValue(2);
                        object x4 = CC.GetValue(3);
                        object x5 = CC.GetValue(4);
                        list.Lista.Add(new Book(Convert.ToString(x1), Convert.ToString(x2), Convert.ToDouble(x3), Convert.ToString(x4), Convert.ToInt32(x5)));
                    }
                }
            }
            ListBook G1 = new ListBook(list.OneTypeBooks(onlineGenre));
            int i = Convert.ToInt32(Text2.Content) - 1;
            if (G1.Lista.Count - i * 5 >= 5)
            {
                Write(5);
                Book_One1.Content = G1.Lista[i * 5 + 0].Name;
                Book_One2.Content = G1.Lista[i * 5 + 0].Author;
                Book_One3.Content = G1.Lista[i * 5 + 0].price;
                Book_Two1.Content = G1.Lista[i * 5 + 1].Name;
                Book_Two2.Content = G1.Lista[i * 5 + 1].Author;
                Book_Two3.Content = G1.Lista[i * 5 + 1].price;
                Book_Three1.Content = G1.Lista[i * 5 + 2].Name;
                Book_Three2.Content = G1.Lista[i * 5 + 2].Author;
                Book_Three3.Content = G1.Lista[i * 5 + 2].price;
                Book_Four1.Content = G1.Lista[i * 5 + 3].Name;
                Book_Four2.Content = G1.Lista[i * 5 + 3].Author;
                Book_Four3.Content = G1.Lista[i * 5 + 3].price;
                Book_Five1.Content = G1.Lista[i * 5 + 4].Name;
                Book_Five2.Content = G1.Lista[i * 5 + 4].Author;
                Book_Five3.Content = G1.Lista[i * 5 + 4].price;
            }
            else
            {
                if (G1.Lista.Count - i * 5 == 0)
                {
                    Write(0);
                }
                if (G1.Lista.Count - i * 5 == 1)
                {
                    Write(1);
                    Book_One1.Content = G1.Lista[i * 5 + 0].Name;
                    Book_One2.Content = G1.Lista[i * 5 + 0].Author;
                    Book_One3.Content = G1.Lista[i * 5 + 0].price;
                }
                if (G1.Lista.Count - i * 5 == 2)
                {
                    Write(2);
                    Book_One1.Content = G1.Lista[i * 5 + 0].Name;
                    Book_One2.Content = G1.Lista[i * 5 + 0].Author;
                    Book_One3.Content = G1.Lista[i * 5 + 0].price;
                    Book_Two1.Content = G1.Lista[i * 5 + 1].Name;
                    Book_Two2.Content = G1.Lista[i * 5 + 1].Author;
                    Book_Two3.Content = G1.Lista[i * 5 + 1].price;
                }
                if (G1.Lista.Count - i * 5 == 3)
                {
                    Write(3);
                    Book_One1.Content = G1.Lista[i * 5 + 0].Name;
                    Book_One2.Content = G1.Lista[i * 5 + 0].Author;
                    Book_One3.Content = G1.Lista[i * 5 + 0].price;
                    Book_Two1.Content = G1.Lista[i * 5 + 1].Name;
                    Book_Two2.Content = G1.Lista[i * 5 + 1].Author;
                    Book_Two3.Content = G1.Lista[i * 5 + 1].price;
                    Book_Three1.Content = G1.Lista[i * 5 + 2].Name;
                    Book_Three2.Content = G1.Lista[i * 5 + 2].Author;
                    Book_Three3.Content = G1.Lista[i * 5 + 2].price;
                }
                if (G1.Lista.Count - i * 5 == 4)
                {
                    Write(4);
                    Book_One1.Content = G1.Lista[i * 5 + 0].Name;
                    Book_One2.Content = G1.Lista[i * 5 + 0].Author;
                    Book_One3.Content = G1.Lista[i * 5 + 0].price;
                    Book_Two1.Content = G1.Lista[i * 5 + 1].Name;
                    Book_Two2.Content = G1.Lista[i * 5 + 1].Author;
                    Book_Two3.Content = G1.Lista[i * 5 + 1].price;
                    Book_Three1.Content = G1.Lista[i * 5 + 2].Name;
                    Book_Three2.Content = G1.Lista[i * 5 + 2].Author;
                    Book_Three3.Content = G1.Lista[i * 5 + 2].price;
                    Book_Four1.Content = G1.Lista[i * 5 + 3].Name;
                    Book_Four2.Content = G1.Lista[i * 5 + 3].Author;
                    Book_Four3.Content = G1.Lista[i * 5 + 3].price;
                }
            }
        }

        private void Genre1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 1;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre1_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre11.Height = 50;
            Genre11.Width = 200;
            Genre12.Height = 50;
            Genre12.Width = 200;
        }
        private void Genre1_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre11.Height = a;
            Genre11.Width = b;
            Genre12.Height = a;
            Genre12.Width = b;
        }
        private void Genre2_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre21.Height = 50;
            Genre21.Width = 200;
            Genre22.Height = 50;
            Genre22.Width = 200;
        }

        private void Genre2_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre21.Height = a;
            Genre21.Width = b;
            Genre22.Height = a;
            Genre22.Width = b;
        }

        private void Genre3_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre31.Height = 50;
            Genre31.Width = 200;
            Genre32.Height = 50;
            Genre32.Width = 200;
        }

        private void Genre3_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre31.Height = a;
            Genre31.Width = b;
            Genre32.Height = a;
            Genre32.Width = b;
        }

        private void Genre3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 3;
            Text2.Content = "01";
            Releaze();
        }

        private void Book_CreateBook_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try { }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректну ціну!");
            }
            finally
            {
                if (Book_Genre.Text != "" || Book_About.Text != "" || Book_Author.Text != "" || Book_Name.Text != "")
                {
                    string script = "INSERT INTO Books VALUES ('" + Book_Name.Text + "','" + Book_Author.Text + "','" + Book_Price.Text + "','" + Book_About.Text + "'," + SearchingNumGenre() + ")";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(script, connection);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show( Book_Name.Text+" ("+Book_Author.Text+") - додано!");
                    Book_About.Text = "";
                    Book_Author.Text = "";
                    Book_Genre.Text = "";
                    Book_Price.Text = "";
                    Book_Name.Text = "";
                }
                else
                    MessageBox.Show("Заповніть всі поля!");
            }
        }

        private void Exit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AddBook.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
        }
            

        public int SearchingNumGenre()
        {   ComboBoxItem selectedItem = (ComboBoxItem)Book_Genre.SelectedItem;
            string localVar = selectedItem.Content.ToString();
            int s=-1;
            switch(localVar)
            {
                case "Бізнес і інвестиції": return 1;
                case "Біографії і мемуари": return 2;
                case "Детективи і триллери": return 3;
                case "Для дітей": return 4;
                case "Здоров'я і спорт": return 5;
                case "Історія": return 6;
                case "Комп'ютери і технології": return 7;
                case "Кулінарія і домашнє господарство": return 8;
                case "Романи": return 9;
                case "Фантастика і фентезі": return 10;
                case "Художня література": return 11;
                default: return -1;
            }
        }

        private void ADD_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AddBook.Visibility = Visibility.Visible;
        }
        private void cking(object sender, MouseButtonEventArgs e)
        {
            ((Rectangle)sender).Fill= new SolidColorBrush(Colors.LightBlue);
        }

        private void Genre4_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre41.Height = 50;
            Genre41.Width = 200;
            Genre42.Height = 50;
            Genre42.Width = 200;
        }

        private void Genre4_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre41.Height = a;
            Genre41.Width = b;
            Genre42.Height = a;
            Genre42.Width = b;
        }

        private void Genre5_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre51.Height = 50;
            Genre51.Width = 200;
            Genre52.Height = 50;
            Genre52.Width = 200;
        }

        private void Genre5_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre51.Height = a;
            Genre51.Width = b;
            Genre52.Height = a;
            Genre52.Width = b;
        }
        private void Genre6_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre61.Height = 50;
            Genre61.Width = 200;
            Genre62.Height = 50;
            Genre62.Width = 200;
        }

        private void Genre6_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre61.Height = a;
            Genre61.Width = b;
            Genre62.Height = a;
            Genre62.Width = b;
        }
        private void Genre7_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre71.Height = 50;
            Genre71.Width = 200;
            Genre72.Height = 50;
            Genre72.Width = 200;
        }

        private void Genre7_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre71.Height = a;
            Genre71.Width = b;
            Genre72.Height = a;
            Genre72.Width = b;
        }
        private void Genre8_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre81.Height = 50;
            Genre81.Width = 200;
            Genre82.Height = 50;
            Genre82.Width = 200;
        }

        private void Genre8_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre81.Height = a;
            Genre81.Width = b;
            Genre82.Height = a;
            Genre82.Width = b;
        }
        private void Genre9_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre91.Height = 50;
            Genre91.Width = 200;
            Genre92.Height = 50;
            Genre92.Width = 200;
        }

        private void Genre9_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre91.Height = a;
            Genre91.Width = b;
            Genre92.Height = a;
            Genre92.Width = b;
        }
        private void Genre10_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre101.Height = 50;
            Genre101.Width = 200;
            Genre102.Height = 50;
            Genre102.Width = 200;
        }

        private void Genre10_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre101.Height = a;
            Genre101.Width = b;
            Genre102.Height = a;
            Genre102.Width = b;
        }
        private void Genre1111_MouseEnter(object sender, MouseEventArgs e)
        {
            Genre111.Height = 50;
            Genre111.Width = 200;
            Genre112.Height = 50;
            Genre112.Width = 200;
        }

        private void Genre1111_MouseLeave(object sender, MouseEventArgs e)
        {
            Genre111.Height = a;
            Genre111.Width = b;
            Genre112.Height = a;
            Genre112.Width = b;
        }

        private void DeleteBook_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            del.Visibility = Visibility.Visible;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            del.Visibility = Visibility.Hidden;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string script = "DELETE FROM Books WHERE Name='" +deleteBook.Text+"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(script, connection);
                command.ExecuteNonQuery();
            }
            MessageBox.Show(deleteBook.Text+" - видалено!");
            del.Visibility = Visibility.Hidden;
        }

        private void Genre4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 4;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 5;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 6;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 7;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 8;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 9;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 10;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 11;
            Text2.Content = "01";
            Releaze();
        }

        private void Genre2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            onlineGenre = 2;
            Text2.Content = "01";
            Releaze();
        }

    }
}

