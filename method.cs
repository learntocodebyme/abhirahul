using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Portal
{
    class Method:Imethod
    {
        static List<Icustomer> lst =new List<Icustomer>();
        static List<Iaccount> alst = new List<Iaccount>();
        public int AddC(Icustomer obj)
        {
            lst.Add(obj);
            return obj.Cid;
        }

        public int  AddA(Iaccount obj1)
        {
            alst.Add(obj1);
            return obj1.Acid;
        }
       public List<Iaccount> ViewbyAtype(string accounttype)

        {
            List<Iaccount> templst = new List<Iaccount>();
            foreach (Iaccount a in alst)
                if (a.Actyp == accounttype)
                    templst.Add(a);

            return templst;
        }
      public  int Deposit(Iaccount acobj)
        {
            return 0;

        }
        public int Deactivate(int accountid)
        {
            return 0;
        }
        public void viewcust()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("CUstomer ID\t\tName\t\tDate of Birth\t\tGender\t\tCity\t\tMobile no.");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (Icustomer a in lst)
            {
                Console.WriteLine(a.Cid+"\t\t"+a.Name + "\t\t" +a.Dob + "\t\t" +a.Gn1 + "\t\t" +a.City + "\t\t" +a.Cno);
            }
        }

        public void viewacc()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Account id\t\tCUstomer ID\t\tAccount type\t\tAmount\t\tStatus\t\tStart Date.");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (Iaccount a in alst)
            {
                Console.WriteLine(a.Acid+"\t\t" + a.Cuid + "\t\t" + a.Actyp + "\t\t" + a.Damnt + "\t\t" + a.Acs + "\t\t" + a.Ast );
            }
        }
       public bool check1(int id)
        {
            foreach (Icustomer a in lst)
                if (a.Cid == id)
                    return true;
            return false;
        }
    }
}
