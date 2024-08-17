using Study_CodingTest._20240818Study;
namespace Study_CodingTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 1, 2, 3 };
            int[] nums2 = { 3, 3, 3, 2, 2, 4 };
            int[] nums3 = { 3, 3, 3, 2, 2, 2, };
            int[] nums4 = { 1, 4, 4, 1, 3, 3, 2, 3 };
            int[] nums5 = { 1, 4, 1, 2, 3, 2, 3 };
            int[] nums6 = { 1, 1, 1, 1 };
            /*Hash_20240817.PickNumPhoneketM(nums1);
            Hash_20240817.PickNumPhoneketM(nums2);
            Hash_20240817.PickNumPhoneketM(nums3);
            Hash_20240817.PickNumPhoneketM(nums4);
            Hash_20240817.PickNumPhoneketM(nums5);
            Hash_20240817.PickNumPhoneketM(nums6);*/
            Console.WriteLine(Hash_20240817.PickNumPhoneketM(nums1));
            Console.WriteLine(Hash_20240817.PickNumPhoneketM(nums2));
            Console.WriteLine(Hash_20240817.PickNumPhoneketM(nums3));
            Console.WriteLine(Hash_20240817.PickNumPhoneketM(nums4));
            Console.WriteLine(Hash_20240817.PickNumPhoneketM(nums5));
            Console.WriteLine(Hash_20240817.PickNumPhoneketM(nums6));
        }
    }
}
