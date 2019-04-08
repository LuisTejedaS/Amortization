using Amortization.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortizaciones
{
    public class FinantialFunctions
    {

        /// <summary>
        /// Calcula la cuota fija en base al total del préstamo la tasa y el numero de periodos
        /// R = P[(i(1 + i)n) / ((1 + i)n – 1)]
        /// P = principal(préstamo adquirido)
        /// i = tasa de interés
        /// n = número de periodos
        /// </summary>
        /// <param name="totalLoan">Total Loan amount </param
        /// <param name="rate">Loan Rate 1 relative E.G. .04 = 4%</param>
        ///  <param name="periodsNumber">Total number of payments</param> 
        public static double CalculateFixCuote(double totalLoan, double rate, int periodsNumber)
        {
            double fixCuote = 0;
            fixCuote = totalLoan * ((rate * Math.Pow((1 + rate), periodsNumber)) / (Math.Pow((1 + rate), periodsNumber) - 1));
            return fixCuote;
        }

        //public int Period { get; set; }
        //public double Cuote { get; set; }
        //public double Interests { get; set; }
        //public double NewBalance { get; set; }
        //public double Amortization { get; set; }

        /// <summary>
        /// Calcula la cuota fija en base al total del préstamo la tasa y el numero de periodos
        /// R = P[(i(1 + i)n) / ((1 + i)n – 1)]
        /// P = principal(préstamo adquirido)
        /// i = tasa de interés
        /// n = número de periodos
        /// </summary>
        /// <param name="balance">Total outstanding balance </param
        /// <param name="rate">Loan Rate 1 relative E.G. .04 = 4%</param>
        /// <param name="actualPeriodNumber">Actual number of payment</param> 
        /// <param name="fixCoute">Fix Cuote to pay</param> 
        public static AmortizationTable CalculateAmortizationTable(double balance, double rate, int actualPeriodNumber, double fixCoute)
        {
            AmortizationTable table = new AmortizationTable();
            table.Rows = new List<AmortizationRow>();
            AmortizationRow amortizationActualRow;
            double intereses = 0;
            double amortization = 0;
            double newBalance = balance;


            while (newBalance > 0)
            {
                intereses = newBalance * rate;
                amortization = fixCoute - intereses;
                newBalance = newBalance - amortization;
                amortizationActualRow = new AmortizationRow(actualPeriodNumber++, fixCoute, intereses, newBalance, amortization);
                table.Rows.Add(amortizationActualRow);
            }
            return table;
        }


        public static Dictionary<int, double> CalculatePossibilities(int minPeriods, int maxPeriods, double maxPeriodPossibility)
        {
            Dictionary<int, double> dic = new Dictionary<int, double>();
            for (int i = minPeriods; i < maxPeriods; i++)
            {
                var res = i * maxPeriodPossibility;
                dic.Add(i, res);
            }
            return dic;
        }
    }
}
