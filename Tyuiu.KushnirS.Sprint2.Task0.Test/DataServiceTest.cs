using Tyuiu.KushnirS.Sprint2.Task0.Lib;
namespace Tyuiu.KushnirS.Sprint2.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x, y;
            x = 1025;
            y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true,false,true,false,true,false};
            CollectionAssert.AreEqual(wait,res );
            
        }
    }
}