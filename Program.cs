using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> things = new List<object>();
            things.Add(7);
            things.Add(28);
            things.Add(-1);
            things.Add("true");
            things.Add("chair");


            int sum = 0;
            foreach (var item in things){
                Console.WriteLine(item);
                if(item is int){
                    int NowAsString = (int)item;
                    sum += NowAsString;
                    //Or
                    // sum += (int)item;
                }
            }
            Console.WriteLine(sum);

        }
    }
}
