namespace Project
{
    public class Hour
    {
        public static void Method(int numOfColon, string answer)
        {
            if (numOfColon == 2)
            {
                var split = answer.Split(':');

                int hour = int.Parse(split[0]);
                int minute = int.Parse(split[1]);
                int second = int.Parse(split[2]);

                if (hour > 24 || minute > 60 || second > 60)
                {
                    Console.SetWindowSize(60, 15);
                    Console.WriteLine("Please use the correct time format.");
                }

                else
                {
                    Console.WriteLine("=====================");
                    Console.WriteLine("    Timer Started:   ");
                    Console.WriteLine("=====================");

                    while (second != 0 || minute != 0 || hour != 0)
                    {
                        Program.ClearCurrentConsoleLine(0, 4);

                        string formattedHour = (hour < 10) ? "0" + hour : hour.ToString();
                        string formattedMinute = minute < 10 ? "0" + minute : minute.ToString();
                        string formattedSecond = (second < 10) ? "0" + second : second.ToString();

                        // Converts second and minute from int to string
                        string stringSecond = second.ToString();
                        string stringMinute = minute.ToString();

                        // Prefix minute and second with a 0 in front if minute and second are single digit
                        if (stringSecond.Length == 1 && stringMinute.Length == 1)
                        {
                            Console.WriteLine("       " + hour + ":0" + minute + ":0" + second);
                        }

                        // Prefix exclusively second with a 0 in front if second is single digit and minute is not
                        else if (stringSecond.Length != 1 && stringMinute.Length == 1)
                        {
                            Console.WriteLine("       " + hour + ":0" + minute + ":" + second);
                        }

                        // Prefix exclusively minute with a 0 in front if minute is single digit and second is not
                        else if (stringSecond.Length == 1 && stringMinute.Length != 1)
                        {
                            Console.WriteLine("       " + hour + ":" + minute + ":0" + second);
                        }

                        // Else put colons in between hour, minute, and second
                        else
                        {
                            Console.WriteLine("       " + hour + ":" + minute + ":" + second);
                        }

                        Thread.Sleep(1000);

                        if (hour == 0)
                        {
                            if (second == 0 && minute != 0)
                            {
                                minute = minute - 1;
                                second = 59;
                            }

                            else if (second != 0)
                            {
                                second = second - 1;
                            }
                        }

                        else
                        {
                            if (second == 0 && minute != 0)
                            {
                                minute = minute - 1;
                                second = 59;
                            }
                            else if (second == 0 && minute == 0)
                            {
                                hour = hour - 1;
                                minute = 59;
                                second = 59;
                            }

                            else if (second != 0)
                            {
                                second = second - 1;
                            }
                        }
                    }
                    Console.WriteLine("0:00:00");
                    Console.WriteLine("\nTimer has finished!");
                } 
            }
        }
    }
}


