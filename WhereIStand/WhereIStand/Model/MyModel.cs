using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIStand.Model
{
    public class MyModel : INotifyPropertyChanged
    {
        private DateTime m_chooseDate;
        public Dictionary<string, List<assignment>> assDict;

        public DateTime ChooseDate
        {
            get { return m_chooseDate; }
            set { m_chooseDate = value; notifyPropertyChanged("chooseDate"); }
        }


        public MyModel()
        {
            assDict = new Dictionary<string, List<assignment>>();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void notifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public void setDayAssinment(DateTime dateTime)
        {
            //insert assinment for test
            DateTime dt1 = new DateTime(2017, 3, 27);
            assignment ass1 = new assignment("course1", dt1, "ass1");
            List<assignment> assList = new List<assignment>();
            assList.Add(ass1);
            string[] t = dt1.ToString().Split(' ');
            assDict.Add(t[0], assList);

            ChooseDate = dateTime;


        }

        public List<assignment> GetAssinment()
        {
            string[] assDate = m_chooseDate.ToString().Split(' ');
            return assDict[assDate[0]];
        }
    }
}