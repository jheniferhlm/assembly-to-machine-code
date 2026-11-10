namespace Instructions
{
    public class Instruction
    {
        public Opcode Opcode { get; set; }
        public int Destination { get; set; }
        public int Source1 { get; set; }
        public int Source2 { get; set; }
        public int Immediate { get; set; }
    }
}