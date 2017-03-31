using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIStand.Model
{
    public class MyModel : INotifyPropertyChanged
    {
        private DateTime m_chooseDate;
        private Moodle moodle;
        private ObservableCollection<assignment> assignmentList;

        public ObservableCollection<assignment> AssignmentList
        {
            get { return moodle.AssignmentsList; }
            set { assignmentList = value; }
        }

        public Dictionary<string, List<assignment>> assDict;

        public DateTime ChooseDate
        {
            get { return m_chooseDate; }
            set { m_chooseDate = value; notifyPropertyChanged("chooseDate"); }
        }

        public MyModel()
        {
            assDict = new Dictionary<string, List<assignment>>();
            moodle = new Moodle();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void notifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public bool addUser(string username)
        {
            if (!Directory.Exists(username))
            {
                Directory.CreateDirectory(username);
                return true;
            }
            return false;
        }

        public bool connectUser(string username)
        {
            if (!Directory.Exists(username))
            {
                return false;
            }
            //take the data
            return true;
        }
    }
}