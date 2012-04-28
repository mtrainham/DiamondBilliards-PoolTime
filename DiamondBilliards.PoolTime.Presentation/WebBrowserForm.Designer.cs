namespace DiamondBilliards.PoolTime.Presentation
{
    partial class WebBrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( WebBrowserForm ) );
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnClose = new System.Windows.Forms.Button();
            this.linkMainSite = new System.Windows.Forms.LinkLabel();
            this.linkNormalBrowser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.webBrowser.Location = new System.Drawing.Point( -1, 33 );
            this.webBrowser.MinimumSize = new System.Drawing.Size( 20, 20 );
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size( 595, 501 );
            this.webBrowser.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnClose.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnClose.Location = new System.Drawing.Point( 498, 548 );
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size( 83, 30 );
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
            // 
            // linkMainSite
            // 
            this.linkMainSite.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.linkMainSite.AutoSize = true;
            this.linkMainSite.Location = new System.Drawing.Point( 405, 9 );
            this.linkMainSite.Name = "linkMainSite";
            this.linkMainSite.Size = new System.Drawing.Size( 51, 13 );
            this.linkMainSite.TabIndex = 2;
            this.linkMainSite.TabStop = true;
            this.linkMainSite.Text = "Main Site";
            this.linkMainSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.linkMainSite_LinkClicked );
            // 
            // linkNormalBrowser
            // 
            this.linkNormalBrowser.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.linkNormalBrowser.AutoSize = true;
            this.linkNormalBrowser.Location = new System.Drawing.Point( 462, 9 );
            this.linkNormalBrowser.Name = "linkNormalBrowser";
            this.linkNormalBrowser.Size = new System.Drawing.Size( 119, 13 );
            this.linkNormalBrowser.TabIndex = 3;
            this.linkNormalBrowser.TabStop = true;
            this.linkNormalBrowser.Text = "View In Normal Browser";
            this.linkNormalBrowser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.linkNormalBrowser_LinkClicked );
            // 
            // WebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 593, 590 );
            this.Controls.Add( this.linkNormalBrowser );
            this.Controls.Add( this.linkMainSite );
            this.Controls.Add( this.btnClose );
            this.Controls.Add( this.webBrowser );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "WebBrowserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Update!";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkMainSite;
        private System.Windows.Forms.LinkLabel linkNormalBrowser;
    }
}