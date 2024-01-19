/* Student Number: ST10084621
 * Name: Tyreece Ryley Pillay
 * BCAD year 2 -- Group 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;  // import used for splash

namespace BudgetPlannerV3._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create object used for splash to get to next window
        DispatcherTimer dt = new DispatcherTimer();
        

        public MainWindow()
        {
            InitializeComponent();

            // call timer for splash
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 3);  // 0 days, 0 hours, 3 seconds
            dt.Start();  // start timer
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();  // create object of next window to navigate to it
            d.Show();  // open next window
            dt.Stop(); // stop timer
            this.Close();  // close current window
        }
    }
}
