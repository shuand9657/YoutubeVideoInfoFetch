using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace YoutubeVideoFetch
{
    public partial class Form1 : Form
    {
        public static string youtubeApiKey = "AIzaSyAiwEtx7yswvVkKKeBdk8twgd_iqPaxNJM";
        private static string rssFolderPath = @"\\\\192.168.1.213\\web\\frontend\\MoneyWeekly\\WWWRoot\\Web\\MoneyWeeklyRSS";
        private static string xmlFileName = @"\\hinetrss.xml";
        private XDocument xDoc;
        BindingSource bs = new BindingSource();

        private NetworkCredential nc = new NetworkCredential("administrator", "xu3h965.d0");

        public List<xmlItem> xmlItemList = new List<xmlItem>();

        private static string Title { get; set; }
        private static string Description { get; set; }
        private static string youtubeID { get; set; }

        private static string UploadTime { get; set; }

        private static int TotalItem { get; set; }

        private static int MaxNum { get; set; }

        public static readonly Regex YoutubeVideoRegex = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FetchVideo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_VideoID.Text))
            {
                //https://www.youtube.com/watch?v=1qZgu6yW0lU
                string text = tb_VideoID.Text;
                    if (text.Length < 11)
                    {
                        MessageBox.Show( "影片ID錯誤!");
                    return;
                    }

                    Match urlMatch = YoutubeVideoRegex.Match(text);
                    if (!urlMatch.Success)
                    {
                        MessageBox.Show("輸入影片網址錯誤!");
                    return;
                    }
                    getVideoInformation(tb_VideoID.Text);
                
            }
            else
            {
                tb_videoInfo.Text = "Empty youtube ID";
            }
        }

        private void getVideoInformation(string text)
        {

            //string url = "https://www.youtube.com/watch?v=" + text;

            ExtractYoutubeInfo(text);

            xmlContent xmlCon = new xmlContent();
            
            tb_videoInfo.Text = xmlCon.SetItemDesc(Title, Description.Replace("\n", "<br/>"), youtubeID);
            tb_XmlTitle.Text = xmlCon.SetItemTitle(tb_XmlTitle.Text, UploadTime);
            dt_PubDate.Text = UploadTime;

        }

        public void ExtractYoutubeInfo(string url)
        {
            string youtubeApi = "https://www.googleapis.com/youtube/v3/videos?part=snippet&id=" + GetArgs(url, "v", '?') + "&key=" + youtubeApiKey;
            string timeurl = "https://www.googleapis.com/youtube/v3/videos?id=" + GetArgs(url, "v", '?') + "&part=contentDetails&key=" + youtubeApiKey;

            HttpWebRequest contentRequest = (HttpWebRequest)WebRequest.CreateHttp(youtubeApi);
            WebResponse contentResponse = contentRequest.GetResponse();

            Stream responseStream = contentResponse.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream);

            string response = sr.ReadToEnd();

            JObject responseObj = JObject.Parse(response);

            Title = (string)responseObj["items"][0]["snippet"]["title"];
            Description = (string)responseObj["items"][0]["snippet"]["description"];
            youtubeID = (string)responseObj["items"][0]["id"];
            UploadTime = (string)responseObj["items"][0]["snippet"]["publishedAt"];
            string a = Convert.ToDateTime(UploadTime).ToString("R", CultureInfo.CreateSpecificCulture("en-US"));
            UploadTime = Convert.ToDateTime(a).ToString("dd MMM yyyy HH:mm:ss zz00", new CultureInfo("en-US"));

        }

        private static string getDescription(string url)
        {
            string result = GetArgs(new WebClient().DownloadString($"http://youtube.com/get_video_info?video_id={GetArgs(url, "v", '?')}"), "intro", '&');
            return result;
        }
            
        public static string GetTitle(string url)
        {
            return GetArgs(new WebClient().DownloadString($"http://youtube.com/get_video_info?video_id={GetArgs(url, "v", '?')}"), "title", '&');
        }
            

        private static string GetArgs(string args, string key, char query)
        {
            var iqs = args.IndexOf(query);
            return iqs == -1
                ? string.Empty
                : HttpUtility.ParseQueryString(iqs < args.Length - 1 ? args.Substring(iqs + 1) : string.Empty)[key];
        }

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "xml (*.xml) | *.xml";
            ofd.InitialDirectory = rssFolderPath;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                getXmlDocumentItem(ofd.FileName);
                
                tb_XmlContent.Text = sr.ReadToEnd();
                sr.Close();
            }
            
        }

        private void getXmlDocumentItem(string fileName)
        {
            xDoc = XDocument.Load(fileName);

            lb_xmlItems.DataSource = null;
            if (lb_xmlItems.Items.Count > 0)
            {
                lb_xmlItems.Items.Clear();
            }
            
            var q = xDoc.DescendantNodes().OfType<XCData>().FirstOrDefault();
            var xmlItems =
                from item in xDoc.Descendants("item")
                select new
                {
                    Title = item.Element("title").Value,
                    Description = item.Element("description").Value,
                    pubDate = item.Element("pubDate").Value,
                    ID = item.Element("id").Value,
                };
            if(xmlItemList.Count>0)
            {
                xmlItemList = new List<xmlItem>();
            }

            foreach(var item in xmlItems)
            {
                xmlItemList.Add(new xmlItem(item.ID,item.Title, item.Description, item.pubDate));
            }
            bs.DataSource = xmlItemList;

            TotalItem = xmlItems.Count();
            MaxNum = 0;
            foreach(var x in xmlItems)
            {
                if(MaxNum < Convert.ToInt32(x.ID))
                {
                    MaxNum = Convert.ToInt32(x.ID);
                }
            }
            label1.Text = MaxNum.ToString() + ' ' + TotalItem.ToString(); 
            lb_xmlItems.ValueMember = "ID";
            lb_xmlItems.DisplayMember = "title";
            lb_xmlItems.DataSource = bs;
        }


        private void btn_XmlUpdate_Click(object sender, EventArgs e)
        {
            string selectvalue = lb_xmlItems.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(selectvalue)) {

                var q = xDoc.DescendantNodes().OfType<XCData>().FirstOrDefault();
                foreach (var item in xDoc.Descendants("item"))
                {
                    if (item.Element("id").Value == selectvalue)
                    {
                        selectvalue = lb_xmlItems.SelectedValue.ToString();
                        item.Element("title").ReplaceNodes(new XCData(tb_XmlTitle.Text));
                        item.Element("description").ReplaceNodes(new XCData(tb_videoInfo.Text));
                        item.Element("pubDate").Value = Convert.ToDateTime(dt_PubDate.Text).ToString("dd MMM yyyy HH:mm:ss zz00", new CultureInfo("en-US"));
                    }
                }
                xDoc.Save(rssFolderPath + xmlFileName);
                //getXmlDocumentItem(rssFolderPath + xmlFileName);
                getXmlDocumentItem(rssFolderPath + xmlFileName);
                lb_xmlItems.SelectedValue = selectvalue;
            }
        }

        private void lb_xmlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty((string)lb_xmlItems.SelectedValue))
            {
                string currentID = lb_xmlItems.SelectedValue.ToString();
                tb_VideoID.Text = string.Empty;

                for (int i = 0; i < xmlItemList.Count; i++)
                {
                    if (xmlItemList[i].ID == currentID)
                    {
                        tb_XmlTitle.Text = xmlItemList[i].Title;
                        tb_videoInfo.Text = xmlItemList[i].Description;
                        //tb_pubDate.Text = xmlItemList[i].PubDate;
                        dt_PubDate.Text = xmlItemList[i].PubDate;
                    }
                }
            }
            

        }
        private void tb_videoInfo_TextChanged(object sender, EventArgs e)
        {
            string currentID = lb_xmlItems.SelectedValue.ToString();
            for (int i = 0; i < xmlItemList.Count; i++)
            {
                //if (xmlItemList[i].ID == currentID)
                //{
                //    xDoc.Save();
                //}
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getXmlDocumentItem(rssFolderPath + xmlFileName);
            dt_PubDate.Format = DateTimePickerFormat.Custom;
            dt_PubDate.CustomFormat = "dd MMM yyyy HH:mm:ss";
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            xmlItem newItem = new xmlItem();
            xmlContent x = new xmlContent();
            newItem.ID = (MaxNum + 1).ToString();

            newItem.Title = x.SetNewTitle();

            lb_xmlItems.DataSource = null;


            xmlItemList.Insert(0,newItem);
            bs.DataSource = xmlItemList;
            tb_XmlTitle.Text = x.SetNewTitle();
            tb_XmlContent.Text = newItem.Description;
            lb_xmlItems.ValueMember = "ID";
            lb_xmlItems.DisplayMember = "title";
            lb_xmlItems.DataSource = bs;
            lb_xmlItems.SelectedValue = newItem.ID;
            
            

        }





        //private string GetTitleValue(string title)
        //{
        //    string result;
        //    result = 
        //    return result;
        //}
    }
}
