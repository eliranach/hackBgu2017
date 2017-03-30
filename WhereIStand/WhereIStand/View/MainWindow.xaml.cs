﻿using System;
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
            //Calendar cl = new Calendar();
            //Grid.SetRow(cl, 0);
            //Grid.SetColumn(cl, 0);
            //mainG.Children.Add(cl);
            Moodle moodle = new Moodle();
            loginControl = new Login(vm);
            mainG.Children.Add(loginControl);
            Thread t = new Thread(waitForConnect);
            t.Start();
        }

        public void waitForConnect()
        {
            while (!loginControl.UserConnected) ;
            //user connected
            this.Dispatcher.Invoke(() =>
            {
                loginControl.Visibility = Visibility.Hidden;
                MainPanel mp = new MainPanel(vm);
                mainG.Children.Add(mp);
            });

        }
    }
}