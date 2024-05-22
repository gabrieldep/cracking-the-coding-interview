using ChapterArraysStrings;
namespace Program;

public abstract class Program
{
    public static void Main()
    {
        const string firstString = "waterbottle";
        const string secondString = "erbottlewat";
        var response = RotationIsSubstring.IsRotation(firstString, secondString);
        Console.WriteLine(response);
    }
}