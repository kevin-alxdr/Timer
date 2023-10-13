// Geeks for Geeks (program count occurrence given character string)
namespace Project
{
    public class Count
    {
        public static int count(string s, char c)
        {
            int num = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                    num++;
            }

            return num;
        }
    }
}
