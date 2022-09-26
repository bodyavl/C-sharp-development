namespace Lab5_university
{
    internal class Program
    {
        static void maxMinSumRows(int[,] matrix, ref int rowIndexMax, ref int rowIndexMin, ref int sumMax, ref int sumMin, int rows, int cols)
        {
            int sum;
            for (int i = 0; i < rows; i++)
            {
                sum = 0;
                for(int j = 0; j < cols; j++)
                {
                    sum += matrix[i,j];
                }
                if (i == 0) sumMin = sum;
                if (sum > sumMax)
                {
                    sumMax = sum;
                    rowIndexMax = i;
                }
                if (sum < sumMin)
                {
                    sumMin = sum;
                    rowIndexMin = i;
                }

            }
        }
        static void maxMinSumCols(int[,] matrix, ref int colIndexMax, ref int colIndexMin, ref int sumMax, ref int sumMin, int rows, int cols)
        {
            int sum;
            for (int i = 0; i < cols; i++)
            {
                sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }
                if (i == 0) sumMin = sum;
                if (sum > sumMax)
                {
                    sumMax = sum;
                    colIndexMax = i;
                }
                if (sum < sumMin)
                {
                    sumMin = sum;
                    colIndexMin = i;
                }
            }
        }
        static void showMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int m = 0;
            string? strM;
            bool mIsValid = false;
            int n = 0;
            string? strN;
            bool nIsValid = false;

            int sumMaxRows = 0, sumMinRows = 0, sumMaxCols = 0, sumMinCols = 0;
            int rowIndexMax = 0, rowIndexMin = 0, colIndexMax = 0, colIndexMin = 0;

            do
            {
                Console.Write("Enter number of rows: ");
                strM = Console.ReadLine();
                mIsValid = int.TryParse(strM, out m) && m > 0;
                if (mIsValid) break;
                Console.WriteLine("Enter a valid number");
            } while (!mIsValid);

            do
            {
                Console.Write("Enter number of columns: ");
                strN = Console.ReadLine();
                nIsValid = int.TryParse(strN, out n) && n > 0;
                if (nIsValid) break;
                Console.WriteLine("Enter a valid number");
            } while (!nIsValid);

            int[,] matrix = new int[m, n];

            int rows = m;
            int cols = n;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = rand.Next(1, 11);
                }
            }
            showMatrix(matrix, rows, cols);

            maxMinSumRows(matrix, ref rowIndexMax, ref rowIndexMin, ref sumMaxRows, ref sumMinRows, rows, cols);
            maxMinSumCols(matrix, ref colIndexMax, ref colIndexMin, ref sumMaxCols, ref sumMinCols, rows, cols);

            Console.WriteLine($"\nRow {rowIndexMax} has the max sum: {sumMaxRows}\nRow {rowIndexMin} has the min sum: {sumMinRows}");
            Console.WriteLine($"\nColumn {colIndexMax} has the max sum: {sumMaxCols}\nColumn {colIndexMin} has the min sum: {sumMinCols}");
        }
    }
}