using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WhereIStand.Model
{
    internal class Moodle
    {
        private HtmlDocument doc;
        private string moodleUrl = "https://moodle2.bgu.ac.il/moodle/my/";

        public Moodle()
        {
            HtmlWeb web = new HtmlWeb();
            try
            {
                doc = web.Load(moodleUrl);
                getCourses();
            }
            catch (Exception e)
            {
            }
        }

        private void getCourses()
        {
            HtmlNode[] nodes = doc.DocumentNode.ChildNodes[2].ChildNodes[3].ChildNodes[20].ChildNodes[7].ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[2].ChildNodes[1].ChildNodes[1].ChildNodes.ToArray();
        }
    }
}