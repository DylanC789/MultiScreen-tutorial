using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace multiscreen2
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void topage3(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }

       

        private void topage1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}
