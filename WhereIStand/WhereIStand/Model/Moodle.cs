using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WhereIStand.Model
{
    public class Moodle
    {
        private HtmlDocument doc;
        private List<assignment> assignmentsList = new List<assignment>();

        public List<assignment> AssignmentsList
        {
            get { return assignmentsList; }
            set { assignmentsList = value; }
        }

        private string moodleUrl = "http://isecal.000webhostapp.com/";

        public Moodle()
        {
            HtmlWeb web = new HtmlWeb();
            try
            {
                doc = web.Load(moodleUrl);
                getAssignments();
            }
            catch (Exception e)
            {
            }
        }

        private void getAssignments()
        {
            HtmlNode[] courses = doc.DocumentNode.SelectNodes("//p").ToArray();
            foreach (HtmlNode node in courses)
            {
                string courseName = node.SelectNodes(".//b")[0].InnerText;
                string assignmentsStr = node.ChildNodes[2].InnerText;
                string[] assignments = assignmentsStr.Replace("\r\n", "@").Split('@');
                foreach (string assign in assignments)
                {
                    if (assign.Trim() != "")
                    {
                        string[] assfull = assign.Split('-');
                        string nameAssign = assfull[0].Trim();
                        string[] date = assfull[1].Trim().Split('.');
                        DateTime dt = new DateTime(2017, Int32.Parse(date[1]), Int32.Parse(date[0]));
                        assignment ass = new assignment(courseName, dt, nameAssign);
                        assignmentsList.Add(ass);
                    }
                }
                Console.WriteLine(courseName);

            }
        }
    }
}