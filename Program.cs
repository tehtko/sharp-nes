using sharp_nes.CPU;
using System.Threading;

namespace sharp_nes
{
    class Program
    {
        static void Main()
        {
            C6502 CPU = new C6502(1);
            Console.WriteLine(CPU.call(5));      
            
            Run();          
        }
        
        public static void Run()
        {
            Console.WriteLine("Hit Escape to exit");
        
            do 
	        {
    		    while (! Console.KeyAvailable) 
		        {
        		    Console.WriteLine("Working");
                    Thread.Sleep(1000);
   	            }             
	        } 
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}