using Lexer;
using Parser;
using Encoder;

Tokenizer tokenizer = new Tokenizer();
InstructionParser parser = new InstructionParser();
InstructionEncoder encoder = new InstructionEncoder();

string[] assemblys = File.ReadAllLines("../examples/hello.asm");

foreach (var assembly in assemblys)
{
    string[] tokens = tokenizer.Tokenize(assembly);
    var instruction = parser.Parse(tokens);
    string machineCode = encoder.Encode(instruction);

    Console.WriteLine(machineCode);
}