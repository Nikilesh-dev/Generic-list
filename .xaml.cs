using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Generic_List
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Page1 page1= new Page1();
            frame.Content = page1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            frame.Content = page1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page2 page2 = new Page2();
            frame.Content = page2;
        }
    }
}
