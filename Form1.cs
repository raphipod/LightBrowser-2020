﻿using System;
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
        public BrowserSettings BrowserSettings { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(textBox1.Text);
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);

            BrowserSettings = new BrowserSettings()
            {
                Javascript = CefState.Enabled,
                WebGl = CefState.Enabled,
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            browser.Load("www.youtube.com");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            browser.Load("www.wikipedia.com");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            browser.Load("www.google.com");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            browser.Load("www.ecosia.org");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.ViewSource();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Print();
        }
    }
}
