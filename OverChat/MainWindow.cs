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

namespace OverChat
{
    public partial class MainWindow : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public MainWindow()
        {
            InitializeComponent();
            // Start the browser after initialize global component
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string twitch_username = input_username.Text;
            string twitch_chat_url = string.Format("http://twitch.tv/popout/{0}/chat?darkpopout", twitch_username);

            Console.WriteLine(twitch_username);
            Console.WriteLine(value: twitch_chat_url);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(twitch_chat_url);
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            
        }
    }
}
