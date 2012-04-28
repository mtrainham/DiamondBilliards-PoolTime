using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DiamondBilliards.PoolTime.Business;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Presentation
{
    /// <summary>
    /// Interaction logic for PoolTable.xaml
    /// </summary>
    public partial class PoolTable : UserControl
    {
        private int _tableNum = 0;
        private bool _isHorizontal = true;
        private TableStatus _status;

        public int TableNum
        {
            get { return _tableNum; }

            set 
            { 
                _tableNum = value;
                lblTableNum.Content = value;
            }
        }

        public TableStatus Status
        {
            get { return _status; }

            set
            {
                _status = value;
                UpdateTableImage();
            }
        }

        public bool IsHorizontal
        {
            get { return _isHorizontal; }
            set 
            {
                if ( value != _isHorizontal )
                {
                    _isHorizontal = value;

                    if ( !_isHorizontal )
                    {
                        RotateTransform rotateTransform1 = new RotateTransform( 90 );
                        RotateTransform rotateTransform2 = new RotateTransform( 270 );

                        rotateTransform1.CenterX = 75;
                        rotateTransform1.CenterY = 40;
                        
                        this.RenderTransform = rotateTransform1;

                        rotateTransform2.CenterX = this.lblTableNum.Width / 2;
                        rotateTransform2.CenterY = this.lblTableNum.Height / 2;

                        this.lblTableNum.RenderTransform = rotateTransform2;
                    } else
                    {
                        this.RenderTransform = Transform.Identity;
                        this.lblTableNum.RenderTransform = Transform.Identity;
                    }
                }
            }
        }

        public PoolTable()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded( object sender, RoutedEventArgs e )
        {

        }

        public void Table_StatusChanged( object sender, EventArgs e )
        {
            this.Status = ( (DiamondBilliards.PoolTime.Data.PoolTable)sender ).Status;
        }

        private void UpdateTableImage()
        {
            ImageBrush newImage;

            if ( _status == TableStatus.Active )
            {
                if ( _tableNum < 12 )
                {
                    newImage = new ImageBrush( new BitmapImage(
                        new Uri( @"pack://application:,,,/PoolTime;component/Images/table_green_active.gif" ) ) );
                } else
                {
                    newImage = new ImageBrush( new BitmapImage(
                        new Uri( @"pack://application:,,,/PoolTime;component/Images/table_blue_active.gif" ) ) );
                }
            } else
            {
                newImage = new ImageBrush( new BitmapImage(
                    new Uri( @"pack://application:,,,/PoolTime;component/Images/table_inactive.gif" ) ) );
            }

            this.Background = newImage;
        }
    }
}
