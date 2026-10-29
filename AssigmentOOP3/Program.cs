namespace AssigmentOOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region answer part1
            //q1  A=الoverloding يعني انا بعمل فانكشن بنفس الاسم بس  فى نفس الكلاس بس الاختلاف بيكون فى عدد البراميتر اونوعهم او ترتيبهم اوقات  بيبقى نفس السلوك بس ده مش افضل حاجه
            //override=اول حاجه لازم لازم يكون فى وراثهم انا بورث فانكشن وبغير فى السلوك بتاعها على حسب الى انا محتاجاه بنكتب فى كلاس الاب virtual واللى هيورث overide
            //وهنا مينفعش نغير او نعمل اي حاجه فى البراميتر
            //B==static binding =بيحصل ساعه الcompiletime  وبنستخدم مهاه الكيورد new 
            //diynimc binding==بيحصل ساعه الruntimeوهو افضل بكتير ريفرنس من الاب يقدر يشاور على الاوبجيكت
            // q 2
            //q2 a== وقف سلسله التورث اوعمليه الثوريت محدش بعده يقدر يورث منه
            // b==seld class بتمنع ان يتم توريثها بالكامل يعني محدش يقدر يجي بعدها يورث منها 
            //selad method بتمنع ان حد يقدر ييورثها بعدها ويعمل عليها override
            //c= لا لان الكيورد seled تمنع اصلا ان حد يقدر يعمل عليها override;
            #endregion
            //q9
            //1 
            Driver d1 = new Driver();
            //q2
            DeliveryCenter delivec = new DeliveryCenter("maser");
            delivec.Driver = d1;
            //q3
            DeliveryAddress de = new DeliveryAddress();
            StandaredShipment s1 = new StandaredShipment("Egypt", "AhmedMaher", 66, 50, de);
            //q4
            ExpressShipment ex = new ExpressShipment("Egypt", "AhmedMaher", 66, 50, de, 66.66m);
            //Q5
            InternationalShipment intrnational = new InternationalShipment("Egypt", "AhmedMaher", 66, 50, de, "10%", 77);
            //q6
           delivec.AddShipment(s1);
            delivec.AddShipment(ex);
            delivec.AddShipment(intrnational);
            //q7
            delivec.PrintAllShipment();
            //q8
            Console.WriteLine("--------------");
            DeliveryHelper.PrintShipmentDetails(s1);
            DeliveryHelper.PrintShipmentDetails(ex);
            DeliveryHelper.PrintShipmentDetails(intrnational);
            //q 9 
            Shipment s = new Shipment();
            s.upDateWeigth(55);
            s.upDateWeigthExtra(66,88);
            //q10
            Console.WriteLine("--------------------------------");
            Shipment[] shipments = { s1, ex, intrnational };
            foreach(Shipment e in shipments)
            {
                Console.WriteLine(e.PrintShipment());
            }
            


        }
    }
}
