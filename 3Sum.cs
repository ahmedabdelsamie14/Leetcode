public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> triplets = new List<IList<int>>();

        if(nums == null || nums.Length < 3) return triplets;
        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 2 /*fixed pointer one of triplets*/; i++)
        {
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int left = i + 1;
            int right = nums.Length - 1;
            while(left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if(sum == 0)
                {
                    triplets.Add(new List<int>(){nums[i] , nums[left] , nums[right]});

                    while(left < right && nums[left] == nums[left + 1]) left++;
                    while(left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;

                    //we can shift only one pointer and it will be more optimized look at the notes
                }
                else if(sum > 0)
                {
                  right--;  
                }
                else
                {
                  left++;
                }
            }

            
        }
        return triplets;
    }
}