/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    let n = nums.length;

        if (n == 0 || n == 1)
            return n;

        let j = 0;
     
        for (let i = 0; i < n - 1; i++)
            if (nums[i] != nums[i + 1])
                nums[j++] = nums[i];
     
        nums[j++] = nums[n - 1];
     
        return j;
};