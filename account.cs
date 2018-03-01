using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Portal
{
    class Account : Iaccount
    {
        static int a = 1000;
        int acid;
        int cuid;
        string actyp;
        int damnt;
        DateTime ast;
        string acs;

        public int Acid
        {
            get
            {
                return acid;
            }

            set
            {
                acid = value;
            }
        }

        public int Cuid
        {
            get
            {
                return cuid;
            }

            set
            {
                cuid = value;
            }
        }

        public string Actyp
        {
            get
            {
                return actyp;
            }

            set
            {
                actyp = value;
            }
        }

        public int Damnt
        {
            get
            {
                return damnt;
            }

            set
            {
                damnt = value;
            }
        }

        public DateTime Ast
        {
            get
            {
                return ast;
            }

            set
            {
                ast = value;
            }
        }

        public string Acs
        {
            get
            {
                return acs;
            }

            set
            {
                acs = value;
            }
        }

        public Account(int acid, int cuid, string actyp, int damnt, DateTime ast, string acs)
        {
            this.Acid = acid;
            this.Cuid = cuid;
            this.Actyp = actyp;
            this.Damnt = damnt;
            this.Ast = ast;
            this.Acs = acs;
        }
        public Account()
        {
            acid = a++;
        }
       public  Account(int cid1, int aid1,int amount)
        {
            this.Acid = aid1;
            this.Cuid = cid1;
            this.Damnt = amount;
        }
    }
}
