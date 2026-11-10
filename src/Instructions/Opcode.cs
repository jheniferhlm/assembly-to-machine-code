namespace Instructions
{
    public enum Opcode
    {
        MOVI = 0b0000,
        ADD = 0b0001,
        SUB = 0b0010,
        AND = 0b0011,
        OR = 0b0100,
        XOR = 0b0101,
        NOT = 0b0110,
        LOAD = 0b0111,
        STORE = 0b1000,
        JMP = 0b1001,
        JZ = 0b1010,
        HALT = 0b1111
    }
}