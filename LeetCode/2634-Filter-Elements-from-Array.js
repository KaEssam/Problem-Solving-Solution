/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function(arr, fn) {
    let resultArray= []
    arr.forEach((item,i)=>
    {
        if(fn(item,i)){
        resultArray.push(item)
        }
    });
    return resultArray;
};