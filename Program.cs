using System;
using System.Collections.Generic;


namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box some string data into a variable
            List<object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");
            //Make sure it is the type you need before proceeding
            if (list is object)
            {
                //This shouldn't run
                Console.WriteLine("I guess we have an integer value in this box?");
            }
            if (list is string)
            {
                Console.WriteLine("It is totally a string in the box!");
            }

        }
    }
}
