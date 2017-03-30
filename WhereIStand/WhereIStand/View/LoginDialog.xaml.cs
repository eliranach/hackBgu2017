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
using System.Windows.Shapes;
using WhereIStand.ViewModel;

namespace WhereIStand.View
{
    /// <summary>
    /// Interaction logic for LoginDialog.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        private MyViewModel vm;
        private bool isConnected = false;

        public LoginDialog(MyViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            //user exist and connected
            if (vm.connectUser(username.Text))
            {
                isConnected = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("The user " + username.Text + " does not exist");
            }
        }

        public string Username
        {
            get { return username.Text; }
        }

        public bool IsConnected
        {
            get { return isConnected; }
        }
    }
}