using System;
namespace Laboratory
{
    class Laboratory1
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int N = 0;
            int M = 0;
            int K = 0;
            int maximumValue = 0;
            string answer;

            Console.WriteLine("Do you want to check tests? Write yes to start");
            answer = Console.ReadLine();
            while (true)
            {
                try
                {
                    if (answer == "yes")
                    {
                        if (Test())
                        {
                            Console.WriteLine("\nAll tests are passed");
                        }
                        else
                        {
                            Console.WriteLine("\nTesting is failed");
                        }
                    }
                    N = enterData(N, "N");
                    M = enterData(M, "M");
                    K = enterData(K, "K");
                    maximumValue = enterData(maximumValue, "maximumValue");
                    int[,] array = new int[N, M];

                    // заповнення масиву псевдовипадковими числами
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            array[i, j] = rnd.Next(1, maximumValue + 1);
                        }
                    }

                    specialSort(array, N, M, K);

                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter correct data");
                }
            }
        }
        static int enterData(int x, string symbol)
        {
            while (x < 1)
            {
                Console.WriteLine("Enter value for " + symbol);
                x = Convert.ToInt32(Console.ReadLine());
            }
            return x;
        }
        static int[,] specialSort(int[,] array, int n, int m, int K)
        {
            // список для чисел, що пройшли умову для сортування
            List<int> searchedNumbers = new();

            // пошук чисел для сортування і вивід масиву до сортування
            Console.WriteLine("Array before sorting");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((array[i, j] % K) % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(array[i, j] + "\t");
                        searchedNumbers.Add(array[i, j]);
                        array[i, j] = 0;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(array[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            insertionSort(searchedNumbers);
            searchedNumbers.Reverse();
            Console.WriteLine("Array after sorting");

            // сортування масиву і його вивід, виділяючи відсортовані числа зеленим кольором
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array[i, j] == 0)
                    {
                        array[i, j] = searchedNumbers[0];
                        searchedNumbers.RemoveAt(0);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(array[i, j] + "  \t");
                    }
                    else
                    {
                        Console.Write(array[i, j] + "  \t");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine();
            }

            return array;
        }
        static int binarySearch(List<int> givenList, int item, int left, int right)
        {
            if (left >= right)
                return (item > givenList[left]) ? (left + 1) : left;

            int mid = (left + right) / 2;

            if (item == givenList[mid])
                return mid;

            else if (item > givenList[mid])
                return binarySearch(givenList, item, mid + 1, right);

            return binarySearch(givenList, item, left, mid - 1);
        }
        static void insertionSort(List<int> givenList)
        {
            int j;
            int searchedOrder;
            int key;

            for (int i = 1; i < givenList.Count(); i++)
            {
                key = givenList[i];
                j = i - 1;

                searchedOrder = binarySearch(givenList, key, 0, j);

                while (j >= searchedOrder)
                {
                    givenList[j + 1] = givenList[j];
                    j--;
                }
                givenList[j + 1] = key;
            }
        }
        static bool Test()
        {
            bool result = true;
            int[,] test1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // K = 4
            int[,] test1_expected = { { 1, 8, 3 }, { 6, 5, 4 }, { 7, 2, 9 } };

            int[,] test2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } }; // K = 3
            int[,] test2_expected = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };

            int[,] test3 = { { 567, 13213, 42414, 31 }, { 4400, 12345, 5, 8998 }, { 95645, 6486, 6849, 7 }, { 313, 53, 8, 321 } }; // K = 100
            int[,] test3_expected = { { 567, 13213, 42414, 31 }, { 8998, 12345, 5, 6486 }, { 95645, 4400, 6849, 7 }, { 313, 53, 8, 321 } };

            try
            {
                Console.WriteLine("\nStart test 1");
                Console.WriteLine("\nn = 3, m = 3, K = 4");

                int[,] test1_actual = specialSort(test1, 3, 3, 4);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (test1_actual[i, j] != test1_expected[i, j])
                        {
                            Console.WriteLine("Test 1 is failed");
                            result = false;
                        }
                    }
                }

                Console.WriteLine("\nEnd test 1");

                Console.WriteLine("\nStart test 2");
                Console.WriteLine("\nn = 3, m = 3, K = 3");

                int[,] test2_actual = specialSort(test2, 3, 3, 3);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (test2_actual[i, j] != test2_expected[i, j])
                        {
                            Console.WriteLine("Test 2 is failed");
                            result = false;
                        }
                    }
                }

                Console.WriteLine("\nEnd test 2");

                Console.WriteLine("\nStart test 3");
                Console.WriteLine("\nn = 4, m = 4, K = 100");

                int[,] test3_actual = specialSort(test3, 4, 4, 100);
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (test3_actual[i, j] != test3_expected[i, j])
                        {
                            Console.WriteLine("Test 3 is failed");
                            result = false;
                        }
                    }
                }

                Console.WriteLine("\nEnd test 3");
            }
            catch
            {
                Console.WriteLine("Error is detected");
                result = false;
            }

            return result;
        }
    }
}