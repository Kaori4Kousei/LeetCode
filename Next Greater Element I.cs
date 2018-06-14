public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int,int>();
        int len1 = findNums.Length;
        int[] arr = new int[len1];
        int len2 = nums.Length;
        for(int i=0; i<len2; i++)
        {
            dict.Add(nums[i], i);
        }
        for(int i=0; i<len1; i++)
        {
            bool found = false;
            for(int j = dict[findNums[i]]+1; j<len2; j++)
            {
                if(findNums[i]<nums[j])
                {
                    found = true;
                    arr[i] = nums[j];
                    break;
                }
            }
            if(!found)
                arr[i] = -1;
        }
        return arr;
    }
}