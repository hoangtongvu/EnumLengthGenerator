using EnumLengthGenerator;

namespace Cores
{
    [GenerateEnumLength]
    public enum EnumWithBaseType_Byte : byte
    {
        First = 0,
        Second = 1,
        Forth = 3,
    }
}
