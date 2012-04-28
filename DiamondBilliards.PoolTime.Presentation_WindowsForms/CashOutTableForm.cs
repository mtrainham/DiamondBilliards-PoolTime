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
    public partial class CashOutTableForm : Form
    {
        private PoolTable _table = null;
        private DateTime _currentTime = DateTime.Now;

        public CashOutTableForm(PoolTable table)
        {
            _table = table;

            InitializeComponent();

            this.SetTableData();

            this.SetPlayerData();
        }

        private void SetTableData()
        {
            this.Text = "Cash out table " + Convert.ToString( _table.TableNum );

            this.lblTotalAmountValue.Text = string.Format( "{0:C}", 
                PoolTimeFunctions.CalcTablePoolTime( _table, _currentTime ) );
        }

        private void SetPlayerData()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewColumn column = new DataGridViewColumn();

            column.HeaderText = "Player Name";
            column.Name = "Name";
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

            this.gridPlayers.Rows.Add( _table.Players.Count );

            int i = 0;

            foreach ( Player player in _table.Players )
            {
                this.gridPlayers.Rows[i].Cells["Name"].Value = player.Name;

                this.gridPlayers.Rows[i].Cells["Amount"].Value = string.Format( "{0:C}",
                    PoolTimeFunctions.CalcPlayerPoolTime( player, _currentTime ) );

                i++;
            }
        }

        private void btnStopTable_Click( object sender, EventArgs e )
        {
            TableDataService.StopTable( _table );

            this.Close();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
