using Instructions;

namespace Parser
{
    public class InstructionParser
    {
        public bool ValidateRegister(string register)
        {
            if (register == null || !register.StartsWith("R"))
                return false;

            int registerNumber;

            if (!int.TryParse(register.Substring(1), out registerNumber))
                return false;

            return registerNumber >= 0 && registerNumber <= 3;
        }

        public bool ValidateImmediate(string immediate)
        {
            if (!int.TryParse(immediate, out int immediateNumber))
                return false;

            return immediateNumber >= 0 && immediateNumber <= 1023;
        }

        public Instruction Parse(string[] tokens)
        {
            switch (tokens[0])
            {
                case "MOVI":
                    if (ValidateRegister(tokens[1]) && ValidateImmediate(tokens[2]))
                    {   
                        return new Instruction()
                        {
                            Opcode = Opcode.MOVI,
                            Destination = Convert.ToInt32(tokens[1].Substring(1)),
                            Immediate = Convert.ToInt32(tokens[2])
                        };
                    }
                    else
                    {
                        throw new Exception("The destination register and/or the immediate is/are invalid.");
                    }
                case "ADD":
                    if (ValidateRegister(tokens[1]) && ValidateRegister(tokens[2]) && ValidateRegister(tokens[3]))
                    {   
                        return new Instruction()
                        {
                            Opcode = Opcode.ADD  ,
                            Destination = Convert.ToInt32(tokens[1].Substring(1)),
                            Source1 = Convert.ToInt32(tokens[2].Substring(1)),
                            Source2 = Convert.ToInt32(tokens[3].Substring(1))
                        };
                    }
                    else
                    {
                        throw new Exception("The registers are invalid.");
                    }
                case "SUB":
                    if (ValidateRegister(tokens[1]) && ValidateRegister(tokens[2]) && ValidateRegister(tokens[3]))
                        { 
                        return new Instruction()
                        {
                            Opcode = Opcode.SUB  ,
                            Destination = Convert.ToInt32(tokens[1].Substring(1)),
                            Source1 = Convert.ToInt32(tokens[2].Substring(1)),
                            Source2 = Convert.ToInt32(tokens[3].Substring(1))
                        };
                    }
                    else
                    {
                        throw new Exception("The registers are invalid.");
                    }
                default:
                    throw new Exception("Error parsing the tokens.");
            }
        }
    }
}