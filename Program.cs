using System;
using System.Collections.Generic;

namespace testtest
{
    internal class Program
    {
        public class listInformation
        {
            public string Name { get; set; }

            public byte weight { get; set; }

            public listInformation()
            {
                Name = string.Empty;
                this.weight = 0;
            }

            public listInformation(string name, byte weight)
            {
                Name = name;
                this.weight = weight;
            }
        }



        public class GraphAdjacencylist
        {
            public string AdjacencyName { get; set; }
            public List<listInformation> listInformation { get; set; }

            public GraphAdjacencylist(string CurrentVertex, List<listInformation> list)
            {
                AdjacencyName = CurrentVertex;
                listInformation = list;
            }


        }

        public static void MatrixSolution()
        {
            string[] Names = { "A", "B", "C", "D" };

            int[,] Matrix =
            {
                {0,3,5,0 },
                {0,0,0,2},
                {0,0,0,7 },
                {0,0,0,0}
            };

            Console.WriteLine();

            Console.WriteLine("\t" + string.Join("\t", Names));

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write($"{Names[i]}\t");

                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

        }

        public static void ListSolution()
        {
            List<GraphAdjacencylist> List = new List<GraphAdjacencylist>();

            GraphAdjacencylist A = new GraphAdjacencylist("A", new List<listInformation>
            {
                new listInformation("B",3),
                new listInformation ("C",5)
            });

            GraphAdjacencylist B = new GraphAdjacencylist("B", new List<listInformation>
            {
                new listInformation("D",2)
            });

            GraphAdjacencylist C = new GraphAdjacencylist("C", new List<listInformation>
            {
                new listInformation("D",7)
            });

            GraphAdjacencylist D = new GraphAdjacencylist("D", new List<listInformation>());


            List.Add(A);
            List.Add(B);
            List.Add(C);
            List.Add(D);



            foreach (var item in List)
            {
                Console.WriteLine($"\t {item.AdjacencyName}  Result : \n");
                foreach (var conn in item.listInformation)
                {
                    Console.WriteLine($" {item.AdjacencyName} ---> {conn.Name} -> weight ({conn.weight})");
                }

                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t Matrix Solution : \n\n");
            MatrixSolution();

            Console.WriteLine("\n\n\t List Solution : \n\n");
            ListSolution();


            Console.ReadKey();
        }
    }
}
