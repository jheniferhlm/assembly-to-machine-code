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
                case "ADD":
                    return new Instruction()
                    {
                        Opcode = Opcode.ADD  ,
                        Destination = Convert.ToInt32(tokens[1].Substring(1)),
                        Source1 = Convert.ToInt32(tokens[2].Substring(1)),
                        Source2 = Convert.ToInt32(tokens[3].Substring(1))
                    };
                case "SUB":
                    return new Instruction()
                    {
                        Opcode = Opcode.SUB  ,
                        Destination = Convert.ToInt32(tokens[1].Substring(1)),
                        Source1 = Convert.ToInt32(tokens[2].Substring(1)),
                        Source2 = Convert.ToInt32(tokens[3].Substring(1))
                    };
                default:
                    throw new Exception("Error parsing the tokens.");
            }
        }
    }
}