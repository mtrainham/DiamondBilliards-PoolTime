namespace DiamondBilliards.PoolTime.Presentation
{
    partial class AddTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AddTableForm ) );
            this.btnStartTable = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboNumPlayers = new System.Windows.Forms.ComboBox();
            this.grpSelectNumPlayers = new System.Windows.Forms.GroupBox();
            this.btn9Player = new System.Windows.Forms.Button();
            this.btn8Player = new System.Windows.Forms.Button();
            this.btn7Player = new System.Windows.Forms.Button();
            this.btn6Player = new System.Windows.Forms.Button();
            this.btn5Player = new System.Windows.Forms.Button();
            this.btn4Player = new System.Windows.Forms.Button();
            this.btn3Player = new System.Windows.Forms.Button();
            this.btn2Player = new System.Windows.Forms.Button();
            this.btn1Player = new System.Windows.Forms.Button();
            this.lblNumPlayers = new System.Windows.Forms.Label();
            this.grpEditPlayers = new System.Windows.Forms.GroupBox();
            this.gridPlayers = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChangeStartTime = new System.Windows.Forms.GroupBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dTStartTime = new System.Windows.Forms.DateTimePicker();
            this.playersBindingSource = new System.Windows.Forms.BindingSource( this.components );
            this.grpSelectNumPlayers.SuspendLayout();
            this.grpEditPlayers.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.gridPlayers ) ).BeginInit();
            this.grpChangeStartTime.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.playersBindingSource ) ).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartTable
            // 
            this.btnStartTable.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnStartTable.Location = new System.Drawing.Point( 308, 524 );
            this.btnStartTable.Name = "btnStartTable";
            this.btnStartTable.Size = new System.Drawing.Size( 114, 30 );
            this.btnStartTable.TabIndex = 4;
            this.btnStartTable.Text = "Start Table";
            this.btnStartTable.UseVisualStyleBackColor = true;
            this.btnStartTable.Click += new System.EventHandler( this.btnStartTable_Click );
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnCancel.Location = new System.Drawing.Point( 428, 524 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 106, 30 );
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler( this.btnCancel_Click );
            // 
            // comboNumPlayers
            // 
            this.comboNumPlayers.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.comboNumPlayers.FormattingEnabled = true;
            this.comboNumPlayers.Items.AddRange( new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"} );
            this.comboNumPlayers.Location = new System.Drawing.Point( 268, 29 );
            this.comboNumPlayers.Name = "comboNumPlayers";
            this.comboNumPlayers.Size = new System.Drawing.Size( 68, 24 );
            this.comboNumPlayers.TabIndex = 1;
            this.comboNumPlayers.SelectedIndexChanged += new System.EventHandler( this.comboNumPlayers_SelectedIndexChanged );
            this.comboNumPlayers.TextChanged += new System.EventHandler( this.comboNumPlayers_TextChanged );
            // 
            // grpSelectNumPlayers
            // 
            this.grpSelectNumPlayers.Controls.Add( this.btn9Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn8Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn7Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn6Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn5Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn4Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn3Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn2Player );
            this.grpSelectNumPlayers.Controls.Add( this.btn1Player );
            this.grpSelectNumPlayers.Controls.Add( this.lblNumPlayers );
            this.grpSelectNumPlayers.Controls.Add( this.comboNumPlayers );
            this.grpSelectNumPlayers.Location = new System.Drawing.Point( 58, 20 );
            this.grpSelectNumPlayers.Name = "grpSelectNumPlayers";
            this.grpSelectNumPlayers.Size = new System.Drawing.Size( 476, 123 );
            this.grpSelectNumPlayers.TabIndex = 1;
            this.grpSelectNumPlayers.TabStop = false;
            this.grpSelectNumPlayers.Text = "Choose Number of Players";
            // 
            // btn9Player
            // 
            this.btn9Player.Location = new System.Drawing.Point( 359, 69 );
            this.btn9Player.Name = "btn9Player";
            this.btn9Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn9Player.TabIndex = 12;
            this.btn9Player.TabStop = false;
            this.btn9Player.Text = "9";
            this.btn9Player.UseVisualStyleBackColor = true;
            this.btn9Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn8Player
            // 
            this.btn8Player.Location = new System.Drawing.Point( 325, 69 );
            this.btn8Player.Name = "btn8Player";
            this.btn8Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn8Player.TabIndex = 11;
            this.btn8Player.TabStop = false;
            this.btn8Player.Text = "8";
            this.btn8Player.UseVisualStyleBackColor = true;
            this.btn8Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn7Player
            // 
            this.btn7Player.Location = new System.Drawing.Point( 291, 69 );
            this.btn7Player.Name = "btn7Player";
            this.btn7Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn7Player.TabIndex = 10;
            this.btn7Player.TabStop = false;
            this.btn7Player.Text = "7";
            this.btn7Player.UseVisualStyleBackColor = true;
            this.btn7Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn6Player
            // 
            this.btn6Player.Location = new System.Drawing.Point( 259, 69 );
            this.btn6Player.Name = "btn6Player";
            this.btn6Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn6Player.TabIndex = 9;
            this.btn6Player.TabStop = false;
            this.btn6Player.Text = "6";
            this.btn6Player.UseVisualStyleBackColor = true;
            this.btn6Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn5Player
            // 
            this.btn5Player.Location = new System.Drawing.Point( 225, 69 );
            this.btn5Player.Name = "btn5Player";
            this.btn5Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn5Player.TabIndex = 8;
            this.btn5Player.TabStop = false;
            this.btn5Player.Text = "5";
            this.btn5Player.UseVisualStyleBackColor = true;
            this.btn5Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn4Player
            // 
            this.btn4Player.Location = new System.Drawing.Point( 191, 69 );
            this.btn4Player.Name = "btn4Player";
            this.btn4Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn4Player.TabIndex = 7;
            this.btn4Player.TabStop = false;
            this.btn4Player.Text = "4";
            this.btn4Player.UseVisualStyleBackColor = true;
            this.btn4Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn3Player
            // 
            this.btn3Player.Location = new System.Drawing.Point( 157, 69 );
            this.btn3Player.Name = "btn3Player";
            this.btn3Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn3Player.TabIndex = 6;
            this.btn3Player.TabStop = false;
            this.btn3Player.Text = "3";
            this.btn3Player.UseVisualStyleBackColor = true;
            this.btn3Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn2Player
            // 
            this.btn2Player.Location = new System.Drawing.Point( 123, 69 );
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn2Player.TabIndex = 5;
            this.btn2Player.TabStop = false;
            this.btn2Player.Text = "2";
            this.btn2Player.UseVisualStyleBackColor = true;
            this.btn2Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // btn1Player
            // 
            this.btn1Player.Location = new System.Drawing.Point( 89, 69 );
            this.btn1Player.Name = "btn1Player";
            this.btn1Player.Size = new System.Drawing.Size( 28, 23 );
            this.btn1Player.TabIndex = 4;
            this.btn1Player.TabStop = false;
            this.btn1Player.Text = "1";
            this.btn1Player.UseVisualStyleBackColor = true;
            this.btn1Player.Click += new System.EventHandler( this.btnNumPlayers_Click );
            // 
            // lblNumPlayers
            // 
            this.lblNumPlayers.AutoSize = true;
            this.lblNumPlayers.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblNumPlayers.Location = new System.Drawing.Point( 140, 31 );
            this.lblNumPlayers.Name = "lblNumPlayers";
            this.lblNumPlayers.Size = new System.Drawing.Size( 122, 16 );
            this.lblNumPlayers.TabIndex = 3;
            this.lblNumPlayers.Text = "Number of Players:";
            // 
            // grpEditPlayers
            // 
            this.grpEditPlayers.Controls.Add( this.gridPlayers );
            this.grpEditPlayers.Location = new System.Drawing.Point( 58, 166 );
            this.grpEditPlayers.Name = "grpEditPlayers";
            this.grpEditPlayers.Size = new System.Drawing.Size( 475, 183 );
            this.grpEditPlayers.TabIndex = 2;
            this.grpEditPlayers.TabStop = false;
            this.grpEditPlayers.Text = "Edit Players";
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
            this.gridPlayers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler( this.gridPlayers_CellContentClick );
            this.gridPlayers.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler( this.gridPlayers_CellEndEdit );
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Names";
            this.PlayerName.MaxInputLength = 50;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // grpChangeStartTime
            // 
            this.grpChangeStartTime.Controls.Add( this.lblStartTime );
            this.grpChangeStartTime.Controls.Add( this.dTStartTime );
            this.grpChangeStartTime.Location = new System.Drawing.Point( 58, 378 );
            this.grpChangeStartTime.Name = "grpChangeStartTime";
            this.grpChangeStartTime.Size = new System.Drawing.Size( 475, 100 );
            this.grpChangeStartTime.TabIndex = 3;
            this.grpChangeStartTime.TabStop = false;
            this.grpChangeStartTime.Text = "Change Start Time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblStartTime.Location = new System.Drawing.Point( 132, 45 );
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size( 72, 16 );
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start Time:";
            // 
            // dTStartTime
            // 
            this.dTStartTime.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.dTStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTStartTime.Location = new System.Drawing.Point( 210, 42 );
            this.dTStartTime.Name = "dTStartTime";
            this.dTStartTime.Size = new System.Drawing.Size( 133, 22 );
            this.dTStartTime.TabIndex = 3;
            // 
            // AddTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size( 593, 590 );
            this.Controls.Add( this.grpChangeStartTime );
            this.Controls.Add( this.grpEditPlayers );
            this.Controls.Add( this.grpSelectNumPlayers );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnStartTable );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "AddTableForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Table";
            this.grpSelectNumPlayers.ResumeLayout( false );
            this.grpSelectNumPlayers.PerformLayout();
            this.grpEditPlayers.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.gridPlayers ) ).EndInit();
            this.grpChangeStartTime.ResumeLayout( false );
            this.grpChangeStartTime.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.playersBindingSource ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button btnStartTable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboNumPlayers;
        private System.Windows.Forms.GroupBox grpSelectNumPlayers;
        private System.Windows.Forms.Button btn1Player;
        private System.Windows.Forms.Label lblNumPlayers;
        private System.Windows.Forms.Button btn9Player;
        private System.Windows.Forms.Button btn8Player;
        private System.Windows.Forms.Button btn7Player;
        private System.Windows.Forms.Button btn6Player;
        private System.Windows.Forms.Button btn5Player;
        private System.Windows.Forms.Button btn4Player;
        private System.Windows.Forms.Button btn3Player;
        private System.Windows.Forms.Button btn2Player;
        private System.Windows.Forms.GroupBox grpEditPlayers;
        private System.Windows.Forms.GroupBox grpChangeStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dTStartTime;
        private System.Windows.Forms.DataGridView gridPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.BindingSource playersBindingSource;
    }
}