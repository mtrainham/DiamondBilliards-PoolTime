﻿using System;
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
        private string _title = string.Empty;

        public WebBrowserForm(string url, string title)
        {
            _url = url;
            _title = title;

            InitializeComponent();

            this.webBrowser.Url = new Uri(_url);
            this.Text = _title;
        }

        private void btnClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void linkMainSite_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start( "http://www.pooltime.us" );
        }

        private void linkNormalBrowser_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start( _url );
        }
    }
}
