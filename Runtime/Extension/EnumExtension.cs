public static class EnumExtension
{
    static IEnumerable<Enum> GetFlags(Enum input)
    {
        foreach (Enum value in Enum.GetValues(input.GetType()))
            if (input.HasFlag(value))
                yield return value;
    }
}