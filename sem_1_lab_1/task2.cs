using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            /* case 1 n = 3
             * case 2 n = 157
             * case 3 n = 1021
             * case 4 n = 10039
             */
            int n; // задана користувачем змінна 
            double m; // змінна, якій буде надано значення логарифму за основою 2 від (i + 1)
            int counter1 = 0; // лічильник для перевірки чи просте число i
            int counter2 = 0; // лічильник для перевірки чи просте число m
            List<int> nums = new(); // список для знайдених чисел Мерсенна
            for (int p = 0; p < nums.Count(); p++)
            {
                Console.Write(nums[p] + " ");
            }
            /* case 1 ""
             * case 2 "3 7 31 127"
             * case 3 "3 7 31 127"
             * case 4 "3 7 31 127 8191"
             */
        }
    }
}