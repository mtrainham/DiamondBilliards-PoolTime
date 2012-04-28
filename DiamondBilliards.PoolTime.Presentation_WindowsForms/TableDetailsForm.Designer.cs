namespace DiamondBilliards.PoolTime.Presentation
{
    partial class TableDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( TableDetailsForm ) );
            this.linkRefresh = new System.Windows.Forms.LinkLabel();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gBDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalMoneyOwedValue = new System.Windows.Forms.Label();
            this.lblTotalMoneyOwedTitle = new System.Windows.Forms.Label();
            this.lblPlayerHourlyRateValue = new System.Windows.Forms.Label();
            this.lblPlayerHourlyRateTitle = new System.Windows.Forms.Label();
            this.lblNumPlayersValue = new System.Windows.Forms.Label();
            this.lblNumPlayersTitle = new System.Windows.Forms.Label();
            this.lblTableHourlyRateValue = new System.Windows.Forms.Label();
            this.lblTotalHoursValue = new System.Windows.Forms.Label();
            this.lblTableHourlyRateTitle = new System.Windows.Forms.Label();
            this.lblTotalHoursTitle = new System.Windows.Forms.Label();
            this.gBStartTime = new System.Windows.Forms.GroupBox();
            this.lblCurrentTimeValue = new System.Windows.Forms.Label();
            this.lblCurrentTimeTitle = new System.Windows.Forms.Label();
            this.linkSave = new System.Windows.Forms.LinkLabel();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dTStartTime = new System.Windows.Forms.DateTimePicker();
            this.gBPlayers = new System.Windows.Forms.GroupBox();
            this.gridPlayers = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStopTable = new System.Windows.Forms.Button();
            this.playersBindingSource = new System.Windows.Forms.BindingSource( this.components );
            this.gBDetails.SuspendLayout();
            this.gBStartTime.SuspendLayout();
            this.gBPlayers.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.gridPlayers ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.playersBindingSource ) ).BeginInit();
            this.SuspendLayout();
            // 
            // linkRefresh
            // 
            this.linkRefresh.AutoSize = true;
            this.linkRefresh.Location = new System.Drawing.Point( 490, 35 );
            this.linkRefresh.Name = "linkRefresh";
            this.linkRefresh.Size = new System.Drawing.Size( 44, 13 );
            this.linkRefresh.TabIndex = 17;
            this.linkRefresh.TabStop = true;
            this.linkRefresh.Text = "Refresh";
            this.linkRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.linkRefresh_LinkClicked );
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnDone.Location = new System.Drawing.Point( 448, 529 );
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size( 83, 30 );
            this.btnDone.TabIndex = 15;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler( this.btnDone_Click );
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTitle.Location = new System.Drawing.Point( 8, 31 );
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size( 577, 20 );
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Table 14\'s Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBDetails
            // 
            this.gBDetails.Controls.Add( this.lblTotalMoneyOwedValue );
            this.gBDetails.Controls.Add( this.lblTotalMoneyOwedTitle );
            this.gBDetails.Controls.Add( this.lblPlayerHourlyRateValue );
            this.gBDetails.Controls.Add( this.lblPlayerHourlyRateTitle );
            this.gBDetails.Controls.Add( this.lblNumPlayersValue );
            this.gBDetails.Controls.Add( this.lblNumPlayersTitle );
            this.gBDetails.Controls.Add( this.lblTableHourlyRateValue );
            this.gBDetails.Controls.Add( this.lblTotalHoursValue );
            this.gBDetails.Controls.Add( this.lblTableHourlyRateTitle );
            this.gBDetails.Controls.Add( this.lblTotalHoursTitle );
            this.gBDetails.Location = new System.Drawing.Point( 59, 176 );
            this.gBDetails.Name = "gBDetails";
            this.gBDetails.Size = new System.Drawing.Size( 475, 127 );
            this.gBDetails.TabIndex = 13;
            this.gBDetails.TabStop = false;
            this.gBDetails.Text = "Table Details";
            // 
            // lblTotalMoneyOwedValue
            // 
            this.lblTotalMoneyOwedValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalMoneyOwedValue.Location = new System.Drawing.Point( 269, 100 );
            this.lblTotalMoneyOwedValue.Name = "lblTotalMoneyOwedValue";
            this.lblTotalMoneyOwedValue.Size = new System.Drawing.Size( 66, 16 );
            this.lblTotalMoneyOwedValue.TabIndex = 10;
            this.lblTotalMoneyOwedValue.Text = "$50.00";
            this.lblTotalMoneyOwedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalMoneyOwedTitle
            // 
            this.lblTotalMoneyOwedTitle.AutoSize = true;
            this.lblTotalMoneyOwedTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalMoneyOwedTitle.Location = new System.Drawing.Point( 140, 100 );
            this.lblTotalMoneyOwedTitle.Name = "lblTotalMoneyOwedTitle";
            this.lblTotalMoneyOwedTitle.Size = new System.Drawing.Size( 130, 16 );
            this.lblTotalMoneyOwedTitle.TabIndex = 9;
            this.lblTotalMoneyOwedTitle.Text = "Total Money Owed:  ";
            // 
            // lblPlayerHourlyRateValue
            // 
            this.lblPlayerHourlyRateValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblPlayerHourlyRateValue.Location = new System.Drawing.Point( 272, 79 );
            this.lblPlayerHourlyRateValue.Name = "lblPlayerHourlyRateValue";
            this.lblPlayerHourlyRateValue.Size = new System.Drawing.Size( 63, 16 );
            this.lblPlayerHourlyRateValue.TabIndex = 8;
            this.lblPlayerHourlyRateValue.Text = "$50.00";
            this.lblPlayerHourlyRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerHourlyRateTitle
            // 
            this.lblPlayerHourlyRateTitle.AutoSize = true;
            this.lblPlayerHourlyRateTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblPlayerHourlyRateTitle.Location = new System.Drawing.Point( 140, 79 );
            this.lblPlayerHourlyRateTitle.Name = "lblPlayerHourlyRateTitle";
            this.lblPlayerHourlyRateTitle.Size = new System.Drawing.Size( 127, 16 );
            this.lblPlayerHourlyRateTitle.TabIndex = 7;
            this.lblPlayerHourlyRateTitle.Text = "Player Hourly Rate: ";
            // 
            // lblNumPlayersValue
            // 
            this.lblNumPlayersValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblNumPlayersValue.Location = new System.Drawing.Point( 320, 16 );
            this.lblNumPlayersValue.Name = "lblNumPlayersValue";
            this.lblNumPlayersValue.Size = new System.Drawing.Size( 15, 16 );
            this.lblNumPlayersValue.TabIndex = 6;
            this.lblNumPlayersValue.Text = "9";
            this.lblNumPlayersValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumPlayersTitle
            // 
            this.lblNumPlayersTitle.AutoSize = true;
            this.lblNumPlayersTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblNumPlayersTitle.Location = new System.Drawing.Point( 140, 16 );
            this.lblNumPlayersTitle.Name = "lblNumPlayersTitle";
            this.lblNumPlayersTitle.Size = new System.Drawing.Size( 125, 16 );
            this.lblNumPlayersTitle.TabIndex = 5;
            this.lblNumPlayersTitle.Text = "Number of Players: ";
            // 
            // lblTableHourlyRateValue
            // 
            this.lblTableHourlyRateValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTableHourlyRateValue.Location = new System.Drawing.Point( 272, 58 );
            this.lblTableHourlyRateValue.Name = "lblTableHourlyRateValue";
            this.lblTableHourlyRateValue.Size = new System.Drawing.Size( 63, 16 );
            this.lblTableHourlyRateValue.TabIndex = 4;
            this.lblTableHourlyRateValue.Text = "$50.00";
            this.lblTableHourlyRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalHoursValue
            // 
            this.lblTotalHoursValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalHoursValue.Location = new System.Drawing.Point( 280, 37 );
            this.lblTotalHoursValue.Name = "lblTotalHoursValue";
            this.lblTotalHoursValue.Size = new System.Drawing.Size( 55, 16 );
            this.lblTotalHoursValue.TabIndex = 3;
            this.lblTotalHoursValue.Text = "14.34";
            this.lblTotalHoursValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTableHourlyRateTitle
            // 
            this.lblTableHourlyRateTitle.AutoSize = true;
            this.lblTableHourlyRateTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTableHourlyRateTitle.Location = new System.Drawing.Point( 140, 58 );
            this.lblTableHourlyRateTitle.Name = "lblTableHourlyRateTitle";
            this.lblTableHourlyRateTitle.Size = new System.Drawing.Size( 124, 16 );
            this.lblTableHourlyRateTitle.TabIndex = 2;
            this.lblTableHourlyRateTitle.Text = "Table Hourly Rate: ";
            // 
            // lblTotalHoursTitle
            // 
            this.lblTotalHoursTitle.AutoSize = true;
            this.lblTotalHoursTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalHoursTitle.Location = new System.Drawing.Point( 140, 37 );
            this.lblTotalHoursTitle.Name = "lblTotalHoursTitle";
            this.lblTotalHoursTitle.Size = new System.Drawing.Size( 124, 16 );
            this.lblTotalHoursTitle.TabIndex = 1;
            this.lblTotalHoursTitle.Text = "Total Hours Active: ";
            // 
            // gBStartTime
            // 
            this.gBStartTime.Controls.Add( this.lblCurrentTimeValue );
            this.gBStartTime.Controls.Add( this.lblCurrentTimeTitle );
            this.gBStartTime.Controls.Add( this.linkSave );
            this.gBStartTime.Controls.Add( this.lblStartTime );
            this.gBStartTime.Controls.Add( this.dTStartTime );
            this.gBStartTime.Location = new System.Drawing.Point( 59, 73 );
            this.gBStartTime.Name = "gBStartTime";
            this.gBStartTime.Size = new System.Drawing.Size( 475, 84 );
            this.gBStartTime.TabIndex = 12;
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
            // gBPlayers
            // 
            this.gBPlayers.Controls.Add( this.gridPlayers );
            this.gBPlayers.Location = new System.Drawing.Point( 59, 322 );
            this.gBPlayers.Name = "gBPlayers";
            this.gBPlayers.Size = new System.Drawing.Size( 475, 183 );
            this.gBPlayers.TabIndex = 11;
            this.gBPlayers.TabStop = false;
            this.gBPlayers.Text = "Players";
            // 
            // gridPlayers
            // 
            this.gridPlayers.AllowUserToAddRows = false;
            this.gridPlayers.AllowUserToDeleteRows = false;
            this.gridPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPlayers.BackgroundColor = System.Drawing.Color.SlateGray;
            this.gridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlayers.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName} );
            this.gridPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPlayers.Location = new System.Drawing.Point( 3, 16 );
            this.gridPlayers.Name = "gridPlayers";
            this.gridPlayers.Size = new System.Drawing.Size( 469, 164 );
            this.gridPlayers.TabIndex = 2;
            this.gridPlayers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler( this.gridPlayers_CellDoubleClick );
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Names";
            this.PlayerName.MaxInputLength = 50;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnStopTable
            // 
            this.btnStopTable.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnStopTable.Location = new System.Drawing.Point( 339, 529 );
            this.btnStopTable.Name = "btnStopTable";
            this.btnStopTable.Size = new System.Drawing.Size( 103, 30 );
            this.btnStopTable.TabIndex = 18;
            this.btnStopTable.Text = "Stop Table";
            this.btnStopTable.UseVisualStyleBackColor = true;
            this.btnStopTable.Click += new System.EventHandler( this.btnStopTable_Click );
            // 
            // TableDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size( 593, 590 );
            this.Controls.Add( this.btnStopTable );
            this.Controls.Add( this.linkRefresh );
            this.Controls.Add( this.btnDone );
            this.Controls.Add( this.lblTitle );
            this.Controls.Add( this.gBDetails );
            this.Controls.Add( this.gBStartTime );
            this.Controls.Add( this.gBPlayers );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "TableDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Details";
            this.Load += new System.EventHandler( this.TableDetailsForm_Load );
            this.gBDetails.ResumeLayout( false );
            this.gBDetails.PerformLayout();
            this.gBStartTime.ResumeLayout( false );
            this.gBStartTime.PerformLayout();
            this.gBPlayers.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.gridPlayers ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.playersBindingSource ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRefresh;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gBDetails;
        private System.Windows.Forms.Label lblNumPlayersValue;
        private System.Windows.Forms.Label lblNumPlayersTitle;
        private System.Windows.Forms.Label lblTableHourlyRateValue;
        private System.Windows.Forms.Label lblTotalHoursValue;
        private System.Windows.Forms.Label lblTableHourlyRateTitle;
        private System.Windows.Forms.Label lblTotalHoursTitle;
        private System.Windows.Forms.GroupBox gBStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dTStartTime;
        private System.Windows.Forms.GroupBox gBPlayers;
        private System.Windows.Forms.DataGridView gridPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.Button btnStopTable;
        private System.Windows.Forms.Label lblTotalMoneyOwedValue;
        private System.Windows.Forms.Label lblTotalMoneyOwedTitle;
        private System.Windows.Forms.Label lblPlayerHourlyRateValue;
        private System.Windows.Forms.Label lblPlayerHourlyRateTitle;
        private System.Windows.Forms.LinkLabel linkSave;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.Label lblCurrentTimeValue;
        private System.Windows.Forms.Label lblCurrentTimeTitle;
    }
}