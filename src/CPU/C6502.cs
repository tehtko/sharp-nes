namespace sharp_nes.CPU
{
	public class C6502
	{
		private Bus Bus { get; set; }
		
		public C6502()
		{
			Bus = new();
		}
		
		void read(ushort addr) { Bus.read(addr); }
		
		void write(ushort addr, byte data) { Bus.write(addr, data); }
	}	
}