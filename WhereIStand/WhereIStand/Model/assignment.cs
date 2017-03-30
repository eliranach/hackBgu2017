using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIStand.Model
{
    public class assignment
    {
        private string m_details;

        public string details
        {
            get { return m_details; }//
            set { m_details = value; }
        }

        private string m_courseName;
        public string CourseName
        {
            get { return m_courseName; }
            set { m_courseName = value; }
        }

        private DateTime m_assignmentDate;

        public DateTime assignmentDate
        {
            get { return m_assignmentDate; }
            set { m_assignmentDate = value; }
        }

        private string m_assName;

        public string assName
        {
            get { return m_assName; }
            set { m_assName = value; }
        }

        public assignment(string name, DateTime date, string AssigmentName)
        {
            m_courseName = name;
            m_assignmentDate = date;
            m_assName = AssigmentName;
        }


    }
}