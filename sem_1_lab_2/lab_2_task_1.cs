using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0; //задана користувачем кількість строк 
                int m = 0; //задана користувачем кількість стовпців
                int range = 0; //задане користувачем максимальне число у матриці
                int temp; //змінна для визначення кількості розрядів у чисел для вирівнення матриці
                int counter = 0; //лічильник для кількості розрядів максимального числа
                int counter2 = 0; //лічильник для кількості розрядів кожного нового числа в матриці
                int lower = 0; //змінна, що буде набувати значення мінімального числа під час руху зліва направо
                string lowerword = ""; //змінна, що буде мати вигляд x[i][j], де х - мінімальне число під час руху зліва направо, i та j - індекси цього числа
                List<string> lowers = new(); //список для змінних lower
                int[,] matrix = new int[n, m];
                string answer;
                string answerrow = "";
                Console.WriteLine("Do you want to check test? Write 'yes' to start it");
                answer = Convert.ToString(Console.ReadLine());
                if (answer == "yes")
                {
                    lower = 10;
                    n = 3;
                    m = 3;
                    Console.WriteLine("n = 3, m = 3");
                    matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    Console.WriteLine("matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }");
                }
                else
                {
                    Random digits = new Random();
                    Console.Write("Enter max value for numbers in matrix: ");
                    range = Convert.ToInt32(Console.ReadLine());
                    lower = range + 1;
                    Console.Write("Enter value for n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter value for m: ");
                    m = Convert.ToInt32(Console.ReadLine());
                    matrix = new int[n, m];
                    //Заповнення матриці псевдовипадковими числами
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix[j, i] = digits.Next(1, range);
                        }
                    }
                }
                //Вивід матриці
                temp = range;
                while (temp > 0)
                {
                    temp /= 10;
                    counter++;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        temp = matrix[i, j];
                        while (temp > 0)
                        {
                            temp /= 10;
                            counter2++;
                        }
                        for (int k = counter - counter2; k > 0; k--)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(matrix[i, j] + " ");
                        counter2 = 0;
                    }
                    Console.WriteLine();
                }
                //Обхід матриці
                counter = 0;
                while (counter < m)
                {
                    //Обхід матриці згори (справа наліво)
                    if (counter < n)
                    {
                        for (int i = m - 1 - counter; i > counter - 1; i--)
                        {
                            if (matrix[counter, i] != 0)
                            {
                                answerrow += matrix[counter, i] + " ";
                                Console.Write(matrix[counter, i] + " ");
                                matrix[counter, i] = 0;
                            }
                        }
                    }
                    //Обхід матриці зліва (згори вниз)
                    for (int i = 1 + counter; i < n - counter - 1; i++)
                    {
                        if (matrix[i, counter] != 0)
                        {
                            answerrow += matrix[i, counter] + " ";
                            Console.Write(matrix[i, counter] + " ");
                            matrix[i, counter] = 0;
                        }
                    }
                    //Обхід матриці знизу (зліва направо) та пошук мінімальних елементів
                    if (n > counter)
                    {
                        for (int i = counter; i <= m - 1 - counter; i++)
                        {
                            if (matrix[n - 1 - counter, i] != 0)
                            {
                                answerrow += matrix[n - 1 - counter, i] + " ";
                                Console.Write(matrix[n - 1 - counter, i] + " ");
                                if (matrix[n - 1 - counter, i] < lower)
                                {
                                    lower = matrix[n - 1 - counter, i];
                                    lowerword = Convert.ToString(lower) + "[" + Convert.ToString(n - 1 - counter) + "][" + Convert.ToString(i) + "]";
                                }
                                else if (matrix[n - 1 - counter, i] == lower)
                                {
                                    lowerword = lowerword + " " + Convert.ToString(matrix[n - 1 - counter, i]) + "[" + Convert.ToString(n - 1 - counter) + "][" + Convert.ToString(i) + "]";
                                }
                                matrix[n - 1 - counter, i] = 0;
                            }
                        }
                    }
                    if (lowers.Count == 0 || lowerword != lowers[^1])
                    {
                        lowers.Add(lowerword);
                    }
                    lower = range + 1;
                    //Обхід матриці справа (знизу вгору)
                    for (int i = n - 2 - counter; i > counter; i--)
                    {
                        if (matrix[i, m - 1 - counter] != 0)
                        {
                            answerrow += matrix[i, m - 1 - counter] + " ";
                            Console.Write(matrix[i, m - 1 - counter] + " ");
                            matrix[i, m - 1 - counter] = 0;
                        }
                    }
                    counter++;
                }
                Console.WriteLine();
                //Вивід мінімальних елементів, що знайдені при русі зліва направо
                if (m < n && m % 2 == 1)
                {
                    lowers.Remove(lowers[^1]);
                }
                Console.Write("List of the least numbers while moving from left to right: ");
                for (int i = 0; i < lowers.Count; i++)
                {
                    Console.Write(lowers[i] + " ");
                }
                Console.WriteLine();
                if (answer == "yes")
                {
                    if (answerrow == "3 2 1 4 7 8 9 6 5 " && lowers[0] == "7[2][0]")
                    {
                        Console.WriteLine("Test is PASSED");
                    }
                    else
                    {
                        Console.WriteLine("Test is not PASSED");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Input data is incorrect");
            }
        }
    }
}