/**
 * @param {number[]} nums
 * @return {number[]}
 */
const getConcatenation = nums => {
    let n = nums.length; 
    let ans = new Array(n * 2); 

    for(let i = 0; i < nums.length; i++){
        ans[i] = ans[nums.length + i] = nums[i];
    }

    return ans; 
};
