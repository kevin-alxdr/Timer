namespace Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(22, 7);
            var answer = SetAnswer();
            var numOfColon = SetTime(answer);

            Console.Clear();

            if (numOfColon == 0)
            {
                Second.Method(answer);
            }

            if (numOfColon == 1)
            {
                Minute.Method(numOfColon, answer);
            }

            if (numOfColon == 2)
            {
                Hour.Method(numOfColon, answer);
            }
        }
        public static string SetAnswer()
        {

            Console.WriteLine("=====================");
            Console.WriteLine(" Set Timer (xx:xx:xx)");
            Console.WriteLine("=====================\n");
            string answer = Console.ReadLine();
            

            if (answer == null)
            {
                Console.WriteLine("Please enter a time.");
            }
            return answer;
        }
        public static int SetTime(string answer) {
            
            char c = ':';

            var numOfColon = Count.count(answer, c);

            return numOfColon;
        }
        public static void ClearCurrentConsoleLine(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, y);
        }
    }
}













































































































/**
Console.WriteLine("How long would you like to set a timer for? (xx:xx:xx)");
string time = Console.ReadLine();

List<string> timer = new List<string>();
timer.Add(time);
String[] arraytimer = timer.ToArray();

Console.WriteLine(arraytimer);





            //Console.WriteLine("\nTimer Started: ");

            //


            //while (answer2 != 0)
            //{
            //    answer2 = answer2 - 1;
            //    

            //}





string[] subs = timer.Split(':');

int hour = int.Parse(subs[0]);
int minute = int.Parse(subs[1]);
int second = int.Parse(subs[2]);


Console.WriteLine(subs[0] + subs[1] + subs[2]);







Console.WriteLine(timer.Contains(":"));
string format = Console.ReadLine();

for (int i = 0; i < format.Length; i++)
{


    Console.WriteLine(format);
}

    /
    string colonCount = format.Count();

    

    if (format == "true")
    {

    }
    
}


int Newtimer = int.Parse(timer);
Newtimer = (Newtimer * 60);






while (timer != null)
{
    Newtimer = Newtimer - 1;
    Thread.Sleep(1000);
    Console.WriteLine(Newtimer);
    
    if (Newtimer == 0)
    {
        Console.WriteLine("Timer finished!");
        // A sound should play here after the timer has finished
        // -------------------------
        //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
        //player.Play();
        break;
    }
}

*/