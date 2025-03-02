using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_DFS_BFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();

            graph.AddEdge('A', 'B', 3);
            graph.AddEdge('A', 'C', 2);
            graph.AddEdge('B', 'F', 2);
            graph.AddEdge('B', 'G', 3);
            graph.AddEdge('C', 'D', 4);
            graph.AddEdge('C', 'E', 2);
            graph.AddEdge('E', 'F', 5);
            graph.AddEdge('F', 'I', 1);
            graph.AddEdge('F', 'H', 3);
            graph.AddEdge('A', 'B', 3);

            Console.Write("BFS : ");
            graph.BFS('B');
            Console.WriteLine();
            Console.Write("DFS : ");
            graph.DFS('B');
        }
    }
}
