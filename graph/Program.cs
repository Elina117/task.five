using System;

namespace graph
{
    public class GraphWalker
    {
        public static int[] buildgraph(bool[][] inputGraph)
        {
            
            Queue<int> vershina = new Queue<int>();
            int NumberOfVersh = inputGraph.Length;
            List<int> visitedversh= new List<int>();

            vershina.Enqueue(0);

            while (vershina.Count > 0)
            {
                int currentVershina = vershina.Dequeue();
                for (int j = 0; j < NumberOfVersh; j++)
                {
                    if (inputGraph[currentVershina][j] == true
                        && (visitedversh.Contains(j)== false)
                        && (vershina.Contains(j) == false)
                        )
                    {
                        vershina.Enqueue(j);
                        
                    }
                }
                visitedversh.Add(currentVershina);
            }
            int[] expected = visitedversh.ToArray();
            return expected;
        }

        static void Main(string[] args)
        {
            
           
        }

      



    }

}

