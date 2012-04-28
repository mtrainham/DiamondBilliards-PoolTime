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
using DiamondBilliards.PoolTime.Data;
using DiamondBilliards.PoolTime.Business;

namespace DiamondBilliards.PoolTime.Presentation
{
    public partial class AppForm : Form
    {
        private EditTableForm editTableForm;

        // array of pool table controls
        public PoolTableControl[] PoolTables = new PoolTableControl[15];

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

            // set all table controls' respective table number
            this.SetTableNum();


            // set all table's status and events
            this.SetTableStatus();

            // initialize edit table form and set its properties
            this.SetEditTableForm();
           
            // set each table's click event
            this.SetTableClickEvent();
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
            PoolTableControl poolTable = (PoolTableControl)sender;

            if (poolTable.Status == TableStatus.Inactive)
            {
                AddTableForm newTableForm = new AddTableForm(poolTable.TableNum);
                newTableForm.ShowDialog();
            } else if (poolTable.Status == TableStatus.Active)
            { }
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
            editTableForm = new EditTableForm();
            editTableForm.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(editTableForm);
            editTableForm.Dock = DockStyle.Fill;
            editTableForm.BringToFront();
            editTableForm.Show();
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

        private void AppForm_Load(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
