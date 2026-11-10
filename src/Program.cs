using Instructions;
using Lexer;
using Parser;

Tokenizer tokenizer = new Tokenizer();
InstructionParser parser = new InstructionParser();

string[] instructions =
{
    "MOVI R1, 10",
    "ADD R1, R1, R2",
    "SUB R3, R1, R2"
};

foreach (string line in instructions)
{
    string[] tokens = tokenizer.Tokenize(line);
    Instruction result = parser.Parse(tokens);
    Console.WriteLine($"{result.Opcode} | {result.Destination} | {result.Source1} | {result.Source2} | {result.Immediate}");
}