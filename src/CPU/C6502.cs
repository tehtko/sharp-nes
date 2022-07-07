namespace sharp_nes.CPU
{
	public class C6502
	{
		private ALU ALU { get; set; }
		
		public C6502(int instruction)
		{
			call(instruction);
		}
		
		public int call(int x)
		{
			ALU = new ALU();
			
			return ALU.Power(x);
		}
	}
}