using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
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
            if (answer == "yes")
            {
                if (answerrow == "3 2 1 4 7 8 9 6 5 " && lowers[0] == "7[2][0]")
                {
                    Console.WriteLine("Test is PASSED");
                }
            }
        }
    }
}