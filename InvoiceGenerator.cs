using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator1
{
    public class InvoiceGenerator

    {
        private readonly double COST_PER_KILOMETER = 10.0;
        private readonly double COST_PER_MINUTE = 1.0;
        private readonly double MINIMUM_FARE = 5.0;
        private double cabFare = 0.0;
        public double CalculateFare(double distance, double time)
        {
            try
            {
                this.cabFare = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
                if (this.cabFare < MINIMUM_FARE)
                    throw new CabInvoiceGeneratorCustomException(CabInvoiceGeneratorCustomException.ExceptionType.INVALID_COST, "Cost Could not LessThan Minimum Cost");
                Console.WriteLine("cost of cab journey is:Rs." + Math.Max(this.cabFare, MINIMUM_FARE));
            }
            catch (CabInvoiceGeneratorCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            return Math.Max(this.cabFare, MINIMUM_FARE);
        }
    }
}
