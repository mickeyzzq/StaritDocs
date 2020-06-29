namespace StaritManual
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnHome = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnHome,
            this.toolBtnPrev,
            this.toolBtnNext,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnHome
            // 
            this.toolBtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnHome.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnHome.Image")));
            this.toolBtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnHome.Name = "toolBtnHome";
            this.toolBtnHome.Size = new System.Drawing.Size(23, 22);
            this.toolBtnHome.Text = "主页";
            this.toolBtnHome.Click += new System.EventHandler(this.toolBtnHome_Click);
            // 
            // toolBtnPrev
            // 
            this.toolBtnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnPrev.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnPrev.Image")));
            this.toolBtnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPrev.Name = "toolBtnPrev";
            this.toolBtnPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnPrev.Text = "上一页";
            this.toolBtnPrev.Click += new System.EventHandler(this.toolBtnPrev_Click);
            // 
            // toolBtnNext
            // 
            this.toolBtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnNext.Image")));
            this.toolBtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNext.Name = "toolBtnNext";
            this.toolBtnNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnNext.Text = "下一页";
            this.toolBtnNext.Click += new System.EventHandler(this.toolBtnNext_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 22);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel2.Text = "质控中心  @2020";
            // 
            // webBrowser
            // 
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(0, 25);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1008, 704);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            this.webBrowser.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser_NewWindow);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "StaritManual（制度流程标准化手册）";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBtnHome;
        private System.Windows.Forms.ToolStripButton toolBtnPrev;
        private System.Windows.Forms.ToolStripButton toolBtnNext;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

