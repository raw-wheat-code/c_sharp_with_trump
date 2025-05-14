public static class MessageValidation
{
    public static bool ValidYesNoInput(string input)
    {
        string i = input.ToUpper();
        return i == "Y" || i == "N" || i == "YES" || i == "NO";
    }

    public static bool ValidNumericSelection(int input)
    {
        return input >= 1 && input <= 100;
    }
}