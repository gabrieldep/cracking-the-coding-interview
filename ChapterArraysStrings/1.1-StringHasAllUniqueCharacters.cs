namespace ChapterArraysStrings;

public static class StringHasAllUniqueCharacters
{
    /// <summary>
    /// O(n^2)
    /// </summary>
    public static bool HasUniqueChar(string inputString)
    {	
        for(var i = 0; i < inputString.Length; i++)
            for(var j = i + 1; j < inputString.Length; j++)
                if(inputString[i] == inputString[j])
                    return false;
        return true;
    }
    
    /// <summary>
    /// O(n log n)
    /// </summary>
    private static bool HasUniqueCharModified(string inputString)
    {
        var charArray = inputString.ToCharArray();
        Array.Sort(charArray);

        for (var i = 0; i < charArray.Length - 1; i++)
            if (charArray[i] == charArray[i + 1])
                return false;
        return true;
    }
}