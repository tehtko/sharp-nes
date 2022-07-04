namespace sharp_nes.CPU
{
	public class CPU
	{
		private ALU ALU { get; set; }
		
		public CPU(int instruction)
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