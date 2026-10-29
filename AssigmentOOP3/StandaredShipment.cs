using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP3
{
   
    internal class StandaredShipment : Shipment
    {
        #region constractor chining 2 answer 3 part 3
        public StandaredShipment(string t, string dec, decimal w, decimal df, DeliveryAddress d) : base(t, dec, w, df, d)
        {

        }
        #endregion
       //method over ride 1 standardshipment
        public override string PrintShipment()
        {
            return $"{base.PrintShipment()}EstimatedCost:{EstimatedCost}";
        }

    }
}
