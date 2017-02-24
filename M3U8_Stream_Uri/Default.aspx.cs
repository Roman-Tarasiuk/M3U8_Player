using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private WebClient _client = new WebClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session.Add("WebClient", _client);
        }
        else
        {
            _client = (WebClient)Session["WebClient"];
        }
    }

    protected void btnGetM3U8_Click(object sender, EventArgs e)
    {
        if (_client != null)
        {
            txtM3uPath.Text = string.Empty;

            string str = _client.DownloadString(txtPath.Text);

            string[] m3uPaths = 
			{
				//@"http://int01.divan.tv:81/secure/[\-A-Za-z0-9/_]*\.m3u8",
				//@"http://cosmo.divan.tv:8001/secure/[\-A-Za-z0-9/_]*\.m3u8",
				//@"http://int04.divan.tv:8001/secure/[\-A-Za-z0-9/_]*\.m3u8",
				//@"http://jabber.divan.tv:81/secure/[\-A-Za-z0-9/_]*\.m3u8",
                //@"http://int10.divan.tv:81/secure/[\-A-Za-z0-9/_]*\.mp4",
                //@"http://j2.divan.tv:81/secure/[\-A-Za-z0-9/_]*\.mp4"
                @"http://.{1,20}.divan.tv:81/secure/[\-A-Za-z0-9/_]*\.((m3u8)|(mp4))"
			};

			for(int i = 0; i < m3uPaths.Length; i++)
			{
                Regex regex = new Regex(m3uPaths[i]);
    
                MatchCollection matches = regex.Matches(str);
    
                if (matches.Count > 0)
				{
                    txtM3uPath.Text = matches[0].Value;
					break;
				}
                else
                    txtM3uPath.Text = "No m3u8 found";
			}
        }
        else
        {
            txtM3uPath.Text = "Reload this page and try again";
        }
    }
}