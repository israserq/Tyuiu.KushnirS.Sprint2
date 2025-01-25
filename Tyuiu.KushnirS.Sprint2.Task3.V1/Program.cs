using Tyuiu.KushnirS.Sprint2.Task3.V1.Lib;
namespace Tyuiu.KushnirS.Sprint2.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(x);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
