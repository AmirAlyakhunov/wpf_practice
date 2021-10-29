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

namespace WpfApp2
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
        private void result_btn_Click(object sender, RoutedEventArgs e)
        {
            answer.Text = null;
            if (string.IsNullOrEmpty(coord1.Text) || string.IsNullOrEmpty(coord2.Text) || string.IsNullOrEmpty(coord3.Text) || string.IsNullOrEmpty(coord4.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if ((coord1.Text.Length == 1 && (coord1.Text == "," || coord1.Text == "-")) || (coord2.Text.Length == 1 && (coord2.Text == "," || coord2.Text == "-")) || (coord3.Text.Length == 1 && (coord3.Text == "," || coord3.Text == "-")) || (coord4.Text.Length == 1 && (coord4.Text == ",")))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            else
            {
                float Shadow = 0;
                float Coord1 = float.Parse(coord1.Text);
                float Coord2 = float.Parse(coord2.Text);
                float Coord3 = float.Parse(coord3.Text);
                float Coord4 = float.Parse(coord4.Text);

                if (Coord1 > Coord2)
                {
                    float Vr = Coord1;
                    Coord1 = Coord2;
                    Coord2 = Vr;
                }
                if (Coord3 > Coord4)
                {
                    float Vr = Coord3;
                    Coord3 = Coord4;
                    Coord4 = Vr;
                }

                if (Coord3 > Coord1 && Coord4 > Coord2)
                {
                    if (Coord3 > Coord2)
                    {
                        Shadow = (Coord2 - Coord1) + (Coord4 - Coord3);
                    }
                    else
                    {
                        Shadow = (Coord4 - Coord1);
                    }
                }
                else if (Coord3 < Coord1 && Coord4 < Coord2)
                {
                    if (Coord1 > Coord4)
                    {
                        Shadow = (Coord2 - Coord1) + (Coord4 - Coord3);
                    }
                    else
                    {
                        Shadow = (Coord2 - Coord3);

                    }
                }
                else if (Coord3 <= Coord1 && Coord4 >= Coord2)
                {
                    Shadow = Coord4 - Coord3;
                }
                else if (Coord1 <= Coord3 && Coord2 >= Coord4)
                {
                    Shadow = Coord2 - Coord1;
                }
                answer.Text = Shadow.ToString();
            }
        }

        private void coord1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            string str = coord1.Text;
            string tmp = coord1.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            bool minus = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) || (ch == ',' && zapyataya) || (ch == '-' && minus))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                    if (ch == '-' || coord1.SelectionStart != 0)
                        minus = false;
                }
            coord1.Text = outS;
            coord1.SelectionStart = outS.Length;
        }

        private void coord1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,-]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void coord2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            string str = coord2.Text;
            string tmp = coord2.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            bool minus = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) || (ch == ',' && zapyataya) || (ch == '-' && minus))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                    if (ch == '-' || coord2.SelectionStart != 0)
                        minus = false;
                }
            coord2.Text = outS;
            coord2.SelectionStart = outS.Length;
        }

        private void coord2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,-]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void coord3_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            string str = coord3.Text;
            string tmp = coord3.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            bool minus = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) || (ch == ',' && zapyataya) || (ch == '-' && minus))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                    if (ch == '-' || coord3.SelectionStart != 0)
                        minus = false;
                }
            coord3.Text = outS;
            coord3.SelectionStart = outS.Length;
        }

        private void coord3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,-]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void coord4_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            string str = coord4.Text;
            string tmp = coord4.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            bool minus = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) || (ch == ',' && zapyataya) || (ch == '-' && minus))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                    if (ch == '-' || coord4.SelectionStart != 0)
                        minus = false;
                }
            coord4.Text = outS;
            coord4.SelectionStart = outS.Length;
        }

        private void coord4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,-]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }

}
