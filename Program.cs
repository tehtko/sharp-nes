using sharp_nes.CPU;

namespace sharp_nes
{
    class Program
    {
        static void Main()
        {
            C6502 CPU = new C6502(1);
            Console.WriteLine(CPU.call(5));                
        }
    }
}