using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MerzhinskiyOO.Sprint5.Task7.V30.Lib
{
    public class DataService : ISprint5Task7V30
    {
        public string LoadDataAndSave(string path)
        {
            string fileContent = File.ReadAllText(path);

            string pattern = @"\b-?[0-9]\b";

            string modifiedContent = Regex.Replace(fileContent, pattern, "9");

            string outputDirectory = Path.GetTempPath();
            string outputFileName = "OutPutDataFileTask7V26.txt";
            string outputFilePath = Path.Combine(outputDirectory, outputFileName);

            File.WriteAllText(outputFilePath, modifiedContent);

            return outputFilePath;
        }

    }
}
