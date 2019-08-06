using System;
using System.Collections.Generic;
using System.Text;

namespace BillInheritanceChallenge
{
    class TippableBill:Bill
    {
        public double Tip { get; set; }
        public TippableBill()
        {

        }
        public TippableBill(double _tip, double _subtotal, double _taxRate)
            :base(_taxRate, _subtotal)
        {
            TaxRate = _taxRate;
            Subtotal = _subtotal;
            Tip = _tip;
        }

        public override double CalcTotal()
        {
            return base.CalcTotal() + Tip; //have to call from parent Bill to activate 
            //CalcTotal from Bill     
        }

       
    }
}
