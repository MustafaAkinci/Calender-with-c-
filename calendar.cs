using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takvim_projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1, day2, month1, month2, year1, year2, number;
            string smonth1, smonth2;

            day1 = 0;
            day2 = 0;
            month1 = 0;
            month2 = 0;
            year1 = 0;
            year2 = 0;

            Console.Write("Please enter day 1 (greater than 0, lower than 32) =  "); //date is selected first
            day1 = Convert.ToInt32(Console.ReadLine());

            if (day1 >= 1 && day1 <= 31)
            {

            }
            else
            {
                Console.WriteLine("Day is wrong");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("Please enter month 1 name  =  ");  //secondly month is requested from string type
            smonth1 = Console.ReadLine();

            while (month1 == 0)
            {
                if (smonth1 == "january")
                {
                    month1 = 1;
                }
                else if (smonth1 == "february")
                {
                    month1 = 2;
                }
                else if (smonth1 == "march")
                {
                    month1 = 3;
                }
                else if (smonth1 == "april")
                {
                    month1 = 4;
                }
                else if (smonth1 == "may")
                {
                    month1 = 5;
                }
                else if (smonth1 == "june")
                {
                    month1 = 6;
                }
                else if (smonth1 == "july")
                {
                    month1 = 7;
                }
                else if (smonth1 == "august")
                {
                    month1 = 8;
                }
                else if (smonth1 == "september")
                {
                    month1 = 9;
                }
                else if (smonth1 == "october")
                {
                    month1 = 10;
                }
                else if (smonth1 == "november")
                {
                    month1 = 11;
                }
                else if (smonth1 == "december")
                {
                    month1 = 12;
                }
                else
                {
                    Console.WriteLine("month is wrong");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            Console.Write("Please enter year 1 (greater than 2014) =  ");  //Third, the user is prompted for the year
            year1 = Convert.ToInt32(Console.ReadLine());

            if (year1 >= 2015)
            {
                {
                    if (month1 == 1)         //then here i used Gauss's algorithm to determine the day of the week
                    {
                        month1 = 13;
                        year1--;
                    }
                    if (month1 == 2)
                    {
                        month1 = 14;
                        year1--;
                    }
                    int q = day1;
                    int m = month1;
                    int k = year1 % 100;
                    int j = year1 / 100;
                    int h = q + 13 * (m + 1) / 5 + k + k / 4 + j / 4 + 5 * j;

                    h = h % 7;
                    switch (h)
                    {
                        case 0:
                            Console.WriteLine("Saturday");
                            break;

                        case 1:
                            Console.WriteLine("Sunday");
                            break;

                        case 2:
                            Console.WriteLine("Monday");
                            break;

                        case 3:
                            Console.WriteLine("Tuesday");
                            break;

                        case 4:
                            Console.WriteLine("Wednesday");
                            break;

                        case 5:
                            Console.WriteLine("Thursday");
                            break;

                        case 6:
                            Console.WriteLine("Friday");
                            break;
                    }   //When transactions are made with January and February, it may seem like it gave an error, but in fact, the system does not give an error and continues. I haven't been able to fully figure out why.
                }
            }
            else
            {
                Console.WriteLine("Year is wrong");
                Console.ReadKey();
                Environment.Exit(0);
            }
            switch (month1)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Autumn");
                    break;
                default:
                    Console.Write("Incorrect entry");
                    break;
                    //here the seasons are selected depending on the month the user enters
            }
            Console.ReadLine();
            Console.Write("Calendar Date 1 : {0}.{1}.{2}", day1, smonth1, year1);
            Console.ReadKey();
            Console.Clear();

            Console.Write("Please enter day 2 (greater than 0, lower than 32) =  ");  //calender date is displayed as a whole
            day2 = Convert.ToInt32(Console.ReadLine());

            if (day2 >= 1 && day2 <= 31)
            {

            }
            else
            {
                Console.WriteLine("Day is wrong");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("Please enter month 2 name =  ");
            smonth2 = Console.ReadLine();

            while (month2 == 0)
            {
                if (smonth2 == "january")
                {
                    month2 = 1;
                }
                else if (smonth2 == "february")
                {
                    month2 = 2;
                }
                else if (smonth2 == "march")
                {
                    month2 = 3;
                }
                else if (smonth2 == "april")
                {
                    month2 = 4;
                }
                else if (smonth2 == "may")
                {
                    month2 = 5;
                }
                else if (smonth2 == "june")
                {
                    month2 = 6;
                }
                else if (smonth2 == "july")
                {
                    month2 = 7;
                }
                else if (smonth2 == "august")
                {
                    month2 = 8;
                }
                else if (smonth2 == "september")
                {
                    month2 = 9;
                }
                else if (smonth2 == "october")
                {
                    month2 = 10;
                }
                else if (smonth2 == "november")
                {
                    month2 = 11;
                }
                else if (smonth2 == "december")
                {
                    month2 = 12;
                }
                else
                {
                    Console.WriteLine("month is wrong");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            Console.Write("Please enter year 2 (greater than 2014) =  ");
            year2 = Convert.ToInt32(Console.ReadLine());

            if (year2 >= 2015)
            {
                {
                    if (month2 == 1)
                    {
                        month2 = 13;
                        year2--;
                    }
                    if (month2 == 2)
                    {
                        month2 = 14;
                        year2--;
                    }
                    int q = day2;
                    int m = month2;
                    int k = year2 % 100;
                    int j = year2 / 100;
                    int h = q + 13 * (m + 1) / 5 + k + k / 4 + j / 4 + 5 * j;

                    h = h % 7;
                    switch (h)
                    {
                        case 0:
                            Console.WriteLine("Saturday");
                            break;

                        case 1:
                            Console.WriteLine("Sunday");
                            break;

                        case 2:
                            Console.WriteLine("Monday");
                            break;

                        case 3:
                            Console.WriteLine("Tuesday");
                            break;

                        case 4:
                            Console.WriteLine("Wednesday");
                            break;

                        case 5:
                            Console.WriteLine("Thursday");
                            break;

                        case 6:
                            Console.WriteLine("Friday");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Year is wrong");
                Console.ReadKey();
                Environment.Exit(0);
            }
            switch (month2)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Autumn");
                    break;
                default:
                    Console.Write("Incorrect entry");
                    break;

            }
            Console.ReadLine();
            Console.Write("Calendar Date 2 : {0}.{1}.{2}", day2, smonth2, year2);
            Console.ReadKey();
            Console.Clear();

            Console.Write("Calendar Date 1 : {0}.{1}.{2}", day1, month1, year1);
            Console.ReadKey();
            Console.Write("Calendar Date 2 : {0}.{1}.{2}", day2, month2, year2);
            Console.ReadKey();

            {
                if (month1 == 1)
                {
                    month1 = 13;
                    year1--;
                }
                if (month1 == 2)
                {
                    month1 = 14;
                    year1--;
                }
                int q = day1;
                int m = month1;
                int k = year1 % 100;
                int j = year1 / 100;
                int h = q + 13 * (m + 1) / 5 + k + k / 4 + j / 4 + 5 * j;

                h = h % 7;
                switch (h)
                {
                    case 0:
                        Console.WriteLine("Saturday");
                        break;

                    case 1:
                        Console.WriteLine("Sunday");
                        break;

                    case 2:
                        Console.WriteLine("Monday");
                        break;

                    case 3:
                        Console.WriteLine("Tuesday");
                        break;

                    case 4:
                        Console.WriteLine("Wednesday");
                        break;

                    case 5:
                        Console.WriteLine("Thursday");
                        break;

                    case 6:
                        Console.WriteLine("Friday");
                        break;
                        Console.ReadKey();
                }
                Console.Write("Please select the number between 2 dates:  ");           //After 2 dates are drawn, the user is prompted for a number to choose how many days between these dates (n in the example)
                number = Convert.ToInt32(Console.ReadLine());

                for (int n = year1; n <= year2; n++)
                {
                    for (int i = month1; i < 13; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                smonth1 = " January ";
                                break;
                            case 2:
                                smonth1 = " February ";
                                break;
                            case 3:
                                smonth1 = " March ";
                                break;
                            case 4:
                                smonth1 = " April ";
                                break;
                            case 5:
                                smonth1 = " May ";
                                break;
                            case 6:
                                smonth1 = " June ";
                                break;
                            case 7:
                                smonth1 = " July ";
                                break;
                            case 8:
                                smonth1 = " August ";
                                break;
                            case 9:
                                smonth1 = " September ";
                                break;
                            case 10:
                                smonth1 = " October ";
                                break;
                            case 11:
                                smonth1 = " November ";
                                break;
                            case 12:
                                smonth1 = " December ";
                                break;

                        }

                        for (int f = day1; f < 32; f += number)                        //I printed the date between the 2 selected dates here
                        {
                            Console.Write(f + smonth1 + n + "\n");

                            if (n == year2 & i == month2 & f + number > day2)
                            {
                                day1 = f;
                                year1 = n;
                                break;
                            }
                            if (f + number > 30 && (i == 4 || i == 6 || i == 9 || i == 11))
                            {
                                day1 = (f + number) - 30;
                                break;
                            }
                            else if (f + number > 29 & i == 2 & (n % 4 == 0))
                            {
                                day1 = (f + number) - 29;
                                break;
                            }
                            else if (f + number > 29 & i == 2)
                            {
                                day1 = (f + number) - 28;
                                break;
                            }
                            else if (f + number > 31 && (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12))
                            {
                                day1 = (f + number) - 31;
                                break;
                            }

                            if (i + 1 > 12)
                            {
                                day1 = f;
                                month1 = 1;
                            }

                        }
                        if (n == year2 & i == month2 & day1 + number > day2)
                        {
                            break;
                        }

                    }
                }


            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Thanks for reviewing my homework :)");
            Console.ReadKey();
        }

    }
}

