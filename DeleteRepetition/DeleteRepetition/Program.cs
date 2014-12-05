using System;
using System.Linq;

namespace DeleteRepetition
{
    using System.IO;

    class Program
    {
        private static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    string[] lineValue = reader.ReadLine().Split(' ');

                    foreach (string s in lineValue)
                    {
                        if (s.Any())
                        {
                            Console.Write(s[0]);

                            for (int i = 1; i < s.Count(); i++)
                            {
                                if (s[i] != s[i - 1])
                                {
                                    Console.Write(s[i]);

                                }
                            }
                            Console.Write(' ');
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.Read();

        }
    }
}
