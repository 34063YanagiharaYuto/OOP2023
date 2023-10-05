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
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> nodes;
        public Form1() {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e) {
            using(var wc = new WebClient()) {
                wc.Encoding = Encoding.UTF8;
                var url = wc.OpenRead(@"https://news.yahoo.co.jp/rss");
                XDocument xdoc = XDocument.Load(url);
                var topics = xdoc.Root.Descendants("li").Descendants("a");
                nodes = xdoc.Root.Descendants("li").Descendants("a")
                    .Select(s => new ItemData {
                        Xml = (string)s.Element("href")
                     }).ToList();
                foreach (var topic in topics) {
                    if (topic.FirstAttribute.Value.Contains(".xml")
                        && !cbMainRss.Items.Contains(topic.Value)){
                        cbMainRss.Items.Add(topic.Value);
                    }
                }
            }
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                nodes = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = x.Element("title").Value,
                                            Link = (x.Element("link").Value),
                                        }).ToList();

                // 一度表に入っているものを削除
                if (lbRssTitle.Items.Count > 1) {
                    lbRssTitle.Items.Clear();
                }

                // 表に追加
                foreach (var node in nodes) {
                    lbRssTitle.Items.Add(node.Title);
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            if(lbRssTitle.SelectedIndex == -1) {
                return;
            }
            wbBrowser.Url = new Uri(nodes[lbRssTitle.SelectedIndex].Link);
        }

        private void cbMainRss_Click(object sender, EventArgs e) {

        }
    }
}
