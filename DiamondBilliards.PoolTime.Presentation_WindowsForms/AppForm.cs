/*********************************************************************
 * SixSence.PoolTime.Client: AppForm.cs
 * By: Mitch Trainham
 * Last Updated:
 * 
 * Contains the main/parent form for the application
 *********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Deployment;
using DiamondBilliards.PoolTime.Data;
using DiamondBilliards.PoolTime.Business;

namespace DiamondBilliards.PoolTime.Presentation
{
    public partial class AppForm : Form
    {
        private MainDetailsForm _mainDetailsForm;
        private EditTableForm _editTableForm;
        private PoolTableControl _selectedTable = null;
        private string _appVersion = string.Empty;
        private bool _isExit = false;
        private bool _isNewUpdate = false;

        // array of pool table controls
        public PoolTableControl[] PoolTables = new PoolTableControl[15];

        public PoolTableControl SelectedTable
        {
            get { return this._selectedTable; }

            set
            {
                if ( this._selectedTable != null )
                {
                    this._selectedTable.IsSelected = false;
                }

                this._selectedTable = value;

                if ( this._selectedTable != null )
                {
                    this._selectedTable.IsSelected = true;
                }
            }
        }

        // constructor
        public AppForm()
        {
            InitializeComponent(); // initialize form

            // set array of pool table controls
            PoolTables[1] = this.table1;
            PoolTables[2] = this.table2;
            PoolTables[3] = this.table3;
            PoolTables[4] = this.table4;
            PoolTables[5] = this.table5;
            PoolTables[6] = this.table6;
            PoolTables[7] = this.table7;
            PoolTables[8] = this.table8;
            PoolTables[9] = this.table9;
            PoolTables[10] = this.table10;
            PoolTables[11] = this.table11;
            PoolTables[12] = this.table12;
            PoolTables[13] = this.table13;
            PoolTables[14] = this.table14;

            try
            {
                // set all table controls' respective table number
                this.SetTableNum();

                // set all table's status and events
                this.SetTableStatus();

                // initialize main details form and set its properties
                this.SetMainDetailsForm();

                // initialize edit table form and set its properties
                this.SetEditTableForm();

                // set each table's click event
                this.SetTableClickEvent();
            }

            catch
            {
                MessageBox.Show( "Uh oh... Can't connect to database. " +
                        "Try restarting the computer or reinstalling this program. Now exiting....",
                        "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                _isExit = true;
            }
        }

        private void AppForm_Load( object sender, EventArgs e )
        {
            if ( _isExit )
            {
                Application.Exit();
            }

            if ( System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed )
            {
                _appVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

                if ( System.Deployment.Application.ApplicationDeployment.CurrentDeployment.IsFirstRun )
                {
                    _isNewUpdate = true;
                } else
                {
                    _isNewUpdate = false;
                }
            } else
            {
                _isNewUpdate = false;
                _appVersion = "1.0.0.0";
            }

            if ( _isNewUpdate )
            {
                string newUpdateUrl = "http://www.pooltime.us/update.htm";
                WebBrowserForm webBrowserForm = new WebBrowserForm( newUpdateUrl );
                webBrowserForm.ShowDialog();
            }
        }

        private void SetMainDetailsForm()
        {
            _mainDetailsForm = new MainDetailsForm();
            _mainDetailsForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add( _mainDetailsForm );
            _mainDetailsForm.Dock = DockStyle.Fill;
            _mainDetailsForm.BringToFront();
            _mainDetailsForm.Show();
        } // end constructor

        // set table number for every pool table control
        private void SetTableNum()
        {
            for (int i = 1; i < PoolTables.Count(); i++)
            {
                PoolTables[i].TableNum = i;
            }
        }

        // initializes table and app properties from database
        private void SetTableClickEvent()
        {
            LabelClickHandlerDelegate handler =
                new LabelClickHandlerDelegate(table_Click);

            for (int i = 1; i < PoolTables.Count(); i++)
            {
                PoolTables[i].LabelClickHandler = handler;
            }
        }

        // called when a pool table control is clicked
        private void table_Click(object sender, EventArgs e)
        {
            try
            {
                PoolTableControl activeTable = (PoolTableControl)sender;

                if ( _editTableForm.Status != EditTableStatus.MovingPlayers )
                {
                    if ( activeTable.Status == TableStatus.Inactive )
                    {
                        _editTableForm.Hide();

                        AddTableForm newTableForm = new AddTableForm( activeTable.TableNum );

                        newTableForm.ShowDialog();
                    } else if ( activeTable.Status == TableStatus.Active )
                    {
                        SelectedTable = activeTable;
                        _editTableForm.SetCurrentTable( activeTable.TableNum );
                    }
                } else if ( _editTableForm.Status == EditTableStatus.MovingPlayers &&
                    _editTableForm.CurrentTable != null )
                {
                    _editTableForm.MovePlayers( activeTable.TableNum );

                    if ( _editTableForm.Status == EditTableStatus.Done )
                    {
                        SelectedTable = activeTable;

                        _editTableForm.SetCurrentTable( activeTable.TableNum );
                    }
                }

                _mainDetailsForm.RefreshData();
            }

            catch
            {
                MessageBox.Show( "Hmmm... A database error occurred. Try again, then restart the program and/or the computer "
                    + "if the error persists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );

                _editTableForm.Hide();
            }
        }

        private void SetTableStatus()
        {
            for (int i = 1; i < PoolTables.Length; i++)
            {
                PoolTables[i].Status = TableDataService.GetStatusByTableNum(i);

                TableDataService.SetStatusChangedHandler(i, new EventHandler(PoolTables[i].Table_StatusChanged));
            }
        }

        private void SetEditTableForm()
        {
            _editTableForm = new EditTableForm();
            _editTableForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(_editTableForm);
            _editTableForm.Dock = DockStyle.Fill;
            _editTableForm.VisibleChanged += new EventHandler(_editTableForm_VisibleChanged);
            _editTableForm.BringToFront();
        }

        #region form control events
        // open diamond billiards website in a browser
        private void diamondWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.diamondbilliardsllc.com");
        }

        // open the diamond billiards facebook page in a browser
        private void diamondOnFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/pages/Midlothian-VA/Diamond-Billiards-Richmond/113956249358?ref=nf");
        }

        // open AccuPOS application if it is not already open,
        // otherwise switch focus to that application
        private void openAccuPosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // code to open AccuPOS application
        }

        // exit the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // display the AboutBox form which displays information about the application
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox applicationInfo = new AboutBox(); // create new AboutBox form
            applicationInfo.ShowDialog(); // show the AboutBox form
        }

        private void _editTableForm_VisibleChanged( object sender, EventArgs e )
        {
            if ( !_editTableForm.Visible )
            {
                SelectedTable = null;

                _mainDetailsForm.RefreshData();
                _mainDetailsForm.Show();
            } else
            {
                _mainDetailsForm.Hide();
            }
        }

        private void clearAllTablesToolStripMenuItem_Click( object sender, EventArgs e )
        {
            try
            {
                if ( TableDataService.GetNumActiveTables() < 1 )
                {
                    MessageBox.Show( "Woops! No tables are currently on time.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error );

                    return;
                }

                if ( MessageBox.Show( "Woah! This will delete all players and reset all tables. Continue!?...", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes )
                {
                    if ( _editTableForm.Visible )
                    {
                        _editTableForm.Finish();
                    }

                    TableDataService.StopAllTables();

                    DBDataService.ResetDB();

                    MessageBox.Show( "All tables are now off time", "Done", MessageBoxButtons.OK,
                        MessageBoxIcon.Information );
                }

                _mainDetailsForm.RefreshData();
            }

            catch
            {
                MessageBox.Show( "An error occurred trying to stop all of the tables. " +
                        "Try again, or try stopping each table individually.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void poolTableControl6_Load(object sender, EventArgs e)
        {

        }

        private void poolTableControl4_Load(object sender, EventArgs e)
        {

        }

        #endregion
    } // end partial class AppForm
} // end namespace SixSence.PoolTime.Client
