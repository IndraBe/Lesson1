using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int myNumber = 15;
            char myFavoriteLetter = 'A';
            bool isCar = true;
            double myConstant = 4.58;
            float myChangingNum = 2.46f; // decimālskaitlis ar mazāk cipariem aiz komata
            string name = "Indra #@$##%@";

            Console.WriteLine(myNumber);
            Console.WriteLine(myFavoriteLetter);
            Console.WriteLine(isCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);

            Console.WriteLine(myConstant + myChangingNum);

            //-------------------------------------------------------

            int myNumber1 = 4;
            int myNumber2 = 6;

            int sum1 = myNumber1 + myNumber2;

            Console.WriteLine(sum1);

            string name1 = "Hello";
            string name2 = "from code";

            string nameTogether = name1 + " " + name2;

            Console.WriteLine(nameTogether);


            int withPluses = 4;
            withPluses++; // palielinma par 1

            Console.WriteLine(withPluses);


            int divisionReminder1 = 5;
            int divisionReminder2 = 2;

            int divisionReminderResult = divisionReminder1 % divisionReminder2;

            Console.WriteLine(divisionReminderResult);



            // Relāciju operatori. Atgriež bool
            int MyNumber5 = 14;
            int MyNumber6 = 17;

            bool isEqualNumber = MyNumber5 == MyNumber6;

            Console.WriteLine(isEqualNumber);


            string myText4 = "ABC";
            string myText5 = "ABC";

            bool isEqualText = myText4 == myText5;

            Console.WriteLine(isEqualText);


            int MyNumber7 = 15;
            int MyNumber8 = 17;

            bool isEqualNumber2 = MyNumber7 > MyNumber8;

            Console.WriteLine(isEqualNumber2);

            // ----------------------------------------------------------------
            // Loģiskie operatori

            bool IAmTrue = true;
            bool IAmFalse = false;

            bool both = IAmTrue && IAmFalse; // gan viens,gan otrs ir true, tad ir true
            bool or = IAmTrue || IAmFalse; // vai viens vai otrs, tad ir true
            bool BothReversed = !both; // NAV operators, pretējais

            Console.WriteLine(both);
            Console.WriteLine(or);
            Console.WriteLine(BothReversed);

            // ----------------------------------------------------------------
            // Piešķiršanas operatori

            int myNumber9 = 14;

            myNumber9 += 10;

            Console.WriteLine(myNumber9);

            // ----------------------------------------------------------------
            //Izgūt no lietotāja ievadi

            //Console.WriteLine("Kāds ir Tavs vārds?");

            //string userName = Console.ReadLine();

            //Console.WriteLine("Sveiks, " + userName);



            //Console.WriteLine("Kāds ir Tavs vecums?");

            //string ageText = Console.ReadLine();

            //int age = int.Parse(ageText);
            //int previousAge = age - 1;

            //Console.WriteLine("Sveiks, Tev iepriekšējā gadā bija: " + previousAge);

            // ----------------------------------------------------------------

            Console.WriteLine("=======================================");

            int maxNumber1 = 4;
            int maxNumber2 = 6;

            int maxResult = Math.Max(maxNumber1, maxNumber2);

            Console.WriteLine(maxResult);


            int absWithMinus = -45;
            int absAfter = Math.Abs(absWithMinus);

            Console.WriteLine(absAfter);


            double numberToRound = 14.258;

            double rounded = Math.Round(numberToRound, 2);

            Console.WriteLine(rounded);

        }
    }
}
