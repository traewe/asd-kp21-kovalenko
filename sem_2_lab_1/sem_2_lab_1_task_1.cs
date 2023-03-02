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
            return x;
        }
        static int[,] specialSort(int[,] array, int n, int m, int K)
        {
            // список для чисел, що пройшли умову для сортування
            List<int> searchedNumbers = new();

            return array;
        }
        static int binarySearch(List<int> givenList, int item, int left, int right)
        {
            return 0;
        }
        static void insertionSort(List<int> givenList)
        {
            int j;
            int searchedOrder;
            int key;
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