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
    /// Логика взаимодействия для PageWhile.xaml
    /// </summary>
    public partial class PageWhile : Page
    {
        public PageWhile()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            ClsFrame.frmObject.Navigate(new PageDoWhile());
        }
    }
}
