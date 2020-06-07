using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace labs1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Lab1.Lab1.Func1(0, 0, 1));
            Assert.AreEqual(15, Lab1.Lab1.Func1(0, 5, 1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, -1,-10,-5 };
            int[] arr2 = { 0, 1, 2, 3, 4, 5};
            Assert.AreEqual(-50, Lab1.Lab1.Func2(arr));
            try
            {
                Lab1.Lab1.Func2(arr2);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Массив не содержит отрицательных элементов");
            }
           
        }
    }
}
