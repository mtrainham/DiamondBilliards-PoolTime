namespace DiamondBilliards.PoolTime.Presentation
{
    partial class CashOutTableForm
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
            this.btnStopTable = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotalAmountTitle = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.gridPlayers = new System.Windows.Forms.DataGridView();
            ( (System.ComponentModel.ISupportInitialize)( this.gridPlayers ) ).BeginInit();
            this.SuspendLayout();
            // 
            // btnStopTable
            // 
            this.btnStopTable.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnStopTable.Location = new System.Drawing.Point( 93, 228 );
            this.btnStopTable.Name = "btnStopTable";
            this.btnStopTable.Size = new System.Drawing.Size( 101, 24 );
            this.btnStopTable.TabIndex = 0;
            this.btnStopTable.Text = "Stop Table";
            this.btnStopTable.UseVisualStyleBackColor = true;
            this.btnStopTable.Click += new System.EventHandler( this.btnStopTable_Click );
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.btnCancel.Location = new System.Drawing.Point( 200, 228 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 72, 24 );
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler( this.btnCancel_Click );
            // 
            // lblTotalAmountTitle
            // 
            this.lblTotalAmountTitle.AutoSize = true;
            this.lblTotalAmountTitle.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalAmountTitle.Location = new System.Drawing.Point( 53, 26 );
            this.lblTotalAmountTitle.Name = "lblTotalAmountTitle";
            this.lblTotalAmountTitle.Size = new System.Drawing.Size( 112, 20 );
            this.lblTotalAmountTitle.TabIndex = 2;
            this.lblTotalAmountTitle.Text = "Total Amount: ";
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblTotalAmountValue.Location = new System.Drawing.Point( 162, 26 );
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size( 69, 20 );
            this.lblTotalAmountValue.TabIndex = 3;
            this.lblTotalAmountValue.Text = "$34.23 ";
            // 
            // gridPlayers
            // 
            this.gridPlayers.AllowUserToAddRows = false;
            this.gridPlayers.AllowUserToDeleteRows = false;
            this.gridPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPlayers.Location = new System.Drawing.Point( 12, 63 );
            this.gridPlayers.Name = "gridPlayers";
            this.gridPlayers.ReadOnly = true;
            this.gridPlayers.Size = new System.Drawing.Size( 260, 150 );
            this.gridPlayers.TabIndex = 4;
            // 
            // CashOutTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size( 284, 264 );
            this.Controls.Add( this.gridPlayers );
            this.Controls.Add( this.lblTotalAmountValue );
            this.Controls.Add( this.lblTotalAmountTitle );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnStopTable );
            this.Name = "CashOutTableForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Out Table";
            ( (System.ComponentModel.ISupportInitialize)( this.gridPlayers ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopTable;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotalAmountTitle;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.DataGridView gridPlayers;

    }
}