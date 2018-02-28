using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Portal
{
    class Program
    { 

        static void Main(string[] args)
        {
            string choice;
            Imethod mobj = new Method();
            do
            {
                
                Console.WriteLine("1. Add customer");
                Console.WriteLine("2. Add account");
                Console.WriteLine("3. View customer account id");
                Console.WriteLine("4. Deposting the ammount");
                Console.WriteLine("5. Deposting the ammount");
                Console.WriteLine("6. View All Customers");
                Console.WriteLine("7. View All Accounts");
                Console.WriteLine("Press 0 for exit");
                Console.WriteLine("Enter your choice");
                choice =Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Customer obj = new Customer();
                        Console.WriteLine("Enter your name");
                        obj.Name = Console.ReadLine();
                        Console.WriteLine("Enter your DOB");
                        obj.Dob =DateTime.Parse (Console.ReadLine());
                        Console.WriteLine("Enter your Gender");
                        obj.Gn1 =Console.ReadLine();
                        Console.WriteLine("Enter your city");
                        obj.City  = Console.ReadLine();
                        Console.WriteLine("Enter your contact number");
                        obj.Cno = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("customer Added succefully with customer id: " + mobj.AddC(obj));
                        break;
                    case "2":
                        bool flag;
                        int cid;
                        do
                        {
                            Console.WriteLine("Enter the Customer id");
                            cid = Convert.ToInt32(Console.ReadLine());
                            flag = mobj.check1(cid);
                            if (!flag)
                                Console.WriteLine("This customer id does not exist in the database");


                        } while (!flag);
                        Iaccount aobj = new Account();
                        aobj.Cuid = cid;

                        string atype;
                        do
                        {
                            Console.WriteLine("Enter Accountn type :Savings/Current");
                            atype = Console.ReadLine();
                            if (atype != "Savings" && atype != "Current")
                            {
                                Console.WriteLine("Enter correct Account Type");
                            }

                        } while (atype != "Savings" && atype != "Current");
                        aobj.Actyp = atype;
                        int amt;
                        do
                        {
                            Console.WriteLine("Enter Amount to be deposited (greater than 500)");
                            amt = Convert.ToInt32(Console.ReadLine());
                            if(amt<500)
                                Console.WriteLine("amount should be greater than 500");

                        } while (amt < 500);
                        aobj.Damnt = amt;
                        aobj.Ast = DateTime.Today;
                        aobj.Acs = "ACTIVE";
                        Console.WriteLine("Account Added succefully with Account id: " + mobj.AddA(aobj));


                       break;
                    case "3":
                        string atype1;
                        do
                        {
                            Console.WriteLine("Enter Accountn type :Savings/Current");
                            atype1 = Console.ReadLine();
                            if (atype1 != "Savings" && atype1 != "Current")
                            {
                                Console.WriteLine("Enter correct Account Type");
                            }

                        } while (atype1 != "Savings" && atype1 != "Current");
                        List<Iaccount> tem = new List<Iaccount>();
                        tem = mobj.ViewbyAtype(atype1);
                        Console.Clear();
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        Console.WriteLine("Account id\t\tCUstomer ID\t\tAccount type\t\tAmount\t\tStatus\t\tStart Date.");
                        Console.WriteLine("-----------------------------------------------------------------------------");
                        foreach (Iaccount a in tem)
                        {
                            Console.WriteLine(a.Acid + "\t\t" + a.Cuid + "\t\t" + a.Actyp + "\t\t" + a.Damnt + "\t\t" + a.Acs + "\t\t" + a.Ast);
                        }
                        break;
                    case "4":


                        break;
                    case "5":
                        break;
                    case "6":
                        mobj.viewcust();

                        break;
                    case "7":
                        mobj.viewacc();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;


                }
            }
            
            while (choice !="0");
                
                


            
             
            

        }
    }
}
