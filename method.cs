using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Portal
{
    class Method : Imethod
    {
        static List<Icustomer> lst = new List<Icustomer>();
        static List<Iaccount> alst = new List<Iaccount>();
        public bool check12(string atype, int cid)
        {
            foreach (Iaccount a in alst)
                if (a.Cuid == cid && a.Actyp == atype) 
                     return true;
            return false;

        }
        public int AddC(Icustomer obj)
        {
            lst.Add(obj);
            return obj.Cid;
        }

        public int AddA(Iaccount obj1)
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
        public int Deposit(Iaccount acobj)
        {
            int abc=0;
            foreach (Iaccount a in alst)
                if (a.Cuid == acobj.Cuid && a.Acid == acobj.Acid)
                {
                    if ((a.Damnt + acobj.Damnt) >= 0)
                    {
                        if (a.Acs != "INACTIVE")
                        {
                            a.Damnt += acobj.Damnt;
                            abc = a.Damnt;
                        }
                        else
                            return -2;
                    }
                    else
                    return -1;
                }
            return abc;


        }
        public int Deactivate(int accountid)
        {
            foreach (Iaccount a in alst)
                if (a.Acid == accountid)
                    if (a.Damnt > 0)
                        return 0;
                    else
                    {
                        a.Acs = "INACTIVE";
                        return 1;
                    }
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
                Console.WriteLine(a.Cid + "\t\t" + a.Name + "\t\t" + Convert.ToString(a.Dob).Split(' ')[0] + "\t\t" + a.Gn1 + "\t\t" + a.City + "\t\t" + a.Cno);
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
                Console.WriteLine(a.Acid + "\t\t" + a.Cuid + "\t\t" + a.Actyp + "\t\t" + a.Damnt + "\t\t" + a.Acs + "\t\t" +Convert.ToString( a.Ast).Split(' ')[0]);
            }
        }
        public bool check1(int id)
        {
            foreach (Icustomer a in lst)
                if (a.Cid == id)
                    return true;
            return false;
        }
        public bool check2(int aid,int cid)
        {
            foreach (Iaccount a in alst)
                if (a.Acid == aid && a.Cuid==cid)
                    return true;
            return false;
        }
       
    }
}

