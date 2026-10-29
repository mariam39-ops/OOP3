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

            //answer 1
            #region part 1 answer 1,2 
            //q1
            // a=q1 يعني انا بظهر للمستخدم الوظائف والمعلومات الاساسيه وبخفى عنه تفاصيل التنفيذ
           //b=q2 اكتر 3 بيسهل علينا الصيانه بقلل التعقيد يعني انا بخفى عن المستخدم الحاجه الى مش بتفيده 2كمان بتخلي الكود redable 
           
        //q2 
        // abstract class: ده كلاس عنده فيلد وميثود وبيحصل فيه وراثه وكمان عنده كونستراكتور مينفعش نعمل منه اوبجيكت مباشر بالnew
        //interfas هو مجرد عقد بين اكتر من كلاس عمره م يحتوي على  فيلد ولا عنده كونستراكتور ولا بيورث  من كلاس ممكن يورث من انترفيس 
        //q2 لما اكون عايزه اعمل contract الكلاس عايزاهم ينفذوها  لما مكونش محتاجه انه يورث من الاب حاجه
        //q3 الكلاس ميقدرش يورث اكتر من abstract class ال لكن الكلاس يقدر يورث من  اكتر interface

            #endregion


        }
    }
}
