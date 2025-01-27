using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MerzhinskiyOO.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Round((x)/(Math.Sqrt(Math.Pow(x,2)+ 2)),3);
            return Convert.ToString(y);
        }
    }
}
