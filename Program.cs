using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] STR = new string[15];
            string[] str = new string[15] { "24", "g", "F", "h", "t", "6", "S", "H", "R", "5", "h", "k", "L", "p", "78", };
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                try
                {
                    int a = Convert.ToInt32(str[i]);
                    str[i] = "";
                }
                catch (Exception) { }
            }
            Console.WriteLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[i].ToUpper())
                {
                    STR[i] = str[i];
                }
            }

            for (int i = 0; i < STR.Length; i++)
            {
                Console.Write(STR[i]);
            }
        }
    }
}
