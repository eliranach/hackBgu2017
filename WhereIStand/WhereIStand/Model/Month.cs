using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace WhereIStand.Model
{
    internal class Month
    {
        private Dictionary<string, Day> monthAss;

        public Month()
        {
            monthAss = new Dictionary<string, Day>();
        }

        // public SortedList<> GetAssignmentDay(string day)
        //{
        //}
    }
}