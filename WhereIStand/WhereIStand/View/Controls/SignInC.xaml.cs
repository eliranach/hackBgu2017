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
    /// Interaction logic for SignInC.xaml
    /// </summary>
    public partial class SignInC : Window
    {
        private MyViewModel vm;

        public SignInC(MyViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
        }

        public string Username
        {
            get { return userNameTB.Text; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (vm.addUser(userNameTB.Text))
                this.Close();
            else
            {
                MessageBox.Show("The user " + userNameTB.Text + " already exist");
            }
        }
    }
}