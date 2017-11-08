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

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            list.Add("Hello");
            list.Add("World");
            list.Add("Alex");
            list.Add("is");
            list.Add("a");
            list.Add("borneo");
            list.Add("and");
            list.Add("wait");
            list.Add("Frieza");
            list.Add("is");
            list.Add("cheating");
            list.Add("my");
            list.Add("name");
            list.Add("be");
            list.Add("Jacco");
            list.Add("Guys");

            list.Add(2, "muffin");
            Console.WriteLine(list.ElementAt(2).Data);
            // TODO:  Print out the list

            // TODO:  Remove every 3rd word
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
