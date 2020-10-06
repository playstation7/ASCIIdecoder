using System;
using System.Collections.Generic;

namespace ASCIIdecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string of nums.For example: 7797121321161041013210211111499101329810132119105116104328911111733");
            string a = Console.ReadLine();
            List<string> s = new List<string>();
            string c = "";
            for (int i = 0; i < a.Length;)
            {
                if ((Convert.ToInt32((a[i].ToString() + a[i + 1].ToString())) >= 32 && (Convert.ToInt32((a[i].ToString() + a[i + 1].ToString())) <= 127)))
                {
                    s.Add(a[i].ToString() + a[i+1].ToString());
                    i += 2;
                }
                else 
                {
                    s.Add(a[i].ToString() + a[i+1].ToString()+a[i + 2].ToString());
                    i += 3;
                }
                
            }
            foreach (var item in s)
            {
                
                c += (char)Convert.ToInt32(item);
            }
            Console.WriteLine(c);


        }
    }
}
