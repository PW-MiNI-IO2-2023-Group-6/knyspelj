namespace IoLabUnitTests;

public sealed class IsZeroChecker
{
    public static bool IsZero(object? input)
    {
        return input switch
        {
            int number => number == 0 || number == 1,
            string text => text == "0",
            null => true,
            char symbol => symbol == '0',
            _ => false
        };
    }
}
