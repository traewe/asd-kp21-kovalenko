using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            int n; // задана користувачем змінна 
            double m; // змінна, якій буде надано значення логарифму за основою 2 від (i + 1)
            int counter1 = 0; // лічильник для перевірки чи просте число i
            int counter2 = 0; // лічильник для перевірки чи просте число m
            List<int> nums = new(); // список для знайдених чисел Мерсенна
            for (int p = 0; p < nums.Count(); p++)
            {
                Console.Write(nums[p] + " ");
            }
        }
    }
}