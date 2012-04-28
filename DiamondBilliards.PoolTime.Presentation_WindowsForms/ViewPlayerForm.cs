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
    public partial class ViewPlayerForm : Form
    {
        private Player _player = null;
        private ICollection<Timestamp> _timestamps = null;
        private DateTime _currentTime = DateTime.Now;
        private DateTime _oldStartTime;

        public ViewPlayerForm(Player player)
        {
            _player = player;
            _timestamps = _player.Timestamps;
            _oldStartTime = _player.StartTime;

            InitializeComponent();

            this.Text = "Table " + Convert.ToString( _player.PoolTable.TableNum ) + ": "
                 + _player.Name;

            this.lblTitle.Text = _player.Name + "'s Details";
        }

        private void RefreshTimestamps()
        {
            this.gridTimestamps.Columns.Clear();

            this.gridTimestamps.AutoGenerateColumns = true;

            this.gridTimestamps.DataSource = null;
            this.timestampsBindingSource.DataSource = null;

            this.timestampsBindingSource.DataSource = _timestamps;
            this.gridTimestamps.DataSource = this.timestampsBindingSource;

            this.gridTimestamps.Columns["ID"].Visible = false;
            this.gridTimestamps.Columns["Player"].Visible = false;
            this.gridTimestamps.Columns["PlayerID"].Visible = false;

            this.gridTimestamps.Columns["TableNum"].HeaderText = "Table Number";
            this.gridTimestamps.Columns["StartTime"].HeaderText = "Start Time";
            this.gridTimestamps.Columns["NumPlayers"].HeaderText = "# of Players";

            this.gridTimestamps.Columns["TableNum"].ReadOnly = true;
            this.gridTimestamps.Columns["StartTime"].ReadOnly = true;
            this.gridTimestamps.Columns["NumPlayers"].ReadOnly = true;

            this.gridTimestamps.Columns["TableNum"].SortMode = DataGridViewColumnSortMode.Programmatic;
            this.gridTimestamps.Columns["StartTime"].SortMode = DataGridViewColumnSortMode.Programmatic;
            this.gridTimestamps.Columns["NumPlayers"].SortMode = DataGridViewColumnSortMode.Programmatic;

            this.gridTimestamps.Columns["StartTime"].DefaultCellStyle.Format = "t";

            this.gridTimestamps.Sort( this.gridTimestamps.Columns["ID"], ListSortDirection.Ascending );

            this.AddTimestampColumns();

            this.RefreshTimestampCalculations();
        }

        private void RefreshTimestampCalculations()
        {
            for ( int i = 0; i < this.gridTimestamps.Rows.Count; i++ )
            {
                DataGridViewRow row = this.gridTimestamps.Rows[i];
                DateTime startTime = Convert.ToDateTime( row.Cells["StartTime"].Value.ToString() );
                DateTime stopTime = ( i < this.gridTimestamps.Rows.Count - 1 ) ?
                    Convert.ToDateTime( this.gridTimestamps.Rows[i + 1].Cells["StartTime"].Value.ToString() ) :
                    _currentTime;
                int numPlayers = Convert.ToInt32( this.gridTimestamps.Rows[i].Cells["NumPlayers"].Value.ToString() );

                row.Cells["TotalHours"].Value = string.Format("{0:0.00}", ( stopTime - startTime ).TotalHours );

                row.Cells["HourlyRate"].Value = string.Format( "{0:C}",
                    PoolTimeFunctions.GetHourlyPlayerRate(numPlayers) ) + "/hr";

                row.Cells["Amount"].Value = string.Format( "{0:C}",
                    PoolTimeFunctions.CalcPoolTime( startTime, stopTime, PoolTimeFunctions.GetHourlyPlayerRate( numPlayers ) ) );
            }
        }

        private void AddTimestampColumns()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewColumn column = new DataGridViewColumn();

            column.HeaderText = "Total Hours";
            column.Name = "TotalHours";
            column.CellTemplate = cell;
            column.ReadOnly = true;

            this.gridTimestamps.Columns.Add( column );

            cell = new DataGridViewTextBoxCell();
            column = new DataGridViewColumn();

            column.HeaderText = "Hourly Rate";
            column.Name = "HourlyRate";
            column.CellTemplate = cell;
            column.ReadOnly = true;

            this.gridTimestamps.Columns.Add( column );

            cell = new DataGridViewTextBoxCell();
            column = new DataGridViewColumn();

            column.HeaderText = "Amount";
            column.Name = "Amount";
            column.CellTemplate = cell;
            column.ReadOnly = true;

            this.gridTimestamps.Columns.Add( column );
        }

        private void RefreshPlayerData()
        {
            _currentTime = DateTime.Now;

            this.dTStartTime.Value = _player.StartTime;

            this.lblCurrentTimeValue.Text = string.Format( "{0:t}", _currentTime );

            this.lblTotalHoursValue.Text = String.Format("{0:0.00}", PoolTimeFunctions.CalcTotalPlayerHours(_player, _currentTime));

            this.lblHourlyRateValue.Text = String.Format( "{0:C}", 
                PoolTimeFunctions.GetHourlyPlayerRate( _player.PoolTable.Players.Count ) );

            this.lblMoneyOwedValue.Text = String.Format( "{0:C}",
                PoolTimeFunctions.CalcPlayerPoolTime( _player, _currentTime ) );
        }

        private void btnDone_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnRemovePlayer_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are you sure you want to remove this player?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes )
            {
                PoolTable table = _player.PoolTable;

                PlayerDataService.DeletePlayer( _player.ID );
                TablesDB.DataContext.SubmitChanges();

                TableDataService.UpdateTimestamps( table, DateTime.Now );
                TablesDB.DataContext.SubmitChanges();

                this.Close();
            }
        }

        private void linkRefresh_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.RefreshPlayerData();
            this.RefreshTimestamps();
        }

        private void ViewPlayerForm_Load( object sender, EventArgs e )
        {
            this.dTStartTime.Format = DateTimePickerFormat.Custom;
            this.dTStartTime.CustomFormat = "h:mm tt";

            this.RefreshPlayerData();
            this.RefreshTimestamps();
        }

        private void linkSave_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            DateTime currentTime = DateTime.Now;
            DateTime newStartTime = this.dTStartTime.Value;

            try
            {
                PlayerDataService.ChangePlayerStartTime( _player, newStartTime, currentTime );
            }

            catch ( Exception error )
            {
                MessageBox.Show( error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            this.RefreshPlayerData();
            this.RefreshTimestamps();
        }
    }
}
