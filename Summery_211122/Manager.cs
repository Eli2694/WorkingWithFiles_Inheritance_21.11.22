using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summery_211122
{
    internal class Manager
    {
        public static void Runner()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1255");


            string file_path = "snifim.txt";

            //Class Bank
            int numOfLines = Bank.retNumOfLines(file_path);
            Bank[] arr = Bank.CreateArrOfBanks(file_path, numOfLines);
            Bank.printBanksInJerusalemAndTelAviv(arr);

            //Class RunBank
            RunBank runBank = new RunBank();
            Bank[] arr1 = runBank.BanksArrOfDiscontOrHapoalim(numOfLines, file_path);



            Console.ReadLine();
        }
    }
}
