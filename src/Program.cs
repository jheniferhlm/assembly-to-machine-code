using Lexer;

Tokenizer tokenizer = new Tokenizer();

string[] instructions =
{
    "MOVI R1, 10",
    "ADD R1, R1, R2",
    "HALT"
};

foreach (string instruction in instructions)
{
    string[] tokens = tokenizer.Tokenize(instruction);
    Console.WriteLine(string.Join(" | ", tokens));
}