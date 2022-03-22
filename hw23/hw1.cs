using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Parameter olaraq integer array variable-i ve bir integer value
            //qebul eden ve hemin integer value-nu integer array-e yeni element
            //kimi elave eden metod.
            //Misal üçün int[] nums = { 1, 5, 7 } deyə bir variable - mız var.
            //yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums
            //arrayının dəyəri { 1,5,7,3} olmalıdır.

            int[] nums = { 1, 5, 7 };
            int num = 3;
            InsEl(ref nums, num);
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
        }
        static void InsEl(ref int[] nums, int num)
        {
            int[] newArr = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                newArr[i] = nums[i];
            }
            newArr[nums.Length] = num;
            nums = newArr;
        }

    }
}
