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

namespace class_interface
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Animal duck = new Animal(); // объект класса

            MessageBox.Show(duck.Swim()); 
            MessageBox.Show(duck.Fly()); // вызов методов
        }

        private void btn1_Copy_Click(object sender, RoutedEventArgs e)
        {
            Animal pigeon = new Animal(); // объект класса

            MessageBox.Show(pigeon.Fly()); // вызов методов
        }

        private void btn1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Animal fish = new Animal(); // объект класса

            MessageBox.Show(fish.Swim()); // вызов методов
        }
    }
}
