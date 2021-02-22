using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_highest_character
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABRAKADABRA
            string _string = Console.ReadLine();
            string result = Program.GetHighestCharInString(_string);
            Console.WriteLine(result);

            Console.ReadLine();

        }
        public static string GetHighestCharInString(String _string)
        {
            Char[] charArray = _string.ToCharArray();
            IDictionary<Char, int> dict = new Dictionary<Char, int>();
            for(int i=0;i<_string.Length-1;i++)
            {
                if(dict.ContainsKey(charArray[i]))
                {
                    int value = dict[charArray[i]];
                    dict[charArray[i]] = value + 1;
                }
                else
                {
                    dict.Add(charArray[i], 1);
                }
            }

            int maxvalue = dict.Values.Max();

            foreach(var value in dict)
            {
                if(value.Value==maxvalue)
                {
                    Console.WriteLine(value.Key + " " + value.Value);
                }

            }

            return dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key.ToString();
        }
    }
}
