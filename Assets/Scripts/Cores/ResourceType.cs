using EnumLengthGenerator;
using UnityEngine;

namespace Cores
{
    [GenerateEnumLength]
    public enum ResourceType : byte
    {
        First = 0,
        Second = 1,
        Third = 2,
        Forth = 3,
        Fifth = 4,
    }
}
