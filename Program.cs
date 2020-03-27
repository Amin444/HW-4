using System;

namespace HW_4
{
    class Program
    {
        static void Main(string[] args)
        {
               /* decimal Person=3000;
                
                decimal sale=0;
                if(Person>=1000)
                {
                    sale=Person/100*5;
                }
                if(Person>=500)
                {
                    sale=Person/100*3;
                }
                System.Console.WriteLine($"Sale={sale}");*/

               /* int a=3,b=83,c=463,d=43;
                   int count=0;
                    if(a!=b&&b!=c&&c!=d)
                    {
                        if(a<c&&a<b&&a<d)
                        {
                            System.Console.WriteLine(a);
                        }
                        if(b<c&&b<d&&b<a)
                        {
                            System.Console.WriteLine(b);
                        }
                        if(c<a&&c<b&&c<d)
                        {
                            System.Console.WriteLine(c);
                        }
                        if(d<c&&d<b&&d<a)
                        {
                            System.Console.WriteLine(d);
                        }
                    }
                    else if(a==b&&b==c&&c==d)
                    {
                       count= a*b*c*d;
                       System.Console.WriteLine(count);
                    }
                    else if(a>b&&b>c&&c>d)
                    {
                        System.Console.WriteLine("Числа расположены по возрастанию");
                    }*/

                    int a=5,b=4,c=9,w=0;
                    if(a>=b&&b>=c)
                    {
                        System.Console.WriteLine($"A={a}B={b}C={c}");
                    }
                    else if(a<=b&&b<=c)
                    {
                        w=a;
                        a=c;
                        c=w;
                        System.Console.WriteLine($"A={a}B={b}C={c}");
                    }
                    else if(b>=a&&a>=c)
                    {
                        w=a;
                        a=b;
                        b=w;
                        System.Console.WriteLine($"A={a}B={b}C={c}");
                    }
                    else if(a>=c&&c>=b)
                    {
                        w=b;
                        b=c;
                        c=w;
                        System.Console.WriteLine($"A={a}B={b}C={c}");
                    }
                    else if(c>=b&&a>=b)
                    {
                        w=b;
                        c=a;
                        w=c;
                    }
                    else
                    {System.Console.WriteLine("Этот вариант не был добавнел");}
              Console.ReadKey();
        }
    }
}
