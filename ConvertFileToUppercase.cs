using System.IO;
public class ConvertFileToUppercase
{
    public ConvertFileToUppercase(string[] args)
    {
        string inputFileName = "inputFile.txt";
        string outputFileName = "outputFile.txt";

        try {
            string contents = File.ReadAllText(inputFileName);
            contents = contents.ToUpper();
 
            File.WriteAllText(outputFileName, contents);
        } catch {
            Console.WriteLine("File not found");
        }
        
    }
}