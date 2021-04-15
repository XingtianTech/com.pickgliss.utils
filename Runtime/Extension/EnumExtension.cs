using System;
using System.Collections.Generic;

public static class EnumExtension
{
    public static IEnumerable<Enum> GetFlags(Enum input)
    {
        foreach (Enum value in Enum.GetValues(input.GetType()))
            if (input.HasFlag(value))
                yield return value;
    }
}