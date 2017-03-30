using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using WhereIStand.Model;
using WhereIStand.View;
using WhereIStand.View.Controls;
using WhereIStand.ViewModel;

namespace WhereIStand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyViewModel vm;
        private Login loginControl;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MyViewModel(new Model.MyModel());
            this.DataContext = vm;
            calendar cal = new calendar(vm);
            mainG.Children.Add(cal);
        }
    }
}