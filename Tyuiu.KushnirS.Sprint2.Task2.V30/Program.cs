using Tyuiu.KushnirS.Sprint2.Task2.V30.Lib;
namespace Tyuiu.KushnirS.Sprint2.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Console.WriteLine(" Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine(" Точка находится в заштрихованной области ");
            }
            else
            {
                Console.WriteLine(" Точка не находится в заштрихованной области ");
            }
            Console.ReadKey();
        }
    }
}
