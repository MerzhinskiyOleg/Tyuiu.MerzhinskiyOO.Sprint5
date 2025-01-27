using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MerzhinskiyOO.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            var values = fileContent
                .Split(new[] { ' ', '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(val =>
                {
                    if (double.TryParse(val, out double doubleValue))
                    {
                        return Math.Round(doubleValue, 3);
                    }
                    return (double?)null;
                })
                .Where(val => val.HasValue)
                .Select(val => val.Value)
                .ToArray();

            var twoDigitIntegers = values
                .Where(val => val == Math.Truncate(val))
                .Select(val => (int)val)
                .Where(val => (val >= 10 && val <= 99) || (val <= -10 && val >= -99))
                .ToList();

            if (twoDigitIntegers.Count == 0)
            {
                return 0;
            }

            double product = 1;
            foreach (var num in twoDigitIntegers)
            {
                product *= num;
            }

            return Math.Round(product, 3); 
        }

    }
}
