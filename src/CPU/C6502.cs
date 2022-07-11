namespace sharp_nes.CPU
{
	public class C6502
	{
		private byte   A         = 0x00;   // Accumulator Register
		private byte   X         = 0x00;   // X Register
		private byte   Y         = 0x00;   // Y Register
		
		private byte   sp        = 0x00;   // Stack Pointer
		private byte   sr        = 0x00;   // Status Register
		private ushort pc        = 0x0000; // Program Counter
		
		private byte fetched     = 0x00;   // Represents the working input value to the ALU
		private byte temp        = 0x00;   // A convenience variable 
		private byte addr_abs    = 0x00;   // All used memory addresses end up here
		private byte addr_rel    = 0x00;   // Represents absolute address following a branch
		private byte opcode      = 0x00;   // The instruction byte
		private byte cycles      = 0;	   // Total number of remaining cycles per instrction
		private byte clock_count = 0;      // Total number of clocks
					
		private Bus Bus { get; set; }
		
		internal struct INSTRUCTION
		{
			char[] opcode = new char[3];
			byte cycles = 0x00;
			public INSTRUCTION() {}
		}
		
		INSTRUCTION[] table = new INSTRUCTION[256];
		
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
		
		byte GetFlag(FLAGS f)
		{
			return 0;
		}
		
		void SetFlag(FLAGS f)
		{
			
		}
		
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