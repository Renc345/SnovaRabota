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

namespace MelegaPr9mdk.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDoWhile.xaml
    /// </summary>
    public partial class PageDoWhile : Page
    {
        public PageDoWhile()
        {
            InitializeComponent();
        }

        private void btnNext1_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.frmObject.Navigate(new PageFor());
        }

        private void btnCalculate1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.frmObject.Navigate(new PageWhile());
        }
    }
}
