using System;
using System.Collections.Generic;
using System.Text;

namespace BillInheritanceChallenge
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }
        public Bill()
        {

        }
        public Bill(double _subtotal, double _taxrate)
        {
            Subtotal = _subtotal;
            TaxRate = _taxrate;
        }

        public virtual double CalcTotal()
        {
            return (Subtotal * (1 + TaxRate));
            
        }
    }
}
