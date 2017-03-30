using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WhereIStand.Model
{
    internal class Connector
    {
        private string moodleUrl = "https://moodle2.bgu.ac.il/moodle/my/";
        private HtmlDocument doc;

        public Connector()
        {
            //connect to the main moodle page
            try
            {
                HtmlWeb web = new HtmlWeb();
                doc = web.Load(moodleUrl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            getCourses();
        }

        private void getCourses()
        {
            throw new NotImplementedException();
        }
    }
}