using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereIStand.Model;

namespace WhereIStand.ViewModel
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private MyModel model;

        public MyViewModel(MyModel model)
        {
            this.model = model;
            model.PropertyChanged += (sender, e) =>
            {
                notifyPropertyChanged("VM_" + e.PropertyName);
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void notifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        internal bool connectUser(string username)
        {
            return model.connectUser(username);
        }

        public bool addUser(string username)
        {
            return model.addUser(username);
        }

        private List<assignment> assignmentList;

        public List<assignment> VM_AssignmentList
        {
            get { return model.AssignmentList; }
            set { assignmentList = value; }
        }

    }
}