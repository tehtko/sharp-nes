namespace sharp_nes.CPU
{
	public unsafe class C6502
	{
#pragma warning disable CS0414 // unused variable warning

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
		private Instruction[] instructions { get; set; }			
								
		public C6502()
		{
			Bus = new();
			instructions = new Instruction[256];
			for(int i=0;i<256;i++)
			{
				instructions[i] = new Instruction { opcode = "BRK", op_mode = &BRK, addr_mode = &IMM, cycles = 7 };
			}
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
		
        // Addressing Modes
        static byte IMP() { return 0; }	static byte IMM() { return 0; }	
        static byte ZP0() { return 0; }	static byte ZPX() { return 0; }	
        static byte ZPY() { return 0; }	static byte REL() { return 0; }
        static byte ABS() { return 0; }	static byte ABX() { return 0; }	
        static byte ABY() { return 0; }	static byte IND() { return 0; }	
        static byte IZX() { return 0; }	static byte IZY() { return 0; }
        
        // Opcodes
        static byte ADC() { return 0; }	static byte AND() { return 0; }	static byte ASL() { return 0; }	static byte BCC() { return 0; }
        static byte BCS() { return 0; }	static byte BEQ() { return 0; }	static byte BIT() { return 0; }	static byte BMI() { return 0; }
        static byte BNE() { return 0; }	static byte BPL() { return 0; }	static byte BRK() { return 0; }	static byte BVC() { return 0; }
        static byte BVS() { return 0; }	static byte CLC() { return 0; }	static byte CLD() { return 0; }	static byte CLI() { return 0; }
        static byte CLV() { return 0; }	static byte CMP() { return 0; }	static byte CPX() { return 0; }	static byte CPY() { return 0; }
        static byte DEC() { return 0; }	static byte DEX() { return 0; }	static byte DEY() { return 0; }	static byte EOR() { return 0; }
        static byte INC() { return 0; }	static byte INX() { return 0; }	static byte INY() { return 0; }	static byte JMP() { return 0; }
        static byte JSR() { return 0; }	static byte LDA() { return 0; }	static byte LDX() { return 0; }	static byte LDY() { return 0; }
        static byte LSR() { return 0; }	static byte NOP() { return 0; }	static byte ORA() { return 0; }	static byte PHA() { return 0; }
        static byte PHP() { return 0; }	static byte PLA() { return 0; }	static byte PLP() { return 0; }	static byte ROL() { return 0; }
        static byte ROR() { return 0; }	static byte RTI() { return 0; }	static byte RTS() { return 0; }	static byte SBC() { return 0; }
        static byte SEC() { return 0; }	static byte SED() { return 0; }	static byte SEI() { return 0; }	static byte STA() { return 0; }
        static byte STX() { return 0; }	static byte STY() { return 0; }	static byte TAX() { return 0; }	static byte TAY() { return 0; }
        static byte TSX() { return 0; }	static byte TXA() { return 0; }	static byte TXS() { return 0; }	static byte TYA() { return 0; }
        
        // Illegal Opcode caught here
        static byte XXX() { return 0; } static byte ZZZ() { return 0; }
	}
}