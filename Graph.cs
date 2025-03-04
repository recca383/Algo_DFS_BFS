using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algo_DFS_BFS
{
    class Graph
    {
        private Dictionary<char, List<char>> _graph;
        public Graph()
        {
            _graph = new Dictionary<char, List<char>>();
        }

        public void AddVertex(char vertex)
        {
            if (!_graph.ContainsKey(vertex))
                _graph[vertex] = new List<char>();
        }
        public void AddEdge(char source, char destination)
        {
            if(!_graph.ContainsKey(source)) AddVertex(source);
            if(!_graph.ContainsKey(destination)) AddVertex(destination);

            _graph[source].Add(destination);
        }
        public void BFS(char root)
        {
            HashSet<char> visited = new HashSet<char>();
            Queue<char> queue = new Queue<char>();
            

            visited.Add(root);
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                char curr = queue.Dequeue();

                Console.Write($"{curr} -> ");

                foreach(var next in _graph[curr])
                {
                    if(!visited.Contains(next))
                    {
                        visited.Add(next);
                        queue.Enqueue(next);
                    }
                }
            }
        }

        public void DFS(char root)
        {
            HashSet<char> visited = new HashSet<char>();
            DFS_CallStack(root, visited);            
        }
        public void DFS_CallStack(char node, HashSet<char> visited)
        {
            if (visited.Contains(node))
                return;

            Console.Write($"{node} -> ");
            visited.Add(node);

            foreach(var next in _graph[node])
            {
                DFS_CallStack(next, visited);
            }
        }
    }
}
