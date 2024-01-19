using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerV3._0
{
    public class Savings  // class used to create Savings object, calculate savings and return name of savings
    {
        private string name = "";
        private double price = 0;
        private double interest = 0;
        private int noMonths = 0;

        public Savings(string name, double price, double interest, int noMonths)  // constructor
        {
            this.name = name;
            this.price = price;
            this.interest = interest;
            this.noMonths = noMonths;
        }

        public double savingsCalc()  // savings calculation
        {
            double savingsCost = 0;

            savingsCost = price/noMonths/(interest/100);

            return savingsCost;  // returns savings cost
        }

        public string setName()  // retrive name of saving
        {

            return name;
        }
    }
}
