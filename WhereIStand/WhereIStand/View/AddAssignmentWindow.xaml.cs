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
using WhereIStand.Model;
using WhereIStand.ViewModel;

namespace WhereIStand.View
{
    /// <summary>
    /// Interaction logic for AddAssignmentWindow.xaml
    /// </summary>
    public partial class AddAssignmentWindow : Window
    {
        private MyViewModel vm;

        public AddAssignmentWindow(MyViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void saveClick(object sender, RoutedEventArgs e)
        {
            assignment ass = new assignment(courseNameTb.Text, datePicker.SelectedDate.Value.Date, assNameTb.Text);
            vm.VM_AssignmentList.Add(ass);
            this.Close();
        }
    }
}