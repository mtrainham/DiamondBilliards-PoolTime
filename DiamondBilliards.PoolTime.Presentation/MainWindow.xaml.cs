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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PoolTable[] _tables = new PoolTable[15];
        private PoolTable _selectedTable = null;
        private bool _isExit = false;
        private bool _isNewUpdate = false;
        private string _appVersion = "2.0.0.0";

        public MainWindow()
        {
            InitializeComponent();

            // set array of pool table controls
            _tables[1] = this.poolTable1;
            _tables[2] = this.poolTable2;
            _tables[3] = this.poolTable3;
            _tables[4] = this.poolTable4;
            _tables[5] = this.poolTable5;
            _tables[6] = this.poolTable6;
            _tables[7] = this.poolTable7;
            _tables[8] = this.poolTable8;
            _tables[9] = this.poolTable9;
            _tables[10] = this.poolTable10;
            _tables[11] = this.poolTable11;
            _tables[12] = this.poolTable12;
            _tables[13] = this.poolTable13;
            _tables[14] = this.poolTable14;

            try
            {
                // set all table's status and events
                this.SetTableStatus();
            }

            catch
            {
                MessageBox.Show( "Uh oh... Can't connect to database. " +
                        "Try restarting the computer or reinstalling this program. Now exiting....",
                        "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Error );

                _isExit = true;
            }
        }

        private void SetTableStatus()
        {
            for ( int i = 1; i < _tables.Length; i++ )
            {
                _tables[i].Status = TableDataService.GetStatusByTableNum( i );

                TableDataService.SetStatusChangedHandler( i, new EventHandler( _tables[i].Table_StatusChanged ) );
            }
        }

        private void Table_Click( object sender, MouseButtonEventArgs e )
        {
            PoolTable table = (PoolTable)sender;
            PoolTable receiver = new PoolTable();
            receiver.TableNum = 15;
            MessageBox.Show( Convert.ToString(table.TableNum) );
            e.Handled = true;
        }

        private void AppWindow_Loaded( object sender, RoutedEventArgs e )
        {
            if ( _isExit )
            {
                MessageBox.Show( "fuck the shit is broke. EXIT!!!!" );
            }
        }
    }
}