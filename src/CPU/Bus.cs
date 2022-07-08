namespace sharp_nes.CPU 
{
	class Bus
	{
		private C6502 CPU { get; set; }
		
		public Bus()
		{
			CPU = new();
		}
		
		public void write(ushort addr, byte data)
		{
			
		}
		
		public byte read(ushort addr)
		{
			return 10;
		}
	}
}