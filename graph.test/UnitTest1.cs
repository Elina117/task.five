using System.Threading.Tasks;
using graph;

namespace testGraph;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        bool[][] inputGraph =
        {
            new bool[] {false, true, true, false, false, false}, //i=0
            new bool[] {false, false, true, true, false, false},
            new bool[] {false, false, false, true, false, false},
            new bool[] {false, false, false, false, true, false},
            new bool[] {true, false, false, false, false, true},
            new bool[] {false, false, false, false, false, false}
        };

        int[] expected = { 0, 1, 2, 3, 4, 5 };
        
        int[] actual = graph.GraphWalker.buildgraph(inputGraph);  

        CollectionAssert.AreEqual(expected, actual);
    }


    [TestMethod]
    public void TestMethod2()
    {
        bool[][] inputGraph =
        {
            new bool[] {false, false, false, false, true, false}, //
            new bool[] {false, false, true, true, false, false},
            new bool[] {false, false, false, true, false, false},
            new bool[] {false, true, false, false, true, false},
            new bool[] {true, false, false, false, false, true}, //
            new bool[] {false, false, true, false, false, false} //
        };

        int[] expected = { 0, 4, 5, 2, 3, 1 };

        int[] actual = graph.GraphWalker.buildgraph(inputGraph);

        CollectionAssert.AreEqual(expected, actual);
    }
}
