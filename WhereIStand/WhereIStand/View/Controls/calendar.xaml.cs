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

        public string ChooseDate
        {
            get { return VM_chooseDate; }
            set { VM_chooseDate = value; }
        }





        public calendar(MyViewModel vm)
        {
            InitializeComponent();
            m_vm = vm;
            currentAss = new List<assignment>();
            this.DataContext = vm;
            m_vm.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == "VM_chooseDate")
                {
                    currentAss = m_vm.getAssinment();
                    updateTask();
                    Console.ReadKey();
                }
            };
        }

        private void updateTask()
        {
            List<string> assList = new List<string>();
            int counter = 1;
            //convert the assinments to string
            foreach (assignment ass in currentAss)
            {
                assList.Add(counter.ToString());
                assList.Add(ass.CourseName);
                assList.Add(ass.assName);
                listViewTasks.Items.Add(assList);
                assList.Clear();

            }

        }

        private void Calendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] date = e.AddedItems[0].ToString().Split('/');
            DateTime dateTime = new DateTime(2017, Int32.Parse(date[0]), Int32.Parse(date[1]));
            m_vm.setDayAssinment(dateTime);

        }
    }
}