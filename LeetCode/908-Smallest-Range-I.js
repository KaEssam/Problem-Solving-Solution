/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var smallestRangeI = function(nums, k) {
    const min = Math.min(...nums);
    const max = Math.max(...nums);
    
    if (max - min <= 2*k) return 0;
    return max - min - 2*k;
};