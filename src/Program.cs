using Lexer;
using Parser;
using Encoder;

Tokenizer tokenizer = new Tokenizer();
InstructionParser parser = new InstructionParser();
InstructionEncoder encoder = new InstructionEncoder();

string[] assemblys = [
    "MOVI R1, 10",
    "MOVI R2, 5",
    "ADD R1, R1, R2",
    "SUB R3, R1, R2"
];

foreach (var assembly in assemblys)
{
    string[] tokens = tokenizer.Tokenize(assembly);
    var instruction = parser.Parse(tokens);
    string machineCode = encoder.Encode(instruction);

    Console.WriteLine(machineCode);
}