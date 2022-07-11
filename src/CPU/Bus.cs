namespace sharp_nes.CPU
{
	public class Bus
	{
		private byte[] RAM = new byte[64 * 1024];
	
		public Bus()
		{
			for(int i=0;i<RAM.Length;i++) { RAM[i]=0x00; }
		}
	
		public void write(ushort addr, byte data)
		{
			if(addr>=0x000 && addr<=0xFFFF)
				RAM[addr] = data;
		}
		
		public byte read(ushort addr)
		{
			if(addr>=0x000 && addr<=0xFFFF)
				return RAM[addr];
				
			return 0x00;
		}
	}
}