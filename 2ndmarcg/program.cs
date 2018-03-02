using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            IcabOperation mobj = new CabOperation();
            do
            {

                Console.WriteLine("1.Book");
                Console.WriteLine("2.View booking");
                Console.WriteLine("3. to update details");
                Console.WriteLine("4.cancel your booking");
                Console.WriteLine("Press 0 for exit");
                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        float amount = 0;
                        IcabDetails obj = new CabDetails();
                        Console.WriteLine("Enter your name");
                        obj.Name1 = Console.ReadLine();
                        Console.WriteLine("Enter your location");
                        obj.From_location1 = Console.ReadLine();
                        Console.WriteLine("TDEparture Time");

                        obj.D_Time1 = DateTime.Parse(Console.ReadLine());
                        ///////////I have a problem here.
                      //  obj.D_Time1.AddHours(5).AddMinutes(30);
                        Console.WriteLine("Enter your destination");
                        obj.To_Location1 = Console.ReadLine();
                        Console.WriteLine("Distance in kilometers");
                        obj.Distance1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your cab type");
                        Console.WriteLine("Enter  '1' to book  Micro");
                        Console.WriteLine("Enter '2' to book Mini");
                        Console.WriteLine("Enter '3' to book Hire");
                        obj.Cab_Type1 = Console.ReadLine();
                        Console.WriteLine("Enter cab contact number");
                        obj.Cab_contact1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Your cab has been booked with booking id" + mobj.Book(obj));
                        if (obj.Cab_Type1 == "1")
                            amount = (30 * obj.Distance1 * 45);
                        else if (obj.Cab_Type1 == "2")
                            amount = (40 * obj.Distance1 * 45);
                        else if (obj.Cab_Type1 == "3")
                            amount = (50 * obj.Distance1 * 45);
                        Console.WriteLine("Your estimated fare is" + amount);
                        break;

                    case "2":
                        List<IcabDetails> temp = new List<IcabDetails>();
                        mobj.view();
                        break;
                    case "3":
                        Console.WriteLine("Enter the booking id you want to search");
                        int id = Convert.ToInt32(Console.ReadLine());
                         mobj.viewbyid(id);
                       // if (i==false)
                         
                        break;
                }
            } while (choice != "0");
        }

    }
}

