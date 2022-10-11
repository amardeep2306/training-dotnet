using System.IO;
public class Task7_ConvertFileToUppercase
{
    public Task7_ConvertFileToUppercase(string[] args)
    {
        string inputFileName = "inputFile.txt";
        string outputFileName = "outputFile.txt";
 
        string contents = File.ReadAllText(inputFileName);
        contents = contents.ToUpper();
 
        File.WriteAllText(outputFileName, contents);
    }
}