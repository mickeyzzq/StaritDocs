using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StaritManual
{
    public partial class FormMain : Form
    {
        private const string homeUrl = "http://wikijs.oa.com/";
        //private const string homeUrl = "https://www.wanweibaike.com/";


        public FormMain()
        {
            InitializeComponent();
            InitializeWebbrowser();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate(homeUrl);
        }

        //初始化浏览器并启动
        public void InitializeWebbrowser()
        {
        }

        private void GoHome()
        {
            webBrowser.Navigate(homeUrl);

            this.RefreshBtns();
        }

        private void toolBtnHome_Click(object sender, EventArgs e)
        {
            this.GoHome();
        }

        private void toolBtnPrev_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
            //chromeBrowser.Back();
            this.RefreshBtns();
        }

        private void toolBtnNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
            //chromeBrowser.Forward();
            this.RefreshBtns();
        }

        private void RefreshBtns()
        {
            Action action = () =>
            {
                //this.toolBtnNext.Enabled = chromeBrowser.CanGoForward;
                //this.toolBtnPrev.Enabled = chromeBrowser.CanGoBack;
                this.toolBtnNext.Enabled = webBrowser.CanGoForward;
                this.toolBtnPrev.Enabled = webBrowser.CanGoBack;
            };
            Invoke(action);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.RefreshBtns();
        }

        private void webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            try
            {
                string url = this.webBrowser.Document.ActiveElement.GetAttribute("href");

                this.webBrowser.Url = new Uri(url);
            }
            catch
            {
            }
            e.Cancel = true;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //将所有的链接的目标，指向本窗体
            foreach (HtmlElement archor in this.webBrowser.Document.Links)
            {
                archor.SetAttribute("target", "_self");
            }
            //将所有的FORM的提交目标，指向本窗体
            foreach (HtmlElement form in this.webBrowser.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }
        }

        //private void OnAddressChanged(object sender, AddressChangedEventArgs e)
        //{
        //    this.RefreshBtns();
        //}

        //private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        //{
        //    this.RefreshBtns();
        //}
    }
}
