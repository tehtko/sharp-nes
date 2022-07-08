namespace sharp_nes.CPU 
{
	class Bus
	{
		private C6502 CPU { get; set; }
		private byte[] RAM = new byte[64 * 1024];
		
		public Bus()
		{
			CPU = new();
			for(int i=0;i<RAM.Length;i++) { RAM[i]=0x00; }
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