using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    public class SameStringCount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            if (s.Length>94)
            {
                Console.WriteLine("Invalid Length");
            }
            else
            {
               string s1=s.ToLower();
                //Console.WriteLine(s1);
                string[] str = s1.Split(':');

                Dictionary<string, int> WordCh = new Dictionary<string, int>();
                foreach(string word in str)
                {
                    if(WordCh.ContainsKey(word))
                    {
                        WordCh[word]++;
                    }
                    else
                    {
                        WordCh[word] = 1;
                    }
                }
                foreach(var CountWord in WordCh)
                {
                   Console.WriteLine($"{CountWord.Key}:{CountWord.Value}");
                }

            }
        }
    }
}