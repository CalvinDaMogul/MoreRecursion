using System;

namespace fiboapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program me= new Program();
            int f= me.fibo(1,2);

            
        }

        public int fibo(int a, int b ) {
            int math;

           do{ 
               math=a+b;
            Console.WriteLine(a+"+"+b+"="+math);               
               

            if(math%2>0) {
                a=b;
                b=math;
                
            }
           }
            while (math%2>0); 
            return math;
            
             
        }
    }
}
