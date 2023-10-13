namespace Project 
{
    public class Second
    {
        public static void Method(string answer)
        {
            int answer2 = int.Parse(answer);

            Program.ClearCurrentConsoleLine(0,0);

            if (answer2 > 60)
            {
                Console.SetWindowSize(60, 15);
                Console.WriteLine("Please use the correct time format.");
            }

            else
            {
                Console.WriteLine("=====================");
                Console.WriteLine("    Timer Started:   ");
                Console.WriteLine("=====================");

                while (answer2 >= 0)
                {
                    Program.ClearCurrentConsoleLine(0, 4);
                    string formattedSecond = (answer2 < 10) ? "0" + answer2 : answer2.ToString();

                    Console.WriteLine("          " + formattedSecond);

                    answer2 = answer2 - 1;
                    Thread.Sleep(1000);

                    if (answer2 == 0)
                    {
                        Console.WriteLine("\nTimer has finished!");
                    }
                }
            }
        }
    }
}


