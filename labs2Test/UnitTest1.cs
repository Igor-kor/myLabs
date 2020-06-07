using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2graph;

namespace labs2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrixInc = { { 1, 0, 1, 1, 1, 0, 0, 1, 1, 0},
                                 { 1, 0, 1, 0, 0, 0, 0, 1, 1, 1},
                                 { 0, 0 ,0 ,0, 1, 1, 0, 0, 0, 1},
                                 { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0},
                                 { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                                 { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                                 { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                                 { 0,0,0,0,0,0,0,0,0,0},
                                 { 0,0,0,0,0,0,0,0,0,0},
                                 { 0,0,0,0,0,0,0,0,0,0}};

            int[,] matrixSmej = { { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0 },
                                  { 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                                  { 1, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
                                  { 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 },
                                  { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                                  { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                  { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                  { 0,0,0,0,0,0,0,0,0,0},
                                  { 0,0,0,0,0,0,0,0,0,0},
                                  { 0,0,0,0,0,0,0,0,0,0}};
            graph mygraph = new graph(matrixInc, 10);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Assert.AreEqual(mygraph.matrix[i, j], matrixSmej[i, j]);
                }
            }



        }

        [TestMethod]
        public void TestMethod2()
        {
           
            int[,] matrixInc = { { 1, 0, 1, 1, 1, 0, 0, 1, 1, 0},
                                 { 1, 0, 1, 0, 0, 0, 0, 1, 1, 1},
                                 { 0, 0 ,0 ,0, 1, 1, 0, 0, 0, 1},
                                 { 0, 1, 0, 0, 0, 1, 0, 0, 0, 0},
                                 { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                                 { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
                                 { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                                 { 0,0,0,0,0,0,0,0,0,0},
                                 { 0,0,0,0,0,0,0,0,0,0},
                                 { 0,0,0,0,0,0,0,0,0,0}};
            graph mygraph = new graph(matrixInc, 10);
            Assert.AreEqual(mygraph.findLoop(), true);
            int[,] matrixCikl = { { 1, 0, 0, 0, 1, 0, 1, 1, 0, 1 },
                                  { 0, 1, 1, 0, 0, 1, 1, 0, 1, 1 },
                                  { 0, 1, 1, 0, 0, 1, 0, 0, 1, 0 },
                                  { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                                  { 1, 0, 0, 1, 0, 0, 0, 1, 0, 0 },
                                  { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                                  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                                  { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },};
            graph mygraph2 = new graph(matrixCikl, 10);
            Assert.AreEqual(mygraph2.findLoop(), false);
        }
    }
}
