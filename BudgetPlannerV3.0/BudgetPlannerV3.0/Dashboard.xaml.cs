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
using System.Windows.Shapes;

namespace BudgetPlannerV3._0
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)  // first listview item selected
        {
            // navigate to another screen
            // create an object of the class
            Planner p = new Planner();
            this.Close();
            p.Show();  // opens planner screen
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e) // second listview item selected
        {
            // navigate to another screen
            // create an object of the class
            About a = new About();
            this.Close();
            a.Show();  // opens about screen
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e) // third listview item selected
        {
            // closes app
            this.Close();
        }
    }
}
