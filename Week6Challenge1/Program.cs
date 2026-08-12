// Create square 2d matrix and rotate clockwise 90degrees inplace
// The new position for the inputs is the first column or consecutive column's row index number

//Console.Write("Please enter the size of your matrix: "); // Prompt the user to enter the size of the matrix
//int size = Convert.ToInt32(Console.ReadLine()); // size - 1 will also be the same as matrix.GetLength(1) - 1 to find the column index
//int[,] matrix = new int[size, size]; // use the size to create a square matrix


// Test Data ---------------------------------------------------------
int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//int[,] matrix = new int[,] { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };

int size = matrix.GetLength(1);

CreateAndDisplayMatrix(matrix);
Rotate90Degrees(matrix);



// Methods
void CreateAndDisplayMatrix(int[,] matrix) // Method to create matrix
{
    //// Create matrix and input data
    //for (int i = 0; i < size; i++)
    //{
    //    for (int j = 0; j < size; j++)
    //    {
    //        Console.Write($"Please enter element [{i},{j}] for: "); // Prompts the user for each element
    //        int number = Convert.ToInt32(Console.ReadLine()); // Converts the input to an integer
    //        matrix[i, j] = number; // Stores the user input
    //        Console.WriteLine();
    //    }
    //}

    Console.WriteLine("The matrix is: ");
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(matrix[i, j] + " "); // Shows each element of the matrix
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Rotate90Degrees(int[,] matrix)
{

    //for (int i = 0; i < size / 2; i++) // Since it's a square matrix column and row size will be the same
    //{
    //    for (int j = i; j < size - 1 - i; j++)
    //    {
    //        int temp = matrix[i, j];

    //        matrix[i, j] = matrix[size - 1 - j, i];
    //        matrix[size - 1 - j, i] = matrix[size - 1 - i, size - 1 - j];
    //        matrix[size - 1 - i, size - 1 - j] = matrix[j, size - 1 - i];
    //        matrix[j, size - 1 - i] = temp;
    //    }
    //}

    //Alt method: Transpose and then reverse columns
    for (int i = 0; i < size; i++)
    {
        for (int j = i + 1; j < size; j++)
        {
            (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]); // Tuple
        }
    }

    for (int i = 0; i < size; i++)
    {
        int left = 0;
        int right = size - 1;
        while (left < right)
        {
            int temp = matrix[i, left];
            matrix[i, left] = matrix[i, right];
            matrix[i, right] = temp;
            left++;
            right--;
        }
    }

    Console.WriteLine("The rotated matrix is: ");
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write(matrix[i, j] + " "); // Shows each element of the matrix
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}