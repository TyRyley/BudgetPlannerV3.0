using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlannerV3._0
{
    abstract class Expense
    {
        // abstract methods

        public abstract void calcTotalExpenses();
        public abstract double homeLoan();
        public abstract string finalSummary();

        
    }
}
