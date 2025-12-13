
// Extension Methods : its the operation of adding a methods to an existing data type 
// so it can be reached by its variables 

// Steps : 
//1- create a static class 
//2- make static methods with the first parameter in the format of [ this dataType parameter name ]


int x = Convert.ToInt32(Console.ReadLine());

if (x.isBetween(50, 100)) System.Console.WriteLine("valid interval");
else System.Console.WriteLine("invalid interval");


System.Console.WriteLine("hello world".RemoveWhiteSpaces());




public static class IntExtensionMethods
{
    public static bool isBetween(this int value, int min, int max)
    {
        if (value >= min && value < max || value > min && value <= max) return true;
        else return false;
    }
}

public static class StringExtensionMethods
{
    public static string RemoveWhiteSpaces(this string str)
    {
        return str.Replace(" ", "");
    }
}