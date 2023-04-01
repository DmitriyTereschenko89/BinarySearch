namespace BinarySearch
{
    internal class Program
    {
        public class BinarySearch
        {
            public int Search(int[] nums, int target)
            {
                int leftIdx = 0;
                int rightIdx = nums.Length - 1;
                while (leftIdx <= rightIdx)
                {
                    int middleIdx = leftIdx + (rightIdx - leftIdx) / 2;
                    if (nums[middleIdx] == target)
                    {
                        return middleIdx;
                    }
                    if (nums[middleIdx] < target)
                    {
                        leftIdx = middleIdx + 1;
                    }
                    else
                    {
                        rightIdx = middleIdx - 1;
                    }
                }
                return -1;
            }
        }

        static void Main(string[] args)
        {
            BinarySearch binarySearch = new();
            Console.WriteLine(binarySearch.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
            Console.WriteLine(binarySearch.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
        }
    }
}