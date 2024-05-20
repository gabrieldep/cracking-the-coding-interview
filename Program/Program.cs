using System;
using ChapterArraysStrings;

namespace Program;

public abstract class Program
{
    public static void Main()
    {
        const string inputValue = "abacd";
        var removedDuplicated = RemoveDuplicateCharWithoutBuffer.RemoveDuplicateCharModified(inputValue);
        Console.WriteLine(removedDuplicated);
    }
}