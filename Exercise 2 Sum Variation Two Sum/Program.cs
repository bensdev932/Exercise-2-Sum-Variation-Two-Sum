int[] nums = [-1, 0];
int target = -1;

int[] result = TwoSumSorted(nums, target);
Console.WriteLine($"Positions: {result[0]}, {result[1]}"); 

int[] TwoSumSorted(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left < right)
    {
        int sum = nums[left] + nums[right];

        if (sum == target)
        {
            
            return new int[] { left + 1, right + 1 };
        }
        else if (sum < target)
        {
            left++;
        }
        else
        {
           
            right--;
        }
    }

    return new int[] { -1, -1 };
}
