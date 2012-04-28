using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiamondBilliards.PoolTime.Business;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Presentation
{
    public partial class MainDetailsForm : Form
    {
        private DateTime _currentTime = DateTime.Now;
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

        public MainDetailsForm()
        {
            InitializeComponent();

            this.SetMainData();
        }

        public void RefreshData()
        {
            this.SetMainData();
        }

        private void SetMainData()
        {
            _currentTime = DateTime.Now;

            int numTotalTables = TableDataService.GetNumTables();
            int numActiveTables = TableDataService.GetNumActiveTables();

            this.lblCurrentTimeValue.Text = string.Format( "{0:t}", _currentTime );
            this.lblActiveTablesValue.Text = Convert.ToString( numActiveTables );
            this.lblInactiveTablesValue.Text = Convert.ToString( numTotalTables - numActiveTables );
            this.lblNumPlayersValue.Text = Convert.ToString( TableDataService.GetNumPlayers() );
            this.lblTotalAmountValue.Text = string.Format("{0:C}", 
                PoolTimeFunctions.CalcTotalPoolTime(_currentTime));
        }

        private void linkRefresh_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.SetMainData();
        }
    }
}
