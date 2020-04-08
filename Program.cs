using System;
using System.Collections.Generic;


namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is int)
                {
                    sum += (int)list[i];
                }
            }
            Console.WriteLine(sum);


            // object ActuallyString = "a string";
            // string ExplicitString = ActuallyString as string;

            // Console.WriteLine(ExplicitString);
        }
    }
}
