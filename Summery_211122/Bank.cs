using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Summery_211122
{

    class RunBank
    {
        // Create New Array Of Banks: Hapoalim Or Discont
        Bank[] mainBank { get; set; }
        public Bank[] BanksArrOfDiscontOrHapoalim(int arrCount, string filePath)
        {
            //15
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine(); // title
            Bank[] paranet_bank = new Bank[arrCount];
            int count = 0;

            for (int i = 0; i < arrCount; i++)
            {

                line = sr.ReadLine();
                string[] splitLines = line.Split(',');
                if (splitLines[1].Contains("דיסקונט"))
                {
                    paranet_bank[count] = new BankDiscont(splitLines[0], splitLines[2]);
                    paranet_bank[count].Bank_name = splitLines[1];
                    paranet_bank[count].Address = splitLines[4];
                    paranet_bank[count].City = splitLines[5];
                    paranet_bank[count].Phone = splitLines[8];
                    count++;
                }
                else if (splitLines[1].Contains("הפועלים"))
                {
                    paranet_bank[count] = new BankHapoalim(splitLines[0], splitLines[2]);
                    paranet_bank[count].Bank_name = splitLines[1];
                    paranet_bank[count].Address = splitLines[4];
                    paranet_bank[count].City = splitLines[5];
                    paranet_bank[count].Phone = splitLines[8];
                    count++;
                }
            }

            sr.Close();
           
            return paranet_bank;

        }
    }
    internal class Bank
    {
        //variables

        private string bank_name;

        public string Bank_name
        {
            get { return bank_name; }
            set { bank_name = value; }
        }
        //-----------------------
        private readonly string bank_code;

        public string Bank_code
        {
            get { return bank_code; }

        }
        //-----------------------
        private string branch_code;

        public string Branch_code
        {
            get { return branch_code; }

        }
        //-----------------------
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        //-----------------------
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        //-----------------------
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        //-----------------------


        // Constructor
        public Bank(string bank_code, string branch_code)
        {
            this.bank_code = bank_code;
            this.branch_code = branch_code;
        }

        // Function That Read Lines From A Text File
        public static int retNumOfLines(string path_to_file)
        {
            StreamReader fopen = new StreamReader(path_to_file);
            fopen.ReadLine(); // titles
            int count_lines = 0;
            while (fopen.ReadLine() is string s)
            {
                count_lines++;
            }
            fopen.Close();
            return count_lines;
        }

        // Function That Creates Array Of Banks
        public static Bank[] CreateArrOfBanks(string path_to_file, int arrSize)
        {
            Bank[] banks = new Bank[arrSize];
            StreamReader fopen = new StreamReader(path_to_file);
            string line = fopen.ReadLine(); // titles
            for (int i = 0; i < arrSize; i++)
            {
                line = fopen.ReadLine();
                string[] strings = line.Split(',');
                banks[i] = new Bank(strings[0], strings[2]);
                banks[i].Bank_name = strings[1];
                banks[i].Address = strings[4];
                banks[i].City = strings[5];
                banks[i].Phone = strings[8];
            }
            fopen.Close();
            return banks;
        }

        // Function That Print Banks In Jerusalem Or Tel-Aviv
        public static void printBanksInJerusalemAndTelAviv(Bank[] arrayOfBanks)
        {
            for (int i = 0; i < arrayOfBanks.Length; i++)
            {
                if (arrayOfBanks[i].City.Contains("ירושלים") || arrayOfBanks[i].City.Contains("תל אביב"))
                {
                    string name = Reverse(arrayOfBanks[i].Bank_name);
                    string city = Reverse(arrayOfBanks[i].City);
                    Console.WriteLine("Bank Name: {0}, City: {1}", name, city);
                }
            }
        }
        // Reverse String
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

      
    }
}
