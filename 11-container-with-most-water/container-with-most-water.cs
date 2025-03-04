public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while(left < right)
        {
            int currentArea = Math.Min(height[right] , height[left]) * (right - left);
            if(currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if(height[left] > height[right])
            {       
                right--;
            }
            else
            {
                left++;
            }
        }
        return maxArea;
    }
}