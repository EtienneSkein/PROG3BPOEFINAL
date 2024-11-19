using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MunicipalServiceApp.DataStore;

namespace MunicipalServiceApp
{
    //Datastruct to satisfy the graph requirement
    public class Graph
    {
        private readonly Dictionary<int, List<int>> adjacencyList = new();

        public int NodeCount => adjacencyList.Count;

        public void AddNode(int node)
        {
            if (!adjacencyList.ContainsKey(node))
                adjacencyList[node] = new List<int>();
        }

        public void AddEdge(int from, int to)
        {
            if (adjacencyList.ContainsKey(from) && adjacencyList.ContainsKey(to))
            {
                adjacencyList[from].Add(to);
                adjacencyList[to].Add(from);
            }
        }

        public List<int> GetNeighbors(int node)
        {
            return adjacencyList.ContainsKey(node) ? adjacencyList[node] : new List<int>();
        }

        public List<Edge> GetAllEdges()
        {
            var edges = new List<Edge>();
            var visited = new HashSet<(int, int)>();

            foreach (var node in adjacencyList.Keys)
            {
                foreach (var neighbor in adjacencyList[node])
                {
                    var edge = (Math.Min(node, neighbor), Math.Max(node, neighbor));
                    if (!visited.Contains(edge))
                    {
                        visited.Add(edge);
                        edges.Add(new Edge { From = edge.Item1, To = edge.Item2, Weight = 1 }); // Default weight is 1
                    }
                }
            }

            return edges;
        }
    }

}
