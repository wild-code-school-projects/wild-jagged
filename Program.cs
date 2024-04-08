namespace Jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tableauUniforme = new int[3, 3] {
                {1, 2, 3},
                {2, 3, 4},
                {3, 4, 5}
            };

            int[][] tableauIrregulier = new int[3][];

            // En Remplie le tableau irregulier avec les valeurs du tableau uniforme : 
            for (int r = 0; r < 3; r++)
            {
                int[] ligne = new int[tableauUniforme.GetLength(1) - r];
                for (int c = 0; c < ligne.Length; c++)
                    ligne[c] = tableauUniforme[r, c];

                tableauIrregulier[r] = ligne;
            }


            // Affichage du tableau irregulier : 
            for (int r = 0; r < tableauIrregulier.Length; r++)
            {
                Console.Write($"[{r} => [");
                for (int c = 0; c < tableauIrregulier[r].Length; c++)
                {
                    Console.Write($"{tableauIrregulier[r][c]}");
                    if (c < tableauIrregulier[r].Length - 1)
                        Console.Write(", ");
                }
                Console.WriteLine("]]");
            }


        }
    }
}
