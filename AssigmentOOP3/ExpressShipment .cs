using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP3
{
    internal class ExpressShipment : Shipment
    {
        #region ExpressShipment

        private decimal extrafee { get; set; }
        #region constractor chainin g 1 answer 3 part 2
        public ExpressShipment(string t, string d, decimal w, decimal de, DeliveryAddress del, decimal Exr) : base(t, d, w, de, del)
        {
            Extrafee = extrafee;
        }
        #endregion
        public decimal Extrafee
        {
            set
            {
                if (value >= 0)
                {
                    extrafee = value;
                }
            }
            get
            {
                return extrafee;
            }
        }
       //over ride1
        public override decimal EstimatedCost
        {
            
            get
            {
                return base.EstimatedCost + Extrafee;
            }


        #endregion

        }
        //method over ride 3
        public override string PrintShipment()
        {
            return $" {base.PrintShipment()}EstimatedCost: {EstimatedCost}Extrafee:{Extrafee}";
        }
    }
    }
