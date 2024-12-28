using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MerzhinskiyOO.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            if (!Directory.Exists("temp_output"))
            {
                Directory.CreateDirectory("temp_output");
            }
            string path = "temp_output/OutputFileTask1.txt";
            try
            {
                File.WriteAllText(path, $"start: {startValue}, stop: {stopValue}");
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
