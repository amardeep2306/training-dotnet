using System.Text.RegularExpressions;

public class CheckIsNumber
{
    public CheckIsNumber()
    {
        Console.Write("Please enter element: ");
        string text = Console.ReadLine();
        string result = IsNumber(text).ToString();
        Console.WriteLine(result);
    }
 
    public static bool IsNumber(string text)
    {
        Regex regex = new Regex(@"^-?[0-9][0-9,\.]+$");
        
        return  regex.IsMatch(text);

    }
}