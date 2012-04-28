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
    public partial class MovePlayersForm : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        // disable close button (x) in upper right corner of form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public event EventHandler Canceled;

        public MovePlayersForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            if ( Canceled != null )
                Canceled( this, EventArgs.Empty );
        }

        public void DisableCancelButton()
        {
            this.btnCancel.Enabled = false;
        }

        public void ChangeDisplayText( string text )
        {
            this.lblInstructions.Text = text;
        }

        private void MovePlayersForm_VisibleChanged( object sender, EventArgs e )
        {
            this.btnCancel.Enabled = true;
            this.lblInstructions.Text = "Select table on the left...";
        }
    }
}
