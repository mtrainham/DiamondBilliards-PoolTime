using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiamondBilliards.PoolTime.Presentation
{
    public partial class WebBrowserForm : Form
    {
        private string _url = string.Empty;

        public WebBrowserForm(string url)
        {
            _url = url;

            InitializeComponent();

            this.webBrowser.Url = new Uri(_url);
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
