namespace DiamondBilliards.PoolTime.Presentation
{
    partial class PoolTableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableNumLabel
            // 
            this.tableNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableNumLabel.AutoSize = true;
            this.tableNumLabel.BackColor = System.Drawing.Color.White;
            this.tableNumLabel.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNumLabel.Location = new System.Drawing.Point(56, 27);
            this.tableNumLabel.Name = "tableNumLabel";
            this.tableNumLabel.Size = new System.Drawing.Size(14, 17);
            this.tableNumLabel.TabIndex = 1;
            this.tableNumLabel.Text = "0";
            this.tableNumLabel.Click += new System.EventHandler(this.tableNumLabel_Click);
            // 
            // PoolTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiamondBilliards.PoolTime.Presentation.Properties.Resources.diamondtable2_active;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableNumLabel);
            this.DoubleBuffered = true;
            this.Name = "PoolTableControl";
            this.Size = new System.Drawing.Size(127, 73);
            this.Load += new System.EventHandler(this.PoolTableControl_Load);
            this.SizeChanged += new System.EventHandler(this.PoolTableControl_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tableNumLabel;

    }
}
