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
using WhereIStand.ViewModel;

namespace WhereIStand.View.Controls
{
    /// <summary>
    /// Interaction logic for MainPanel.xaml
    /// </summary>
    public partial class MainPanel : UserControl
    {
        private MyViewModel vm;
        public MainPanel(MyViewModel _vm)
        {
            vm = _vm;
            InitializeComponent();
        }

        private void connectClick(object sender, RoutedEventArgs e)
        {
            wb.Navigate(new Uri("https://moodle2.bgu.ac.il/moodle/login/index.php"));  // connect
            connectButton.Visibility = Visibility.Hidden;
        }
    }
}
