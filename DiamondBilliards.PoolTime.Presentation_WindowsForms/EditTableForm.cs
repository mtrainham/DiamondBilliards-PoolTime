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
    public enum EditTableStatus
    {
        Done,
        Busy,
        MovingPlayers
    }

    public partial class EditTableForm : Form
    {
        private PoolTable _currentTable;
        private ICollection<Player> _currentPlayers = null;
        private EditTableStatus _status = EditTableStatus.Done;
        private MovePlayersForm _movePlayersForm = null;
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

        public PoolTable CurrentTable 
        {
            get { return this._currentTable; }

            private set
            {
                _currentTable = value;
                _currentPlayers = _currentTable.Players;
            }
        }

        public EditTableStatus Status
        {
            get { return _status; }
        }

        public EditTableForm()
        {
            InitializeComponent();

            SetPlayersBinding();

            _movePlayersForm = new MovePlayersForm();
            _movePlayersForm.Canceled += new EventHandler( this.movePlayersForm_Canceled );
        }

        public void Finish()
        {
            this.playersGrid.EndEdit();

            this.Hide();
        }

        private void SetPlayersBinding()
        {
            this.playersGrid.AutoGenerateColumns = false;
          
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewColumn column = new DataGridViewColumn();

            column.HeaderText = "ID";
            column.Name = "ID";
            column.DataPropertyName = "ID";
            column.CellTemplate = cell;
            column.Visible = false;

            this.playersGrid.Columns.Add( column );

            cell = new DataGridViewTextBoxCell();
            column = new DataGridViewColumn();

            column.HeaderText = "Player Name";
            column.Name = "Name";
            column.DataPropertyName = "Name";
            column.CellTemplate = cell;
            column.FillWeight = 0.65F;
            column.SortMode = DataGridViewColumnSortMode.Automatic;

            this.playersGrid.Columns.Add( column );

            cell = new DataGridViewTextBoxCell();
            column = new DataGridViewColumn();

            column.HeaderText = "Start Time";
            column.Name = "StartTime";
            column.DataPropertyName = "StartTime";
            column.CellTemplate = cell;
            column.DefaultCellStyle.Format = "t";
            column.FillWeight = .35F;
            column.ReadOnly = true;
            column.SortMode = DataGridViewColumnSortMode.Automatic;

            this.playersGrid.Columns.Add( column );
        }

        private void FillPlayersGrid()
        {
            this.playersGrid.DataSource = null;
            this.playersBindingSource.DataSource = null;

            this.playersBindingSource.DataSource = _currentPlayers;
            this.playersGrid.DataSource = this.playersBindingSource;

            this.playersGrid.Sort( this.playersGrid.Columns["Name"], ListSortDirection.Ascending );
        }

        internal void SetCurrentTable( int tableNum )
        {
            if ( this.CurrentTable != null && this.playersGrid.Rows.Count > 0 )
            {
                this.playersGrid.EndEdit();
            }

            this.lblTableNum.Text = "Table " + Convert.ToString( tableNum );
            this.CurrentTable = TableDataService.GetTableByNum( tableNum );

            this.SetTableData();

            this.Show();

            this.playersGrid.Select();

            if ( this.playersGrid.Rows.Count > 0 )
            {
                this.playersGrid.Rows[0].Cells[1].Selected = true;
                this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                this.playersGrid.CurrentCell.Selected = true;
            }
        }

        private void SetTableData()
        {
            this.FillPlayersGrid();

            this.lblNumPlayers.Text = Convert.ToString( _currentTable.Players.Count ) +
                ((_currentTable.Players.Count == 1) ? " Player" : " Players");

            this.RefreshMoney();
        }

        private void RefreshMoney()
        {
            this.lblTotalMoneyValue.Text = string.Format("{0:C}", 
                PoolTimeFunctions.CalcTablePoolTime( _currentTable.TableNum, DateTime.Now ) );
        }

        private List<string> GetPlayerNames()
        {
            List<string> playerNames = new List<string>();

            for ( int i = 0; i < this.playersGrid.Rows.Count; i++ )
            {
                playerNames.Add( (string)this.playersGrid.Rows[i].Cells[1].Value );
            }

            return playerNames;
        }

        private List<string> GetPlayerNames( int rowIndex )
        {
            List<string> playerNames = new List<string>();

            for ( int i = 0; i < this.playersGrid.Rows.Count; i++ )
            {
                if ( i != rowIndex )
                {
                    playerNames.Add( (string)this.playersGrid.Rows[i].Cells[1].Value );
                }
            }

            return playerNames;
        }

        private void ViewPlayerDetails(int rowIndex)
        {
            int playerID = Convert.ToInt32( this.playersGrid.Rows[rowIndex].Cells[0].Value.ToString() );

            this.playersGrid.EndEdit();

            this.SetTableData();

            this.playersGrid.Select();
            this.playersGrid.Rows[0].Cells[1].Selected = true;
            this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
            this.playersGrid.CurrentCell.Selected = true;

            foreach ( DataGridViewRow row in this.playersGrid.Rows )
            {
                if ( Convert.ToInt32( row.Cells[0].Value.ToString() ) == playerID )
                {
                    this.playersGrid.ClearSelection();

                    row.Cells[1].Selected = true;
                    this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                    this.playersGrid.CurrentCell.Selected = true;
                }
            }

            ViewPlayerForm viewPlayerForm = new ViewPlayerForm( PlayerDataService.GetPlayerByID( playerID ) );

            viewPlayerForm.ShowDialog();

            this.SetTableData();

            playersGrid.ClearSelection();

            if ( this.playersGrid.Rows.Count > 0 )
            {
                this.playersGrid.Select();
                this.playersGrid.Rows[0].Cells[1].Selected = true;
                this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                this.playersGrid.CurrentCell.Selected = true;

                foreach ( DataGridViewRow row in this.playersGrid.Rows )
                {
                    if ( Convert.ToInt32( row.Cells[0].Value.ToString() ) == playerID )
                    {
                        this.playersGrid.ClearSelection();

                        row.Cells[1].Selected = true;
                        this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                        this.playersGrid.CurrentCell.Selected = true;
                    }
                }
            } else
            {
                this.Hide();
            }
        }

        public void MovePlayers( int tableNum )
        {
            int numPlayersOnTable = TableDataService.GetNumPlayers( tableNum );
            int numSelectedPlayers = this.playersGrid.SelectedRows.Count;

            this.playersGrid.EndEdit();

            if ( numPlayersOnTable + numSelectedPlayers > 9 )
            {
                MessageBox.Show( "Too many players. You can only have 9 players per table. Select another table or cancel.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            List<int> playerIDs = new List<int>();

            _movePlayersForm.DisableCancelButton();
            _movePlayersForm.ChangeDisplayText( "Moving players to table " + Convert.ToString( tableNum ) + ".....");

            foreach ( DataGridViewRow player in this.playersGrid.SelectedRows )
            {
                playerIDs.Add( Convert.ToInt32( player.Cells[0].Value.ToString() ) );
            }

            TableDataService.MovePlayers( playerIDs, tableNum );

            _movePlayersForm.Hide();

            _status = EditTableStatus.Done;

            this.Enabled = true;
        }

        private void playersGrid_CellEndEdit( object sender, DataGridViewCellEventArgs e )
        {
            playersGrid.Rows[e.RowIndex].ErrorText = String.Empty;

            List<string> playerNames = GetPlayerNames( e.RowIndex );
            string newPlayerName = PlayerNameFunctions.GetName( (string)playersGrid.Rows[e.RowIndex].Cells[1].Value,
                playerNames );
            playersGrid.Rows[e.RowIndex].Cells[1].Value = newPlayerName;

            TablesDB.DataContext.SubmitChanges();

            _status = EditTableStatus.Done;
        }

        private void btnRemove_Click( object sender, EventArgs e )
        {
            this.playersGrid.EndEdit();

            foreach ( DataGridViewCell cell in this.playersGrid.SelectedCells )
            {
                cell.OwningRow.Selected = true;
            }

            int selectedRowCount = this.playersGrid.Rows.GetRowCount( DataGridViewElementStates.Selected );

            string confirmMessage = string.Empty;

            if ( selectedRowCount < 1 )
            {
                MessageBox.Show( "No players are selected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );

                return;
            }

            if ( selectedRowCount == this.playersGrid.Rows.Count )
            {
                confirmMessage = "Are you sure you want to remove all of the players on this table?";
            } else if ( selectedRowCount > 1 )
            {
                confirmMessage = "Are you sure you want to remove the selected players from this table?";
            } else if ( selectedRowCount == 1 )
            {
                confirmMessage = "Are you sure you want to remove this player from the table?";
            } else
            {
                confirmMessage = "Confirm delete?";
            }

            if ( MessageBox.Show( confirmMessage, "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes )
            {
                for ( int i = 0; i < selectedRowCount; i++ )
                {
                    int playerID = Convert.ToInt32( this.playersGrid.SelectedRows[0].Cells[0].Value.ToString() );

                    this.playersGrid.Rows.Remove( this.playersGrid.SelectedRows[0] );

                    PlayerDataService.DeletePlayer( playerID );
                }

                TablesDB.DataContext.SubmitChanges();
                TableDataService.UpdateTimestamps( _currentTable, DateTime.Now );
                TablesDB.DataContext.SubmitChanges();

                this.SetTableData();

                playersGrid.ClearSelection();

                if ( this.playersGrid.Rows.Count > 0 )
                {
                    this.playersGrid.Rows[0].Cells[1].Selected = true;
                    this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                    this.playersGrid.CurrentCell.Selected = true;
                } else
                {
                    this.Hide();
                }
            }
        }

        private void btnViewPlayerDetails_Click( object sender, EventArgs e )
        {
            foreach ( DataGridViewCell cell in this.playersGrid.SelectedCells )
            {
                cell.OwningRow.Selected = true;
            }

            int selectedRowCount = this.playersGrid.Rows.GetRowCount( DataGridViewElementStates.Selected );

            if ( selectedRowCount < 1 )
            {
                MessageBox.Show( "No players are selected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );

                return;
            } else if ( selectedRowCount > 1 )
            {
                MessageBox.Show( "Too many players selected. You can only view one player at a time.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );

                return;
            }

            this.ViewPlayerDetails(this.playersGrid.SelectedRows[0].Index);
        }

        private void btnSelectAll_Click( object sender, EventArgs e )
        {
            if ( this.playersGrid.Rows.Count > 0 )
            {
                foreach (DataGridViewRow row in this.playersGrid.Rows)
                {
                    row.Selected = true;
                }

                if ( this.playersGrid.Rows.Count > 1 )
                {
                    this.btnViewPlayerDetails.Enabled = false;
                }
            }
        }

        private void playersGrid_CellStateChanged( object sender, DataGridViewCellStateChangedEventArgs e )
        {
            if ( playersGrid.Rows.Count <= 0 || playersGrid.SelectedCells.Count <= 0 )
            {
                return;
            }

            bool isMultiple = false;

            int selectedRowIndex = this.playersGrid.SelectedCells[0].OwningRow.Index;

            foreach ( DataGridViewCell cell in this.playersGrid.SelectedCells )
            {
                if ( cell.OwningRow.Index != selectedRowIndex )
                {
                    isMultiple = true;
                    break;
                }
            }

            if ( isMultiple )
            {
                this.btnViewPlayerDetails.Enabled = false;
            } else
            {
                this.btnViewPlayerDetails.Enabled = true;
            }
        }

        private void btnAddPlayer_Click( object sender, EventArgs e )
        {
            int numPlayers = this.playersGrid.Rows.Count;

            this.playersGrid.EndEdit();

            if ( numPlayers <= 8 )
            {
                DateTime timestamp = DateTime.Now;
                string playerName = PlayerNameFunctions.GetDefaultName( numPlayers + 1, GetPlayerNames() );

                PlayerDataService.AddPlayer( playerName, _currentTable.TableNum, numPlayers + 1, timestamp );

                TablesDB.DataContext.SubmitChanges();

                TableDataService.UpdateTimestamps( _currentTable, timestamp );

                TablesDB.DataContext.SubmitChanges();

                this.SetTableData();

                this.playersGrid.Select();
                this.playersGrid.ClearSelection();

                foreach (DataGridViewRow row in this.playersGrid.Rows)
                {
                    if ( row.Cells[1].Value.ToString() == playerName )
                    {
                        row.Cells[1].Selected = true;
                        this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                        this.playersGrid.CurrentCell.Selected = true;

                        break;
                    }
                }
            } else
            {
                MessageBox.Show( "Too many players", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void playersGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            this.playersGrid.EndEdit();
            this.ViewPlayerDetails( e.RowIndex );
        }

        private void btnMovePlayers_Click( object sender, EventArgs e )
        {
            foreach ( DataGridViewCell cell in this.playersGrid.SelectedCells )
            {
                cell.OwningRow.Selected = true;
            }

            int selectedRowCount = this.playersGrid.Rows.GetRowCount( DataGridViewElementStates.Selected );

            if ( selectedRowCount < 1 )
            {
                MessageBox.Show( "No players are selected!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );

                return;
            }

            _status = EditTableStatus.MovingPlayers;


            _movePlayersForm.Show();
            _movePlayersForm.Left = this.Parent.Left + (this.Width / 2) - (_movePlayersForm.Width / 2);
            _movePlayersForm.BringToFront();
            this.Enabled = false;
        }

        private void movePlayersForm_Canceled( object sender, EventArgs e )
        {
            this._status = EditTableStatus.Done;

            this._movePlayersForm.Hide();

            this.Enabled = true;
        }

        private void btnViewTableDetails_Click( object sender, EventArgs e )
        {
            this.playersGrid.EndEdit();

            this.SetTableData();

            TableDetailsForm tableDetailsForm = new TableDetailsForm( _currentTable );

            tableDetailsForm.ShowDialog();

            this.SetTableData();

            if ( this.playersGrid.Rows.Count < 1 )
            {
                this.Hide();
            } else
            {
                this.playersGrid.ClearSelection();

                this.playersGrid.Select();

                this.playersGrid.Rows[0].Cells[1].Selected = true;
                this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                this.playersGrid.CurrentCell.Selected = true;
            }
        }

        private void btnCashOut_Click( object sender, EventArgs e )
        {
            this.playersGrid.EndEdit();

            this.SetTableData();

            CashOutTableForm cashOutTableForm = new CashOutTableForm( _currentTable );

            cashOutTableForm.ShowDialog();

            this.SetTableData();

            if ( this.playersGrid.Rows.Count < 1 )
            {
                this.Hide();
            } else
            {
                this.playersGrid.ClearSelection();

                this.playersGrid.Select();

                this.playersGrid.Rows[0].Cells[1].Selected = true;
                this.playersGrid.CurrentCell = this.playersGrid.SelectedCells[0];
                this.playersGrid.CurrentCell.Selected = true;
            }
        }

        private void linkLabelRefresh_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.RefreshMoney();
        }

        private void btnDone_Click( object sender, EventArgs e )
        {
            this.Hide();
        }

        private void lblPlayers_Click( object sender, EventArgs e )
        {

        }

        private void playersGrid_CellValidating( object sender, DataGridViewCellValidatingEventArgs e )
        {

        }

        private void playersGrid_CellBeginEdit( object sender, DataGridViewCellCancelEventArgs e )
        {
            _status = EditTableStatus.Busy;
        }

        private void playersGrid_CellClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void EditTableForm_Load( object sender, EventArgs e )
        {

        }

        private void playersGrid_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void playersGrid_CellEnter( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void playersGrid_CellLeave( object sender, DataGridViewCellEventArgs e )
        {

        }
    }
}
