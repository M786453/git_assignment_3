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
           j();
           k();
 }

        static void a(){
           int n=22/8;
           Console.WriteLine("a): "+ n);
           }

       static void b(){
      int n=99/8 + 21/11*7;
      Console.WriteLine("b): "+ n);
        }

       static void c(){
           double a =4,b=3,p=8,q=2;
           double n=q/a - p/b;
           Console.WriteLine("c): "+n);

       }

       static void d(){
         int a=6,b=3,p=8,q=2;
         double n=p/a + q/b;
         Console.WriteLine("d): "+n);
   
       }

       static void e(){
         
         double a=3.3,b=2.7,p=8.7,q=5.4;
         int n= (int) (p/b +q/a);
         Console.WriteLine("e): "+ n);

       }
        
        static void f(){

          int n=11+7/4+98%6*3;
          Console.WriteLine("f): "+ n);

        }

        static void g(){
     
     int n=11/31%8*5-12;
     Console.WriteLine("g): "+ n);



        }

        static void h(){
      
      double p=8;
      int q=5;
      int n=(int) (q*p + 3.0*p*p - (q%3)*p*p*p);
      Console.WriteLine("h): "+ n);

   }

        static void i(){
        
        double p=5;
        int q=9;
        int n= (int) ((q%2)*p +6.0*p*(q%3) + (q%4)*p*p*p);
        Console.WriteLine("i): "+ n);

        }

        static void j(){
            int n=3,a=6,b=2;
            n *= a+b;
            a--;
            n %=a;
            Console.WriteLine("j): "+n);
        }

        static void k(){
            int a,n=5;
            ++n;
            a=--n;
            n = n-a;
            Console.WriteLine("k): "+ n);
        }
      
    }
}
