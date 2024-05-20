namespace ChapterArraysStrings;

public static class RemoveDuplicateCharWithoutBuffer
{
    public static string? RemoveDuplicateChar(string inputString)
    {
        for (var i = 0; i < inputString.Length; i++)
            for (var j = i + 1; j < inputString.Length; j++)
                if (inputString[i] == inputString[j])
                    inputString = inputString.Remove(j, 1);
        return inputString;
    }
    
    public static string? RemoveDuplicateCharModified(string inputString)
    {
        if (string.IsNullOrEmpty(inputString))
            return inputString;

        var checker = 0;

        for (var i = 0; i < inputString.Length; i++)
        {
            var value = inputString[i] - 'a';
            if ((checker & (1 << value)) > 0)
            {
                inputString = inputString.Remove(i, 1);
                i--;
            }
            else
                checker |= (1 << value);
        }

        return inputString;
    }

}