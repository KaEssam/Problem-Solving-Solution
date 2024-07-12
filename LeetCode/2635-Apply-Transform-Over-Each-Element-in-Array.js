/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function(arr, fn) {
    let resultArray= []
    arr.forEach((item,i)=>
    {
        resultArray.push(fn(item,i))
    });
    return resultArray;
};