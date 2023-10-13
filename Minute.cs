namespace Project
{
    public class Minute
    {
        public static void Method(int numOfColon, string answer)
        {
            Program.ClearCurrentConsoleLine(0, 0);

            if (numOfColon == 1)
            {
                var split = answer.Split(':');

                int minute = int.Parse(split[0]);
                int second = int.Parse(split[1]);

                if (minute > 60 || second > 60)
                {
                    Console.SetWindowSize(60, 15);
                    Console.WriteLine("Please use the correct time format.");
                }

                else
                {

                    Console.WriteLine("=====================");
                    Console.WriteLine("    Timer Started:   ");
                    Console.WriteLine("=====================");

                    while (second != 0 || minute != 0)
                    {
                        Program.ClearCurrentConsoleLine(0, 4);

                        // Add leading zero for single-digit seconds
                        string formattedMinute = minute < 10 ? "0" + minute : minute.ToString();
                        string formattedSecond = (second < 10) ? "0" + second : second.ToString();

                        Console.WriteLine("        " + formattedMinute + ":" + formattedSecond);

                        Thread.Sleep(1000);

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
                    Console.WriteLine("0:00");
                    Console.WriteLine("\nTimer has finished!");
                }
            }      
        }
    }
}
