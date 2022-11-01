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
            Console.WriteLine("Enter value for n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter1++;
                    }
                }
                if (counter1 == 2)
                {
                    m = Math.Log(i + 1, 2);
                    if (m == Convert.ToInt32(m))
                    {
                        for (int k = 1; k <= m; k++)
                        {
                            if (m % k == 0)
                            {
                                counter2++;
                            }
                        }
                        if (counter2 == 2)
                        {
                            nums.Add(i);
                        }
                    }
                    counter2 = 0;
                }
                counter1 = 0;
            }
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