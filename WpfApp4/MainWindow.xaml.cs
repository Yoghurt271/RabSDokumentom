using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string Call;
        string write;
        string pathEx = @"D:\4.csv";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader reader = new StreamReader(pathEx, Encoding.Default))
            {
                Call = reader.ReadToEnd();
                TBox.Text = Call;

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (FileStream file = new FileStream(pathEx, FileMode.OpenOrCreate))
            {
                using (StreamWriter stream = new StreamWriter(file))
                {
                    write = TBox.Text;
                    stream.WriteLine(write);
                }
                
            }
        }
    }
}
