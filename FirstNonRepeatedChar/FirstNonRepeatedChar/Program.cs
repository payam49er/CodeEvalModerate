using System;
using System.IO;
using System.Linq;

namespace FirstNonRepeatedChar
{
    class Program
    {
        private static void Main(string[] args)
        {

            using (StreamReader reader = File.OpenText(args[0]))
            {
                while (!reader.EndOfStream)
                {
                    var lineValue = reader.ReadLine();

                    var grouped = lineValue.GroupBy(x => x);

                    foreach (var group in grouped)
                    {
                        if (group.Count() == 1)
                        {
                            Console.WriteLine(group.Key);
                            break;
                        }

                    }
                }
            }
        }
    }
}
