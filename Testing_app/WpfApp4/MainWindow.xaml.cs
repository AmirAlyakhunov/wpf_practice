using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            result_label.Content = null;
            if (string.IsNullOrEmpty(a_txtbox.Text) || string.IsNullOrEmpty(b_txtbox.Text) || string.IsNullOrEmpty(c_txtbox.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if ((a_txtbox.Text.Length == 1 && a_txtbox.Text == ",") || (b_txtbox.Text.Length == 1 && b_txtbox.Text == ",") || (c_txtbox.Text.Length == 1 && c_txtbox.Text == ","))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            else
            {
                double a = Convert.ToDouble(a_txtbox.Text);
                double b = Convert.ToDouble(b_txtbox.Text);
                double c = Convert.ToDouble(c_txtbox.Text);

                if (a==0 || b==0 || c==0)
                {
                    MessageBox.Show("Значения должны быть больше нуля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if ((a + b > c) && (a + c > b) && (c + b > a))
                    {
                        if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a))
                        {
                            result_label.Content = "Прямоугольный";
                        }
                        else if ((a * a > b * b + c * c) || (b * b > a * a + c * c) || (c * c > b * b + a * a))
                        {
                            result_label.Content = "Тупоугольный";
                        }
                        else
                        {
                            result_label.Content = "Остроугольный";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Треугольника не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
        
        private void a_txtbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void a_txtbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            string str = a_txtbox.Text;
            string tmp = a_txtbox.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) || (ch == ',' && zapyataya))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                }
            a_txtbox.Text = outS;
            a_txtbox.SelectionStart = outS.Length;
        }

        private void b_txtbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void b_txtbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            string str = b_txtbox.Text;
            string tmp = b_txtbox.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) || (ch == ',' && zapyataya))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                }
            b_txtbox.Text = outS;
            b_txtbox.SelectionStart = outS.Length;
        }

        private void c_txtbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void c_txtbox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            string str = c_txtbox.Text;
            string tmp = c_txtbox.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) || (ch == ',' && zapyataya))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                }
            c_txtbox.Text = outS;
            c_txtbox.SelectionStart = outS.Length;
        }
    }
}
