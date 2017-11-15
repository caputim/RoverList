using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program 
    {
        static void Main(string[] args)
        {
            RoverList list = new RoverList();
            String input = "";
            int b = 0;
            int c = 0;

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            list.Add("hello");
            list.Add("world");
            list.Add("alex");
            list.Add("is");
            list.Add("a");
            list.Add("borneo");
            list.Add("and");
            list.Add("wait");
            list.Add("frieza");
            list.Add("is");
            list.Add("cheating");
            list.Add("my");
            list.Add("name");
            list.Add("be");
            list.Add("jacco");
            list.Add("guys");
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Remove every 3rd word
            list.RemoveAt(2);
            list.RemoveAt(4);
            list.RemoveAt(6);
            list.RemoveAt(8);
            list.RemoveAt(10);
            // TODO:  Print out the list
            Console.WriteLine("");
            list.ListNodes();
            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"

            Console.WriteLine();
            Console.WriteLine("Type words to add to the list. Write done when done.");
            while(input != "done")
            {
                input = Console.ReadLine();
                list.Add(input);
            }

            // TODO:  Print out the list
            list.ListNodes();
            input = "";
            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            Console.WriteLine("");
            Console.WriteLine("Type words to add to the front of the list. Write done when done.");
            while (input != "done")
            {
                input = Console.ReadLine();
                list.Add(0, input);
            }
            // TODO:  Print out the list
            Console.WriteLine("");
            list.ListNodes();
            // TODO:  Remove every word with an odd length
            while (list.ElementAt(b) != null)
            {
                c = (((list.ElementAt(b)).Data).ToString()).Length;
                Console.WriteLine(c);
                if (c % 2 != 0)
                    list.RemoveAt(b);
                b++;
            }
            // TODO:  Print out the list
            Console.WriteLine("");
            list.ListNodes();
                // TODO:  Clear the list
                // TODO:  Print out the list


        }
    }
}
