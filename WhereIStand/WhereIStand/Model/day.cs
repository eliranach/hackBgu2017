using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIStand.Model
{
    internal class Day
    {
        private SortedList<DateTime, assignment> dayAssignment;
        private DateTime _date;

        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Day(DateTime date)
        {
            _date = date;
            dayAssignment = new SortedList<DateTime, assignment>();
        }

        private void addAss(DateTime date, assignment ass)
        {
            dayAssignment.Add(date, ass);
        }
    }
}