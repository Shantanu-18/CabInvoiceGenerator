using System;

namespace CabInvoiceGeneratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            RideRepository rideRepository = new RideRepository();
            InvoiceSummary invoiceSummary;

            double singleFare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Single Ride Fare : {singleFare}");

            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) };
            invoiceGenerator.CalculateFare(rides);
            invoiceSummary.averageFare;
        }
    }
}
