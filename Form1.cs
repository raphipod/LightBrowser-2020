using System;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using CefSharp.Example;
using CefSharp.Example.Handlers;
using LightBrowser_2020.Properties;
using System.Drawing.Text;

namespace LightBrowser_2020
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser browser;

        public ChromiumWebBrowser AddressChanged { get; private set; }
        public BrowserSettings BrowserSettings { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();

            settings.CefCommandLineArgs.Add("enable-gpu", "1");
            settings.CefCommandLineArgs.Add("start-in-incognito", "1");

            Cef.Initialize(settings);

            browser = new ChromiumWebBrowser(textBox1.Text);
            browser.Dock = DockStyle.Fill;
            browser.Load("duckduckgo.com");
            browser.DownloadHandler = new DownloadHandler();
            this.pContainer.Controls.Add(browser);

            BrowserSettings = new BrowserSettings()
            {
                Javascript = CefState.Enabled,
                WebGl = CefState.Enabled,
                WebSecurity = CefState.Enabled,
                ApplicationCache = CefState.Disabled,
            };

        }

        private void textBox1KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                browser.Load(textBox1.Text);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }

        // Shortcut-based controls

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
            {
                browser.Print();
            }
        }
    }
}
        