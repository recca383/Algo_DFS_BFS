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

            graph.AddEdge('A', 'B');
            graph.AddEdge('A', 'C');
            graph.AddEdge('B', 'F');
            graph.AddEdge('B', 'G');
            graph.AddEdge('C', 'D');
            graph.AddEdge('C', 'E');
            graph.AddEdge('E', 'F');
            graph.AddEdge('F', 'I');
            graph.AddEdge('F', 'H');
            graph.AddEdge('A', 'B');

            Console.Write("BFS : ");
            graph.BFS('A');
            Console.WriteLine();
            Console.Write("DFS : ");
            graph.DFS('A');
        }
    }
}
