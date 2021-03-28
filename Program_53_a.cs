using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {


            int x=20,y=35;
            x=y++ + x++;
            y = ++y + ++x;
            Console.WriteLine(":: Output of Question.No.53 is bellow :: ");
            Console.WriteLine("a): "+x+""+y);
           
           
        }
    }
}
