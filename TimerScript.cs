/*
  this script may have some slight errors
  with the time of hour and some  'try again'
  errors but other than that it should work
  fully to either set a timer or display 
  the current time
*/
using System;
using System.Threading;
namespace Timer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int timeYear = DateTime.Now.Year;
            int timeDay = DateTime.Now.Day;
            int timeMonth = DateTime.Now.Month;
            int timeHour = DateTime.Now.Hour;
            int timeMinute = DateTime.Now.Minute;
            int timeSecond = DateTime.Now.Second;

            int timeToCountDownFrom = 0;

            switch (timeHour)
            {
				case 1:
					timeHour = 1;
					break;
				case 2:
					timeHour = 2;
					break;
				case 3:
					timeHour = 3;
					break;
				case 4:
					timeHour = 4;
					break;
				case 5:
					timeHour = 5;
					break;
				case 6:
					timeHour = 6;
					break;
				case 7:
					timeHour = 7;
					break;
				case 8:
					timeHour = 8;
					break;
				case 9:
					timeHour = 9;
					break;
				case 10:
					timeHour = 10;
					break;
				case 11:
					timeHour = 11;
					break;
				case 12:
					timeHour = 12;
					break;

                case 13:
                    timeHour = 1;
                    break;
                case 14:
                    timeHour = 2;
                    break;
                case 15:
                    timeHour = 3;
                    break;
                case 16:
                    timeHour = 4;
                    break;
				case 17:
					timeHour = 5;
					break;
				case 18:
					timeHour = 6;
					break;
				case 19:
					timeHour = 7;
					break;
				case 20:
					timeHour = 8;
					break;
				case 21:
					timeHour = 9;
					break;
				case 22:
					timeHour = 10;
					break;
				case 23:
					timeHour = 11;
					break;
				case 24:
					timeHour = 12;
					break;
            }

            Console.WriteLine("would you like to [ set a timer ] or [ view current time ]?: ");
            bool repeatQuestion = true;
            while (repeatQuestion == true)
            {
                bool countDown = false;
                string option = Console.ReadLine();
                if (option == "set a timer")
                {
                    repeatQuestion = false;
                    bool repeatTimer = true;
                    while (repeatTimer == true)
                    {
                        Console.Write("how much time do you want to add ");
                        Console.Write("[keep within a range of a couple hours and atleast 1 minute ");
                        Console.Write(" and type a number (e.g. two minutes: 60 (newline) 60) \nas well" +
                                      "as saying 0 when you have enough time in] : ");
                        int addNumbers = Convert.ToInt32(Console.ReadLine());
                        if (addNumbers <= 59)
                        {
                            Console.WriteLine("Please type a number above a minute");
                        }
                        if (addNumbers >= 60)
                        {
                            Console.WriteLine("adding 1 minute to timer {0}", timeToCountDownFrom += 60);
                        }
						if (addNumbers >= 120)
						{
							Console.WriteLine("adding 2 minutes to timer {0}", timeToCountDownFrom += 120);
						}
						if (addNumbers >= 180)
						{
							Console.WriteLine("adding 3 minutes to timer {0}", timeToCountDownFrom += 180);
						}
						if (addNumbers >= 240)
						{
							Console.WriteLine("adding 3 minutes to timer {0}", timeToCountDownFrom += 240);
						}
                        if (addNumbers == 0) { repeatTimer = false; countDown = true; }
                    }
                    if (repeatTimer == false && countDown == true)
                    {
                        for (int i = timeToCountDownFrom; i >= 0; i--)
                        {
                            Console.WriteLine(i);
                            Thread.Sleep(1000);
                            if(i == 0) 
                            {
                                Console.WriteLine("Your Times Up!");
                                bool repeatQuestion2 = true;
                                while (repeatQuestion2 == true)
                                {
                                    Console.WriteLine("Do you want to repeat the question? [ yes or no ]");
                                    string optionRepeat = Console.ReadLine();
                                    if (optionRepeat == "yes")
                                    {
                                        repeatQuestion = true;
                                        repeatQuestion2 = false;
                                    }
                                    if (optionRepeat == "no")
                                    {
                                        Console.WriteLine("press any button to exit");
                                        repeatQuestion2 = false;
                                    }
                                    if (optionRepeat != "no" || optionRepeat != "yes")
                                    {
                                        Console.Write("your input was not taken, ");
                                        Console.WriteLine("please type your input correctly");
                                    }
                                }

                            }
                        }
                    }
                }
                else if (option == "view current time")
                {
                    repeatQuestion = false;
                    Console.WriteLine("The current year is: {0}", timeYear);
                    Console.WriteLine("The current month is: {0}", timeMonth);
                    Console.WriteLine("The current day is: {0}", timeDay);
                    Console.WriteLine("The current hour is: {0}:00", timeHour);
                    Console.WriteLine("The current minute is: :{0}", timeMinute);
                    Console.WriteLine("The current second is: : :{0}", timeSecond);
                    Console.WriteLine("Do you want to repeat the question? [ yes or no ]");
                    string optionRepeat = Console.ReadLine();
                    if (optionRepeat == "yes") {repeatQuestion = true;} else if (optionRepeat == "no") {
                        Console.WriteLine("press any key to quit"); 
                    }
                } else {
                    Console.Write("your input wasnt taken, make sure ");
                    Console.WriteLine("to type either \n[ set a timer ] or [ view current time ]?: ");
                }
            }
             

        }
    }
}


