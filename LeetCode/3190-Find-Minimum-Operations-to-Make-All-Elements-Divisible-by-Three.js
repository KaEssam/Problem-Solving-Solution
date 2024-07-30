/**
 * @param {number[]} nums
 * @return {number}
 */
var minimumOperations = function(nums) {
   let count = 0;
    for (let num of nums) {
        if (num % 3 !== 0 && (num -1) % 3 === 0 || (num + 1) % 3 === 0 ) {
            count++ 
        }
    }
    return count;
};