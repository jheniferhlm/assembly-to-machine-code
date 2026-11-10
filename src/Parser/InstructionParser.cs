using Instructions;

namespace Parser
{
    public class InstructionParser
    {
        public Instruction Parse(string[] tokens)
        {
            switch (tokens[0])
            {
                case "MOVI":
                    return new Instruction()
                    {
                        Opcode = Opcode.MOVI,
                        Destination = Convert.ToInt32(tokens[1].Substring(1)),
                        Immediate = Convert.ToInt32(tokens[2])
                    };
                default:
                    throw new Exception("Error parsing the tokens.");
            }
        }
    }
}