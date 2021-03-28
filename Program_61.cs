using System;

namespace assignment4
{
    class Program
    {
        static int a,b,c,d,e;
          
        static void Main(string[] args)
        {
              a=10;
            b=20;
            c=15;
            d=8;
            e=40;
         one();
         two();
         three();
}

 static void one(){
     int n = ((a+b/(c-5))/((d+7)/(e-37)%3));
     Console.WriteLine("1. "+ n);
 }

 static void two(){
     int n = a+b/c-5/d+7/e-37%3;
     Console.WriteLine("2. "+ n);
 }

 static void three(){
     int n= a*(b*b)-(c*b)+d;
     Console.WriteLine("3. "+ n);
 }

 

}
}
