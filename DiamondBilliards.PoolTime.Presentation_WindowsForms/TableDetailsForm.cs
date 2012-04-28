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
    public partial class TableDetailsForm : Form
    {
        private PoolTable _table = null;
        private ICollection<Player> _players = null;
        private DateTime _currentTime = DateTime.Now;
        private DateTime _oldStartTime;
      
        public TableDetailsForm(PoolTable table)
        {
            _table = table;
            _players = table.Players;
            _oldStartTime = TableDataService.GetStartTime(_table);

            InitializeComponent();

            this.Text = "Table " + Convert.ToString( _table.TableNum );
            this.lblTitle.Text = "Table " + Convert.ToString( _table.TableNum ) + "'s Details";
        }

        private void TableDetailsForm_Load( object sender, EventArgs e )
        {
            this.dTStartTime.Format = DateTimePickerFormat.Custom;
            this.dTStartTime.CustomFormat = "h:mm tt";

            this.RefreshTableData();
            this.RefreshPlayers();
        }

        private void RefreshTableData()
        {
            _currentTime = DateTime.Now;
            int numPlayers = _table.Players.Count;

            this.dTStartTime.Value = TableDataService.GetStartTime( _table );

            this.lblCurrentTimeValue.Text = string.Format( "{0:t}", _currentTime );

            this.lblNumPlayersValue.Text = Convert.ToString( numPlayers );

            this.lblTotalHoursValue.Text = String.Format( "{0:0.00}",
                PoolTimeFunctions.CalcTotalTableHours( _table, _currentTime ) );

            this.lblTableHourlyRateValue.Text = String.Format( "{0:C}",
                PoolTimeFunctions.GetHourlyTableRate( numPlayers ) );

            this.lblPlayerHourlyRateValue.Text = String.Format( "{0:C}",
                PoolTimeFunctions.GetHourlyPlayerRate( numPlayers ) );

            this.lblTotalMoneyOwedValue.Text = String.Format( "{0:C}",
                PoolTimeFunctions.CalcTablePoolTime( _table, _currentTime ) );
        }

        private void RefreshPlayers()
        {
            this.gridPlayers.Columns.Clear();

            this.gridPlayers.AutoGenerateColumns = true;

            this.gridPlayers.DataSource = null;
            this.playersBindingSource.DataSource = null;

            this.playersBindingSource.DataSource = _players;
            this.gridPlayers.DataSource = this.playersBindingSource;

            this.gridPlayers.Columns["ID"].Visible = false;
            this.gridPlayers.Columns["TableNum"].Visible = false;
            this.gridPlayers.Columns["PoolTable"].Visible = false;
            this.gridPlayers.Columns["Status"].Visible = false;
            this.gridPlayers.Columns["Timestamps"].Visible = false;

            this.gridPlayers.Columns["StartTime"].HeaderText = "Start Time";
            
            this.gridPlayers.Columns["Name"].ReadOnly = true;
            this.gridPlayers.Columns["StartTime"].ReadOnly = true;

            this.gridPlayers.Columns["Name"].SortMode = DataGridViewColumnSortMode.Programmatic;
            this.gridPlayers.Columns["StartTime"].SortMode = DataGridViewColumnSortMode.Programmatic;

            this.gridPlayers.Columns["StartTime"].DefaultCellStyle.Format = "t";

            this.gridPlayers.Sort( this.gridPlayers.Columns["Name"], ListSortDirection.Ascending );

            this.AddPlayerColumns();

            this.RefreshPlayerCalculations();
        }

        private void RefreshPlayerCalculations()
        {
            for ( int i = 0; i < this.gridPlayers.Rows.Count; i++ )
            {
                DataGridViewRow row = this.gridPlayers.Rows[i];
                int playerID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                DateTime startTime = Convert.ToDateTime( row.Cells["StartTime"].Value.ToString() );
                DateTime stopTime = _currentTime;

                row.Cells["TotalHours"].Value = string.Format( "{0:0.00}", ( stopTime - startTime ).TotalHours );

                row.Cells["Amount"].Value = string.Format( "{0:C}",
                    PoolTimeFunctions.CalcPlayerPoolTime(playerID, _currentTime) );
            }
        }

        private void AddPlayerColumns()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewColumn column = new DataGridViewColumn();

            column.HeaderText = "Total Hours";
            column.Name = "TotalHours";
            column.CellTemplate = cell;
            column.ReadOnly = true;

            this.gridPlayers.Columns.Add( column );

            cell = new DataGridViewTextBoxCell();
            column = new DataGridViewColumn();

            column.HeaderText = "Amount Owed";
            column.Name = "Amount";
            column.CellTemplate = cell;
            column.ReadOnly = true;

            this.gridPlayers.Columns.Add( column );
        }

        private void ViewPlayerDetails( int rowIndex )
        {
            int playerID = Convert.ToInt32( this.gridPlayers.Rows[rowIndex].Cells[0].Value.ToString() );

            this.RefreshTableData();
            this.RefreshPlayers();

            ViewPlayerForm viewPlayerForm = new ViewPlayerForm( PlayerDataService.GetPlayerByID( playerID ) );

            viewPlayerForm.ShowDialog();

            if ( _table.Players.Count < 1 )
            {
                this.Close();
            } else
            {
                this.RefreshTableData();
                this.RefreshPlayers();
            }
        }

        private void linkRefresh_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.RefreshTableData();
            this.RefreshPlayers();
        }

        private void linkSave_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            DateTime currentTime = DateTime.Now;
            DateTime newStartTime = this.dTStartTime.Value;
            DateTime playerStartTime = _players.First().StartTime;
            bool isError = false;

            if ( newStartTime == TableDataService.GetStartTime(_table) )
            {
                return;
            }

            foreach ( Player player in _players )
            {
                if ( player.StartTime != playerStartTime )
                {
                    isError = true;
                    break;
                }
            }

            if ( isError )
            {
                MessageBox.Show( "Some of the players on this table started on another table, so can't change start time for entire table.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );

                this.RefreshTableData();
                this.RefreshPlayers();

                return;
            }

            try
            {
                TableDataService.ChangeTableStartTime( _table, newStartTime, currentTime );
            }

            catch ( Exception error )
            {
                MessageBox.Show( error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            this.RefreshTableData();
            this.RefreshPlayers();
        }

        private void btnDone_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void btnStopTable_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are you sure you want to stop this table and delete all players on this table?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes )
            {
                TableDataService.StopTable( _table );

                this.Close();
            }
        }

        private void gridPlayers_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            this.ViewPlayerDetails( e.RowIndex );
        }
    }
}
