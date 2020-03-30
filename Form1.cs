using System;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace LightBrowser_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser browser;

        public ChromiumWebBrowser AddressChanged { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(textBox1.Text);
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            browser.Load(textBox1.Text);
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

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            browser.Load("www.google.com");
        }

        private void btnEcosia_Click(object sender, EventArgs e)
        {
            browser.Load("www.ecosia.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Load("www.wikipedia.com");
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            browser.Load("www.youtube.com");
        }
    }
}
