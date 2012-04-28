using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiamondBilliards.PoolTime.Data;
using DiamondBilliards.PoolTime.Business;

namespace DiamondBilliards.PoolTime.Presentation
{
    public partial class PoolTableControl : UserControl
    {
        private int tableNum = 0;
        private TableStatus status;
        private bool isRotated = false;

        public LabelClickHandlerDelegate LabelClickHandler { private get; set; }
        
        public PoolTableControl()
        {
            InitializeComponent();

            tableNumLabel.BackColor = Color.Transparent;
            tableNumLabel.Parent = this;

            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;

            this.Status = TableStatus.Inactive;
        }

        // custom property for table number
        [Category("_Custom"),
        Description("Pool table number")]
        public int TableNum
        {
            get { return tableNum; }
            set
            {
                this.Name = "table" + Convert.ToString(value);
                tableNum = value;
                tableNumLabel.Text = Convert.ToString(value);

                

                CenterTableNumLabel();
            }
        }

        // custom property that rotates pool table image 90 degrees
        [Category("_Custom"),
        Description("Pool table is either horizontal or vertical")]
        public bool IsRotated
        {
            get { return isRotated; }
            set
            {
                if (value != isRotated)
                {
                    isRotated = value;
                    UpdateTableImage();
                }
            }
        }

        public TableStatus Status
        {
            get { return status; }
            set
            {
                    status = value;
                    UpdateTableImage();
            } // end set
        } // end property Status

        private void rotatePicture()
        {
            int newWidth = this.Height;
            int newHeight = this.Width;

            if (isRotated == true)
            {
                this.BackgroundImage = Properties.Resources.diamondtable1_active;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.diamondtable2_active;
            }

            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;

            Invalidate();
        }

        private void CenterTableNumLabel()
        {
            tableNumLabel.Left = (tableNumLabel.Parent.Width - tableNumLabel.Width) / 2;
            tableNumLabel.Top = (tableNumLabel.Parent.Height - tableNumLabel.Height) / 2;
        }

        // update table image based on table status and whether it's rotated or not
        private void UpdateTableImage()
        {
            switch (this.Status)
            {
                case TableStatus.Inactive:
                    if (this.IsRotated == true)
                    {
                        this.BackgroundImage = Properties.Resources.diamondtable1_inactive;
                    }
                    else
                    {
                        this.BackgroundImage = Properties.Resources.diamondtable2_inactive;
                    }
                    break;
                case TableStatus.Active:
                    if (this.IsRotated == true)
                    {
                        this.BackgroundImage = Properties.Resources.diamondtable1_active;
                    }
                    else
                    {
                        this.BackgroundImage = Properties.Resources.diamondtable2_active;
                    }
                    break;
                default:
                    if (this.IsRotated == true)
                    {
                        this.BackgroundImage = Properties.Resources.diamondtable1_inactive;
                    }
                    else
                    {
                        this.BackgroundImage = Properties.Resources.diamondtable2_inactive;
                    }
                    break;
            } // end switch

            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;

            Invalidate();
        } // end method UpdateTableImage

        private void PoolTableControl_Load(object sender, EventArgs e)
        {

        }

        private void PoolTableControl_SizeChanged(object sender, EventArgs e)
        {
            CenterTableNumLabel();
        }

        // catches label click event and calls delegate method in main form
        private void tableNumLabel_Click(object sender, EventArgs e)
        {
            if (LabelClickHandler != null)
            {
                LabelClickHandler(this, EventArgs.Empty);
            } // end if
        } // end method tableNumLabel_Click

        public void Table_StatusChanged(object sender, EventArgs e)
        {
            this.Status = ((PoolTable)sender).Status;
        }
    }
}
