using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerV3._0
{
    class CEOoffice : Expense  // uses Expense class (abstract) to pull abstract methods
    {
        public CEOoffice()
        {
            // default constructor
        }

        // income
        double income = 0;
        double tax = 0;

        // expense
        List<double> expenses = new List<double>();  // expense List<T>
        double totExpenses = 0;

        // accomodation
        double rent = 0;

        double hlPrice = 0;
        double hlDeposit = 0;
        double hlInterest = 0;
        int hlNoMonths = 0;
        double monthlyHomeLoan = 0;
        string notifyUser = "ALERT: the approval of the home loan is unlikely because it costs more than a third of your monthly income.";

        // car
        double carCost = 0;
        string notifyUserTwo = "ALERT: the total expenses including loan repayments exceed 75%.";

        // savings
        string savingsName = "";
        double savingsCost = 0;

        // gets and sets
        public double Income { get => income; set => income = value; }
        public double Tax { get => tax; set => tax = value; }
        public List<double> Expenses { get => expenses; set => expenses = value; }
        public double Rent { get => rent; set => rent = value; }
        public double HlPrice { get => hlPrice; set => hlPrice = value; }
        public double HlDeposit { get => hlDeposit; set => hlDeposit = value; }
        public double HlInterest { get => hlInterest; set => hlInterest = value; }
        public int HlNoMonths { get => hlNoMonths; set => hlNoMonths = value; }
        public double MonthlyHomeLoan { get => monthlyHomeLoan; set => monthlyHomeLoan = value; }
        public string NotifyUser { get => notifyUser; set => notifyUser = value; }
        public double CarCost { get => carCost; set => carCost = value; }
        public string NotifyUserTwo { get => notifyUserTwo; set => notifyUserTwo = value; }
        public double TotExpenses { get => totExpenses; set => totExpenses = value; }
        public string SavingsName { get => savingsName; set => savingsName = value; }
        public double SavingsCost { get => savingsCost; set => savingsCost = value; }

        override public double homeLoan() // monthly home loan repayment calculation
        {
            /* Formula for monthly home loan repayment:
             * monthlyLoanRepayment = ( hlPrice * hlInterest * ( 1 + hlInterest ) raised to the exponent hlNoMonths ) divided by ( 1 + hlInterest ) raised to the exponent hlNoMonths - 1
             */

            //calc
            hlPrice = hlPrice - hlDeposit;  // to get total price of loan after deposit is paid
            hlInterest = hlInterest / 100;  // converts user's answer to a valid value for interest (percentage)

            //calculation
            monthlyHomeLoan = hlPrice * hlInterest / 12 * Math.Pow(1 + hlInterest / 12, hlNoMonths) / Math.Pow(1 + hlInterest / 12, hlNoMonths) - 1;

            return monthlyHomeLoan;
        }

        override public void calcTotalExpenses()
        {
            foreach (int i in expenses)  // add up all expenses
            {
                totExpenses += i;  // adds each value in the expenses list and stores it in totExpen
            }

            totExpenses += monthlyHomeLoan += carCost;  // add home loan to total expenses
        }

        override public string finalSummary()
        {
            // variables
            string output = "";

            string heading = "FINAL SUMMARY\n\n";
            string inco = "";  // income
            string headingTwo = "\n\nExpenses:\n";
            string expen = "";
            string expenDisplay = "";
            string accom = "";
            string car = "";
            string savings = "";
            double moneyLeftOver = income - tax - totExpenses - SavingsCost;

            inco = "Income:\t\t\tR" + income + "\nDeducted tax:\t\tR" + tax; 

            // sort expenses in descending order
            expenses.Sort();
            expenses.Reverse();

            int num = 1;
            foreach (int i in expenses)  // display expenses in descending
            {
                expen = num + ": R" + i;
                num++;
                expenDisplay = expenDisplay + expen + "\n";
            }

            if (rent > 0)
            {
                accom = "\nMonthly rent cost:\tR" + rent;
            }

            if (monthlyHomeLoan > 0)
            {
                accom = "\nMonthly home loan cost:\tR" + monthlyHomeLoan;
            }

            if (carCost > 0)
            {
                car = "\n\nMonthly car cost:\t\tR" + carCost;
            }

            if (SavingsCost > 0)
            {
                savings = "\n\nSavings name:\t\t" + SavingsName + "\nSavings cost:\t\tR" + SavingsCost;
            }

            output = heading + inco + headingTwo + expenDisplay + accom + car + savings + "\n\nMoney left over:\t\tR" + moneyLeftOver;

            return output;
        }
    }
}
