namespace sharp_nes.CPU
{
	public class C6502
	{
		private byte A = 0;
		private byte X = 0;
		private byte Y = 0;
		
		private Bus Bus { get; set; }
		
		public C6502()
		{
			Bus = new();
		}
		
		[Flags]
		enum FLAGS
		{
			C = (1 << 0), // Carry Bit 
			Z = (1 << 1), // Zero
			I = (1 << 2), // Disable Interrupts
			D = (1 << 3), // Decimal Mode
			B = (1 << 4), // Break
			U = (1 << 5), // Unused
			V = (1 << 6), // Overflow
			N = (1 << 7)  // Negative
		};
		
		void write(ushort addr, byte data) { Bus.write(addr, data); }
		
		void read(ushort addr) { Bus.read(addr); }
		
		void IRQ()
		{
			
		}
		
		void NMI()
		{
			
		}
		
		void RESET()
		{
			
		}
	}
}