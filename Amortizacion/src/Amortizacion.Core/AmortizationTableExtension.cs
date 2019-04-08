using Amortization.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortization.Schema
{
    public static class AmortizationTableExtension
    {

        public static string PrintString(this AmortizationTable amortizationTable)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(System.Environment.NewLine + "numero periodo\t" + "interés\t" + "amortizacion\t" + "cuota\t" + "final\t" + System.Environment.NewLine);
            foreach (AmortizationRow actual in amortizationTable.Rows)
            {
                builder.Append(actual.Period + "\t" + actual.Interests + "\t" + actual.Amortization + "\t" + actual.Cuote + "\t" + actual.NewBalance + System.Environment.NewLine);
            }

            return builder.ToString();
        }
    }
}
