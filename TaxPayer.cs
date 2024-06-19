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

        public double SalaryTax()
        {
            double monthlySalary = SalaryIncome / 12;
            if (monthlySalary < 3000)
            {
                return 0.0;
            }
            else
            {
                 if (monthlySalary < 5000.00)
                {
                    return SalaryIncome * 0.10;
                }
                else
                {
                    return SalaryIncome * 0.20;
                }
            }
        }

        public double ServiceTax()
        {
            return ServiceIncome * 0.15;
        }

        public double CapitalTax()
        {
            return CapitalIncome * 0.20;
        }

        public double GrossTax() 
        {
            return SalaryTax() + ServiceTax() + CapitalTax();

        }

        public double TaxRebate()
        {
            double maxRebate = GrossTax() * 0.30;
            double actualRebate = HealthSpeding + EducationSpending;
            return Math.Min(actualRebate, maxRebate);
        }

        public double NetTax()
        {
            return GrossTax() - TaxRebate();
        }


    }
}
