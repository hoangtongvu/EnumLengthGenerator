using System;

namespace EnumLengthGenerator
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
    public class GenerateEnumLengthAttribute : Attribute
    {
    }
}