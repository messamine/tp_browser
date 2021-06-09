using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace TpWeb_browser
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser webBrowser;
        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.Locale = "fr";

            if(!Cef.IsInitialized)
            {
                Cef.Initialize(settings);
            }
            webBrowser = new ChromiumWebBrowser("https://www.google.com/?hl=fr");
            chromiumWebBrowser1.Controls.Add(webBrowser);
            webBrowser.LoadingStateChanged += chromiumWebBrowser1_LoadingStateChanged;
        }
        
        private void btndroite_Click(object sender, EventArgs e)
        {
            webBrowser.Forward();
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            webBrowser.Back();
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            webBrowser.Reload();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}
