
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
                Console.WriteLine("3. View customer account type");
                Console.WriteLine("4. Deposting the ammount");
                Console.WriteLine("5. Deactivate your account");
                Console.WriteLine("6. View All Customers");
                Console.WriteLine("7. View All Accounts");
                Console.WriteLine("Press 0 for exit");
                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Customer obj = new Customer();
                        Console.WriteLine("Enter your name");
                        obj.Name = Console.ReadLine();
                        Console.WriteLine("Enter your DOB (MM/DD/YYYY)");
                        obj.Dob = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Gender");
                        obj.Gn1 = Console.ReadLine();
                        Console.WriteLine("Enter your city");
                        obj.City = Console.ReadLine();
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
                       
                        string atype;
                        bool f1;
                          do
                            {
                                Console.WriteLine("Enter Accountn type :Savings/Current");
                                atype = Console.ReadLine();
                                if (atype != "Savings" && atype != "Current")
                                {
                                    Console.WriteLine("Enter correct Account Type");
                                }

                            } while (atype != "Savings" && atype != "Current");
                            f1 = mobj.check12(atype, cid);
                        if (f1)
                        {
                            Console.WriteLine("The customer with customer id" + cid + "already has a " + atype + " account");
                            break;
                        }
                        Iaccount aobj = new Account();
                        aobj.Cuid = cid;
                        aobj.Actyp = atype;


                        int amt;
                        do
                        {
                            Console.WriteLine("Enter Amount to be deposited (greater than 500)");
                            amt = Convert.ToInt32(Console.ReadLine());
                            if (amt < 500)
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
                            if (atype1 != "Savings" && atype1!= "Current")
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
                            Console.WriteLine(a.Acid + "\t\t" + a.Cuid + "\t\t" + a.Actyp + "\t\t" + a.Damnt + "\t\t" + a.Acs + "\t\t" + Convert.ToString(a.Ast).Split(' ')[0]);
                        }
                        break;
                    case "4":
                       // bool flag1;
                        int cid1;
                          Console.WriteLine("Enter the Customer id");
                            cid1 = Convert.ToInt32(Console.ReadLine());
                        bool flag2;
                        int aid1;
                       
                            Console.WriteLine("Enter the Account id");
                            aid1 = Convert.ToInt32(Console.ReadLine());
                            flag2 = mobj.check2(aid1,cid1);
                        if (!flag2)
                        {
                            Console.WriteLine("This customer id" + cid1 + "having acconut id" + aid1 + "does not exist in the database");
                            break;
                        }

                      

                        int amount;
                       
                        Console.WriteLine("Enter the amount you want to deposit(Enter -ve amount to withdraw)");
                        amount = Convert.ToInt32(Console.ReadLine());
                        Iaccount aobj1 = new Account(cid1, aid1,amount);
                        amount = mobj.Deposit(aobj1);
                        if (amount == -1)
                            Console.WriteLine("You do not have enough balance to withdraw this amount");
                        else if (amount == -2)
                            Console.WriteLine("Amount cant be deposited/withdrawn as account is INACTIVE");
                        else
                            Console.WriteLine("The new Updated abount is" + amount);
                        break;
                    case "5":
                        int cid12;
                        Console.WriteLine("Enter the Customer id");
                        cid12 = Convert.ToInt32(Console.ReadLine());
                        bool flag21;
                        int aid12;

                        Console.WriteLine("Enter the Account id");
                        aid12 = Convert.ToInt32(Console.ReadLine());
                        flag21 = mobj.check2(aid12, cid12);
                        if (!flag21)
                        {
                            Console.WriteLine("This customer id" + cid12 + "having acconut id" + aid12 + "does not exist in the database");
                            break;
                        }
                        if (mobj.Deactivate(aid12) == 1)
                            Console.WriteLine("account id " + aid12 + " deactivated successfully");
                        else
                            Console.WriteLine("something went wrong");

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

            while (choice != "0");








        }
    }
}
