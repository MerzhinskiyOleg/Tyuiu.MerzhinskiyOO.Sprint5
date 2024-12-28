using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MerzhinskiyOO.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = "OutputFileTask0.txt";
            double z;
            try
            {
                z = x / (Math.Pow(Math.Pow(x, 2) + x, 0.5));
                z = Math.Round(z, 3);
                File.WriteAllText(path, Convert.ToString(z));
                Console.WriteLine($"Файл успешно сохранён по пути: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
            }
            return path;
        }
    }
}
