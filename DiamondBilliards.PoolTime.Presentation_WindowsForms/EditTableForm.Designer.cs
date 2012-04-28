namespace DiamondBilliards.PoolTime.Presentation
{
    partial class EditTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playersGrid = new System.Windows.Forms.DataGridView();
            this.btnMovePlayers = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnViewPlayerDetails = new System.Windows.Forms.Button();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.playersBindingSource = new System.Windows.Forms.BindingSource( this.components );
            this.lblTotalMoneyTitle = new System.Windows.Forms.Label();
            this.lblNumPlayers = new System.Windows.Forms.Label();
            this.lblTotalMoneyValue = new System.Windows.Forms.Label();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.btnViewTableDetails = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCashOut = new System.Windows.Forms.Button();
            ( (System.ComponentModel.ISupportInitialize)( this.playersGrid ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.playersBindingSource ) ).BeginInit();
            this.SuspendLayout();
            // 
            // playersGrid
            // 
            this.playersGrid.AllowUserToAddRows = false;
            this.playersGrid.AllowUserToDeleteRows = false;
            this.playersGrid.AllowUserToOrderColumns = true;
            this.playersGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersGrid.BackgroundColor = System.Drawing.Color.SlateGray;
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Location = new System.Drawing.Point( 14, 201 );
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.Size = new System.Drawing.Size( 260, 235 );
            this.playersGrid.TabIndex = 0;
            this.playersGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler( this.playersGrid_CellBeginEdit );
            this.playersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler( this.playersGrid_CellClick );
            this.playersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler( this.playersGrid_CellContentClick );
            this.playersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler( this.playersGrid_CellDoubleClick );
            this.playersGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler( this.playersGrid_CellEndEdit );
            this.playersGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler( this.playersGrid_CellEnter );
            this.playersGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler( this.playersGrid_CellLeave );
            this.playersGrid.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler( this.playersGrid_CellStateChanged );
            this.playersGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler( this.playersGrid_CellValidating );
            // 
            // btnMovePlayers
            // 
            this.btnMovePlayers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMovePlayers.Location = new System.Drawing.Point( 14, 462 );
            this.btnMovePlayers.Name = "btnMovePlayers";
            this.btnMovePlayers.Size = new System.Drawing.Size( 104, 25 );
            this.btnMovePlayers.TabIndex = 1;
            this.btnMovePlayers.Text = "Move Players";
            this.btnMovePlayers.UseVisualStyleBackColor = true;
            this.btnMovePlayers.Click += new System.EventHandler( this.btnMovePlayers_Click );
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.Location = new System.Drawing.Point( 170, 462 );
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size( 104, 25 );
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Players";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler( this.btnRemove_Click );
            // 
            // lblPlayers
            // 
            this.lblPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblPlayers.Location = new System.Drawing.Point( 11, 176 );
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size( 57, 16 );
            this.lblPlayers.TabIndex = 3;
            this.lblPlayers.Text = "Players:";
            this.lblPlayers.Click += new System.EventHandler( this.lblPlayers_Click );
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddPlayer.Location = new System.Drawing.Point( 92, 502 );
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size( 104, 25 );
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler( this.btnAddPlayer_Click );
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectAll.Location = new System.Drawing.Point( 199, 173 );
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size( 75, 23 );
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler( this.btnSelectAll_Click );
            // 
            // btnViewPlayerDetails
            // 
            this.btnViewPlayerDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewPlayerDetails.Location = new System.Drawing.Point( 92, 173 );
            this.btnViewPlayerDetails.Name = "btnViewPlayerDetails";
            this.btnViewPlayerDetails.Size = new System.Drawing.Size( 104, 23 );
            this.btnViewPlayerDetails.TabIndex = 6;
            this.btnViewPlayerDetails.Text = "View Player\'s Time";
            this.btnViewPlayerDetails.UseVisualStyleBackColor = true;
            this.btnViewPlayerDetails.Click += new System.EventHandler( this.btnViewPlayerDetails_Click );
            // 
            // lblTableNum
            // 
            this.lblTableNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTableNum.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTableNum.Location = new System.Drawing.Point( 8, 21 );
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size( 268, 25 );
            this.lblTableNum.TabIndex = 7;
            this.lblTableNum.Text = "Table 14";
            this.lblTableNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMoneyTitle
            // 
            this.lblTotalMoneyTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalMoneyTitle.AutoSize = true;
            this.lblTotalMoneyTitle.Location = new System.Drawing.Point( 68, 75 );
            this.lblTotalMoneyTitle.Name = "lblTotalMoneyTitle";
            this.lblTotalMoneyTitle.Size = new System.Drawing.Size( 103, 13 );
            this.lblTotalMoneyTitle.TabIndex = 9;
            this.lblTotalMoneyTitle.Text = "Total Money Owed: ";
            // 
            // lblNumPlayers
            // 
            this.lblNumPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumPlayers.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblNumPlayers.Location = new System.Drawing.Point( 10, 46 );
            this.lblNumPlayers.Name = "lblNumPlayers";
            this.lblNumPlayers.Size = new System.Drawing.Size( 264, 16 );
            this.lblNumPlayers.TabIndex = 10;
            this.lblNumPlayers.Text = "(9 Players)";
            this.lblNumPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMoneyValue
            // 
            this.lblTotalMoneyValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalMoneyValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalMoneyValue.Location = new System.Drawing.Point( 166, 75 );
            this.lblTotalMoneyValue.Name = "lblTotalMoneyValue";
            this.lblTotalMoneyValue.Size = new System.Drawing.Size( 50, 13 );
            this.lblTotalMoneyValue.TabIndex = 11;
            this.lblTotalMoneyValue.Text = "$75.00";
            this.lblTotalMoneyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelRefresh
            // 
            this.linkLabelRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabelRefresh.AutoSize = true;
            this.linkLabelRefresh.Location = new System.Drawing.Point( 120, 88 );
            this.linkLabelRefresh.Name = "linkLabelRefresh";
            this.linkLabelRefresh.Size = new System.Drawing.Size( 44, 13 );
            this.linkLabelRefresh.TabIndex = 12;
            this.linkLabelRefresh.TabStop = true;
            this.linkLabelRefresh.Text = "Refresh";
            this.linkLabelRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler( this.linkLabelRefresh_LinkClicked );
            // 
            // btnViewTableDetails
            // 
            this.btnViewTableDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewTableDetails.Location = new System.Drawing.Point( 23, 113 );
            this.btnViewTableDetails.Name = "btnViewTableDetails";
            this.btnViewTableDetails.Size = new System.Drawing.Size( 116, 26 );
            this.btnViewTableDetails.TabIndex = 13;
            this.btnViewTableDetails.Text = "View Table Details";
            this.btnViewTableDetails.UseVisualStyleBackColor = true;
            this.btnViewTableDetails.Click += new System.EventHandler( this.btnViewTableDetails_Click );
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDone.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnDone.Location = new System.Drawing.Point( 105, 562 );
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size( 75, 24 );
            this.btnDone.TabIndex = 14;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler( this.btnDone_Click );
            // 
            // btnCashOut
            // 
            this.btnCashOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCashOut.Location = new System.Drawing.Point( 145, 113 );
            this.btnCashOut.Name = "btnCashOut";
            this.btnCashOut.Size = new System.Drawing.Size( 116, 26 );
            this.btnCashOut.TabIndex = 15;
            this.btnCashOut.Text = "Cash Table Out";
            this.btnCashOut.UseVisualStyleBackColor = true;
            this.btnCashOut.Click += new System.EventHandler( this.btnCashOut_Click );
            // 
            // EditTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size( 284, 618 );
            this.Controls.Add( this.btnCashOut );
            this.Controls.Add( this.btnDone );
            this.Controls.Add( this.btnViewTableDetails );
            this.Controls.Add( this.linkLabelRefresh );
            this.Controls.Add( this.lblTotalMoneyValue );
            this.Controls.Add( this.lblNumPlayers );
            this.Controls.Add( this.lblTotalMoneyTitle );
            this.Controls.Add( this.lblTableNum );
            this.Controls.Add( this.btnViewPlayerDetails );
            this.Controls.Add( this.btnSelectAll );
            this.Controls.Add( this.btnAddPlayer );
            this.Controls.Add( this.lblPlayers );
            this.Controls.Add( this.btnRemove );
            this.Controls.Add( this.btnMovePlayers );
            this.Controls.Add( this.playersGrid );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditTableForm";
            this.ShowInTaskbar = false;
            this.Text = "Edit Table";
            this.Load += new System.EventHandler( this.EditTableForm_Load );
            ( (System.ComponentModel.ISupportInitialize)( this.playersGrid ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.playersBindingSource ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playersGrid;
        private System.Windows.Forms.Button btnMovePlayers;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnViewPlayerDetails;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Label lblTotalMoneyTitle;
        private System.Windows.Forms.Label lblNumPlayers;
        private System.Windows.Forms.Label lblTotalMoneyValue;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.Button btnViewTableDetails;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCashOut;
    }
}