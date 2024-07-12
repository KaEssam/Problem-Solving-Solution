/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[][]}
 */
var findDifference = function(nums1, nums2) {
    let n1 = new Set(nums1);
    let n2 = new Set(nums2);

    for( let i of n1){
        if(n2.has(i)){
            n1.delete(i)
            n2.delete(i)
        }
    }

    return [Array.from(n1), Array.from(n2)];
};