using System;

namespace _08.Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string[] alcholicPerson = Console.ReadLine().Split();
            string[] bankInfo = Console.ReadLine().Split();

            string personName = personInfo[0] + " " + personInfo[1];
            string personAddres = personInfo[2];
            string personTown = string.Join(" ",personInfo.Skip(3));

            string alcholicName = alcholicPerson[0];
            int alcholicLiters = int.Parse(alcholicPerson[1]);
            bool drunk = alcholicPerson[2] == "drunk";

            string personBankInfoName = bankInfo[0];
            double accountBalance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];

            var personInfoTuple = new MyTuple<string, string,string>(personName, personAddres, personTown);
            var alcholicPersonTuple = new MyTuple<string, int, bool>(alcholicName, alcholicLiters, drunk);
            var personBankTuple = new MyTuple<string, double, string>(personBankInfoName, accountBalance, bankName);

            Console.WriteLine(personInfoTuple);
            Console.WriteLine(alcholicPersonTuple);
            Console.WriteLine(personBankTuple);
        }
    }
}

/*
Adam Smith Wallstreet New York
Mark 18 drunk
Karren 0.10 USBank
 */