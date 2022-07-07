namespace sharp_nes.CPU
{
	public class C6502
	{
		public void DoStuff()
		{
			Bus bus = new Bus();
			Console.WriteLine("Read the value: " + bus.read(1) + " from address 0x04");	
		}
	}
}