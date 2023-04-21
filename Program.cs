// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];
    
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(min, max + 1);
    
//     return array;
// }

// void Write2dArray(int[,]array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SortRowsFromMaxToMin(int[,] array)
// {
//     for(int k = 1; k < array.GetLength(1); k++)
//         for(int i = 0; i < array.GetLength(0); i++)
//             for(int j = 1; j < array.GetLength(1); j++)
//             {
//             if(array[i, j] > array[i, j -1])
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[i, j - 1];
//                 array[i, j - 1] = temp;
//             }
//             }
// }

// int[,] myArray = CreateRandom2dArray();

// Write2dArray(myArray);

// SortRowsFromMaxToMin(myArray);

// Write2dArray(myArray);

// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите минимальное число: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите максимальное число: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];
    
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(min, max + 1);
    
//     return array;
// }

// void Write2dArray(int[,]array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for(int j=0; j<array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int FindRowWithMinElementsSum(int [,] array)
// {
//     int i = 0;
//     int j = 0;
//     int minSum = 0;
//     int sumOfRow = 0;
//     int sumOfNextRow = 0;
//     int rowWithMinSumInd = 0;   
//         for(i = 0, j = 0; j < array.GetLength(1); j++)
//             sumOfRow += array[i, j];
//         for(j = 0; j < array.GetLength(1); j++)
//         {
//             sumOfNextRow += array[i + 1, j];
//         }
//         if(sumOfRow < sumOfNextRow)
//         {
//             minSum = sumOfRow;
//             rowWithMinSumInd = i;
//         }
//         else
//         {
//             minSum = sumOfNextRow;
//             rowWithMinSumInd = i + 1;
//         }
//         if(array.GetLength(0) > 2)
//             for(i = 2; i < array.GetLength(0); i++)
//             {
//                 sumOfNextRow = 0;
//                 for(j = 0; j < array.GetLength(1); j++)
//                     sumOfNextRow += array[i, j];
//             if(sumOfNextRow < minSum)
//             {
//             minSum = sumOfNextRow;
//             rowWithMinSumInd = i;
//             }
//             }
//     return rowWithMinSumInd;
// }

// int[,] myArray = CreateRandom2dArray();

// Write2dArray(myArray);

// Console.WriteLine($"Минимальную сумму элементов имеет строка: {FindRowWithMinElementsSum(myArray) + 1}");

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4       3 4
// 3 2       3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//==================================================================================*/


// int UserInput(string message)
// {
//     Console.Write(message + "... ");
//     Int32.TryParse(Console.ReadLine(), out int num);
//     return num;
// }
// int[,] CreateRndMatrix(int mtrxNumber, int rows, int columns)
// {
//     int minValue = 1;
//     int maxValue = 9;
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             // выравниваем столбики пробелами перед числом в зависимости от длины числа
//             // расчитано на (+)двухзначные
//             string filler = new string(' ', 3 - Convert.ToString(array[i, j]).Length);
//             Console.Write(filler + array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }
// bool ValidateMatrices (int columns1st, int rows2nd)
// {
//     return columns1st == rows2nd;
// }
// int[,] МultipleMatrix (int[,] matrix1, int[,] matrix2)
// {
//     System.Console.WriteLine("Умножаем ... ");
//     int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int resultRow = 0; resultRow < resultMatrix.GetLength(0); resultRow++)
//     {
//         for (int resultCol = 0; resultCol < resultMatrix.GetLength(1); resultCol++)
//         {
//             for (int j = 0; j < matrix1.GetLength(1); j++)
//             {
//                 resultMatrix[resultRow, resultCol] += matrix1[resultRow, j] * matrix2[j, resultCol];
                
//                 string sign = " + ";
//                 if (j == matrix1.GetLength(1) - 1) sign = "";
//                 Console.Write($"{matrix1[resultRow, j]}·{matrix2[j, resultCol]}{sign}");
//             }
//             if (resultCol < resultMatrix.GetLength(1) - 1) Console.Write($"  |  ");
//         }
//         Console.WriteLine();
//     }
//     return resultMatrix;
// }
// Console.WriteLine("======== УМНОЖЕНИЕ МАТРИЦ ========");
// Console.WriteLine("Умножение возможно, если кол-во колонок 1й матрицы равно кол-ву строк 2й.");
// int rows1st    = UserInput("Введите размеры 1й матрицы: кол-во строк");
// int columns1st = UserInput("                            кол-во колонок");
// int rows2nd    = UserInput("Введите размеры 2й матрицы: кол-во строк");
// int columns2nd = UserInput("                            кол-во колонок");
// if (ValidateMatrices(columns1st, rows2nd))
// {
//     int[,] matrix1st = CreateRndMatrix(1, rows1st, columns1st);
//     int[,] matrix2nd = CreateRndMatrix(2, rows2nd, columns2nd);
//     System.Console.WriteLine("Первая матрица:");
//     PrintArray(matrix1st);
//     System.Console.WriteLine("Вторая матрица:");
//     PrintArray(matrix2nd);
//     int[,] resultMatrix = МultipleMatrix (matrix1st, matrix2nd);
//     Console.WriteLine("Результат умножения первой матрицы на вторую:");
//     PrintArray(resultMatrix);
// }
// else
// {
//     System.Console.WriteLine("Матрицы таких габаритов умножить невозможно.");
// }



// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] Generate3dArray()
// {   
//     Console.Write("Введите число строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число столбцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число слоёв: ");
//     int layers = Convert.ToInt32(Console.ReadLine());
//     if (rows * columns * layers < 90)
//     {
//         int[,,] array = new int[rows, columns, layers];
//             for(int k = 0; k < layers; k++)
//                 for(int i = 0; i < rows; i++)
//                     for(int j = 0; j < columns; j++)
//                         array[i, j, k] = GenerateUniqueElement(array);
//         return array;
//     }
//     else
//     {
//         Console.WriteLine("Такой массив невозможно заполнить только уникальными значениями. Попробуйте ещё раз.");
//         return Generate3dArray();
//     }   
// }

// int GenerateUniqueElement(int[,,] array)
// {   
//     // while(true)
//     // {
//     Random rnd = new Random();
//     int num = rnd.Next(10, 100);
//     if(CheckForUnique(num, array)) return num;
//     else return GenerateUniqueElement(array);
//     // }
// }

// bool CheckForUnique(int num, int[,,] array)
// {
//     for(int k = 0; k < array.GetLength(2); k++)
//         for(int i = 0; i < array.GetLength(0); i++)
//             for(int j = 0; j < array.GetLength(1); j++)
//                 if(num == array[i, j, k]) return false;
//     return true;
// }

// void Write3dArray(int[,,]array)
// {
//     for(int k = 0; k < array.GetLength(0); k++)
//     {   
//         Console.WriteLine($"Слой №{k + 1}");
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//                 Console.Write(array[i,j,k] + " ");
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// int[,,] myArray = Generate3dArray();

// Write3dArray(myArray);
