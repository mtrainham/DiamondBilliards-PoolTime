namespace DiamondBilliards.PoolTime.Presentation
{
    partial class ViewPlayerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ViewPlayerForm ) );
            this.gBTimestamps = new System.Windows.Forms.GroupBox();
            this.gridTimestamps = new System.Windows.Forms.DataGridView();
            this.gBDetails = new System.Windows.Forms.GroupBox();
            this.lblHourlyRateValue = new System.Windows.Forms.Label();
            this.lblHourlyRateTitle = new System.Windows.Forms.Label();
            this.lblMoneyOwedValue = new System.Windows.Forms.Label();
            this.lblTotalHoursValue = new System.Windows.Forms.Label();
            this.lblMoneyOwedTitle = new System.Windows.Forms.Label();
            this.lblHoursPlayedTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.timestampsBindingSource = new System.Windows.Forms.BindingSource( this.components );
            this.gBStartTime = new System.Windows.Forms.GroupBox();
            this.lblCurrentTimeValue = new System.Windows.Forms.Label();
            this.lblCurrentTimeTitle = new System.Windows.Forms.Label();
            this.linkSave = new System.Windows.Forms.LinkLabel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dTStartTime = new System.Windows.Forms.DateTimePicker();
            this.gBTimestamps.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.gridTimestamps ) ).BeginInit();
            this.gBDetails.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.timestampsBindingSource ) ).BeginInit();
            this.gBStartTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTimestamps
            // 
            this.gBTimestamps.Controls.Add( this.gridTimestamps );
            this.gBTimestamps.Location = new System.Drawing.Point( 67, 296 );
            this.gBTimestamps.Name = "gBTimestamps";
            this.gBTimestamps.Size = new System.Drawing.Size( 475, 183 );
            this.gBTimestamps.TabIndex = 4;
            this.gBTimestamps.TabStop = false;
            this.gBTimestamps.Text = "Player\'s Activity";
            // 
            // gridTimestamps
            // 
            this.gridTimestamps.AllowUserToAddRows = false;
            this.gridTimestamps.AllowUserToDeleteRows = false;
            this.gridTimestamps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTimestamps.BackgroundColor = System.Drawing.Color.SlateGray;
            this.gridTimestamps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTimestamps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTimestamps.Location = new System.Drawing.Point( 3, 16 );
            this.gridTimestamps.Name = "gridTimestamps";
            this.gridTimestamps.Size = new System.Drawing.Size( 469, 164 );
            this.gridTimestamps.TabIndex = 2;
            // 
            // gBDetails
            // 
            this.gBDetails.Controls.Add( this.lblHourlyRateValue );
            this.gBDetails.Controls.Add( this.lblHourlyRateTitle );
            this.gBDetails.Controls.Add( this.lblMoneyOwedValue );
            this.gBDetails.Controls.Add( this.lblTotalHoursValue );
            this.gBDetails.Controls.Add( this.lblMoneyOwedTitle );
            this.gBDetails.Controls.Add( this.lblHoursPlayedTitle );
            this.gBDetails.Location = new System.Drawing.Point( 67, 166 );
            this.gBDetails.Name = "gBDetails";
            this.gBDetails.Size = new System.Drawing.Size( 475, 117 );
            this.gBDetails.TabIndex = 6;
            this.gBDetails.TabStop = false;
            this.gBDetails.Text = "Player Details";
            // 
            // lblHourlyRateValue
            // 
            this.lblHourlyRateValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHourlyRateValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblHourlyRateValue.Location = new System.Drawing.Point( 291, 52 );
            this.lblHourlyRateValue.Name = "lblHourlyRateValue";
            this.lblHourlyRateValue.Size = new System.Drawing.Size( 39, 16 );
            this.lblHourlyRateValue.TabIndex = 6;
            this.lblHourlyRateValue.Text = "$2.50";
            this.lblHourlyRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHourlyRateTitle
            // 
            this.lblHourlyRateTitle.AutoSize = true;
            this.lblHourlyRateTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblHourlyRateTitle.Location = new System.Drawing.Point( 140, 52 );
            this.lblHourlyRateTitle.Name = "lblHourlyRateTitle";
            this.lblHourlyRateTitle.Size = new System.Drawing.Size( 130, 16 );
            this.lblHourlyRateTitle.TabIndex = 5;
            this.lblHourlyRateTitle.Text = "Current Hourly Rate: ";
            // 
            // lblMoneyOwedValue
            // 
            this.lblMoneyOwedValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMoneyOwedValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblMoneyOwedValue.Location = new System.Drawing.Point( 278, 77 );
            this.lblMoneyOwedValue.Name = "lblMoneyOwedValue";
            this.lblMoneyOwedValue.Size = new System.Drawing.Size( 52, 16 );
            this.lblMoneyOwedValue.TabIndex = 4;
            this.lblMoneyOwedValue.Text = "$50.00";
            this.lblMoneyOwedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalHoursValue
            // 
            this.lblTotalHoursValue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalHoursValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalHoursValue.Location = new System.Drawing.Point( 291, 27 );
            this.lblTotalHoursValue.Name = "lblTotalHoursValue";
            this.lblTotalHoursValue.Size = new System.Drawing.Size( 39, 16 );
            this.lblTotalHoursValue.TabIndex = 3;
            this.lblTotalHoursValue.Text = "14.34";
            this.lblTotalHoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoneyOwedTitle
            // 
            this.lblMoneyOwedTitle.AutoSize = true;
            this.lblMoneyOwedTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblMoneyOwedTitle.Location = new System.Drawing.Point( 140, 77 );
            this.lblMoneyOwedTitle.Name = "lblMoneyOwedTitle";
            this.lblMoneyOwedTitle.Size = new System.Drawing.Size( 127, 16 );
            this.lblMoneyOwedTitle.TabIndex = 2;
            this.lblMoneyOwedTitle.Text = "Total Money Owed: ";
            // 
            // lblHoursPlayedTitle
            // 
            this.lblHoursPlayedTitle.AutoSize = true;
            this.lblHoursPlayedTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblHoursPlayedTitle.Location = new System.Drawing.Point( 140, 27 );
            this.lblHoursPlayedTitle.Name = "lblHoursPlayedTitle";
            this.lblHoursPlayedTitle.Size = new System.Drawing.Size( 130, 16 );
            this.lblHoursPlayedTitle.TabIndex = 1;
            this.lblHoursPlayedTitle.Text = "Total Hours Played: ";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTitle.Location = new System.Drawing.Point( 25, 28 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 543, 20 );
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Player Name\'s Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnDone.Location = new System.Drawing.Point( 453, 526 );
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size( 83, 30 );
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler( this.btnDone_Click );
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Location = new System.Drawing.Point( 498, 32 );
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size( 44, 13 );
            this.linkRefresh.TabIndex = 10;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "Refresh";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.linkRefresh_LinkClicked );
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnRemovePlayer.Location = new System.Drawing.Point( 314, 526 );
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size( 133, 30 );
            this.btnRemovePlayer.TabIndex = 11;
            this.btnRemovePlayer.Text = "Remove Player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler( this.btnRemovePlayer_Click );
            // 
            // gBStartTime
            // 
            this.gBStartTime.Controls.Add( this.lblCurrentTimeValue );
            this.gBStartTime.Controls.Add( this.lblCurrentTimeTitle );
            this.gBStartTime.Controls.Add( this.linkSave );
            this.gBStartTime.Controls.Add( this.lblStartTime );
            this.gBStartTime.Controls.Add( this.dTStartTime );
            this.gBStartTime.Location = new System.Drawing.Point( 67, 69 );
            this.gBStartTime.Name = "gBStartTime";
            this.gBStartTime.Size = new System.Drawing.Size( 475, 84 );
            this.gBStartTime.TabIndex = 13;
            this.gBStartTime.TabStop = false;
            this.gBStartTime.Text = "Time Info";
            // 
            // lblCurrentTimeValue
            // 
            this.lblCurrentTimeValue.AutoSize = true;
            this.lblCurrentTimeValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblCurrentTimeValue.Location = new System.Drawing.Point( 224, 52 );
            this.lblCurrentTimeValue.Name = "lblCurrentTimeValue";
            this.lblCurrentTimeValue.Size = new System.Drawing.Size( 62, 16 );
            this.lblCurrentTimeValue.TabIndex = 21;
            this.lblCurrentTimeValue.Text = "11:30 PM";
            // 
            // lblCurrentTimeTitle
            // 
            this.lblCurrentTimeTitle.AutoSize = true;
            this.lblCurrentTimeTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblCurrentTimeTitle.Location = new System.Drawing.Point( 140, 52 );
            this.lblCurrentTimeTitle.Name = "lblCurrentTimeTitle";
            this.lblCurrentTimeTitle.Size = new System.Drawing.Size( 90, 16 );
            this.lblCurrentTimeTitle.TabIndex = 20;
            this.lblCurrentTimeTitle.Text = "Current Time: ";
            // 
            // linkSave
            // 
            this.linkSave.AutoSize = true;
            this.linkSave.Location = new System.Drawing.Point( 365, 28 );
            this.linkSave.Name = "linkSave";
            this.linkSave.Size = new System.Drawing.Size( 32, 13 );
            this.linkSave.TabIndex = 19;
            this.linkSave.TabStop = true;
            this.linkSave.Text = "Save";
            this.linkSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.linkSave_LinkClicked );
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblStartTime.Location = new System.Drawing.Point( 140, 26 );
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size( 72, 16 );
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start Time:";
            // 
            // dTStartTime
            // 
            this.dTStartTime.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.dTStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTStartTime.Location = new System.Drawing.Point( 226, 23 );
            this.dTStartTime.Name = "dTStartTime";
            this.dTStartTime.Size = new System.Drawing.Size( 133, 22 );
            this.dTStartTime.TabIndex = 3;
            // 
            // ViewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size( 593, 590 );
            this.Controls.Add( this.gBStartTime );
            this.Controls.Add( this.btnRemovePlayer );
            this.Controls.Add( this.linkRefresh );
            this.Controls.Add( this.btnDone );
            this.Controls.Add( this.lblTitle );
            this.Controls.Add( this.gBDetails );
            this.Controls.Add( this.gBTimestamps );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "ViewPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Details";
            this.Load += new System.EventHandler( this.ViewPlayerForm_Load );
            this.gBTimestamps.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.gridTimestamps ) ).EndInit();
            this.gBDetails.ResumeLayout( false );
            this.gBDetails.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.timestampsBindingSource ) ).EndInit();
            this.gBStartTime.ResumeLayout( false );
            this.gBStartTime.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBTimestamps;
        private System.Windows.Forms.DataGridView gridTimestamps;
        private System.Windows.Forms.GroupBox gBDetails;
        private System.Windows.Forms.Label lblHoursPlayedTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblMoneyOwedValue;
        private System.Windows.Forms.Label lblTotalHoursValue;
        private System.Windows.Forms.Label lblMoneyOwedTitle;
        private System.Windows.Forms.LinkLabel linkRefresh;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Label lblHourlyRateValue;
        private System.Windows.Forms.Label lblHourlyRateTitle;
        private System.Windows.Forms.BindingSource timestampsBindingSource;
        private System.Windows.Forms.GroupBox gBStartTime;
        private System.Windows.Forms.Label lblCurrentTimeValue;
        private System.Windows.Forms.Label lblCurrentTimeTitle;
        private System.Windows.Forms.LinkLabel linkSave;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dTStartTime;
    }
}