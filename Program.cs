using System;

namespace BillInheritanceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill billy = new Bill();
            
            billy.Subtotal = 15.80;
            billy.TaxRate = 0.06;

             Pay(billy);
           

            TippableBill tippy = new TippableBill();
            tippy.Subtotal = 8.50;
            tippy.TaxRate = 0.06;
            tippy.Tip = 2.00;

             Pay(tippy);  
        }

        public static void Pay(Bill thatBill)
        {
            thatBill.CalcTotal();
            Console.WriteLine($"${thatBill.CalcTotal()}\n");
        }
    }
}
