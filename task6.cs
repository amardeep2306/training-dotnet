public class Task6_CheckIsNumber
{
    public Task6_CheckIsNumber()
    {
        Console.WriteLine("Please enter element");
        string text = Console.ReadLine();
        Console.WriteLine(IsNumber(text));
    }
 
    public static bool IsNumber(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] < '0') || (text[i] > '9'))
            {
                return false;
            }
        }
 
        return true;
    }
}