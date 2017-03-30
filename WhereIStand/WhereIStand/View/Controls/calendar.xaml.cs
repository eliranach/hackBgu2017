using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WhereIStand;
using WhereIStand.Model;
using WhereIStand.ViewModel;

namespace WhereIStand.View.Controls
{

    /// <summary>
    /// Interaction logic for calendar.xaml
    /// </summary>
    public partial class calendar : UserControl
    {
        MyViewModel m_vm;
        private string VM_chooseDate;
        string m_selectedDate;
        List<assignment> currentAss;
        private readonly CalenderBackground background;

        public string ChooseDate
        {
            get { return VM_chooseDate; }
            set { VM_chooseDate = value; }
        }


        public calendar(MyViewModel vm)
        {
            InitializeComponent();
            m_vm = vm;
            background = new CalenderBackground(cl);
            background.AddOverlay("circle", "circle.png");
            background.AddOverlay("tjek", "tjek.png");
            background.AddOverlay("cross", "cross.png");
            background.AddOverlay("box", "box.png");
            background.AddOverlay("gray", "gray.png");
            cl.Background = background.GetBackground();
            // Update background when changing the shown month
            cl.DisplayDateChanged += KalenderOnDisplayDateChanged;
            currentAss = new List<assignment>();
            this.DataContext = vm;
            m_vm.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "VM_chooseDate")
                {
                    //currentAss = m_vm.getAssinment();
                    updateTask();
                    Console.ReadKey();
                }
            };
            fillCalendar();
        }

        private void fillCalendar()
        {
            foreach (assignment assign in m_vm.VM_AssignmentList)
            {
                DateTime dt = assign.assignmentDate;
                background.AddDate(dt, "circle");
            }
        }

        private void updateTask()
        {

        }

        private void KalenderOnDisplayDateChanged(object sender, CalendarDateChangedEventArgs calendarDateChangedEventArgs)
        {
            cl.Background = background.GetBackground();
        }

        private void Calendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            //string[] date = e.AddedItems[0].ToString().Split('/');
            //DateTime dateTime = new DateTime(2017, Int32.Parse(date[0]), Int32.Parse(date[1]));
            //m_vm.setDayAssinment(dateTime);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddAssignmentWindow assignmentW = new AddAssignmentWindow();
            assignmentW.Show();
        }
    }
}