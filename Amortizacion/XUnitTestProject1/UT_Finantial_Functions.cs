using Amortizaciones;
using Amortization.Schema;
using System;
using System.Configuration;
using System.Diagnostics;
using Xunit;

namespace XUnitTestProject1
{
    public class UT_Finantial_Functions
    {


        static double totalLoan;
        static double rate;
        static int periodsNumber;
        static double fixCoute;




        [Theory]
        [InlineData(50000, .03, 40, 2163.12)]
        [InlineData(12000, .07, 5, 2926.69)]
        [InlineData(1000, .04, 5, 224.63)]
        public void UT_Calculate_Fix_Cuote(double totalLoan, double rate, int periodsNumber, double fixCoute)
        {
            
            var result = FinantialFunctions.CalculateFixCuote(totalLoan, rate, periodsNumber);
            var rounded = Math.Round(result, 2);
            Assert.Equal(fixCoute, rounded);
        }

        [Theory]
        [InlineData(50000, .03, 40, 2163.12)]
        [InlineData(12000, .07, 5, 2926.69)]
        [InlineData(1000, .04, 5, 224.63)]
        public void UT_Calculate_Amortization_table(double totalLoan, double rate, int periodsNumber, double fixCoute)
        {
            try
            {
                
                var result = FinantialFunctions.CalculateFixCuote(totalLoan, rate, periodsNumber);
                var rounded = Math.Round(result, 2);
                Assert.Equal(fixCoute, rounded);
                AmortizationTable table = new AmortizationTable();
                table = FinantialFunctions.CalculateAmortizationTable(totalLoan, rate, 1, rounded);
                Trace.TraceInformation(table.PrintString());
            }
            catch (Exception ex)
            {
                Assert.True(false, ex.Message);
            }
        }

        [Fact]

        public void UT_Calculate_Amortization_table2()
        {
            var table = FinantialFunctions.CalculatePossibilities(1, 36, 10000);
        }


    }
}
