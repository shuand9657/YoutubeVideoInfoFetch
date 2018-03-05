using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeVideoFetch
{
    public class xmlItem
    {
        private string _title;
        private string _description;
        private string _pubDate;
        private string _id;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string PubDate
        {
            get { return _pubDate; }
            set { _pubDate = value; }
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public xmlItem(string id,string title, string description, string pubDate)
        {
            ID = id;
            Title = title;
            Description = description;
            PubDate = pubDate;
        }

        public xmlItem()
        {
        }
    }
}
