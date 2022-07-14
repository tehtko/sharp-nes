namespace sharp_nes.CPU
{
	public unsafe class Instruction
	{
#pragma warning disable CS8618 // consider declaring nullable warning
		public string opcode { get; set; }
		public delegate* <byte> op_mode { get; set; }
		public delegate* <byte> addr_mode { get; set; }
		public byte cycles { get; set; }
	}
}