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
using System.Data.SqlClient;

namespace Проекта
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int ClearAll(string Al)
        {
            string A="";
            for (int ii = 5; ii < Al.Length; ii++)
                A += Al[ii];
            return Convert.ToInt32(A)/10;
        }
        public int FourthCh(string Al)
        {
            return Convert.ToInt32(Al[4]+"");
        }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Proekta;Integrated Security=True";
        ListBook list = new ListBook();
        List<Book> BBook = new List<Book> { };
        ListAcc listAcc = new ListAcc();
        string Name;
        int onlineGenre = 1;
        int sort = 0;

        private void Uppp(object sender, MouseEventArgs e)
        {
            ((Rectangle)sender).Height = 50;
            ((Rectangle)sender).Width = 200;
        }

        private void RC(object sender, MouseEventArgs e)
        {
            BookINFO.Visibility = Visibility.Visible;
            RReleaze(FourthCh(((Rectangle)sender).Name));
        }
        private void LC(object sender, MouseEventArgs e)
        {
            ListBook G1 = new ListBook(list.OneTypeBooks(onlineGenre));
            if (BBook.Count < 5)
            {
                BBook.Add(G1.Lista[(FromFourth(((Rectangle)sender).Name))]);
                    }
            else
                MessageBox.Show("Корзина повна");
            Repaing(BBook.Count);
            Releaze1();
        }
        private int  FromFourth(string a)
        {
            string A = "";
            for (int i = 4; i < a.Length; i++)
                A += a[i];
            return Convert.ToInt32(A);
        }
        private void Dooo(object sender, MouseEventArgs e)
        {
            ((Rectangle)sender).Height = 40;
            ((Rectangle)sender).Width = 180;
        }
        private void GGGO(object sender, MouseEventArgs e)
        {
            onlineGenre = ClearAll(((Rectangle)sender).Name);
            Releaze();
        }
        public MainWindow()
        {
            InitializeComponent();
            gr.Content = "Видалити\nкнигу\nіз бази";
            Repaing(0);
        }
        int a =40, b =180;
        int LOGlever = 1;
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
            if(LOGlever == 1)
            {
                list.Lista.Clear();
                if (listAcc.SearchAcc(LG.Text,PW.Text))
                {
                    LG.Text = "";
                    PW.Text = "";
                    PW_2.Visibility = Visibility.Hidden;
                    NICK.Visibility = Visibility.Hidden;
                    NICK1.Visibility = Visibility.Hidden;
                    PW_1.Visibility = Visibility.Hidden;
                    LOG.Visibility = Visibility.Hidden;
                    MAIN.Visibility = Visibility.Visible;
                    if (Name != "admin")
                    {
                        A.Visibility = Visibility.Hidden;
                        ADD.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        A.Visibility = Visibility.Visible;
                        ADD.Visibility = Visibility.Visible;
                    }
                    congr.Content = "Вас обслуговує " + Name;
                }
                else
                    MessageBox.Show("Акаунт не знайдено!");
            }
            else
            {
                if (PW.Text == PW_2.Text)
                {
                    string script = "INSERT INTO LOGIN (Nickname,Login,Password) VALUES ('" + NICK.Text + "','" + LG.Text + "','" + PW.Text + "')"; 
            LOG.Visibility = Visibility.Hidden;
            MAIN.Visibility = Visibility.Visible;
            NICK.Visibility = Visibility.Hidden;
            PW_1.Visibility = Visibility.Hidden;
            NICK1.Visibility = Visibility.Hidden;
            NICK.Text = "";
            LG.Text = "";
            PW.Text = "";
            PW_2.Text = "";
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
        public string GenreStr(int a)
        {
            switch(a)
                {
                case 1: return "Бізнес і інвестиції";
                case 2: return "Біографії і мемуари";
                case 3:  return "Детективи і триллери";
                case 4: return "Для дітей";
                case 5: return  "Здоров'я і спорт";
                case 6: return "Історія";
                case 7: return  "Комп'ютери і технології";
                case 8: return "Кулінарія і домашнє господарство";
                case 9: return "Романи";
                case 10:return "Фантастика і фентезі";
                case 11: return "Художня література";
                default: return "Невідомий жанр";
            }
        }
        public void RReleaze(int ir)
        {
            string b;
            if (sort == 1)
                b = "SELECT * FROM Books order by Price";
            else
                b = "SELECT * FROM Books order by Name";
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
            int i =  1;
            I1.Content = G1.Lista[i * 5 + ir].Name;
            I2.Content = G1.Lista[i * 5 + ir].Author;
            I3.Content = G1.Lista[i * 5 + ir].price + "₴";
            I4.Content = G1.Lista[i * 5 + ir].About;
            I5.Content = GenreStr(G1.Lista[i * 5 + ir].Genre);
        }
        public void Releaze()
        {
            Tovari.Children.Clear();
            list.Lista.Clear();
            string b;
            if (sort == 1)
                b = "SELECT * FROM Books order by Price";
            else
                b = "SELECT * FROM Books order by Name";
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
            foreach (var j in G1.Lista)
            {
                AddBooks(j);
            }
        }
        public void AddBooks(Book A) {
            Grid x = new Grid();
            x.Margin = new Thickness(10, 0, 0, 0);
            x.Height = 85;
            Rectangle a1 = new Rectangle();
            a1.Style = FindResource("BName") as Style;
            Label b1 = new Label();
            b1.Content = A.Name;
            b1.Name ="Nam_"+Tovari.Children.Count;
            b1.Style = FindResource("BNAME") as Style;
            Label b2 = new Label();
            b2.Content = A.Author;
            b1.Name = "Aut_" + Tovari.Children.Count;
            b2.Style = FindResource("BAUTHOR") as Style;
            Label b3 = new Label();
            b3.Style = FindResource("PRICE") as Style;
            b3.Content = A.price + "₴";
            b1.Name = "Pri_" + Tovari.Children.Count;
            Rectangle a2 = new Rectangle();
            a2.Name = "Book" + (Tovari.Children.Count ) ;
            a2.Style = FindResource("BNameBUT") as Style;
            x.Children.Add(a1);
            x.Children.Add(b1);
            x.Children.Add(b2);
            x.Children.Add(b3);
            x.Children.Add(a2);
            Tovari.Children.Add(x);
        }
           
        public void Releaze1()
        {
            if (BBook.Count== 5)
            {
                Repaing(5);
                B11.Content = BBook[0].Name;
                B12.Content = BBook[0].Author;
                B13.Content = BBook[0].price + "₴";
                B21.Content = BBook[1].Name;
                B22.Content = BBook[1].Author;
                B23.Content = BBook[1].price + "₴";
                B31.Content = BBook[2].Name;
                B32.Content = BBook[2].Author;
                B33.Content = BBook[2].price + "₴";
                B41.Content = BBook[3].Name;
                B42.Content = BBook[3].Author;
                B43.Content = BBook[3].price + "₴";
                B51.Content = BBook[4].Name;
                B52.Content = BBook[4].Author;
                B53.Content = BBook[4].price + "₴";
            }
            if (BBook.Count == 4)
            {
                Repaing(4);
                B11.Content = BBook[0].Name;
                B12.Content = BBook[0].Author;
                B13.Content = BBook[0].price + "₴";
                B21.Content = BBook[1].Name;
                B22.Content = BBook[1].Author;
                B23.Content = BBook[1].price + "₴";
                B31.Content = BBook[2].Name;
                B32.Content = BBook[2].Author;
                B33.Content = BBook[2].price + "₴";
                B41.Content = BBook[3].Name;
                B42.Content = BBook[3].Author;
                B43.Content = BBook[3].price + "₴";
            }
            if (BBook.Count == 3)
            {
                Repaing(3);
                B11.Content = BBook[0].Name;
                B12.Content = BBook[0].Author;
                B13.Content = BBook[0].price + "₴";
                B21.Content = BBook[1].Name;
                B22.Content = BBook[1].Author;
                B23.Content = BBook[1].price + "₴";
                B31.Content = BBook[2].Name;
                B32.Content = BBook[2].Author;
                B33.Content = BBook[2].price + "₴";
            }
            if (BBook.Count == 2)
            {
                Repaing(2);
                B11.Content = BBook[0].Name;
                B12.Content = BBook[0].Author;
                B13.Content = BBook[0].price + "₴";
                B21.Content = BBook[1].Name;
                B22.Content = BBook[1].Author;
                B23.Content = BBook[1].price + "₴";
            }
            if (BBook.Count == 1)
            {
                Repaing(1);
                B11.Content = BBook[0].Name;
                B12.Content = BBook[0].Author;
                B13.Content = BBook[0].price + "₴";
            }
            double sum = 0;
            foreach(Book i in BBook)
            {
                sum += i.price;
            }
            SUM.Content = sum + "₴";
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

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            BBook.Remove(BBook[1]);
            Releaze1();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (BBook.Count == 0)
                Basket1.Margin = new Thickness(0, -1500, 0, 0);
            else
            {
                BBook.Remove(BBook[0]);
            }
            Releaze1();
        }
        public void Repaing(int write)
        {
            if (write == 0)
            {
                Basket1.Margin = new Thickness(0, -1500, 0, 0);
                Basket2.Margin = new Thickness(0, -1500, 0, 0);
                Basket3.Margin = new Thickness(0, -1500, 0, 0);
                Basket4.Margin = new Thickness(0, -1500, 0, 0);
                Basket5.Margin = new Thickness(0, -1500, 0, 0);
            }
            if (write == 1)
            {
                Basket1.Margin = new Thickness();
                Basket2.Margin = new Thickness(0, -1500, 0, 0);
                Basket3.Margin = new Thickness(0, -1500, 0, 0);
                Basket4.Margin = new Thickness(0, -1500, 0, 0);
                Basket5.Margin = new Thickness(0, -1500, 0, 0);
            }
            if (write == 2)
            {
                Basket1.Margin = new Thickness();
                Basket2.Margin = new Thickness();
                Basket3.Margin = new Thickness(0, -1500, 0, 0);
                Basket4.Margin = new Thickness(0, -1500, 0, 0);
                Basket5.Margin = new Thickness(0, -1500, 0, 0);
            }
            if (write == 3)
            {
                Basket1.Margin = new Thickness();
                Basket2.Margin = new Thickness();
                Basket3.Margin = new Thickness();
                Basket4.Margin = new Thickness(0, -1500, 0, 0);
                Basket5.Margin = new Thickness(0, -1500, 0, 0);
            }
            if (write == 4)
            {
                Basket1.Margin = new Thickness();
                Basket2.Margin = new Thickness();
                Basket3.Margin = new Thickness();
                Basket4.Margin = new Thickness();
                Basket5.Margin = new Thickness(0, -1500, 0, 0);
            }
            if (write == 5)
            {
                Basket1.Margin = new Thickness();
                Basket2.Margin = new Thickness();
                Basket3.Margin = new Thickness();
                Basket4.Margin = new Thickness();
                Basket5.Margin = new Thickness();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            BBook.Remove(BBook[2]);
            Releaze1();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            BBook.Remove(BBook[3]);
            Releaze1();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            BBook.Remove(BBook[4]);
            Releaze1();
        }

        private void END_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Замовлення оформлено!");
            BBook.Clear();
            Repaing(0);
            Releaze1();
        }

        private void sort1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sort = 1;
            Releaze();
        }

        private void sort2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sort = 2;
            Releaze();
        }

        private void Exit1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BookINFO.Visibility = Visibility.Hidden;
        }
        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Acc.Visibility = Visibility.Visible;
            if (Name == "admin")
            {
                _1.IsEnabled = false;
                NEWLOG.IsEnabled = false;
            }
            else
            {
                _1.IsEnabled = true;
                NEWLOG.IsEnabled = true;
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string b = "UPDATE LOGIN SET Login='" + NEWLOG.Text+"' WHERE Nickname='"+Name+"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(b, connection);
                command.ExecuteNonQuery();
            }
            NEWLOG.Text = "";
            listAcc.CHLogin(Name,NEWLOG.Text);
        }

        private void Exit2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Acc.Visibility = Visibility.Hidden;
            NEWPASS.Text = "";
            NEWLOG.Text = "";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            string b = "UPDATE LOGIN SET Password='" + NEWPASS.Text + "' WHERE Nickname='" + Name+"'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(b, connection);
                command.ExecuteNonQuery();
            }
            NEWPASS.Text = "";
            listAcc.CHPass(Name, NEWPASS.Text);
        }

        private void Button_Click_655(object sender, RoutedEventArgs e)
        {
            delacc.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1455(object sender, RoutedEventArgs e)
        {
            delacc.Visibility = Visibility.Visible;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_755(object sender, RoutedEventArgs e)
        {
            string b = "DELETE LOGIN WHERE Nickname='" + Name + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(b, connection);
                command.ExecuteNonQuery();
            }
            NEWPASS.Text = "";
            delacc.Visibility = Visibility.Hidden;
        }
    }
}

