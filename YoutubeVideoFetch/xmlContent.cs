using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeVideoFetch
{
    public class xmlContent
    {
        private string xml_title = "{0}";
        private string xml_desc = "<img src=\"http://img.youtube.com/vi/{2}/0.jpg\" /><h3>{0}</h3><iframe class=\"embed-responsive-item\" width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/{2}\" frameborder=\"0\" allowfullscreen=\"true\"></iframe><br /><p>{1}</p><p>以上影片由《理財周刊》提供，不代表本頻道立場</p>";

        private string newXmltitle = "{0} 盤前/後-投顧 分析師 ";

        public string SetItemTitle(string title, string date)
        {
            string result = string.Format(xml_title, title);

            string temp = result.Substring(0, 8);
            string tempDate = Convert.ToDateTime(date).ToString("yyyyMMdd");
            var strBuilder = new StringBuilder(result);
            strBuilder.Remove(0, 8);
            strBuilder.Insert(0,tempDate);

            return strBuilder.ToString();
        }

        public string SetItemDesc(string title, string desc, string youtubeID)
        {
            string result = string.Format(xml_desc,title,desc,youtubeID);
            return result;
        }

        public string SetNewTitle()
        {
            DateTime date = DateTime.Today;
            string datte = date.ToString("yyyyMMdd");
            string retTitle = string.Format(newXmltitle, datte);
            return retTitle;
        }
        
    }
}
