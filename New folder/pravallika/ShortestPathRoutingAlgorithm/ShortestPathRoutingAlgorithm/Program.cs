using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathRoutingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph =  {
	                        { 0, 1, 2, 0, 0, 0, 0, 0, 0 ,0},
	                        { 0, 0, 0, 0, 3, 0, 0, 0, 0 ,0},
	                        { 0, 0, 0, 1, 0, 0, 0, 0, 0 ,0},
	                        { 0, 0, 0, 0, 0, 2, 0, 0, 8 ,0},
	                        { 0, 0, 0, 0, 0, 1, 4, 0, 0 ,0},
	                        { 0, 0, 0, 2, 1, 0, 0, 0, 0 ,0},
	                        { 0, 0, 0, 0, 4, 0, 0, 1, 3 ,0},
	                        { 0, 0, 0, 0, 0, 0, 1, 0, 5 ,3},
	                        { 0, 0, 0, 0, 0, 0, 0, 3, 0 ,2}
                            };
            dijkastra.DijkstraAlgo(graph, 0, 10);
            Console.ReadLine();
        }
    }
    public class dijkastra
    {
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;
            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }
            return minIndex;
        }

        private static void Print(int[] distance, int verticesCount, int[] arr)
        {
            Console.WriteLine("Enter the destination node between 0 to 9:");
            int destNode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Todal minimum distance 1-->{0} is :{1}", destNode, distance[destNode]);
        }
        public static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];
            int[] arr = new int[10];
            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;
                for (int v = 0; v < verticesCount; ++v)
                {
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];

                    }
                }
            }
            Print(distance, verticesCount, arr);
        }
    }
}
        
    

