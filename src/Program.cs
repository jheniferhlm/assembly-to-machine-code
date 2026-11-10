using Lexer;
using Parser;

Tokenizer tokenizer = new Tokenizer();
InstructionParser parser = new InstructionParser();

string instruction = "MOVI R1, 10";

string[] tokens = tokenizer.Tokenize(instruction);

var result = parser.Parse(tokens);

Console.WriteLine($"Opcode: {result.Opcode}");
Console.WriteLine($"Destination: {result.Destination}");
Console.WriteLine($"Immediate: {result.Immediate}");