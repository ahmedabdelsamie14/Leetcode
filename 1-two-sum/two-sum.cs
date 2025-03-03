public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();
        int[] indecies = new int[2];

        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(dict.ContainsKey(complement))
            {
                indecies[0] = dict[complement];
                indecies[1] = i;
            }

            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        return indecies;
    }
}
