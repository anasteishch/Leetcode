namespace Leetcode._941._Valid_Mountain_Array
{
    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3) return false;
            var point = 0;
            for (var i=1; i< arr.Length-1; i++)
            {
                if (point > 1 || arr[i] == arr[i - 1] || arr[i] == arr[i + 1] || (arr[i - 1] > arr[i] && arr[i] < arr[i + 1])) return false;
                if ((arr[i - 1] < arr[i] && arr[i] > arr[i + 1])){ point++; }
            }

            return point == 1;
        }
    }
}