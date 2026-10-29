using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentOOP3
{
    internal class PriorityInternationalShipment:InternationalShipment
    {

        public PriorityInternationalShipment(string t, string d, decimal W, decimal dm, DeliveryAddress dl, string dC, decimal Cus):base(t,d,W,dm,dl,dC,Cus)
        {
            
        }
       //answer 8
        public  sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("PriorityInternationalShipment");
        }
    }
    
}
