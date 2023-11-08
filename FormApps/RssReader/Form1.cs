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
        List<string> topics = new List<string> {
                @"https://news.yahoo.co.jp/rss/topics/top-picks.xml",
                @"https://news.yahoo.co.jp/rss/topics/domestic.xml",
                @"https://news.yahoo.co.jp/rss/topics/world.xml",
                @"https://news.yahoo.co.jp/rss/topics/business.xml",
                @"https://news.yahoo.co.jp/rss/topics/entertainment.xml",
                @"https://news.yahoo.co.jp/rss/topics/sports.xml",
                @"https://news.yahoo.co.jp/rss/topics/it.xml",
                @"https://news.yahoo.co.jp/rss/topics/science.xml",
                @"https://news.yahoo.co.jp/rss/topics/local.xml",
            };

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "") return;
            
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                nodes = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = x.Element("title").Value,
                                            Link = x.Element("link").Value,
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
            if (lbRssTitle.SelectedIndex == -1) {
                return;
            }
            wbBrowser.Url = new Uri(nodes[lbRssTitle.SelectedIndex].Link);
        }

        private void btAddUrl_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "") return;
            if (tbUrlName.Text == "") return;

            var addurls = new ItemData {
                Title = tbUrlName.Text,
                Link = tbUrl.Text
            };

            if (!cbSaveLink.Items.Contains(addurls.Title)) {
                if (!cbSaveLink.Text.Contains(addurls.Link)) {
                    cbSaveLink.Items.Add(addurls.Title);
                    tbUrl.Clear();
                    tbUrlName.Clear();
                }
            }
            else {
                return;
            }
            
        }

        private void rb_CheckedChanged(object sender, EventArgs e) {
            foreach (RadioButton item in gbButon.Controls) {
                if (item.Checked) {
                    tbUrl.Text = topics[int.Parse(item.Tag.ToString())];
                }
            }
        }
    }
}
