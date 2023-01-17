//// 1
//int row, col;
//int sum = 0;
//// entering matrix elements
//Console.WriteLine("enter number of rows: ");
//row = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("enter number of clumns: ");
//col = Convert.ToInt16(Console.ReadLine());

//int[,] matrix = new int[row, col];
//Console.WriteLine("enter your elements: ");
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.WriteLine($"enter elment({i})({j}): ");
//        matrix[i, j] = Convert.ToInt16(Console.ReadLine());
//    }
//}


//// printing the entered matrix
//Console.WriteLine("your matrix: ");

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//// calculating sum of the elements on main diagonal
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum += matrix[i, j];
//        }
//    }

//}
//Console.WriteLine(sum);



//// 2
//int row, col;
//// entering matrix elements
//Console.WriteLine("enter number of rows: ");
//row = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("enter number of clumns: ");
//col = Convert.ToInt16(Console.ReadLine());
//int[,] matrix = new int[row, col];
//int[,] matrix2 = new int[row, col];
//int[,] matrix3 = new int[row, col];


//Console.WriteLine("enter your elements: ");
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.WriteLine($"enter elment({i})({j}): ");
//        matrix[i, j] = Convert.ToInt16(Console.ReadLine());
//    }
//}

//// entering matrix2 elements
//Console.WriteLine("enter number of rows: ");
//row = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("enter number of clumns: ");
//col = Convert.ToInt16(Console.ReadLine());


//Console.WriteLine("enter your elements of the second matrix: ");
//for (int i = 0; i < matrix2.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix2.GetLength(1); j++)
//    {
//        Console.WriteLine($"enter elment({i})({j}): ");
//        matrix2[i, j] = Convert.ToInt16(Console.ReadLine());
//    }
//}



//// printing the entered matrix
//Console.WriteLine("first matrix: ");

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine("+");
//Console.WriteLine();
//// printing the entered matrix2
//Console.WriteLine("second matrix:");

//for (int i = 0; i < matrix2.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix2.GetLength(1); j++)
//    {
//        Console.Write(matrix2[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//// calculating sum of the elements of first and second matrixes
//for (int i = 0; i < matrix3.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix3.GetLength(1); j++)
//    {
//        matrix3[i, j] = matrix[i, j] + matrix2[i, j];
//    }
//}
//Console.WriteLine();
//Console.WriteLine("=");
//Console.WriteLine();
//for (int i = 0; i < matrix3.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix3.GetLength(1); j++)
//    {
//        Console.Write(matrix3[i, j] + " ");
//    }
//    Console.WriteLine();
//}



////3
//int row, col;
//// entering matrix elements
//Console.WriteLine("enter number of rows: ");
//row = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("enter number of clumns: ");
//col = Convert.ToInt16(Console.ReadLine());

//int[,] matrix = new int[row, col];
//Console.WriteLine("enter your elements: ");
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.WriteLine($"enter elment({i})({j}): ");
//        matrix[i, j] = Convert.ToInt16(Console.ReadLine());
//    }
//}


//// printing the rebuilt  matrix
//Console.WriteLine("matrix: ");

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if(i > j)
//        {
//            matrix[i, j] = 0;
//        }
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}





