using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioContribuintesOOListaCsharp
{
    internal class TaxPayer
    {
        public double SalaryIncome { get; private set; }
        public double ServiceIncome { get; private set; }
        public double CapitalIncome { get; private set; }
        public double HealthSpeding {  get; private set; }  
        public double EducationSpending { get; private set; }

        public TaxPayer(double salaryIncome, double serviceIncome, double capitalIncome, double healthSpeding, double educationSpending)
        {
            SalaryIncome = salaryIncome;
            ServiceIncome = serviceIncome;
            CapitalIncome = capitalIncome;
            HealthSpeding = healthSpeding;
            EducationSpending = educationSpending;
        }


    }
}
