using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blueBrowser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser.Navigate(cboLocation.Text);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(cboLocation.Text);
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "blueBrowser - " + webBrowser.Document.Title;
        }
    }
}
