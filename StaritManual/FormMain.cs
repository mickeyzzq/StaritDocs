using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace StaritManual
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class FormMain : Form
    {
        //private const string homeUrl = "http://staritmanual.oa.com/web/#/4?page_id=24";
        private const string homeUrl = "https://www.showdoc.cc/help?page_id=16118";
        //private const string homeUrl = "https://www.jianshu.com/p/131ec51356ce";
        private const string testUrl = "https://ie.icoa.cn/";
        //private const string homeUrl = "https://html5test.com/";

        /// <summary>
        /// 修改注册表信息使WebBrowser使用指定版本IE内核
        /// </summary>
        public static void SetFeatures(UInt32 ieMode)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
            {
                throw new ApplicationException();
            }
            //获取程序及名称
            string appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            string featureControlRegKey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\";
            //设置浏览器对应用程序(appName)以什么模式(ieMode)运行
            Registry.SetValue(featureControlRegKey + "FEATURE_BROWSER_EMULATION", appName, ieMode, RegistryValueKind.DWord);
            //不晓得设置有什么用
            Registry.SetValue(featureControlRegKey + "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", appName, 1, RegistryValueKind.DWord);
        }

        public FormMain()
        {
            SetFeatures(99000);
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeWebbrowser();
            this.GoHome(false);
            //GotTestpage();
        }

        //初始化浏览器并启动
        public void InitializeWebbrowser()
        {
            webBrowser.ScriptErrorsSuppressed = true;
            //webBrowser.ObjectForScripting = this;
            //webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }

        private void GoHome(bool stopLastNavigation = true)
        {
            if (stopLastNavigation)
            {
                webBrowser.Stop();

                while (webBrowser.IsBusy == true || webBrowser.ReadyState != WebBrowserReadyState.Complete)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
                
            }

            //webBrowser.Navigate(homeUrl);
            //while (webBrowser.IsBusy) { }
            //bBrowser.Refresh(WebBrowserRefreshOption.Completely);

            webBrowser.Navigate(homeUrl);
            while (webBrowser.IsBusy == true || webBrowser.ReadyState != WebBrowserReadyState.Complete)
            {
                System.Windows.Forms.Application.DoEvents();
            }

            //webBrowser.Refresh(WebBrowserRefreshOption.Completely);
            //webBrowser.Navigate()
            this.RefreshBtns();

            if (stopLastNavigation)
            {
                this.OnMaximumSizeChanged(EventArgs.Empty);
                this.OnResize(EventArgs.Empty);
                this.NotifyInvalidate(new Rectangle(0, 0, 1200, 860));
                this.OnInvalidated(new InvalidateEventArgs(new Rectangle(0, 0, 1200, 860)));
                //typeof(Control).GetMethod("OnResize", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(this, new object[] { EventArgs.Empty });
            }
        }

        private void GotTestpage()
        {
            webBrowser.Navigate(new Uri(testUrl));
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

            ((WebBrowser)sender).Document.Window.Error += new HtmlElementErrorEventHandler(Window_Error);

            ////将所有的链接的目标，指向本窗体
            //foreach (HtmlElement archor in this.webBrowser.Document.Links)
            //{
            //    archor.SetAttribute("target", "_self");
            //}
            ////将所有的FORM的提交目标，指向本窗体
            //foreach (HtmlElement form in this.webBrowser.Document.Forms)
            //{
            //    form.SetAttribute("target", "_self");
            //}
        }

        private void Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            // 忽略该错误并抑制错误对话框
            e.Handled = true;
        }

        //private void FormMain_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F7)
        //        GotTestpage();
        //}

        //private void FormMain_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F7)
        //        GotTestpage();
        //}

        protected override bool ProcessDialogKey(Keys keyData)

        {
            if (keyData == (Keys.Control | Keys.D))
            {
                GotTestpage();
                return false;
            }
            else
                return base.ProcessDialogKey(keyData);

        }

        private void toolStripLabel2_DoubleClick(object sender, EventArgs e)
        {
            //GotTestpage();
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
