namespace Lexer
{
    public class Tokenizer
    {
        public string[] Tokenize(string instruction)
        {
            if (string.IsNullOrWhiteSpace(instruction))
                return new string[0];

            string[] tokens = instruction
                .Replace(",", "")
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return tokens;
        }
    }
}