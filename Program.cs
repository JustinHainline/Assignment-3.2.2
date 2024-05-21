namespace Assignment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 1, 2, }, { 3, 4, } };
            int[,] array2 = { { 5, 6, }, { 7, 8, } };
            
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(array1[i, j] + array2[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }

      
}
