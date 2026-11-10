namespace Lexer
{
    public class Tokenizer
    {
        public string[] Tokenize(string instruction)
        {
            string[] tokens = instruction
                .Replace(",", "")
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return tokens;
        }
    }
}