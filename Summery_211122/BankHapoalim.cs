using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summery_211122
{
    internal class BankHapoalim : Bank
    {
        //Constructor
        public BankHapoalim(string bank_code,string branch_code):base(bank_code, branch_code)
        {

        }

        private int workersInSnif;

        public int WorkersInSnif
        {
            get { return workersInSnif; }
            set { workersInSnif = value; }
        }

    }
}
