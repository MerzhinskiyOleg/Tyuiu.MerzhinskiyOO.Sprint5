using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MerzhinskiyOO.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            int count = 0;

            foreach (char c in fileContent)
            {
                if (c >= 'а' && c <= 'я')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
