using Instructions;

namespace Encoder
{
    public class InstructionEncoder
    {
        public string Encode(Instruction instruction)
        {
            string opcode;
            string destination;
            string source1;
            string source2;
            string immediate;
            string reserved = "000000";

            switch (instruction.Opcode)
            {
                case Opcode.MOVI:
                    opcode = Convert.ToString(Convert.ToInt32(instruction.Opcode), 2).PadLeft(4, '0');
                    destination = Convert.ToString(instruction.Destination, 2).PadLeft(2, '0');
                    immediate = Convert.ToString(instruction.Immediate, 2).PadLeft(10, '0');

                    return opcode + destination + immediate;    
                case Opcode.ADD:
                case Opcode.SUB:
                    opcode = Convert.ToString(Convert.ToInt32(instruction.Opcode), 2).PadLeft(4, '0');
                    destination = Convert.ToString(instruction.Destination, 2).PadLeft(2, '0');
                    source1 = Convert.ToString(instruction.Source1, 2).PadLeft(2, '0');
                    source2 = Convert.ToString(instruction.Source2, 2).PadLeft(2, '0');

                    return opcode + destination + source1 + source2 + reserved;
                default:
                    throw new Exception("Something went wrong when encoding.");
            }
        }
    }
}