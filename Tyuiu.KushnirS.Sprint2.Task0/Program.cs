using Tyuiu.KushnirS.Sprint2.Task0;
using Tyuiu.KushnirS.Sprint2.Task0.Lib;
namespace Tyuiu.KushnirS.Sprint2.Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
          DataService ds = new DataService();
          int x = 1025;
          int y = 275;
          bool[] res = new bool[6];
          res = ds.GetCompareOperations(x, y);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}
