using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Portal
{
    interface Icustomer
    {
        int Cid { get; set; }
        string Name { get; set; }
        DateTime Dob { get; set; }
        string Gn1 { get; set; }
        string City { get; set; }
        long Cno { get; set; }
    }
    }

