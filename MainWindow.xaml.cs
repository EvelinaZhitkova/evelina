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

namespace evelina
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

        private void buton1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = false;
            textBox1.Text = "Заблокирован";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = true;
            textBox1.Text = "Разблокирован";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gridon.Background = Brushes.Blue;
            textBox1.Visibility = Visibility.Hidden;
            buton1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;

        }
    }
}
