using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace mwImports
{
    public class PageGrab
    {
        protected WebClient client;
        protected string pageData;
        protected string pageUrl;
        protected DateTime startDate;
        protected DateTime endDate;
        protected Form1 mainForm;

        public PageGrab()
        {
            client = new WebClient();
            pageData = "";
            pageUrl  = "";           
        }

        public string getPage(string url)
        {
            string pageData = "";

            try
            {
                pageData = client.DownloadString(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Connection Error", MessageBoxButtons.OK);
            }

            return pageData;
        }

    }
}
