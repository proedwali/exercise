using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivo_Filipov_Hristov_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":P agsdfs");
            Console.WriteLine("Waiting for input: ");
            string input;
            input = Console.ReadLine();
            input = input.ToUpper();
            input = input.Replace(" ", "");
            char[] array = input.ToArray();
            Array.Sort(array);    
               
           
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (var count in array)
            {
                if (dictionary.ContainsKey(count))
                    dictionary[count] = dictionary[count] + 1;
                else
                    dictionary.Add(count, 1);
            }
            var items = from pair in dictionary
                    orderby pair.Value descending
                    select pair;


            var i = 0;
                foreach (KeyValuePair<char, int> pair in items)
                {
                    string sharp = new String('#', pair.Value * 5);
                   
                    Console.WriteLine("{0}: {1}{2}", pair.Key, pair.Value, sharp);
                    i++;
                    if (i >= 20) break;
                
                }

           
                Console.ReadLine();

            }
        }
    }
