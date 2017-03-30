using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIStand.Model
{
    public class MyModel : INotifyPropertyChanged
    {
        public MyModel()
        {
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