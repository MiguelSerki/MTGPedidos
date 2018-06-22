using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace BackStage
{
    public class Parser
    {
        private HtmlWeb web = new HtmlWeb();
        private HtmlDocument html = new HtmlDocument();
        public void LinkParser(string link)
        {
           this.html = this.web.Load(link);
        }

        public string NameSelector()
        {
            var node = this.html.DocumentNode.SelectSingleNode("//*[@id='productinfoBody']/div/div[2]/div[1]/div[4]/div[1]/h1/span");
            return node.InnerText.ToString();
        }

        public string ExpansionSelector()
        {
            var node = this.html.DocumentNode.SelectSingleNode("//*[@id='productinfoBody']/div/ul/li[4]/a");
            return node.InnerText;
        }

        public float PriceSelector()
        {
            var node = this.html.DocumentNode.SelectSingleNode("//*[@id='productinfoBody']/div/div[2]/div[1]/div[4]/div[2]/div[1]/span/form/h3/span");
            var value = float.Parse(node.InnerHtml, System.Globalization.CultureInfo.InvariantCulture);
            return value;
        }
    }
}
