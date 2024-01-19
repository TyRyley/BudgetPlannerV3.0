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
    /// Interaction logic for Planner.xaml
    /// </summary>
    public partial class Planner : Window
    {
        // global variables

        CEOoffice ceo = new CEOoffice();

        // income
        double income = 0;
        double tax = 0;

        // expense
        List<double> expenses = new List<double>();  // expense List<T>

        // accomodation
        double rent = 0;


        double hlPrice = 0;
        double hlDeposit = 0;
        double hlInterest = 0;
        int hlNoMonths = 0;

        // car
        string carModel = "";
        double carPrice = 0;
        double carDeposit = 0;
        double carInterest = 0;
        double carInsurance = 0;

        // savings
        string savingsName = "";
        double savingsPrice = 0;
        double savingsInterest = 0;
        int savingsNoMonths = 0;

        public Planner()
        {
            InitializeComponent();
            
            gridExpenses.IsEnabled = false;
            accomType.IsEnabled = false;
            gridRent.IsEnabled = false;
            gridHomeLoan.IsEnabled = false;
            gridCarOption.IsEnabled = false;
            gridCar.IsEnabled = false;
            gridSaveOption.IsEnabled = false;
            gridSavings.IsEnabled = false;
            gridSummary.IsEnabled = false;
           
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)  // submit button (income)
        {
            try
            {
                income = Convert.ToDouble(tbIncome.Text); // store user's income
                tax = Convert.ToDouble(tbTax.Text);  // store user's monthly tax reduction

                // store input in ceo class
                ceo.Income = income;
                ceo.Tax = tax;
                MessageBox.Show("Great! Now for your monthly expenses ...");
                gridExpenses.IsEnabled = true;
                gridIncome.IsEnabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please enter a number (e.g. 3 000,50)");
            }
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)  // clear all (income)
        {
            tbIncome.Clear();
            tbTax.Clear();
        }

        private void helpBtn_Click(object sender, RoutedEventArgs e)  // help (income)
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program, we gather information about your income, to get an idea of how much you are able to spend." +
                "\nPlease enter your income details and click Submit to proceed." +
                "\n--------------");
        }

        private void expenseSubmitBtn_Click(object sender, RoutedEventArgs e)  // submit button (expense)
        {
            try
            {
                // add user's expense info to list
                expenses.Add(Convert.ToDouble(tbGroceries.Text));
                expenses.Add(Convert.ToDouble(tbOtherExpenses.Text));
                expenses.Add(Convert.ToDouble(tbPhone.Text));
                expenses.Add(Convert.ToDouble(tbTravel.Text));
                expenses.Add(Convert.ToDouble(tbWaterLights.Text));

                // store expenses in ceo class
                ceo.Expenses = expenses;
                ceo.calcTotalExpenses();  // calculate total expenses method

                MessageBox.Show("Great! Now for your accomodation ...");
                accomType.IsEnabled = true;
                gridExpenses.IsEnabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please enter a number (e.g. 1 000,50)");
            }
        }

        private void expenseHelp_Click(object sender, RoutedEventArgs e)  // help (expense)
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program, we gather information about your expenses, to get an idea of how much must be deducted from your income." +
                "\nPlease enter your expense details and click Submit to proceed." +
                "\n--------------");
        }

        private void expenseClear_Click(object sender, RoutedEventArgs e)  // clear all (expense)
        {
            tbGroceries.Clear();
            tbOtherExpenses.Clear();
            tbPhone.Clear();
            tbTravel.Clear();
            tbWaterLights.Clear();
        }

        private void activateRent_Click(object sender, RoutedEventArgs e)  // activate rent grid
        {
            gridRent.IsEnabled = true;
            accomType.IsEnabled = false;
        }

        private void activateHomeLoan_Click(object sender, RoutedEventArgs e)  // activate home loan grid
        {
            gridHomeLoan.IsEnabled = true;
            accomType.IsEnabled = false;
        }

        private void accomHelp_Click(object sender, RoutedEventArgs e)  // accomodation help button
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program, we need to know how you will be paying for a living space." +
                "\nPlease click on either the Rent or Buy option to proceed." +
                "\n--------------");
        }

        private void rentHelp_Click(object sender, RoutedEventArgs e)  // help (rent)
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program, we need to know how much you will be spending for a living space every month." +
                "\nPlease enter how much you will be paying for rent every month and click Submit to proceed." +
                "\n--------------");
        }

        private void rentSubmit_Click(object sender, RoutedEventArgs e)  // submit (rent)
        {
            try
            {
                // store user rent info
                rent = Convert.ToDouble(tbRent.Text);

                // store rent value in ceo class
                ceo.Rent = rent;
                MessageBox.Show("Great! Input accepted...");
                gridCarOption.IsEnabled = true;
                gridRent.IsEnabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please enter a number (e.g. 2 000,50)");
            }
        }

        private void homeLoanClear_Click(object sender, RoutedEventArgs e)  // clear all (homeLoan)
        {
            tbHLPrice.Clear();
            tbHLDeposit.Clear();
            tbHLInterest.Clear();
            tbHLNoMonths.Clear();
        }

        private void homeLoanHelp_Click(object sender, RoutedEventArgs e)  // help (homeLoan)
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program, we need to know how much you will be spending for a living space every month." +
                "\nPlease enter your home loan details and click Submit to proceed." +
                "\n--------------");
        }

        private void rentClear_Click(object sender, RoutedEventArgs e)  // clear (rent)
        {
            tbRent.Clear();
        }

        private void homeLoanSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // store user home loan info
                hlPrice = Convert.ToDouble(tbHLPrice.Text);
                hlDeposit = Convert.ToDouble(tbHLDeposit.Text);
                hlInterest = Convert.ToDouble(tbHLInterest.Text);
                hlNoMonths = Convert.ToInt32(tbHLNoMonths.Text);

                if (hlNoMonths > 240 && hlNoMonths < 360)  // checks if the user entered a value that is in range
                {
                        // store input in ceo class
                        ceo.HlPrice = hlPrice;
                        ceo.HlDeposit = hlDeposit;
                        ceo.HlInterest = hlInterest;
                        ceo.HlNoMonths = hlNoMonths;
                        ceo.homeLoan();  // call method to calculate monthly home loan pay
                        if (ceo.MonthlyHomeLoan > (ceo.Income / 3))
                        {
                            MessageBox.Show(ceo.NotifyUser);
                        }
                        MessageBox.Show("Great! Input accepted...");
                        gridCarOption.IsEnabled = true;
                        gridHomeLoan.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show("Enter a value between 240 and 360 for the number of months to repay the home loan.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please enter a number (e.g. 2 000,50).");
            }
        }

        private void carChoiceHelp_Click(object sender, RoutedEventArgs e)  // help (carOption)
        {
            MessageBox.Show("Hello dear user" +
               "\n--------------" +
               "\nIn this part of the program, we provide you with a short summary for your plan so far, and we give you the ability to add a car loan to your expenses." +
               "\nClick Buy a car or Continue program to proceed." +
               "\n--------------");
        }

        private void continueProgram_Click(object sender, RoutedEventArgs e)  // for user to skip car option
        {
            gridSaveOption.IsEnabled = true;
            gridCarOption.IsEnabled = false;
        }

        private void activateBuyCar_Click(object sender, RoutedEventArgs e)  // activate car grid
        {
            gridCar.IsEnabled = true;
            gridCarOption.IsEnabled = false;
        }

        private void carSubmit_Click(object sender, RoutedEventArgs e)  // submit (car)
        {
            try
            {
                // store user's info
                carModel = tbModel.Text;
                carPrice = Convert.ToDouble(tbPrice.Text);
                carDeposit = Convert.ToDouble(tbDeposit.Text);
                carInterest = Convert.ToDouble(tbInterest.Text);
                carInsurance = Convert.ToDouble(tbInsurance.Text);

                // pass input to car class
                Car c = new Car(carModel, carPrice, carDeposit, carInterest, carInsurance);
                ceo.CarCost = c.calcCarCost();  // calculate car cost and store it in ceoOffice

                if (ceo.TotExpenses > (income*0.75))  // notify user if their expenses including loan payments exceed 75% of their income
                {
                    MessageBox.Show(ceo.NotifyUserTwo);
                }
                

                MessageBox.Show("Great! Input accepted...");
                gridSaveOption.IsEnabled = true;
                gridCar.IsEnabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please enter a number (e.g. 3 000,50)");
            }
        }

        private void carClear_Click(object sender, RoutedEventArgs e)  // clear all (car)
        {
            tbDeposit.Clear();
            tbInsurance.Clear();
            tbInterest.Clear();
            tbModel.Clear();
            tbPrice.Clear();
        }

        private void carHelp_Click(object sender, RoutedEventArgs e)  // help (car)
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program, information about the car loan you are taking needs to be retrieved to be added to your expenses." +
                "\nEnter your car loan details and click Submit to continue." +
                "\n--------------");
        }

        private void activateSavings_Click(object sender, RoutedEventArgs e)  // activate savings grid
        {
            gridSavings.IsEnabled = true;
            gridSaveOption.IsEnabled = false;
        }

        private void continueProgramTwo_Click(object sender, RoutedEventArgs e)  // skip savings option
        {
            gridSummary.IsEnabled = true;
            summary.Text = ceo.finalSummary();
            gridSaveOption.IsEnabled = false;
        }

        private void saveOptionHelp_Click(object sender, RoutedEventArgs e)  // help (savingsOption)
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program where we give you the ability to add something that you would like to save for." +
                "\nClick START SAVING NOW or Continue program to proceed." +
                "\n--------------");
        }

        private void savingsSubmit_Click(object sender, RoutedEventArgs e)  // submit (savings)
        {
            try
            {
                // store user input
                savingsName = tbSavingsName.Text;
                savingsPrice = Convert.ToDouble(tbSavingsAmount.Text);
                savingsInterest = Convert.ToDouble(tbSavingsInterest.Text);
                savingsNoMonths = Convert.ToInt32(tbSavingsNoOfMonths.Text);

                Savings s = new Savings(savingsName, savingsPrice, savingsInterest, savingsNoMonths);
                ceo.SavingsCost = s.savingsCalc();  // calculate savings cost method called and answer store in ceo class
                ceo.SavingsName = s.setName();  // store name of saving  

                MessageBox.Show("Great! Now for your final summary ...");
                gridSummary.IsEnabled = true;
                summary.Text = ceo.finalSummary();
                gridSavings.IsEnabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. Please enter a number (e.g. 3 000,50)");
            }
        }

        private void savingsClear_Click(object sender, RoutedEventArgs e)  // clear (savings)
        {
            tbSavingsAmount.Clear();
            tbSavingsInterest.Clear();
            tbSavingsName.Clear();
            tbSavingsNoOfMonths.Clear();
        }

        private void helpClear_Click(object sender, RoutedEventArgs e)  // help (savings)
        {
            MessageBox.Show("Hello dear user" +
                "\n--------------" +
                "\nIn this part of the program, you will be able to save for something particular." +
                "\nEnter the details of your Saving, and click Submit to proceed." +
                "\n--------------");
        }

        private void summaryHelp_Click(object sender, RoutedEventArgs e)  // help (summary)
        {
            MessageBox.Show("Hello dear user, welcome to the end of the program" +
               "\n--------------" +
               "\nThis is your final summary, your Budget plan. Thanks for using the program!" +
               "\nClick Dashboard to restart the program, or click Exit to exit the program." +
               "\n--------------");
        }

        private void endProgram_Click(object sender, RoutedEventArgs e)  // end program (summary)
        {
            this.Close();
        }

        private void dashboardBtn_Click(object sender, RoutedEventArgs e)  // dashboard navigation
        {
            Dashboard d = new Dashboard();
            this.Close();
            d.Show();
        }
    }
}
