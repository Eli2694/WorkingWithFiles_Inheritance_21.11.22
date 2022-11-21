using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summery_211122
{
    internal class BankDiscont : Bank
    {
        public BankDiscont(string bank_code, string bank_branch):base(bank_code, bank_branch)
        {

        }

        private bool isTeacher;

        public bool IsTeacher
        {
            get { return isTeacher; }
            set { isTeacher = value; }
        }

    }
}
