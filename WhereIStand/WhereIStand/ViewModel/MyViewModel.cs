using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereIStand.Model;

namespace WhereIStand.ViewModel
{
    class MyViewModel : INotifyPropertyChanged
    {
        MyModel model;
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
    }
}
