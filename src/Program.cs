using Instructions;

foreach (Opcode opcode in Enum.GetValues(typeof(Opcode)))
{
    int value = (int)opcode;
    Console.WriteLine($"{opcode} | Decimal: {value} | Binary: {Convert.ToString(value, 2).PadLeft(4, '0')}");
}