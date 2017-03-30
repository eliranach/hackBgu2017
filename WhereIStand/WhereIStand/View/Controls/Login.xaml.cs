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
using WhereIStand.ViewModel;

namespace WhereIStand.View.Controls
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private MyViewModel vm;
        private bool userConnected = false;

        public Login(MyViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            LoginDialog inputDialog = new LoginDialog(vm);
            inputDialog.Show();
            Thread t = new Thread(() =>
            {
                while (!inputDialog.IsConnected) ;
                //connected
                userConnected = true;
            });
            t.Start();
        }

        private void SignClick(object sender, RoutedEventArgs e)
        {
            SignInC signIn = new SignInC(vm);
            signIn.Show();
        }

        public bool UserConnected
        {
            get { return userConnected; }
        }
    }
}