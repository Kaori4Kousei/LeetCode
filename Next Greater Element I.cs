//Following code beats 98.98% of subsmissions in C#
public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int,int>();
        int len1 = findNums.Length;
        int[] arr = new int[len1];
        int len2 = nums.Length;
        //adding the elements of 2nd array with their respective indexes in the dictionary
        for(int i=0; i<len2; i++)
        {
            dict.Add(nums[i], i);
        }
        
        //going through each of the element of the first array
        for(int i=0; i<len1; i++)
        {
            
            bool found = false;
            //finds the index of the number in nums array and starts searching for the greater element in the right side of it
            for(int j = dict[findNums[i]]+1; j<len2; j++)
            {
                //if element is found then it is added to the arr array and the loop is broken
                if(findNums[i]<nums[j])
                {
                    found = true;
                    arr[i] = nums[j];
                    break;
                }
            }
            //found = false means no element found
            if(!found)
                arr[i] = -1;
        }
        return arr;
    }
}
