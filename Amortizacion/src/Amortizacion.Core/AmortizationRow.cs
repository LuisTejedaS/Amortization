using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortization.Schema
{
    public class AmortizationRow
    {
        public int Period { get; set; }
        public double Cuote { get; set; }
        public double Interests { get; set; }
        public double NewBalance { get; set; }
        public double Amortization { get; set; }


        public AmortizationRow( )
        {
             
        }

        public AmortizationRow(int period, double cuote, double interests, double newBalance, double amortization)
        {
            Period = period;
            Cuote = cuote;
            Interests = interests;
            NewBalance = newBalance;
            Amortization = amortization;
        }
    }
}
