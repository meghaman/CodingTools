using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTools
{
    public class TSP
    {
        int[,] roads =
            {
                {0, 10, 15, 20},
                {10, 0, 35, 25},
                {15, 35, 0, 30},
                {20, 25, 30, 0}
            };

        public TSP()
        {
            //int[] vertices = new int[] { 0, 1, 2, 3 };
            List<int> vertices = new List<int>();
            for (int i = 0; i < roads.GetLength(0); i++)
            {
                vertices.Add(i);
            }

            TSP_Path minPath = ShortestPathEndingAtVertice(vertices.Where(x => x != 0).ToList(), 0);

            Console.WriteLine(minPath);
        }

        TSP_Path ShortestPathEndingAtVertice(List<int> _vertices, int endPoint)
        {
            if (_vertices.Count == 0)
                return new TSP_Path() { Value = roads[0, endPoint], Path = "0=>" + endPoint.ToString() };

            TSP_Path minPath = new TSP_Path { Value = int.MaxValue, Path = "" };
            TSP_Path currentPath;

            foreach (int vertice in _vertices)
            {
                currentPath = ShortestPathEndingAtVertice(_vertices.Where(x => x != vertice).ToList(), vertice);
                if (currentPath.Value + roads[vertice, endPoint] < minPath.Value)
                {
                    minPath.Value = currentPath.Value + roads[vertice, endPoint];
                    minPath.Path = currentPath.Path + "=>" + endPoint.ToString();
                }
            }

            return minPath;
        }
    }

    public class TSP_Path
    {
        public int Value { get; set; }
        public string Path { get; set; }
    }
}
