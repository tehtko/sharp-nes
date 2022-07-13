namespace sharp_nes.CPU
{
	public unsafe class C6502
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
		
		struct INSTRUCTION
		{
			char[] opcode = new char[3];
			delegate* <byte> op_mode = null;
			delegate* <byte> addr_mode = null;
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
		
        // Addressing Modes
        byte IMP() { return 0; }	byte IMM() { return 0; }	
        byte ZP0() { return 0; }	byte ZPX() { return 0; }	
        byte ZPY() { return 0; }	byte REL() { return 0; }
        byte ABS() { return 0; }	byte ABX() { return 0; }	
        byte ABY() { return 0; }	byte IND() { return 0; }	
        byte IZX() { return 0; }	byte IZY() { return 0; }
        
        // Opcodes
        byte ADC() { return 0; }	byte AND() { return 0; }	byte ASL() { return 0; }	byte BCC() { return 0; }
        byte BCS() { return 0; }	byte BEQ() { return 0; }	byte BIT() { return 0; }	byte BMI() { return 0; }
        byte BNE() { return 0; }	byte BPL() { return 0; }	byte BRK() { return 0; }	byte BVC() { return 0; }
        byte BVS() { return 0; }	byte CLC() { return 0; }	byte CLD() { return 0; }	byte CLI() { return 0; }
        byte CLV() { return 0; }	byte CMP() { return 0; }	byte CPX() { return 0; }	byte CPY() { return 0; }
        byte DEC() { return 0; }	byte DEX() { return 0; }	byte DEY() { return 0; }	byte EOR() { return 0; }
        byte INC() { return 0; }	byte INX() { return 0; }	byte INY() { return 0; }	byte JMP() { return 0; }
        byte JSR() { return 0; }	byte LDA() { return 0; }	byte LDX() { return 0; }	byte LDY() { return 0; }
        byte LSR() { return 0; }	byte NOP() { return 0; }	byte ORA() { return 0; }	byte PHA() { return 0; }
        byte PHP() { return 0; }	byte PLA() { return 0; }	byte PLP() { return 0; }	byte ROL() { return 0; }
        byte ROR() { return 0; }	byte RTI() { return 0; }	byte RTS() { return 0; }	byte SBC() { return 0; }
        byte SEC() { return 0; }	byte SED() { return 0; }	byte SEI() { return 0; }	byte STA() { return 0; }
        byte STX() { return 0; }	byte STY() { return 0; }	byte TAX() { return 0; }	byte TAY() { return 0; }
        byte TSX() { return 0; }	byte TXA() { return 0; }	byte TXS() { return 0; }	byte TYA() { return 0; }
        
        // Illegal Opcode caught here
        byte XXX() { return 0; }
	}
}