using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Portal
{
    interface Imethod
    {
        int AddC(Icustomer obj);

        int AddA(Iaccount aobj);
        List<Iaccount> ViewbyAtype(string accounttype);
        int Deposit(Iaccount acobj);
        int Deactivate(int accountid);
        void viewacc();
        void viewcust();
        bool check1(int id);
    }


}
