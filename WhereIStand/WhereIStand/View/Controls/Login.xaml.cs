﻿using System;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private MyViewModel vm;

        public Login(MyViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            LoginDialog inputDialog = new LoginDialog();
            if (inputDialog.ShowDialog() == true)
            {
            }
        }

        private void SignClick(object sender, RoutedEventArgs e)
        {
        }
    }
}