using System;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
           
           a();
           b();
           c();
           d();
           e();
           f();
           g();
           h();
           i();
 
           
           

          
           
           
        }

        static void a(){
          int a,b,c;
          a=2;
          b=3;
          c=5;

          ++a;

          Console.WriteLine("a): Valid :: "+a+","+b+","+c);
        }

       static void b(){
           Console.WriteLine("b): Invalid Expression :: abc ::");
       }

       static void c(){
int a,b,c;
          a=2;
          b=3;
          c=5;
          
          a++;

          Console.WriteLine("c): Valid :: "+ a+","+b+","+c);

       }

       static void d(){
int a,b,c;
          a=2;
          b=3;
          c=5;

          b+=a;

           Console.WriteLine("d): Valid :: "+ a+","+b+","+c);
       }

       static void e(){
int a,b,c;
          a=2;
          b=3;
          c=5;
          b+=a*c;
               Console.WriteLine("e): Valid :: "+ a+","+b+","+c);
       }
        
        static void f(){
int a,b,c;
          a=2;
          b=3;
          c=5;
  Console.WriteLine("f): Invalid Expression :: a++b ::");

        }

        static void g(){
int a,b,c;
          a=2;
          b=3;
          c=5;
          a+=2;
          b=2/2;
          c=a*b;
           Console.WriteLine("g): Valid :: "+ a+","+b+","+c);
        }

        static void h(){
int a,b,c;
          a=2;
          b=3;
          c=5;

          Console.WriteLine("h): Invalid Expression :: ++b++ ::");
        }

        static void i(){
int a,b,c;
          a=2;
          b=3;
          c=5;
          b=a++ + b++;
           Console.WriteLine("i): Valid :: "+ a+","+b+","+c);
        }
      
    }
}
